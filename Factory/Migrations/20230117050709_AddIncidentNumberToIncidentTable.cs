using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectName.Migrations
{
    public partial class AddIncidentNumberToIncidentTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "IncidentNumber",
                table: "Incidents",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IncidentNumber",
                table: "Incidents");
        }
    }
}
