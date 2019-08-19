using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NewsPortal.Identity.API.Migrations
{
    public partial class user1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Guid",
                keyValue: new Guid("00a35180-51ef-4219-9d91-0f82d12202ef"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Guid",
                keyValue: new Guid("7af58215-28e5-400f-ab60-2e3c3d3b9759"));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Guid", "Login", "Password" },
                values: new object[,]
                {
                    { new Guid("53411741-42b6-4808-9414-b8d884cd5da3"), "nikita@mail.ru", "AQAAAAEAACcQAAAAEJ+oiz9BOPiMSOv0Bxh6dRhV+Y9oISN9teDEinIZ991bMR1rnm4RhkcOAHwY+UUx1Q==" },
                    { new Guid("120d7266-a633-4bfa-90a6-84448af2990f"), "ivan@mail.ru", "654321" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Guid",
                keyValue: new Guid("120d7266-a633-4bfa-90a6-84448af2990f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Guid",
                keyValue: new Guid("53411741-42b6-4808-9414-b8d884cd5da3"));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Guid", "Login", "Password" },
                values: new object[,]
                {
                    { new Guid("7af58215-28e5-400f-ab60-2e3c3d3b9759"), "nikita@mail.ru", "AQAAAAEAACcQAAAAEE/CxB9Zs0P1T2bwduuslra/qJWnyIniUw6BDOTT15MPtzJhgvI7HFya3kSdv7GEMQ==" },
                    { new Guid("00a35180-51ef-4219-9d91-0f82d12202ef"), "ivan@mail.ru", "654321" }
                });
        }
    }
}
