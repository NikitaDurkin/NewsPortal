using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NewsPortal.Identity.API.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Guid = table.Column<Guid>(nullable: false),
                    Login = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Guid);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Guid", "Login", "Password" },
                values: new object[,]
                {
                    { new Guid("7af58215-28e5-400f-ab60-2e3c3d3b9759"), "nikita@mail.ru", "AQAAAAEAACcQAAAAEE/CxB9Zs0P1T2bwduuslra/qJWnyIniUw6BDOTT15MPtzJhgvI7HFya3kSdv7GEMQ==" },
                    { new Guid("00a35180-51ef-4219-9d91-0f82d12202ef"), "ivan@mail.ru", "654321" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
