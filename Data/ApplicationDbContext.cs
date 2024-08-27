using Labb_3_Webb_API.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace Labb_3_Webb_API.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Person> Persons { get; set; }
        public DbSet<Interest> Interests { get; set; }
        public DbSet<PersonInterest> PersonInterests { get; set; }
        public DbSet<Link> Links { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Seed Persons to the database
            modelBuilder.Entity<Person>().HasData(
                new Person { Id = 1, Name = "John Doe", PhoneNumber = "123-456-7890" },
                new Person { Id = 2, Name = "Jane Smith", PhoneNumber = "987-654-3210" },
                new Person { Id = 3, Name = "Michael Johnson", PhoneNumber = "555-234-5678" },
                new Person { Id = 4, Name = "Emily Davis", PhoneNumber = "555-345-6789" },
                new Person { Id = 5, Name = "David Wilson", PhoneNumber = "555-456-7890" },
                new Person { Id = 6, Name = "Sophia Brown", PhoneNumber = "555-567-8901" },
                new Person { Id = 7, Name = "James Taylor", PhoneNumber = "555-678-9012" },
                new Person { Id = 8, Name = "Isabella Moore", PhoneNumber = "555-789-0123" },
                new Person { Id = 9, Name = "William White", PhoneNumber = "555-890-1234" },
                new Person { Id = 10, Name = "Olivia Harris", PhoneNumber = "555-901-2345" },
                new Person { Id = 11, Name = "Benjamin Clark", PhoneNumber = "555-012-3456" },
                new Person { Id = 12, Name = "Ava Lewis", PhoneNumber = "555-123-4567" },
                new Person { Id = 13, Name = "Lucas Walker", PhoneNumber = "555-234-5678" },
                new Person { Id = 14, Name = "Mia Hall", PhoneNumber = "555-345-6789" },
                new Person { Id = 15, Name = "Alexander Young", PhoneNumber = "555-456-7890" }
            );

            //Seed Interests to the database
            modelBuilder.Entity<Interest>().HasData(
                new Interest { Id = 1, Title = "Photography", Description = "Capturing moments through the lens of a camera." },
                new Interest { Id = 2, Title = "Cooking", Description = "Exploring culinary techniques and creating delicious dishes." },
                new Interest { Id = 3, Title = "Gardening", Description = "Cultivating plants, flowers, and vegetables in a garden." },
                new Interest { Id = 4, Title = "Hiking", Description = "Exploring nature trails and enjoying outdoor adventures." },
                new Interest { Id = 5, Title = "Painting", Description = "Expressing creativity through painting on various canvases." },
                new Interest { Id = 6, Title = "Traveling", Description = "Exploring new countries, cultures, and experiences." },
                new Interest { Id = 7, Title = "Cycling", Description = "Riding bicycles for fitness, fun, or transportation." },
                new Interest { Id = 8, Title = "Music", Description = "Enjoying and creating music across different genres." },
                new Interest { Id = 9, Title = "Reading", Description = "Diving into books and exploring different worlds through literature." },
                new Interest { Id = 10, Title = "Yoga", Description = "Practicing yoga to enhance physical and mental well-being." }
            );

            //Associates and seeds person and interest to the database
            modelBuilder.Entity<PersonInterest>().HasData(
                new PersonInterest { PersonId = 1, InterestId = 1 },
                new PersonInterest { PersonId = 1, InterestId = 2 },
                new PersonInterest { PersonId = 1, InterestId = 3 },
                new PersonInterest { PersonId = 2, InterestId = 2 },
                new PersonInterest { PersonId = 2, InterestId = 4 },
                new PersonInterest { PersonId = 3, InterestId = 1 },
                new PersonInterest { PersonId = 3, InterestId = 5 },
                new PersonInterest { PersonId = 3, InterestId = 6 },
                new PersonInterest { PersonId = 4, InterestId = 3 },
                new PersonInterest { PersonId = 4, InterestId = 7 },
                new PersonInterest { PersonId = 5, InterestId = 4 },
                new PersonInterest { PersonId = 5, InterestId = 8 },
                new PersonInterest { PersonId = 6, InterestId = 9 },
                new PersonInterest { PersonId = 7, InterestId = 5 },
                new PersonInterest { PersonId = 7, InterestId = 10 },
                new PersonInterest { PersonId = 8, InterestId = 6 },
                new PersonInterest { PersonId = 8, InterestId = 7 },
                new PersonInterest { PersonId = 8, InterestId = 8 },
                new PersonInterest { PersonId = 9, InterestId = 9 },
                new PersonInterest { PersonId = 9, InterestId = 10 },
                new PersonInterest { PersonId = 10, InterestId = 1 },
                new PersonInterest { PersonId = 11, InterestId = 2 },
                new PersonInterest { PersonId = 11, InterestId = 4 },
                new PersonInterest { PersonId = 12, InterestId = 3 },
                new PersonInterest { PersonId = 12, InterestId = 5 },
                new PersonInterest { PersonId = 13, InterestId = 6 },         
                new PersonInterest { PersonId = 14, InterestId = 7 },
                new PersonInterest { PersonId = 14, InterestId = 8 },
                new PersonInterest { PersonId = 15, InterestId = 9 },
                new PersonInterest { PersonId = 15, InterestId = 10 },
                new PersonInterest { PersonId = 15, InterestId = 1 }
            );

            //Associates and seeds URL links and interest to the database
            modelBuilder.Entity<Link>().HasData(
               new Link { Id = 1, Url = "https://www.digitalphotomentor.com", InterestId = 1 },
               new Link { Id = 2, Url = "https://www.seriouseats.com", InterestId = 2 },
               new Link { Id = 3, Url = "https://www.gardeners.com", InterestId = 3 },
               new Link { Id = 4, Url = "https://www.alltrails.com", InterestId = 4 },
               new Link { Id = 5, Url = "https://www.artistsnetwork.com", InterestId = 5 },
               new Link { Id = 6, Url = "https://www.lonelyplanet.com", InterestId = 6 },
               new Link { Id = 7, Url = "https://www.bicycling.com", InterestId = 7 },
               new Link { Id = 8, Url = "https://www.rollingstone.com/music", InterestId = 8 },
               new Link { Id = 9, Url = "https://www.goodreads.com", InterestId = 9 },
               new Link { Id = 10, Url = "https://www.yogajournal.com", InterestId = 10 }
           );
            // Configuring the composite key for PersonInterest
            modelBuilder.Entity<PersonInterest>()
                .HasKey(pi => new { pi.PersonId, pi.InterestId });

            // Configuring the composite foreign key for Links
            modelBuilder.Entity<Link>()
                .HasKey(l => l.Id); // Primary key for Link


            modelBuilder.Entity<Link>()
                .HasOne(l => l.Interest)
                .WithMany(pi => pi.Links)
                .HasForeignKey(l => l.InterestId);
            
        }
    }

}
