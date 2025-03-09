using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Model.Migrations
{
    /// <inheritdoc />
    public partial class initCreate2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AIRCRAFT_CREW_JT_Aircrafts_AIRCRAFT_ID",
                table: "AIRCRAFT_CREW_JT");

            migrationBuilder.DropForeignKey(
                name: "FK_Aircrafts_AIRCRAFT_SPECIFICATIONS_SPEZIFIKATION_ID",
                table: "Aircrafts");

            migrationBuilder.DropForeignKey(
                name: "FK_COMPARTMENT_Aircrafts_AIRCRAFT_ID",
                table: "COMPARTMENT");

            migrationBuilder.DropForeignKey(
                name: "FK_MACHINERIES_BT_COMPARTMENT_COMPARTMENT_ID",
                table: "MACHINERIES_BT");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Aircrafts",
                table: "Aircrafts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_COMPARTMENT",
                table: "COMPARTMENT");

            migrationBuilder.RenameTable(
                name: "Aircrafts",
                newName: "AIRCRAFTS");

            migrationBuilder.RenameTable(
                name: "COMPARTMENT",
                newName: "COMPARTMENTS");

            migrationBuilder.RenameIndex(
                name: "IX_Aircrafts_SPEZIFIKATION_ID",
                table: "AIRCRAFTS",
                newName: "IX_AIRCRAFTS_SPEZIFIKATION_ID");

            migrationBuilder.RenameIndex(
                name: "IX_COMPARTMENT_AIRCRAFT_ID",
                table: "COMPARTMENTS",
                newName: "IX_COMPARTMENTS_AIRCRAFT_ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AIRCRAFTS",
                table: "AIRCRAFTS",
                column: "AIRCRAFT_ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_COMPARTMENTS",
                table: "COMPARTMENTS",
                column: "COMPARTMENT_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_AIRCRAFT_CREW_JT_AIRCRAFTS_AIRCRAFT_ID",
                table: "AIRCRAFT_CREW_JT",
                column: "AIRCRAFT_ID",
                principalTable: "AIRCRAFTS",
                principalColumn: "AIRCRAFT_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AIRCRAFTS_AIRCRAFT_SPECIFICATIONS_SPEZIFIKATION_ID",
                table: "AIRCRAFTS",
                column: "SPEZIFIKATION_ID",
                principalTable: "AIRCRAFT_SPECIFICATIONS",
                principalColumn: "AIRCRAFT_SPECIFICATION_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_COMPARTMENTS_AIRCRAFTS_AIRCRAFT_ID",
                table: "COMPARTMENTS",
                column: "AIRCRAFT_ID",
                principalTable: "AIRCRAFTS",
                principalColumn: "AIRCRAFT_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MACHINERIES_BT_COMPARTMENTS_COMPARTMENT_ID",
                table: "MACHINERIES_BT",
                column: "COMPARTMENT_ID",
                principalTable: "COMPARTMENTS",
                principalColumn: "COMPARTMENT_ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AIRCRAFT_CREW_JT_AIRCRAFTS_AIRCRAFT_ID",
                table: "AIRCRAFT_CREW_JT");

            migrationBuilder.DropForeignKey(
                name: "FK_AIRCRAFTS_AIRCRAFT_SPECIFICATIONS_SPEZIFIKATION_ID",
                table: "AIRCRAFTS");

            migrationBuilder.DropForeignKey(
                name: "FK_COMPARTMENTS_AIRCRAFTS_AIRCRAFT_ID",
                table: "COMPARTMENTS");

            migrationBuilder.DropForeignKey(
                name: "FK_MACHINERIES_BT_COMPARTMENTS_COMPARTMENT_ID",
                table: "MACHINERIES_BT");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AIRCRAFTS",
                table: "AIRCRAFTS");

            migrationBuilder.DropPrimaryKey(
                name: "PK_COMPARTMENTS",
                table: "COMPARTMENTS");

            migrationBuilder.RenameTable(
                name: "AIRCRAFTS",
                newName: "Aircrafts");

            migrationBuilder.RenameTable(
                name: "COMPARTMENTS",
                newName: "COMPARTMENT");

            migrationBuilder.RenameIndex(
                name: "IX_AIRCRAFTS_SPEZIFIKATION_ID",
                table: "Aircrafts",
                newName: "IX_Aircrafts_SPEZIFIKATION_ID");

            migrationBuilder.RenameIndex(
                name: "IX_COMPARTMENTS_AIRCRAFT_ID",
                table: "COMPARTMENT",
                newName: "IX_COMPARTMENT_AIRCRAFT_ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Aircrafts",
                table: "Aircrafts",
                column: "AIRCRAFT_ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_COMPARTMENT",
                table: "COMPARTMENT",
                column: "COMPARTMENT_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_AIRCRAFT_CREW_JT_Aircrafts_AIRCRAFT_ID",
                table: "AIRCRAFT_CREW_JT",
                column: "AIRCRAFT_ID",
                principalTable: "Aircrafts",
                principalColumn: "AIRCRAFT_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Aircrafts_AIRCRAFT_SPECIFICATIONS_SPEZIFIKATION_ID",
                table: "Aircrafts",
                column: "SPEZIFIKATION_ID",
                principalTable: "AIRCRAFT_SPECIFICATIONS",
                principalColumn: "AIRCRAFT_SPECIFICATION_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_COMPARTMENT_Aircrafts_AIRCRAFT_ID",
                table: "COMPARTMENT",
                column: "AIRCRAFT_ID",
                principalTable: "Aircrafts",
                principalColumn: "AIRCRAFT_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MACHINERIES_BT_COMPARTMENT_COMPARTMENT_ID",
                table: "MACHINERIES_BT",
                column: "COMPARTMENT_ID",
                principalTable: "COMPARTMENT",
                principalColumn: "COMPARTMENT_ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
