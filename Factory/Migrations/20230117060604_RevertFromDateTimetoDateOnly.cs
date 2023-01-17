using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectName.Migrations
{
    public partial class RevertFromDateTimetoDateOnly : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateOnly>(
                name: "LicenseExpiry",
                table: "Engineers",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "LicenseExpiry",
                table: "Engineers",
                type: "datetime(6)",
                nullable: false,
                oldClrType: typeof(DateOnly),
                oldType: "date");
        }
    }
}
