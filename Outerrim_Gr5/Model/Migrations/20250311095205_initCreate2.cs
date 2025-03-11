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
                name: "FK_AIRCRAFTS_AircraftSpezifications_SPECIFICATION_ID",
                table: "AIRCRAFTS");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AircraftSpezifications",
                table: "AircraftSpezifications");

            migrationBuilder.RenameTable(
                name: "AircraftSpezifications",
                newName: "AIRCRAFT_SPECIFICATIONS");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AIRCRAFT_SPECIFICATIONS",
                table: "AIRCRAFT_SPECIFICATIONS",
                column: "AIRCRAFT_SPECIFICATION_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_AIRCRAFTS_AIRCRAFT_SPECIFICATIONS_SPECIFICATION_ID",
                table: "AIRCRAFTS",
                column: "SPECIFICATION_ID",
                principalTable: "AIRCRAFT_SPECIFICATIONS",
                principalColumn: "AIRCRAFT_SPECIFICATION_ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AIRCRAFTS_AIRCRAFT_SPECIFICATIONS_SPECIFICATION_ID",
                table: "AIRCRAFTS");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AIRCRAFT_SPECIFICATIONS",
                table: "AIRCRAFT_SPECIFICATIONS");

            migrationBuilder.RenameTable(
                name: "AIRCRAFT_SPECIFICATIONS",
                newName: "AircraftSpezifications");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AircraftSpezifications",
                table: "AircraftSpezifications",
                column: "AIRCRAFT_SPECIFICATION_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_AIRCRAFTS_AircraftSpezifications_SPECIFICATION_ID",
                table: "AIRCRAFTS",
                column: "SPECIFICATION_ID",
                principalTable: "AircraftSpezifications",
                principalColumn: "AIRCRAFT_SPECIFICATION_ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
