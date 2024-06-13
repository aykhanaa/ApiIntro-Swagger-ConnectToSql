using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiIntro.Migrations
{
    public partial class CreatedCategoryAtbles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedDate", "Name" },
                values: new object[] { 1, new DateTime(2024, 6, 13, 1, 52, 15, 765, DateTimeKind.Local).AddTicks(9384), "UI UX" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedDate", "Name" },
                values: new object[] { 2, new DateTime(2024, 6, 13, 1, 52, 15, 765, DateTimeKind.Local).AddTicks(9387), "Backend" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedDate", "Name" },
                values: new object[] { 3, new DateTime(2024, 6, 13, 1, 52, 15, 765, DateTimeKind.Local).AddTicks(9389), "Frontend" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
