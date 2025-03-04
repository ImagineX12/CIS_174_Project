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
                    CountryFlag = "~/images/olympics/ca.png"
                },
                new
                {
                    CountryID = "se",
                    Name = "Sweden",
                    SportTypeID = "indoor",
                    GameTypeID = "winter",
                    CountryFlag = "~/images/olympics/se.png"
                },
                new
                {
                    CountryID = "gb",
                    Name = "Great Britain",
                    SportTypeID = "indoor",
                    GameTypeID = "winter",
                    CountryFlag = "~/images/olympics/gb.png"
                },
                new
                {
                    CountryID = "jm",
                    Name = "Jamaica",
                    SportTypeID = "outdoor",
                    GameTypeID = "winter",
                    CountryFlag = "~/images/olympics/jm.png"
                },
                new
                {
                    CountryID = "it",
                    Name = "Italy",
                    SportTypeID = "outdoor",
                    GameTypeID = "winter",
                    CountryFlag = "~/images/olympics/it.png"
                },
                new
                {
                    CountryID = "jp",
                    Name = "Japan",
                    SportTypeID = "outdoor",
                    GameTypeID = "winter",
                    CountryFlag = "~/images/olympics/jp.png"
                },
                new
                {
                    CountryID = "de",
                    Name = "Germany",
                    SportTypeID = "indoor",
                    GameTypeID = "summer",
                    CountryFlag = "~/images/olympics/de.png"
                },
                new
                {
                    CountryID = "cn",
                    Name = "China",
                    SportTypeID = "indoor",
                    GameTypeID = "summer",
                    CountryFlag = "~/images/olympics/cn.png"
                },
                new
                {
                    CountryID = "mx",
                    Name = "Mexico",
                    SportTypeID = "indoor",
                    GameTypeID = "summer",
                    CountryFlag = "~/images/olympics/mx.png"
                },
                new
                {
                    CountryID = "br",
                    Name = "Brazil",
                    SportTypeID = "outdoor",
                    GameTypeID = "summer",
                    CountryFlag = "~/images/olympics/br.png"
                },
                new
                {
                    CountryID = "nl",
                    Name = "Netherlands",
                    SportTypeID = "outdoor",
                    GameTypeID = "summer",
                    CountryFlag = "~/images/olympics/nl.png"
                },
                new
                {
                    CountryID = "us",
                    Name = "USA",
                    SportTypeID = "outdoor",
                    GameTypeID = "summer",
                    CountryFlag = "~/images/olympics/us.png"
                },
                new
                {
                    CountryID = "th",
                    Name = "Thailand",
                    SportTypeID = "indoor",
                    GameTypeID = "paralympic",
                    CountryFlag = "~/images/olympics/th.png"
                },
                new
                {
                    CountryID = "uy",
                    Name = "Uruguay",
                    SportTypeID = "indoor",
                    GameTypeID = "paralympic",
                    CountryFlag = "~/images/olympics/uy.png"
                },
                new
                {
                    CountryID = "ua",
                    Name = "Ukraine",
                    SportTypeID = "indoor",
                    GameTypeID = "paralympic",
                    CountryFlag = "~/images/olympics/ua.png"
                },
                new
                {
                    CountryID = "at",
                    Name = "Austria",
                    SportTypeID = "outdoor",
                    GameTypeID = "paralympic",
                    CountryFlag = "~/images/olympics/at.png"
                },
                new
                {
                    CountryID = "pk",
                    Name = "Pakistan",
                    SportTypeID = "outdoor",
                    GameTypeID = "paralympic",
                    CountryFlag = "~/images/olympics/pk.png"
                },
                new
                {
                    CountryID = "zw",
                    Name = "Zimbabwe",
                    SportTypeID = "outdoor",
                    GameTypeID = "paralympic",
                    CountryFlag = "~/images/olympics/zw.png"
                },
                new
                {
                    CountryID = "fr",
                    Name = "France",
                    SportTypeID = "indoor",
                    GameTypeID = "youth",
                    CountryFlag = "~/images/olympics/fr.png"
                },
                new
                {
                    CountryID = "cy",
                    Name = "Cyprus",
                    SportTypeID = "indoor",
                    GameTypeID = "youth",
                    CountryFlag = "~/images/olympics/cy.png"
                },
                new
                {
                    CountryID = "ru",
                    Name = "Russia",
                    SportTypeID = "indoor",
                    GameTypeID = "youth",
                    CountryFlag = "~/images/olympics/ru.png"
                },
                new
                {
                    CountryID = "fi",
                    Name = "Finland",
                    SportTypeID = "outdoor",
                    GameTypeID = "youth",
                    CountryFlag = "~/images/olympics/fi.png"
                },
                new
                {
                    CountryID = "sk",
                    Name = "Slovakia",
                    SportTypeID = "outdoor",
                    GameTypeID = "youth",
                    CountryFlag = "~/images/olympics/sk.png"
                },
                new
                {
                    CountryID = "pt",
                    Name = "Portugal",
                    SportTypeID = "outdoor",
                    GameTypeID = "youth",
                    CountryFlag = "~/images/olympics/pt.png"
                }
            );
        }
    }
}
