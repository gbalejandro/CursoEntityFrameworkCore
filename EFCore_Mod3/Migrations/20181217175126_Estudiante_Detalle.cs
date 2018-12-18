using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCore_Mod3.Migrations
{
    public partial class Estudiante_Detalle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EstudianteDetalles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Identificacion = table.Column<string>(nullable: true),
                    EstudianteId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstudianteDetalles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EstudianteDetalles_Estudiantes_EstudianteId",
                        column: x => x.EstudianteId,
                        principalTable: "Estudiantes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Estudiantes",
                columns: new[] { "Id", "FechaNacimiento", "Nombre" },
                values: new object[] { 25, new DateTime(1985, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Data Seed" });

            migrationBuilder.InsertData(
                table: "Estudiantes",
                columns: new[] { "Id", "FechaNacimiento", "Nombre" },
                values: new object[] { 26, new DateTime(1995, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Data Seed2" });

            migrationBuilder.CreateIndex(
                name: "IX_EstudianteDetalles_EstudianteId",
                table: "EstudianteDetalles",
                column: "EstudianteId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EstudianteDetalles");

            migrationBuilder.DeleteData(
                table: "Estudiantes",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Estudiantes",
                keyColumn: "Id",
                keyValue: 26);
        }
    }
}
