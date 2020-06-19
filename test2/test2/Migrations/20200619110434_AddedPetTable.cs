using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace test2.Migrations
{
    public partial class AddedPetTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pet",
                columns: table => new
                {
                    IdPet = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdBreedType = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 80, nullable: false),
                    IsMale = table.Column<bool>(type: "bit", nullable: false),
                    DateRegistered = table.Column<DateTime>(type: "date", nullable: true),
                    DateAdopted = table.Column<DateTime>(type: "date", nullable: false),
                    ApprocimateDateOfBirth = table.Column<DateTime>(type: "date", nullable: false),
                    BreedTypeNavigationIdBreedType = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Pet_pk", x => x.IdPet);
                    table.ForeignKey(
                        name: "FK_Pet_BreedType_BreedTypeNavigationIdBreedType",
                        column: x => x.BreedTypeNavigationIdBreedType,
                        principalTable: "BreedType",
                        principalColumn: "IdBreedType",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pet_BreedTypeNavigationIdBreedType",
                table: "Pet",
                column: "BreedTypeNavigationIdBreedType");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pet");
        }
    }
}
