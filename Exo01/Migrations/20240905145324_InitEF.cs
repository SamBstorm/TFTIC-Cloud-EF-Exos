﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Exo01.Migrations
{
    /// <inheritdoc />
    public partial class InitEF : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Films",
                columns: table => new
                {
                    FilmId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    AnneeSortie = table.Column<int>(type: "int", nullable: false),
                    Realisateur = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ActeurPrincipal = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Genre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Films", x => x.FilmId);
                    table.CheckConstraint("CK_Film_AnneeSortie", "[AnneeSortie] > 1975");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Films_Titre",
                table: "Films",
                column: "Titre",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Films");
        }
    }
}
