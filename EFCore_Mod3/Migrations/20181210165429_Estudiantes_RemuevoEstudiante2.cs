using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCore_Mod3.Migrations
{
    public partial class Estudiantes_RemuevoEstudiante2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Estudiantes",
                keyColumn: "Id",
                keyValue: 26);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Estudiantes",
                columns: new[] { "Id", "EstaBorrado", "FechaNacimiento", "Nombre" },
                values: new object[] { 26, false, new DateTime(1995, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Data Seed2" });
        }
    }
}
