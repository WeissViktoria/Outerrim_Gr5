using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Model.Migrations
{
    /// <inheritdoc />
    public partial class initCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AircraftSpezifications",
                columns: table => new
                {
                    AIRCRAFT_SPECIFICATION_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    STRUCTURE = table.Column<int>(type: "int", nullable: false),
                    FUEL_CAPACITY = table.Column<int>(type: "int", nullable: false),
                    MIN_SPEED = table.Column<int>(type: "int", nullable: false),
                    MAX_SPEED = table.Column<int>(type: "int", nullable: false),
                    MAX_ALTITUDE = table.Column<int>(type: "int", nullable: false),
                    SPECIFICATION_CODE = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AircraftSpezifications", x => x.AIRCRAFT_SPECIFICATION_ID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CRIME_SYNDICATES",
                columns: table => new
                {
                    SYNDICATE_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NAME = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LOCATION = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CRIME_SYNDICATES", x => x.SYNDICATE_ID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "MERCENARIES",
                columns: table => new
                {
                    MERCENARY_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FIRST_NAME = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LAST_NAME = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    BODY_SKILL = table.Column<int>(type: "int", nullable: false),
                    COMBAT_SKILL = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MERCENARIES", x => x.MERCENARY_ID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AIRCRAFTS",
                columns: table => new
                {
                    AIRCRAFT_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    SPECIFICATION_ID = table.Column<int>(type: "int", nullable: false),
                    FUEL = table.Column<int>(type: "int", nullable: false),
                    SPEED = table.Column<int>(type: "int", nullable: false),
                    ALTITUDE = table.Column<int>(type: "int", nullable: false),
                    NAME = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AIRCRAFTS", x => x.AIRCRAFT_ID);
                    table.ForeignKey(
                        name: "FK_AIRCRAFTS_AircraftSpezifications_SPECIFICATION_ID",
                        column: x => x.SPECIFICATION_ID,
                        principalTable: "AircraftSpezifications",
                        principalColumn: "AIRCRAFT_SPECIFICATION_ID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "MERCENARY_HAS_REPUTATIONS_JT",
                columns: table => new
                {
                    MERCENARY_ID = table.Column<int>(type: "int", nullable: false),
                    CRIME_SYNDICATE_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MERCENARY_HAS_REPUTATIONS_JT", x => new { x.MERCENARY_ID, x.CRIME_SYNDICATE_ID });
                    table.ForeignKey(
                        name: "FK_MERCENARY_HAS_REPUTATIONS_JT_CRIME_SYNDICATES_CRIME_SYNDICAT~",
                        column: x => x.CRIME_SYNDICATE_ID,
                        principalTable: "CRIME_SYNDICATES",
                        principalColumn: "SYNDICATE_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MERCENARY_HAS_REPUTATIONS_JT_MERCENARIES_MERCENARY_ID",
                        column: x => x.MERCENARY_ID,
                        principalTable: "MERCENARIES",
                        principalColumn: "MERCENARY_ID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AIRCRAFT_CREW_JT",
                columns: table => new
                {
                    AIRCRAFT_ID = table.Column<int>(type: "int", nullable: false),
                    MERCENARY_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AIRCRAFT_CREW_JT", x => new { x.AIRCRAFT_ID, x.MERCENARY_ID });
                    table.ForeignKey(
                        name: "FK_AIRCRAFT_CREW_JT_AIRCRAFTS_AIRCRAFT_ID",
                        column: x => x.AIRCRAFT_ID,
                        principalTable: "AIRCRAFTS",
                        principalColumn: "AIRCRAFT_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AIRCRAFT_CREW_JT_MERCENARIES_MERCENARY_ID",
                        column: x => x.MERCENARY_ID,
                        principalTable: "MERCENARIES",
                        principalColumn: "MERCENARY_ID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "COMPARTMENTS",
                columns: table => new
                {
                    COMPARTMENT_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    AIRCRAFT_ID = table.Column<int>(type: "int", nullable: false),
                    NAME = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_COMPARTMENTS", x => x.COMPARTMENT_ID);
                    table.ForeignKey(
                        name: "FK_COMPARTMENTS_AIRCRAFTS_AIRCRAFT_ID",
                        column: x => x.AIRCRAFT_ID,
                        principalTable: "AIRCRAFTS",
                        principalColumn: "AIRCRAFT_ID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "MACHINERIES_BT",
                columns: table => new
                {
                    MACHINERY_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    COMPARTMENT_ID = table.Column<int>(type: "int", nullable: false),
                    LABEL = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FUNCTION = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MACHINERIES_BT", x => x.MACHINERY_ID);
                    table.ForeignKey(
                        name: "FK_MACHINERIES_BT_COMPARTMENTS_COMPARTMENT_ID",
                        column: x => x.COMPARTMENT_ID,
                        principalTable: "COMPARTMENTS",
                        principalColumn: "COMPARTMENT_ID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ENERGY_SYSTEMS",
                columns: table => new
                {
                    MACHINERY_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ENERGY_SYSTEMS", x => x.MACHINERY_ID);
                    table.ForeignKey(
                        name: "FK_ENERGY_SYSTEMS_MACHINERIES_BT_MACHINERY_ID",
                        column: x => x.MACHINERY_ID,
                        principalTable: "MACHINERIES_BT",
                        principalColumn: "MACHINERY_ID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ENVIRONMENTAL_SYSTEMS",
                columns: table => new
                {
                    MACHINERY_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ENVIRONMENTAL_SYSTEMS", x => x.MACHINERY_ID);
                    table.ForeignKey(
                        name: "FK_ENVIRONMENTAL_SYSTEMS_MACHINERIES_BT_MACHINERY_ID",
                        column: x => x.MACHINERY_ID,
                        principalTable: "MACHINERIES_BT",
                        principalColumn: "MACHINERY_ID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "WEAPONS",
                columns: table => new
                {
                    MACHINERY_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WEAPONS", x => x.MACHINERY_ID);
                    table.ForeignKey(
                        name: "FK_WEAPONS_MACHINERIES_BT_MACHINERY_ID",
                        column: x => x.MACHINERY_ID,
                        principalTable: "MACHINERIES_BT",
                        principalColumn: "MACHINERY_ID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_AIRCRAFT_CREW_JT_MERCENARY_ID",
                table: "AIRCRAFT_CREW_JT",
                column: "MERCENARY_ID");

            migrationBuilder.CreateIndex(
                name: "IX_AIRCRAFTS_SPECIFICATION_ID",
                table: "AIRCRAFTS",
                column: "SPECIFICATION_ID");

            migrationBuilder.CreateIndex(
                name: "IX_COMPARTMENTS_AIRCRAFT_ID",
                table: "COMPARTMENTS",
                column: "AIRCRAFT_ID");

            migrationBuilder.CreateIndex(
                name: "IX_MACHINERIES_BT_COMPARTMENT_ID",
                table: "MACHINERIES_BT",
                column: "COMPARTMENT_ID");

            migrationBuilder.CreateIndex(
                name: "IX_MERCENARY_HAS_REPUTATIONS_JT_CRIME_SYNDICATE_ID",
                table: "MERCENARY_HAS_REPUTATIONS_JT",
                column: "CRIME_SYNDICATE_ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AIRCRAFT_CREW_JT");

            migrationBuilder.DropTable(
                name: "ENERGY_SYSTEMS");

            migrationBuilder.DropTable(
                name: "ENVIRONMENTAL_SYSTEMS");

            migrationBuilder.DropTable(
                name: "MERCENARY_HAS_REPUTATIONS_JT");

            migrationBuilder.DropTable(
                name: "WEAPONS");

            migrationBuilder.DropTable(
                name: "CRIME_SYNDICATES");

            migrationBuilder.DropTable(
                name: "MERCENARIES");

            migrationBuilder.DropTable(
                name: "MACHINERIES_BT");

            migrationBuilder.DropTable(
                name: "COMPARTMENTS");

            migrationBuilder.DropTable(
                name: "AIRCRAFTS");

            migrationBuilder.DropTable(
                name: "AircraftSpezifications");
        }
    }
}
