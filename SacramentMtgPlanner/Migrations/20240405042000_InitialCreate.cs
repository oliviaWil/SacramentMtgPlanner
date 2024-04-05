using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SacramentMtgPlanner.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Meeting",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateOfMeeting = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ConductingLeader = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OpeningHymn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SacramentHymn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClosingHymn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MusicalNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IntermediateHymn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OpeningPrayer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClosingPrayer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Speakers = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Topics = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meeting", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Meeting");
        }
    }
}
