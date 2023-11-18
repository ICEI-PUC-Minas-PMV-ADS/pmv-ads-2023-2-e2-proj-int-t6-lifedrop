using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LifeDrop.Migrations
{
    public partial class Relacao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AB_Negative",
                table: "BancosDeSangue",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AB_Positive",
                table: "BancosDeSangue",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "A_Negative",
                table: "BancosDeSangue",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "A_Positive",
                table: "BancosDeSangue",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "B_Negative",
                table: "BancosDeSangue",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "B_Positive",
                table: "BancosDeSangue",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "O_Negative",
                table: "BancosDeSangue",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "O_Positive",
                table: "BancosDeSangue",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AB_Negative",
                table: "BancosDeSangue");

            migrationBuilder.DropColumn(
                name: "AB_Positive",
                table: "BancosDeSangue");

            migrationBuilder.DropColumn(
                name: "A_Negative",
                table: "BancosDeSangue");

            migrationBuilder.DropColumn(
                name: "A_Positive",
                table: "BancosDeSangue");

            migrationBuilder.DropColumn(
                name: "B_Negative",
                table: "BancosDeSangue");

            migrationBuilder.DropColumn(
                name: "B_Positive",
                table: "BancosDeSangue");

            migrationBuilder.DropColumn(
                name: "O_Negative",
                table: "BancosDeSangue");

            migrationBuilder.DropColumn(
                name: "O_Positive",
                table: "BancosDeSangue");
        }
    }
}
