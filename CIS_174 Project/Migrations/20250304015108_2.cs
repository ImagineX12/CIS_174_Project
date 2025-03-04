using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CIS_174_Project.Migrations
{
    /// <inheritdoc />
    public partial class _2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Countries_OlympicGames_GameTypeOlympicGameTypeID",
                table: "Countries");

            migrationBuilder.DropTable(
                name: "OlympicGames");

            migrationBuilder.RenameColumn(
                name: "GameTypeOlympicGameTypeID",
                table: "Countries",
                newName: "GameTypeID");

            migrationBuilder.RenameIndex(
                name: "IX_Countries_GameTypeOlympicGameTypeID",
                table: "Countries",
                newName: "IX_Countries_GameTypeID");

            migrationBuilder.CreateTable(
                name: "GameTypes",
                columns: table => new
                {
                    GameTypeID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameTypes", x => x.GameTypeID);
                });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "at",
                column: "GameTypeID",
                value: "paralympic");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "br",
                column: "GameTypeID",
                value: "summer");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "ca",
                column: "GameTypeID",
                value: "winter");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "cn",
                column: "GameTypeID",
                value: "summer");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "cy",
                column: "GameTypeID",
                value: "youth");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "de",
                column: "GameTypeID",
                value: "summer");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "fi",
                column: "GameTypeID",
                value: "youth");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "fr",
                column: "GameTypeID",
                value: "youth");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "gb",
                column: "GameTypeID",
                value: "winter");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "it",
                column: "GameTypeID",
                value: "winter");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "jm",
                column: "GameTypeID",
                value: "winter");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "jp",
                column: "GameTypeID",
                value: "winter");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "mx",
                column: "GameTypeID",
                value: "summer");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "nl",
                column: "GameTypeID",
                value: "summer");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "pk",
                column: "GameTypeID",
                value: "paralympic");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "pt",
                column: "GameTypeID",
                value: "youth");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "ru",
                column: "GameTypeID",
                value: "youth");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "se",
                column: "GameTypeID",
                value: "winter");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "sk",
                column: "GameTypeID",
                value: "youth");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "th",
                column: "GameTypeID",
                value: "paralympic");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "ua",
                column: "GameTypeID",
                value: "paralympic");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "us",
                column: "GameTypeID",
                value: "summer");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "uy",
                column: "GameTypeID",
                value: "paralympic");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "zw",
                column: "GameTypeID",
                value: "paralympic");

            migrationBuilder.InsertData(
                table: "GameTypes",
                columns: new[] { "GameTypeID", "Name" },
                values: new object[,]
                {
                    { "paralympic", "Paralympic Games" },
                    { "summer", "Summer Olympics" },
                    { "winter", "Winter Olympics" },
                    { "youth", "Youth Olympic Games" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Countries_GameTypes_GameTypeID",
                table: "Countries",
                column: "GameTypeID",
                principalTable: "GameTypes",
                principalColumn: "GameTypeID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Countries_GameTypes_GameTypeID",
                table: "Countries");

            migrationBuilder.DropTable(
                name: "GameTypes");

            migrationBuilder.RenameColumn(
                name: "GameTypeID",
                table: "Countries",
                newName: "GameTypeOlympicGameTypeID");

            migrationBuilder.RenameIndex(
                name: "IX_Countries_GameTypeID",
                table: "Countries",
                newName: "IX_Countries_GameTypeOlympicGameTypeID");

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

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "at",
                column: "GameTypeOlympicGameTypeID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "br",
                column: "GameTypeOlympicGameTypeID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "ca",
                column: "GameTypeOlympicGameTypeID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "cn",
                column: "GameTypeOlympicGameTypeID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "cy",
                column: "GameTypeOlympicGameTypeID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "de",
                column: "GameTypeOlympicGameTypeID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "fi",
                column: "GameTypeOlympicGameTypeID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "fr",
                column: "GameTypeOlympicGameTypeID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "gb",
                column: "GameTypeOlympicGameTypeID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "it",
                column: "GameTypeOlympicGameTypeID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "jm",
                column: "GameTypeOlympicGameTypeID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "jp",
                column: "GameTypeOlympicGameTypeID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "mx",
                column: "GameTypeOlympicGameTypeID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "nl",
                column: "GameTypeOlympicGameTypeID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "pk",
                column: "GameTypeOlympicGameTypeID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "pt",
                column: "GameTypeOlympicGameTypeID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "ru",
                column: "GameTypeOlympicGameTypeID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "se",
                column: "GameTypeOlympicGameTypeID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "sk",
                column: "GameTypeOlympicGameTypeID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "th",
                column: "GameTypeOlympicGameTypeID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "ua",
                column: "GameTypeOlympicGameTypeID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "us",
                column: "GameTypeOlympicGameTypeID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "uy",
                column: "GameTypeOlympicGameTypeID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "zw",
                column: "GameTypeOlympicGameTypeID",
                value: null);

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

            migrationBuilder.AddForeignKey(
                name: "FK_Countries_OlympicGames_GameTypeOlympicGameTypeID",
                table: "Countries",
                column: "GameTypeOlympicGameTypeID",
                principalTable: "OlympicGames",
                principalColumn: "OlympicGameTypeID");
        }
    }
}
