using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AnimaLuv.Data.Migrations
{
    public partial class stuffingMaterial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Age",
                table: "Character");

            migrationBuilder.AddColumn<string>(
                name: "stuffingLevel",
                table: "Character",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "stuffingMaterial",
                table: "Character",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "stuffingLevel",
                table: "Character");

            migrationBuilder.DropColumn(
                name: "stuffingMaterial",
                table: "Character");

            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "Character",
                nullable: false,
                defaultValue: 0);
        }
    }
}
