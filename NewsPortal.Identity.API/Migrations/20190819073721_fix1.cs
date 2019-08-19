using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NewsPortal.Identity.API.Migrations
{
    public partial class fix1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Guid",
                keyValue: new Guid("1f9d065b-1077-4b9c-aa57-e9fd26881cda"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Guid",
                keyValue: new Guid("cff8059b-91ee-4394-80a8-feb44fa86b9c"));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Guid", "Login", "Password" },
                values: new object[,]
                {
                    { new Guid("9d0bbacb-968f-49cd-afc2-ce55eac11def"), "nikita@mail.ru", "AQAAAAEAACcQAAAAEH9+83KP84WPdlpit90WJkFoXxe9YNsoy4JZ7g25B5M6PgR8tOs2rTc5tthPPVawCA==" },
                    { new Guid("68bab636-8213-4424-b00f-07ae5a96d021"), "ivan@mail.ru", "AQAAAAEAACcQAAAAEF+a2Z0qt0qOqXhsuvRhg/mNRDzIOak8ZDCZzeapIxiJutwkVgk3w1seATSnpLbGpA==" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Guid",
                keyValue: new Guid("68bab636-8213-4424-b00f-07ae5a96d021"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Guid",
                keyValue: new Guid("9d0bbacb-968f-49cd-afc2-ce55eac11def"));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Guid", "Login", "Password" },
                values: new object[,]
                {
                    { new Guid("cff8059b-91ee-4394-80a8-feb44fa86b9c"), "nikita@mail.ru", "AQAAAAEAACcQAAAAEEPkcr+Hj00NbC3ANqytDfCD+9nSlp1Lssl19Qkh9T41xSIB2Iq23ic3hjVsSiI5+w==" },
                    { new Guid("1f9d065b-1077-4b9c-aa57-e9fd26881cda"), "ivan@mail.ru", "AQAAAAEAACcQAAAAEB+jLnAl1tv/JmG5jiZgLGahAwYoAUBm/mEGTh4qW8favHXOMVQwpcZCJ/sx1dxtbg==" }
                });
        }
    }
}
