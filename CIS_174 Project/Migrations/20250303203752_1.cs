using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CIS_174_Project.Migrations
{
    /// <inheritdoc />
    public partial class _1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "austria");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "brazil");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "canada");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "china");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "cyprus");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "finland");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "france");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "germany");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "greatbritain");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "italy");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "jamaica");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "japan");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "mexico");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "netherlands");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "pakistan");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "portugal");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "russia");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "slovakia");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "sweden");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "thailand");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "ukraine");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "uruguay");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "usa");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "zimbabwe");

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "CountryID", "CountryFlag", "GameTypeOlympicGameTypeID", "Name", "SportTypeID" },
                values: new object[,]
                {
                    { "at", "~/images/olympics/at.png", null, "Austria", "outdoor" },
                    { "br", "~/images/olympics/br.png", null, "Brazil", "outdoor" },
                    { "ca", "~/images/olympics/ca.png", null, "Canada", "indoor" },
                    { "cn", "~/images/olympics/cn.png", null, "China", "indoor" },
                    { "cy", "~/images/olympics/cy.png", null, "Cyprus", "indoor" },
                    { "de", "~/images/olympics/de.png", null, "Germany", "indoor" },
                    { "fi", "~/images/olympics/fi.png", null, "Finland", "outdoor" },
                    { "fr", "~/images/olympics/fr.png", null, "France", "indoor" },
                    { "gb", "~/images/olympics/gb.png", null, "Great Britain", "indoor" },
                    { "it", "~/images/olympics/it.png", null, "Italy", "outdoor" },
                    { "jm", "~/images/olympics/jm.png", null, "Jamaica", "outdoor" },
                    { "jp", "~/images/olympics/jp.png", null, "Japan", "outdoor" },
                    { "mx", "~/images/olympics/mx.png", null, "Mexico", "indoor" },
                    { "nl", "~/images/olympics/nl.png", null, "Netherlands", "outdoor" },
                    { "pk", "~/images/olympics/pk.png", null, "Pakistan", "outdoor" },
                    { "pt", "~/images/olympics/pt.png", null, "Portugal", "outdoor" },
                    { "ru", "~/images/olympics/ru.png", null, "Russia", "indoor" },
                    { "se", "~/images/olympics/se.png", null, "Sweden", "indoor" },
                    { "sk", "~/images/olympics/sk.png", null, "Slovakia", "outdoor" },
                    { "th", "~/images/olympics/th.png", null, "Thailand", "indoor" },
                    { "ua", "~/images/olympics/ua.png", null, "Ukraine", "indoor" },
                    { "us", "~/images/olympics/us.png", null, "USA", "outdoor" },
                    { "uy", "~/images/olympics/uy.png", null, "Uruguay", "indoor" },
                    { "zw", "~/images/olympics/zw.png", null, "Zimbabwe", "outdoor" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "at");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "br");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "ca");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "cn");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "cy");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "de");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "fi");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "fr");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "gb");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "it");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "jm");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "jp");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "mx");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "nl");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "pk");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "pt");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "ru");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "se");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "sk");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "th");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "ua");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "us");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "uy");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "zw");

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
        }
    }
}
