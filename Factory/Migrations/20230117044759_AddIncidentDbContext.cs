using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectName.Migrations
{
    public partial class AddIncidentDbContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Engineers_Location_LocationId",
                table: "Engineers");

            migrationBuilder.DropForeignKey(
                name: "FK_Incident_Engineers_EngineerId",
                table: "Incident");

            migrationBuilder.DropForeignKey(
                name: "FK_Incident_Location_LocationId",
                table: "Incident");

            migrationBuilder.DropForeignKey(
                name: "FK_Incident_Machines_MachineId",
                table: "Incident");

            migrationBuilder.DropForeignKey(
                name: "FK_Machines_Location_LocationId",
                table: "Machines");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Location",
                table: "Location");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Incident",
                table: "Incident");

            migrationBuilder.RenameTable(
                name: "Location",
                newName: "Locations");

            migrationBuilder.RenameTable(
                name: "Incident",
                newName: "Incidents");

            migrationBuilder.RenameIndex(
                name: "IX_Incident_MachineId",
                table: "Incidents",
                newName: "IX_Incidents_MachineId");

            migrationBuilder.RenameIndex(
                name: "IX_Incident_LocationId",
                table: "Incidents",
                newName: "IX_Incidents_LocationId");

            migrationBuilder.RenameIndex(
                name: "IX_Incident_EngineerId",
                table: "Incidents",
                newName: "IX_Incidents_EngineerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Locations",
                table: "Locations",
                column: "LocationId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Incidents",
                table: "Incidents",
                column: "IncidentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Engineers_Locations_LocationId",
                table: "Engineers",
                column: "LocationId",
                principalTable: "Locations",
                principalColumn: "LocationId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Incidents_Engineers_EngineerId",
                table: "Incidents",
                column: "EngineerId",
                principalTable: "Engineers",
                principalColumn: "EngineerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Incidents_Locations_LocationId",
                table: "Incidents",
                column: "LocationId",
                principalTable: "Locations",
                principalColumn: "LocationId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Incidents_Machines_MachineId",
                table: "Incidents",
                column: "MachineId",
                principalTable: "Machines",
                principalColumn: "MachineId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Machines_Locations_LocationId",
                table: "Machines",
                column: "LocationId",
                principalTable: "Locations",
                principalColumn: "LocationId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Engineers_Locations_LocationId",
                table: "Engineers");

            migrationBuilder.DropForeignKey(
                name: "FK_Incidents_Engineers_EngineerId",
                table: "Incidents");

            migrationBuilder.DropForeignKey(
                name: "FK_Incidents_Locations_LocationId",
                table: "Incidents");

            migrationBuilder.DropForeignKey(
                name: "FK_Incidents_Machines_MachineId",
                table: "Incidents");

            migrationBuilder.DropForeignKey(
                name: "FK_Machines_Locations_LocationId",
                table: "Machines");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Locations",
                table: "Locations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Incidents",
                table: "Incidents");

            migrationBuilder.RenameTable(
                name: "Locations",
                newName: "Location");

            migrationBuilder.RenameTable(
                name: "Incidents",
                newName: "Incident");

            migrationBuilder.RenameIndex(
                name: "IX_Incidents_MachineId",
                table: "Incident",
                newName: "IX_Incident_MachineId");

            migrationBuilder.RenameIndex(
                name: "IX_Incidents_LocationId",
                table: "Incident",
                newName: "IX_Incident_LocationId");

            migrationBuilder.RenameIndex(
                name: "IX_Incidents_EngineerId",
                table: "Incident",
                newName: "IX_Incident_EngineerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Location",
                table: "Location",
                column: "LocationId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Incident",
                table: "Incident",
                column: "IncidentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Engineers_Location_LocationId",
                table: "Engineers",
                column: "LocationId",
                principalTable: "Location",
                principalColumn: "LocationId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Incident_Engineers_EngineerId",
                table: "Incident",
                column: "EngineerId",
                principalTable: "Engineers",
                principalColumn: "EngineerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Incident_Location_LocationId",
                table: "Incident",
                column: "LocationId",
                principalTable: "Location",
                principalColumn: "LocationId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Incident_Machines_MachineId",
                table: "Incident",
                column: "MachineId",
                principalTable: "Machines",
                principalColumn: "MachineId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Machines_Location_LocationId",
                table: "Machines",
                column: "LocationId",
                principalTable: "Location",
                principalColumn: "LocationId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
