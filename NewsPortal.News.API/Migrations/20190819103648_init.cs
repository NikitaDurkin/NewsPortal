using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NewsPortal.News.API.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Publications",
                columns: table => new
                {
                    Guid = table.Column<Guid>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    Info = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Publications", x => x.Guid);
                });

            migrationBuilder.InsertData(
                table: "Publications",
                columns: new[] { "Guid", "Info", "Title" },
                values: new object[] { new Guid("b5b8926e-ad34-4cfc-a460-e9d8295dc448"), "qwertyuiop", "News1" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Publications");
        }
    }
}
