using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LifeDrop.Migrations
{
    public partial class M04AlterTableAgendamentoBancoDeSangue : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DataEHora",
                table: "Agendamentos",
                newName: "Hora");

            migrationBuilder.AddColumn<string>(
                name: "Estado",
                table: "BancosDeSangue",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Municipio",
                table: "BancosDeSangue",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "Data",
                table: "Agendamentos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "IdBancoDeSangue",
                table: "Agendamentos",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Estado",
                table: "BancosDeSangue");

            migrationBuilder.DropColumn(
                name: "Municipio",
                table: "BancosDeSangue");

            migrationBuilder.DropColumn(
                name: "Data",
                table: "Agendamentos");

            migrationBuilder.DropColumn(
                name: "IdBancoDeSangue",
                table: "Agendamentos");

            migrationBuilder.RenameColumn(
                name: "Hora",
                table: "Agendamentos",
                newName: "DataEHora");
        }
    }
}