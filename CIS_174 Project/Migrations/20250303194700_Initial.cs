using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CIS_174_Project.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OlympicGames",
                columns: table => new
                {
                    OlympicGameTypeID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OlympicGames", x => x.OlympicGameTypeID);
                });

            migrationBuilder.CreateTable(
                name: "SportTypes",
                columns: table => new
                {
                    SportTypeID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SportTypes", x => x.SportTypeID);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    CountryID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SportTypeID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    GameTypeOlympicGameTypeID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CountryFlag = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.CountryID);
                    table.ForeignKey(
                        name: "FK_Countries_OlympicGames_GameTypeOlympicGameTypeID",
                        column: x => x.GameTypeOlympicGameTypeID,
                        principalTable: "OlympicGames",
                        principalColumn: "OlympicGameTypeID");
                    table.ForeignKey(
                        name: "FK_Countries_SportTypes_SportTypeID",
                        column: x => x.SportTypeID,
                        principalTable: "SportTypes",
                        principalColumn: "SportTypeID");
                });

            migrationBuilder.InsertData(
                table: "OlympicGames",
                columns: new[] { "OlympicGameTypeID", "Name" },
                values: new object[,]
                {
                    { "paralympic", "Paralympic Games" },
                    { "summer", "Summer Olympics" },
                    { "winter", "Winter Olympics" },
                    { "youth", "Youth Olympic Games" }
                });

            migrationBuilder.InsertData(
                table: "SportTypes",
                columns: new[] { "SportTypeID", "Name" },
                values: new object[,]
                {
                    { "indoor", "Indoor" },
                    { "outdoor", "Outdoor" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "CountryID", "CountryFlag", "GameTypeOlympicGameTypeID", "Name", "SportTypeID" },
                values: new object[,]
                {
                    { "austria", "~/images/olympics/austria.png", null, "Austria", "outdoor" },
                    { "brazil", "~/images/olympics/brazil.png", null, "Brazil", "outdoor" },
                    { "canada", "~/images/olympics/canada.png", null, "Canada", "indoor" },
                    { "china", "~/images/olympics/china.png", null, "China", "indoor" },
                    { "cyprus", "~/images/olympics/cyprus.png", null, "Cyprus", "indoor" },
                    { "finland", "~/images/olympics/finland.png", null, "Finland", "outdoor" },
                    { "france", "~/images/olympics/france.png", null, "France", "indoor" },
                    { "germany", "~/images/olympics/germany.png", null, "Germany", "indoor" },
                    { "greatbritain", "~/images/olympics/greatbritain.png", null, "Great Britain", "indoor" },
                    { "italy", "~/images/olympics/italy.png", null, "Italy", "outdoor" },
                    { "jamaica", "~/images/olympics/jamaica.png", null, "Jamaica", "outdoor" },
                    { "japan", "~/images/olympics/japan.png", null, "Japan", "outdoor" },
                    { "mexico", "~/images/olympics/mexico.png", null, "Mexico", "indoor" },
                    { "netherlands", "~/images/olympics/netherlands.png", null, "Netherlands", "outdoor" },
                    { "pakistan", "~/images/olympics/pakistan.png", null, "Pakistan", "outdoor" },
                    { "portugal", "~/images/olympics/portugal.png", null, "Portugal", "outdoor" },
                    { "russia", "~/images/olympics/russia.png", null, "Russia", "indoor" },
                    { "slovakia", "~/images/olympics/slovakia.png", null, "Slovakia", "outdoor" },
                    { "sweden", "~/images/olympics/sweden.png", null, "Sweden", "indoor" },
                    { "thailand", "~/images/olympics/thailand.png", null, "Thailand", "indoor" },
                    { "ukraine", "~/images/olympics/ukraine.png", null, "Ukraine", "indoor" },
                    { "uruguay", "~/images/olympics/uruguay.png", null, "Uruguay", "indoor" },
                    { "usa", "~/images/olympics/usa.png", null, "USA", "outdoor" },
                    { "zimbabwe", "~/images/olympics/zimbabwe.png", null, "Zimbabwe", "outdoor" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Countries_GameTypeOlympicGameTypeID",
                table: "Countries",
                column: "GameTypeOlympicGameTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Countries_SportTypeID",
                table: "Countries",
                column: "SportTypeID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "OlympicGames");

            migrationBuilder.DropTable(
                name: "SportTypes");
        }
    }
}
