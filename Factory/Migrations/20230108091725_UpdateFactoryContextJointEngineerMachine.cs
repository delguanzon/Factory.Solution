using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectName.Migrations
{
    public partial class UpdateFactoryContextJointEngineerMachine : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Assignments_Engineers_EngineerId",
                table: "Assignments");

            migrationBuilder.DropForeignKey(
                name: "FK_Assignments_Machines_MachineId",
                table: "Assignments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Assignments",
                table: "Assignments");

            migrationBuilder.DropIndex(
                name: "IX_Assignments_MachineId",
                table: "Assignments");

            migrationBuilder.RenameTable(
                name: "Assignments",
                newName: "EngineerMachines");

            migrationBuilder.RenameIndex(
                name: "IX_Assignments_EngineerId",
                table: "EngineerMachines",
                newName: "IX_EngineerMachines_EngineerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EngineerMachines",
                table: "EngineerMachines",
                column: "EngineerMachineId");

            migrationBuilder.CreateIndex(
                name: "IX_EngineerMachines_MachineId",
                table: "EngineerMachines",
                column: "MachineId");

            migrationBuilder.AddForeignKey(
                name: "FK_EngineerMachines_Engineers_EngineerId",
                table: "EngineerMachines",
                column: "EngineerId",
                principalTable: "Engineers",
                principalColumn: "EngineerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EngineerMachines_Machines_MachineId",
                table: "EngineerMachines",
                column: "MachineId",
                principalTable: "Machines",
                principalColumn: "MachineId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EngineerMachines_Engineers_EngineerId",
                table: "EngineerMachines");

            migrationBuilder.DropForeignKey(
                name: "FK_EngineerMachines_Machines_MachineId",
                table: "EngineerMachines");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EngineerMachines",
                table: "EngineerMachines");

            migrationBuilder.DropIndex(
                name: "IX_EngineerMachines_MachineId",
                table: "EngineerMachines");

            migrationBuilder.RenameTable(
                name: "EngineerMachines",
                newName: "Assignments");

            migrationBuilder.RenameIndex(
                name: "IX_EngineerMachines_EngineerId",
                table: "Assignments",
                newName: "IX_Assignments_EngineerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Assignments",
                table: "Assignments",
                column: "EngineerMachineId");

            migrationBuilder.CreateIndex(
                name: "IX_Assignments_MachineId",
                table: "Assignments",
                column: "MachineId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Assignments_Engineers_EngineerId",
                table: "Assignments",
                column: "EngineerId",
                principalTable: "Engineers",
                principalColumn: "EngineerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Assignments_Machines_MachineId",
                table: "Assignments",
                column: "MachineId",
                principalTable: "Machines",
                principalColumn: "MachineId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
