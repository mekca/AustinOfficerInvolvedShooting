using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AustinOfficerInvolvedShootings.Data.Migrations
{
    public partial class _2ndMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "id",
                table: "OfficerEthnicity",
                newName: "Id");

            migrationBuilder.AlterColumn<string>(
                name: "Date",
                table: "ShootingIncident",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AddColumn<string>(
                name: "fName",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "lName",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "EditUserViewModel",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Role = table.Column<string>(nullable: true),
                    fName = table.Column<string>(nullable: true),
                    lName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EditUserViewModel", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EditUserViewModel");

            migrationBuilder.DropColumn(
                name: "fName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "lName",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "OfficerEthnicity",
                newName: "id");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "ShootingIncident",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
