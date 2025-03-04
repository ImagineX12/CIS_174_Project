﻿// <auto-generated />
using CIS_174_Project.Models.Olympics;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CIS_174_Project.Migrations
{
    [DbContext(typeof(CountryContext))]
    partial class CountryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CIS_174_Project.Models.Olympics.Country", b =>
                {
                    b.Property<string>("CountryID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CountryFlag")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GameTypeID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SportTypeID")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("CountryID");

                    b.HasIndex("GameTypeID");

                    b.HasIndex("SportTypeID");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            CountryID = "ca",
                            CountryFlag = "~/images/olympics/ca.png",
                            GameTypeID = "winter",
                            Name = "Canada",
                            SportTypeID = "indoor"
                        },
                        new
                        {
                            CountryID = "se",
                            CountryFlag = "~/images/olympics/se.png",
                            GameTypeID = "winter",
                            Name = "Sweden",
                            SportTypeID = "indoor"
                        },
                        new
                        {
                            CountryID = "gb",
                            CountryFlag = "~/images/olympics/gb.png",
                            GameTypeID = "winter",
                            Name = "Great Britain",
                            SportTypeID = "indoor"
                        },
                        new
                        {
                            CountryID = "jm",
                            CountryFlag = "~/images/olympics/jm.png",
                            GameTypeID = "winter",
                            Name = "Jamaica",
                            SportTypeID = "outdoor"
                        },
                        new
                        {
                            CountryID = "it",
                            CountryFlag = "~/images/olympics/it.png",
                            GameTypeID = "winter",
                            Name = "Italy",
                            SportTypeID = "outdoor"
                        },
                        new
                        {
                            CountryID = "jp",
                            CountryFlag = "~/images/olympics/jp.png",
                            GameTypeID = "winter",
                            Name = "Japan",
                            SportTypeID = "outdoor"
                        },
                        new
                        {
                            CountryID = "de",
                            CountryFlag = "~/images/olympics/de.png",
                            GameTypeID = "summer",
                            Name = "Germany",
                            SportTypeID = "indoor"
                        },
                        new
                        {
                            CountryID = "cn",
                            CountryFlag = "~/images/olympics/cn.png",
                            GameTypeID = "summer",
                            Name = "China",
                            SportTypeID = "indoor"
                        },
                        new
                        {
                            CountryID = "mx",
                            CountryFlag = "~/images/olympics/mx.png",
                            GameTypeID = "summer",
                            Name = "Mexico",
                            SportTypeID = "indoor"
                        },
                        new
                        {
                            CountryID = "br",
                            CountryFlag = "~/images/olympics/br.png",
                            GameTypeID = "summer",
                            Name = "Brazil",
                            SportTypeID = "outdoor"
                        },
                        new
                        {
                            CountryID = "nl",
                            CountryFlag = "~/images/olympics/nl.png",
                            GameTypeID = "summer",
                            Name = "Netherlands",
                            SportTypeID = "outdoor"
                        },
                        new
                        {
                            CountryID = "us",
                            CountryFlag = "~/images/olympics/us.png",
                            GameTypeID = "summer",
                            Name = "USA",
                            SportTypeID = "outdoor"
                        },
                        new
                        {
                            CountryID = "th",
                            CountryFlag = "~/images/olympics/th.png",
                            GameTypeID = "paralympic",
                            Name = "Thailand",
                            SportTypeID = "indoor"
                        },
                        new
                        {
                            CountryID = "uy",
                            CountryFlag = "~/images/olympics/uy.png",
                            GameTypeID = "paralympic",
                            Name = "Uruguay",
                            SportTypeID = "indoor"
                        },
                        new
                        {
                            CountryID = "ua",
                            CountryFlag = "~/images/olympics/ua.png",
                            GameTypeID = "paralympic",
                            Name = "Ukraine",
                            SportTypeID = "indoor"
                        },
                        new
                        {
                            CountryID = "at",
                            CountryFlag = "~/images/olympics/at.png",
                            GameTypeID = "paralympic",
                            Name = "Austria",
                            SportTypeID = "outdoor"
                        },
                        new
                        {
                            CountryID = "pk",
                            CountryFlag = "~/images/olympics/pk.png",
                            GameTypeID = "paralympic",
                            Name = "Pakistan",
                            SportTypeID = "outdoor"
                        },
                        new
                        {
                            CountryID = "zw",
                            CountryFlag = "~/images/olympics/zw.png",
                            GameTypeID = "paralympic",
                            Name = "Zimbabwe",
                            SportTypeID = "outdoor"
                        },
                        new
                        {
                            CountryID = "fr",
                            CountryFlag = "~/images/olympics/fr.png",
                            GameTypeID = "youth",
                            Name = "France",
                            SportTypeID = "indoor"
                        },
                        new
                        {
                            CountryID = "cy",
                            CountryFlag = "~/images/olympics/cy.png",
                            GameTypeID = "youth",
                            Name = "Cyprus",
                            SportTypeID = "indoor"
                        },
                        new
                        {
                            CountryID = "ru",
                            CountryFlag = "~/images/olympics/ru.png",
                            GameTypeID = "youth",
                            Name = "Russia",
                            SportTypeID = "indoor"
                        },
                        new
                        {
                            CountryID = "fi",
                            CountryFlag = "~/images/olympics/fi.png",
                            GameTypeID = "youth",
                            Name = "Finland",
                            SportTypeID = "outdoor"
                        },
                        new
                        {
                            CountryID = "sk",
                            CountryFlag = "~/images/olympics/sk.png",
                            GameTypeID = "youth",
                            Name = "Slovakia",
                            SportTypeID = "outdoor"
                        },
                        new
                        {
                            CountryID = "pt",
                            CountryFlag = "~/images/olympics/pt.png",
                            GameTypeID = "youth",
                            Name = "Portugal",
                            SportTypeID = "outdoor"
                        });
                });

            modelBuilder.Entity("CIS_174_Project.Models.Olympics.GameType", b =>
                {
                    b.Property<string>("GameTypeID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GameTypeID");

                    b.ToTable("GameTypes");

                    b.HasData(
                        new
                        {
                            GameTypeID = "summer",
                            Name = "Summer Olympics"
                        },
                        new
                        {
                            GameTypeID = "winter",
                            Name = "Winter Olympics"
                        },
                        new
                        {
                            GameTypeID = "paralympic",
                            Name = "Paralympic Games"
                        },
                        new
                        {
                            GameTypeID = "youth",
                            Name = "Youth Olympic Games"
                        });
                });

            modelBuilder.Entity("CIS_174_Project.Models.Olympics.SportType", b =>
                {
                    b.Property<string>("SportTypeID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SportTypeID");

                    b.ToTable("SportTypes");

                    b.HasData(
                        new
                        {
                            SportTypeID = "indoor",
                            Name = "Indoor"
                        },
                        new
                        {
                            SportTypeID = "outdoor",
                            Name = "Outdoor"
                        });
                });

            modelBuilder.Entity("CIS_174_Project.Models.Olympics.Country", b =>
                {
                    b.HasOne("CIS_174_Project.Models.Olympics.GameType", "GameType")
                        .WithMany()
                        .HasForeignKey("GameTypeID");

                    b.HasOne("CIS_174_Project.Models.Olympics.SportType", "SportType")
                        .WithMany()
                        .HasForeignKey("SportTypeID");

                    b.Navigation("GameType");

                    b.Navigation("SportType");
                });
#pragma warning restore 612, 618
        }
    }
}
