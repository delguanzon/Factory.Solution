using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectName.Migrations
{
    public partial class UpdateColumnTypeForDateTime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "NextService",
                table: "Machines",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "NextService",
                table: "Machines",
                type: "datetime(6)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "date");
        }
    }
}
