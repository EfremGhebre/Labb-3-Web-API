﻿// <auto-generated />
using System;
using Labb_3_Webb_API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Labb_3_Web_API.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240822135050_init")]
    partial class init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Labb_3_Webb_API.Models.Interest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Interests");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Capturing moments through the lens of a camera.",
                            Title = "Photography"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Exploring culinary techniques and creating delicious dishes.",
                            Title = "Cooking"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Cultivating plants, flowers, and vegetables in a garden.",
                            Title = "Gardening"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Exploring nature trails and enjoying outdoor adventures.",
                            Title = "Hiking"
                        },
                        new
                        {
                            Id = 5,
                            Description = "Expressing creativity through painting on various canvases.",
                            Title = "Painting"
                        },
                        new
                        {
                            Id = 6,
                            Description = "Exploring new countries, cultures, and experiences.",
                            Title = "Traveling"
                        },
                        new
                        {
                            Id = 7,
                            Description = "Riding bicycles for fitness, fun, or transportation.",
                            Title = "Cycling"
                        },
                        new
                        {
                            Id = 8,
                            Description = "Enjoying and creating music across different genres.",
                            Title = "Music"
                        },
                        new
                        {
                            Id = 9,
                            Description = "Diving into books and exploring different worlds through literature.",
                            Title = "Reading"
                        },
                        new
                        {
                            Id = 10,
                            Description = "Practicing yoga to enhance physical and mental well-being.",
                            Title = "Yoga"
                        });
                });

            modelBuilder.Entity("Labb_3_Webb_API.Models.Link", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("InterestId")
                        .HasColumnType("int");

                    b.Property<int?>("PersonInterestInterestId")
                        .HasColumnType("int");

                    b.Property<int?>("PersonInterestPersonId")
                        .HasColumnType("int");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("InterestId");

                    b.HasIndex("PersonInterestPersonId", "PersonInterestInterestId");

                    b.ToTable("Links");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            InterestId = 1,
                            Url = "https://www.digitalphotomentor.com"
                        },
                        new
                        {
                            Id = 2,
                            InterestId = 2,
                            Url = "https://www.seriouseats.com"
                        },
                        new
                        {
                            Id = 3,
                            InterestId = 3,
                            Url = "https://www.gardeners.com"
                        },
                        new
                        {
                            Id = 4,
                            InterestId = 4,
                            Url = "https://www.alltrails.com"
                        },
                        new
                        {
                            Id = 5,
                            InterestId = 5,
                            Url = "https://www.artistsnetwork.com"
                        },
                        new
                        {
                            Id = 6,
                            InterestId = 6,
                            Url = "https://www.lonelyplanet.com"
                        },
                        new
                        {
                            Id = 7,
                            InterestId = 7,
                            Url = "https://www.bicycling.com"
                        },
                        new
                        {
                            Id = 8,
                            InterestId = 8,
                            Url = "https://www.rollingstone.com/music"
                        },
                        new
                        {
                            Id = 9,
                            InterestId = 9,
                            Url = "https://www.goodreads.com"
                        },
                        new
                        {
                            Id = 10,
                            InterestId = 10,
                            Url = "https://www.yogajournal.com"
                        });
                });

            modelBuilder.Entity("Labb_3_Webb_API.Models.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Persons");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "John Doe",
                            PhoneNumber = "123-456-7890"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Jane Smith",
                            PhoneNumber = "987-654-3210"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Michael Johnson",
                            PhoneNumber = "555-234-5678"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Emily Davis",
                            PhoneNumber = "555-345-6789"
                        },
                        new
                        {
                            Id = 5,
                            Name = "David Wilson",
                            PhoneNumber = "555-456-7890"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Sophia Brown",
                            PhoneNumber = "555-567-8901"
                        },
                        new
                        {
                            Id = 7,
                            Name = "James Taylor",
                            PhoneNumber = "555-678-9012"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Isabella Moore",
                            PhoneNumber = "555-789-0123"
                        },
                        new
                        {
                            Id = 9,
                            Name = "William White",
                            PhoneNumber = "555-890-1234"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Olivia Harris",
                            PhoneNumber = "555-901-2345"
                        },
                        new
                        {
                            Id = 11,
                            Name = "Benjamin Clark",
                            PhoneNumber = "555-012-3456"
                        },
                        new
                        {
                            Id = 12,
                            Name = "Ava Lewis",
                            PhoneNumber = "555-123-4567"
                        },
                        new
                        {
                            Id = 13,
                            Name = "Lucas Walker",
                            PhoneNumber = "555-234-5678"
                        },
                        new
                        {
                            Id = 14,
                            Name = "Mia Hall",
                            PhoneNumber = "555-345-6789"
                        },
                        new
                        {
                            Id = 15,
                            Name = "Alexander Young",
                            PhoneNumber = "555-456-7890"
                        });
                });

            modelBuilder.Entity("Labb_3_Webb_API.Models.PersonInterest", b =>
                {
                    b.Property<int>("PersonId")
                        .HasColumnType("int");

                    b.Property<int>("InterestId")
                        .HasColumnType("int");

                    b.HasKey("PersonId", "InterestId");

                    b.HasIndex("InterestId");

                    b.ToTable("PersonInterests");

                    b.HasData(
                        new
                        {
                            PersonId = 1,
                            InterestId = 1
                        },
                        new
                        {
                            PersonId = 1,
                            InterestId = 2
                        },
                        new
                        {
                            PersonId = 1,
                            InterestId = 3
                        },
                        new
                        {
                            PersonId = 2,
                            InterestId = 2
                        },
                        new
                        {
                            PersonId = 2,
                            InterestId = 4
                        },
                        new
                        {
                            PersonId = 3,
                            InterestId = 1
                        },
                        new
                        {
                            PersonId = 3,
                            InterestId = 5
                        },
                        new
                        {
                            PersonId = 3,
                            InterestId = 6
                        },
                        new
                        {
                            PersonId = 4,
                            InterestId = 3
                        },
                        new
                        {
                            PersonId = 4,
                            InterestId = 7
                        },
                        new
                        {
                            PersonId = 5,
                            InterestId = 4
                        },
                        new
                        {
                            PersonId = 5,
                            InterestId = 8
                        },
                        new
                        {
                            PersonId = 6,
                            InterestId = 9
                        },
                        new
                        {
                            PersonId = 7,
                            InterestId = 5
                        },
                        new
                        {
                            PersonId = 7,
                            InterestId = 10
                        },
                        new
                        {
                            PersonId = 8,
                            InterestId = 6
                        },
                        new
                        {
                            PersonId = 8,
                            InterestId = 7
                        },
                        new
                        {
                            PersonId = 8,
                            InterestId = 8
                        },
                        new
                        {
                            PersonId = 9,
                            InterestId = 9
                        },
                        new
                        {
                            PersonId = 9,
                            InterestId = 10
                        },
                        new
                        {
                            PersonId = 10,
                            InterestId = 1
                        },
                        new
                        {
                            PersonId = 11,
                            InterestId = 2
                        },
                        new
                        {
                            PersonId = 11,
                            InterestId = 4
                        },
                        new
                        {
                            PersonId = 12,
                            InterestId = 3
                        },
                        new
                        {
                            PersonId = 12,
                            InterestId = 5
                        },
                        new
                        {
                            PersonId = 13,
                            InterestId = 6
                        },
                        new
                        {
                            PersonId = 14,
                            InterestId = 7
                        },
                        new
                        {
                            PersonId = 14,
                            InterestId = 8
                        },
                        new
                        {
                            PersonId = 15,
                            InterestId = 9
                        },
                        new
                        {
                            PersonId = 15,
                            InterestId = 10
                        },
                        new
                        {
                            PersonId = 15,
                            InterestId = 1
                        });
                });

            modelBuilder.Entity("Labb_3_Webb_API.Models.Link", b =>
                {
                    b.HasOne("Labb_3_Webb_API.Models.Interest", "Interest")
                        .WithMany("Links")
                        .HasForeignKey("InterestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Labb_3_Webb_API.Models.PersonInterest", null)
                        .WithMany("Links")
                        .HasForeignKey("PersonInterestPersonId", "PersonInterestInterestId");

                    b.Navigation("Interest");
                });

            modelBuilder.Entity("Labb_3_Webb_API.Models.PersonInterest", b =>
                {
                    b.HasOne("Labb_3_Webb_API.Models.Interest", "Interest")
                        .WithMany("PersonInterests")
                        .HasForeignKey("InterestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Labb_3_Webb_API.Models.Person", "Person")
                        .WithMany("PersonInterests")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Interest");

                    b.Navigation("Person");
                });

            modelBuilder.Entity("Labb_3_Webb_API.Models.Interest", b =>
                {
                    b.Navigation("Links");

                    b.Navigation("PersonInterests");
                });

            modelBuilder.Entity("Labb_3_Webb_API.Models.Person", b =>
                {
                    b.Navigation("PersonInterests");
                });

            modelBuilder.Entity("Labb_3_Webb_API.Models.PersonInterest", b =>
                {
                    b.Navigation("Links");
                });
#pragma warning restore 612, 618
        }
    }
}
