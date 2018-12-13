using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCore_Mod3.Migrations
{
    public partial class Estudiantes_DataSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Estudiantes",
                columns: new[] { "Id", "EstaBorrado", "FechaNacimiento", "Nombre" },
                values: new object[] { 25, false, new DateTime(1985, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Data Seed" });

            migrationBuilder.InsertData(
                table: "Estudiantes",
                columns: new[] { "Id", "EstaBorrado", "FechaNacimiento", "Nombre" },
                values: new object[] { 26, false, new DateTime(1995, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Data Seed2" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
