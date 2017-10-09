using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace TravelPackersLab17.Migrations
{
    public partial class supplyCollection : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SuppliesID",
                table: "Weather");

            migrationBuilder.CreateIndex(
                name: "IX_Supplies_WeatherID",
                table: "Supplies",
                column: "WeatherID");

            migrationBuilder.AddForeignKey(
                name: "FK_Supplies_Weather_WeatherID",
                table: "Supplies",
                column: "WeatherID",
                principalTable: "Weather",
                principalColumn: "WeatherID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Supplies_Weather_WeatherID",
                table: "Supplies");

            migrationBuilder.DropIndex(
                name: "IX_Supplies_WeatherID",
                table: "Supplies");

            migrationBuilder.AddColumn<int>(
                name: "SuppliesID",
                table: "Weather",
                nullable: false,
                defaultValue: 0);
        }
    }
}
