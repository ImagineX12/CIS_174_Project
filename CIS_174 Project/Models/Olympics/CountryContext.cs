using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;


namespace CIS_174_Project.Models.Olympics
{
    public class CountryContext : DbContext
    {
        public CountryContext(DbContextOptions<CountryContext> options) : base(options) { }

        public DbSet<Country> Countries { get; set; } = null!;
        public DbSet<SportType> SportTypes { get; set; } = null!;
        public DbSet<GameType> GameTypes { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<SportType>().HasData(

                new SportType { SportTypeID = "indoor", Name = "Indoor"},
                new SportType { SportTypeID = "outdoor", Name = "Outdoor"}
            );

            modelBuilder.Entity<GameType>().HasData(

                new GameType { GameTypeID = "summer", Name = "Summer Olympics"},
                new GameType { GameTypeID = "winter", Name = "Winter Olympics" },
                new GameType { GameTypeID = "paralympic", Name = "Paralympic Games" },
                new GameType { GameTypeID = "youth", Name = "Youth Olympic Games" }
            );

            modelBuilder.Entity<Country>().HasData(

                new
                {
                    CountryID = "ca",
                    Name = "Canada",
                    SportTypeID = "indoor",
                    GameTypeID = "winter",
                    CountryFlag = "ca.png"
                },
                new
                {
                    CountryID = "se",
                    Name = "Sweden",
                    SportTypeID = "indoor",
                    GameTypeID = "winter",
                    CountryFlag = "se.png"
                },
                new
                {
                    CountryID = "gb",
                    Name = "Great Britain",
                    SportTypeID = "indoor",
                    GameTypeID = "winter",
                    CountryFlag = "gb.png"
                },
                new
                {
                    CountryID = "jm",
                    Name = "Jamaica",
                    SportTypeID = "outdoor",
                    GameTypeID = "winter",
                    CountryFlag = "jm.png"
                },
                new
                {
                    CountryID = "it",
                    Name = "Italy",
                    SportTypeID = "outdoor",
                    GameTypeID = "winter",
                    CountryFlag = "it.png"
                },
                new
                {
                    CountryID = "jp",
                    Name = "Japan",
                    SportTypeID = "outdoor",
                    GameTypeID = "winter",
                    CountryFlag = "jp.png"
                },
                new
                {
                    CountryID = "de",
                    Name = "Germany",
                    SportTypeID = "indoor",
                    GameTypeID = "summer",
                    CountryFlag = "de.png"
                },
                new
                {
                    CountryID = "cn",
                    Name = "China",
                    SportTypeID = "indoor",
                    GameTypeID = "summer",
                    CountryFlag = "cn.png"
                },
                new
                {
                    CountryID = "mx",
                    Name = "Mexico",
                    SportTypeID = "indoor",
                    GameTypeID = "summer",
                    CountryFlag = "mx.png"
                },
                new
                {
                    CountryID = "br",
                    Name = "Brazil",
                    SportTypeID = "outdoor",
                    GameTypeID = "summer",
                    CountryFlag = "br.png"
                },
                new
                {
                    CountryID = "nl",
                    Name = "Netherlands",
                    SportTypeID = "outdoor",
                    GameTypeID = "summer",
                    CountryFlag = "nl.png"
                },
                new
                {
                    CountryID = "us",
                    Name = "USA",
                    SportTypeID = "outdoor",
                    GameTypeID = "summer",
                    CountryFlag = "us.png"
                },
                new
                {
                    CountryID = "th",
                    Name = "Thailand",
                    SportTypeID = "indoor",
                    GameTypeID = "paralympic",
                    CountryFlag = "th.png"
                },
                new
                {
                    CountryID = "uy",
                    Name = "Uruguay",
                    SportTypeID = "indoor",
                    GameTypeID = "paralympic",
                    CountryFlag = "uy.png"
                },
                new
                {
                    CountryID = "ua",
                    Name = "Ukraine",
                    SportTypeID = "indoor",
                    GameTypeID = "paralympic",
                    CountryFlag = "ua.png"
                },
                new
                {
                    CountryID = "at",
                    Name = "Austria",
                    SportTypeID = "outdoor",
                    GameTypeID = "paralympic",
                    CountryFlag = "at.png"
                },
                new
                {
                    CountryID = "pk",
                    Name = "Pakistan",
                    SportTypeID = "outdoor",
                    GameTypeID = "paralympic",
                    CountryFlag = "pk.png"
                },
                new
                {
                    CountryID = "zw",
                    Name = "Zimbabwe",
                    SportTypeID = "outdoor",
                    GameTypeID = "paralympic",
                    CountryFlag = "zw.png"
                },
                new
                {
                    CountryID = "fr",
                    Name = "France",
                    SportTypeID = "indoor",
                    GameTypeID = "youth",
                    CountryFlag = "fr.png"
                },
                new
                {
                    CountryID = "cy",
                    Name = "Cyprus",
                    SportTypeID = "indoor",
                    GameTypeID = "youth",
                    CountryFlag = "cy.png"
                },
                new
                {
                    CountryID = "ru",
                    Name = "Russia",
                    SportTypeID = "indoor",
                    GameTypeID = "youth",
                    CountryFlag = "ru.png"
                },
                new
                {
                    CountryID = "fi",
                    Name = "Finland",
                    SportTypeID = "outdoor",
                    GameTypeID = "youth",
                    CountryFlag = "fi.png"
                },
                new
                {
                    CountryID = "sk",
                    Name = "Slovakia",
                    SportTypeID = "outdoor",
                    GameTypeID = "youth",
                    CountryFlag = "sk.png"
                },
                new
                {
                    CountryID = "pt",
                    Name = "Portugal",
                    SportTypeID = "outdoor",
                    GameTypeID = "youth",
                    CountryFlag = "pt.png"
                }
            );
        }
    }
}
