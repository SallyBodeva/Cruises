using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Cruises.Data.Migrations
{
    public partial class InitialMigration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 200, nullable: false),
                    Country = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CrewMembers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(maxLength: 50, nullable: false),
                    LastName = table.Column<string>(maxLength: 50, nullable: false),
                    Age = table.Column<int>(nullable: false),
                    Rating = table.Column<double>(nullable: false),
                    Position = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CrewMembers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Passengers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(maxLength: 50, nullable: false),
                    LastName = table.Column<string>(maxLength: 50, nullable: false),
                    PhoneNumber = table.Column<string>(nullable: false),
                    Age = table.Column<int>(nullable: false),
                    IsStudent = table.Column<bool>(nullable: false),
                    IsRetiree = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Passengers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ShipTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 75, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShipTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Harbours",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    CityId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Harbours", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Harbours_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ships",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Model = table.Column<string>(maxLength: 20, nullable: false),
                    Capacity = table.Column<int>(nullable: false),
                    ImageUrl = table.Column<string>(nullable: true),
                    ShipTypeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ships", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ships_ShipTypes_ShipTypeId",
                        column: x => x.ShipTypeId,
                        principalTable: "ShipTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ShipCrewMembers",
                columns: table => new
                {
                    ShipId = table.Column<int>(nullable: false),
                    CrewMemberId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShipCrewMembers", x => new { x.ShipId, x.CrewMemberId });
                    table.ForeignKey(
                        name: "FK_ShipCrewMembers_CrewMembers_CrewMemberId",
                        column: x => x.CrewMemberId,
                        principalTable: "CrewMembers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ShipCrewMembers_Ships_ShipId",
                        column: x => x.ShipId,
                        principalTable: "Ships",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Voyages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    HarbourId = table.Column<int>(nullable: false),
                    DestinationHarbourId = table.Column<int>(nullable: false),
                    Duration = table.Column<int>(nullable: false),
                    ShipId = table.Column<int>(nullable: false),
                    TicketPrice = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Voyages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Voyages_Harbours_DestinationHarbourId",
                        column: x => x.DestinationHarbourId,
                        principalTable: "Harbours",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Voyages_Harbours_HarbourId",
                        column: x => x.HarbourId,
                        principalTable: "Harbours",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Voyages_Ships_ShipId",
                        column: x => x.ShipId,
                        principalTable: "Ships",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PassengerId = table.Column<int>(nullable: false),
                    VoyageId = table.Column<int>(nullable: false),
                    ReservationDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reservations_Passengers_PassengerId",
                        column: x => x.PassengerId,
                        principalTable: "Passengers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reservations_Voyages_VoyageId",
                        column: x => x.VoyageId,
                        principalTable: "Voyages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Harbours_CityId",
                table: "Harbours",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Harbours_Name",
                table: "Harbours",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Passengers_PhoneNumber",
                table: "Passengers",
                column: "PhoneNumber",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_PassengerId",
                table: "Reservations",
                column: "PassengerId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_VoyageId",
                table: "Reservations",
                column: "VoyageId");

            migrationBuilder.CreateIndex(
                name: "IX_ShipCrewMembers_CrewMemberId",
                table: "ShipCrewMembers",
                column: "CrewMemberId");

            migrationBuilder.CreateIndex(
                name: "IX_Ships_Name",
                table: "Ships",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ships_ShipTypeId",
                table: "Ships",
                column: "ShipTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ShipTypes_Name",
                table: "ShipTypes",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Voyages_DestinationHarbourId",
                table: "Voyages",
                column: "DestinationHarbourId");

            migrationBuilder.CreateIndex(
                name: "IX_Voyages_HarbourId",
                table: "Voyages",
                column: "HarbourId");

            migrationBuilder.CreateIndex(
                name: "IX_Voyages_ShipId",
                table: "Voyages",
                column: "ShipId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reservations");

            migrationBuilder.DropTable(
                name: "ShipCrewMembers");

            migrationBuilder.DropTable(
                name: "Passengers");

            migrationBuilder.DropTable(
                name: "Voyages");

            migrationBuilder.DropTable(
                name: "CrewMembers");

            migrationBuilder.DropTable(
                name: "Harbours");

            migrationBuilder.DropTable(
                name: "Ships");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "ShipTypes");
        }
    }
}
