using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCore_Mod3.Migrations
{
    public partial class Estudiante_EstaBorrado : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "EstaBorrado",
                table: "Estudiantes",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EstaBorrado",
                table: "Estudiantes");
        }
    }
}
