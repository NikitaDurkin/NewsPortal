using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NewsPortal.Identity.API.Migrations
{
    public partial class docker : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("a1ef9b02-68db-4243-8f16-2076e4405a7c"), "nikita@mail.ru", "AQAAAAEAACcQAAAAEJxEsUZQ+rchi0uw9yWqspojc+jO3LdrqedWsVfYyTzLkwclGZx50nLRXKevZ9Rddg==" },
                    { new Guid("08e9c9df-9f7b-41dd-8f58-cf574eba4e23"), "ivan@mail.ru", "AQAAAAEAACcQAAAAEDmRadqhukJsfrnj7CHqeEGo2lMvf83/8p/V05al3vLdwScUYLY4s43OMTZ/m9WbRg==" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Guid",
                keyValue: new Guid("08e9c9df-9f7b-41dd-8f58-cf574eba4e23"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Guid",
                keyValue: new Guid("a1ef9b02-68db-4243-8f16-2076e4405a7c"));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Guid", "Login", "Password" },
                values: new object[,]
                {
                    { new Guid("9d0bbacb-968f-49cd-afc2-ce55eac11def"), "nikita@mail.ru", "AQAAAAEAACcQAAAAEH9+83KP84WPdlpit90WJkFoXxe9YNsoy4JZ7g25B5M6PgR8tOs2rTc5tthPPVawCA==" },
                    { new Guid("68bab636-8213-4424-b00f-07ae5a96d021"), "ivan@mail.ru", "AQAAAAEAACcQAAAAEF+a2Z0qt0qOqXhsuvRhg/mNRDzIOak8ZDCZzeapIxiJutwkVgk3w1seATSnpLbGpA==" }
                });
        }
    }
}
