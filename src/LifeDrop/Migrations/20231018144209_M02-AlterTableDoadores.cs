using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LifeDrop.Migrations
{
    public partial class M02AlterTableDoadores : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CPF",
                table: "Doadores",
                type: "nvarchar(max)",
                nullable: false);

            migrationBuilder.AddColumn<string>(
                name: "Genero",
                table: "Doadores",
                type: "nvarchar(max)",
                nullable: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}