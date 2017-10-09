using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace lab17DatabaseDesign.Migrations
{
    public partial class addedDSTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DestinationID",
                table: "Required");

            migrationBuilder.DropColumn(
                name: "DestinationID",
                table: "Recomended");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DestinationID",
                table: "Required",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DestinationID",
                table: "Recomended",
                nullable: false,
                defaultValue: 0);
        }
    }
}
