using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace test2.Migrations
{
    public partial class AddedVolunteer_PetTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Volunteer_Pet",
                columns: table => new
                {
                    IdVolunteer = table.Column<int>(nullable: false),
                    IdPet = table.Column<int>(nullable: false),
                    DateAccepted = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Volunteer_Pet", x => new { x.IdPet, x.IdVolunteer });
                    table.ForeignKey(
                        name: "IdPet",
                        column: x => x.IdPet,
                        principalTable: "Pet",
                        principalColumn: "IdPet",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "IdVolunteer",
                        column: x => x.IdVolunteer,
                        principalTable: "Volunteer",
                        principalColumn: "IdVolunteer",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Volunteer_Pet_IdVolunteer",
                table: "Volunteer_Pet",
                column: "IdVolunteer");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Volunteer_Pet");
        }
    }
}
