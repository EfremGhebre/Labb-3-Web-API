
using Labb_3_Web_API.Models.DTO;
using Labb_3_Webb_API.Data;
using Labb_3_Webb_API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Labb_3_Web_API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers()
                .AddJsonOptions(options =>
                {
                    options.JsonSerializerOptions.DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull;
                });
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            //Enables adding a new person with only Name and PhoneNumber
            app.MapPost("/Add a new person", async (PersonDTO personDto, ApplicationDbContext context) =>
            {
                if (string.IsNullOrWhiteSpace(personDto.Name) || string.IsNullOrWhiteSpace(personDto.PhoneNumber))
                {
                    return Results.BadRequest("Name and phone number are required.");
                }
                var newPerson = new Person
                {
                    Name = personDto.Name,
                    PhoneNumber = personDto.PhoneNumber
                };

                context.Persons.Add(newPerson);
                await context.SaveChangesAsync();

                return Results.Created($"/person/{newPerson.Id}", newPerson);
            })
                .WithName("AddPerson")
                .WithTags("Persons");


            //Gets all persons in DB with their interests and respective URLs
            app.MapGet("/Get all persons in DB", async (ApplicationDbContext context) =>
            {
                var people = await context.Persons
                    .Include(p => p.PersonInterests)
                    .ThenInclude(pi => pi.Interest)
                    .ThenInclude(i => i.Links)
                    .Select(p => new PersonDTO
                    {
                        Id = p.Id,
                        Name = p.Name,
                        PhoneNumber = p.PhoneNumber,
                        Interests = p.PersonInterests.Select(pi => new InterestDTO
                        {
                            Id = pi.Interest.Id,
                            Title = pi.Interest.Title,
                            Description = pi.Interest.Description,
                            Links = pi.Interest.Links.Select(l => new LinkDTO
                            {
                                Id = l.Id,
                                Url = l.Url
                            }).ToList()
                        }).ToList()
                    })
                    .ToListAsync();

                if (people == null || people.Count == 0)
                {
                    return Results.NotFound("No person is found in the database.");
                }

                return Results.Ok(people);
            })
                .WithName("GetAllPersons")
                .WithTags("Persons");

            //Gets all interests and URLs associated with a specific person 
            app.MapGet("/Get interests by person ID/{id:int}", async (int id, ApplicationDbContext context) =>
            {
                var interests = await context.PersonInterests
                    .Where(pi => pi.PersonId == id)
                    .Include(pi => pi.Interest)
                    .Select(pi => new InterestDTO
                    {
                        Id = pi.Interest.Id,
                        Title = pi.Interest.Title,
                        Description = pi.Interest.Description,
                        Links = pi.Links.Select(l => new LinkDTO
                        {
                            Id = l.Id,
                            Url = l.Url
                        }).ToList()
                    }).ToListAsync();
                
                if (interests == null || interests.Count == 0)
                {
                    return Results.NotFound("No interests found for the specified person.");
                }

                return Results.Ok(interests);
            })
                .WithName("GetPersonInterests")
                .WithTags("Interests");

            //Gets all links associated with a specific person
            app.MapGet("/Get links associated to person/{id:int}/links", async (int id, ApplicationDbContext context) =>
            {
                var links = await context.PersonInterests
                    .Where(pi => pi.PersonId == id)
                    .Include(pi => pi.Interest)
                    .ThenInclude(i => i.Links)
                    .SelectMany(pi => pi.Interest.Links)
                    .Select(link => new LinkDTO
                    {
                        Id = link.Id,
                        Url = link.Url
                    })
                    .ToListAsync();

                if (links == null || links.Count == 0)
                {
                    return Results.NotFound("No links found for the specified person.");
                }

                return Results.Ok(links);
            })
                .WithName("GetPersonLinks")
                .WithTags("Links");

            //Adds a new interest to person
            app.MapPost("/Add an interest to person/{personId:int}/interests/{interestId:int}", async (int personId, int interestId, ApplicationDbContext context) =>
            {
                var person = await context.Persons.FindAsync(personId);
                var interest = await context.Interests.FindAsync(interestId);

                if (person == null || interest == null)
                {
                    return Results.NotFound("Person or interest not found.");
                }

                var personInterest = new PersonInterest
                {
                    PersonId = personId,
                    InterestId = interestId
                };

                context.PersonInterests.Add(personInterest);
                await context.SaveChangesAsync();

                return Results.Ok("Person successfully linked to the interest.");
            })
                .WithName("AddPersonInterest")
                .WithTags("Interests");

            //Add new link to specific person and interest
            app.MapPost("/Add new link to specific person and interest/{personId:int}/interests/{interestId:int}/links", async (int personId, int interestId, [FromBody] LinkDTO linkDto, ApplicationDbContext context) =>
            {
                var personInterest = await context.PersonInterests
                    .FirstOrDefaultAsync(pi => pi.PersonId == personId && pi.InterestId == interestId);

                if (personInterest == null)
                {
                    return Results.NotFound("Person or interest not found.");
                }

                var link = new Link
                {
                    Url = linkDto.Url,                    
                    InterestId = interestId
                };

                context.Links.Add(link);
                await context.SaveChangesAsync();

                return Results.Ok("Link successfully added to the interest.");
            })
                .WithName("AddLinkToInterest")
                .WithTags("Links");

            app.Run();
        }
    }
}
