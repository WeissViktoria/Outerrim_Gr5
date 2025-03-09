using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Model.Migrations
{
    /// <inheritdoc />
    public partial class initCreate3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AIRCRAFTS_AIRCRAFT_SPECIFICATIONS_SPEZIFIKATION_ID",
                table: "AIRCRAFTS");

            migrationBuilder.RenameColumn(
                name: "SPEZIFIKATION_ID",
                table: "AIRCRAFTS",
                newName: "SPECIFICATION_ID");

            migrationBuilder.RenameColumn(
                name: "SPEZIFICATION_ID",
                table: "AIRCRAFTS",
                newName: "FUEL");

            migrationBuilder.RenameIndex(
                name: "IX_AIRCRAFTS_SPEZIFIKATION_ID",
                table: "AIRCRAFTS",
                newName: "IX_AIRCRAFTS_SPECIFICATION_ID");

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

            migrationBuilder.RenameColumn(
                name: "SPECIFICATION_ID",
                table: "AIRCRAFTS",
                newName: "SPEZIFIKATION_ID");

            migrationBuilder.RenameColumn(
                name: "FUEL",
                table: "AIRCRAFTS",
                newName: "SPEZIFICATION_ID");

            migrationBuilder.RenameIndex(
                name: "IX_AIRCRAFTS_SPECIFICATION_ID",
                table: "AIRCRAFTS",
                newName: "IX_AIRCRAFTS_SPEZIFIKATION_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_AIRCRAFTS_AIRCRAFT_SPECIFICATIONS_SPEZIFIKATION_ID",
                table: "AIRCRAFTS",
                column: "SPEZIFIKATION_ID",
                principalTable: "AIRCRAFT_SPECIFICATIONS",
                principalColumn: "AIRCRAFT_SPECIFICATION_ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
