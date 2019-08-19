using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NewsPortal.Identity.API.Migrations
{
    public partial class user : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("cff8059b-91ee-4394-80a8-feb44fa86b9c"), "nikita@mail.ru", "AQAAAAEAACcQAAAAEEPkcr+Hj00NbC3ANqytDfCD+9nSlp1Lssl19Qkh9T41xSIB2Iq23ic3hjVsSiI5+w==" },
                    { new Guid("1f9d065b-1077-4b9c-aa57-e9fd26881cda"), "ivan@mail.ru", "AQAAAAEAACcQAAAAEB+jLnAl1tv/JmG5jiZgLGahAwYoAUBm/mEGTh4qW8favHXOMVQwpcZCJ/sx1dxtbg==" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { new Guid("53411741-42b6-4808-9414-b8d884cd5da3"), "nikita@mail.ru", "AQAAAAEAACcQAAAAEJ+oiz9BOPiMSOv0Bxh6dRhV+Y9oISN9teDEinIZ991bMR1rnm4RhkcOAHwY+UUx1Q==" },
                    { new Guid("120d7266-a633-4bfa-90a6-84448af2990f"), "ivan@mail.ru", "654321" }
                });
        }
    }
}
