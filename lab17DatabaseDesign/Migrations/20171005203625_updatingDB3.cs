using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace lab17DatabaseDesign.Migrations
{
    public partial class updatingDB3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Recomended_Destinations_DestinationsID",
                table: "Recomended");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Recomended",
                table: "Recomended");

            migrationBuilder.RenameTable(
                name: "Recomended",
                newName: "Recomendeds");

            migrationBuilder.RenameIndex(
                name: "IX_Recomended_DestinationsID",
                table: "Recomendeds",
                newName: "IX_Recomendeds_DestinationsID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Recomendeds",
                table: "Recomendeds",
                column: "ID");

            migrationBuilder.CreateTable(
                name: "DestinationSupplies",
                columns: table => new
                {
                    DestinationID = table.Column<int>(type: "int", nullable: false),
                    RecomendedsID = table.Column<int>(type: "int", nullable: false),
                    RequiredsID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DestinationSupplies", x => new { x.DestinationID, x.RecomendedsID });
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Recomendeds_Destinations_DestinationsID",
                table: "Recomendeds",
                column: "DestinationsID",
                principalTable: "Destinations",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Recomendeds_Destinations_DestinationsID",
                table: "Recomendeds");

            migrationBuilder.DropTable(
                name: "DestinationSupplies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Recomendeds",
                table: "Recomendeds");

            migrationBuilder.RenameTable(
                name: "Recomendeds",
                newName: "Recomended");

            migrationBuilder.RenameIndex(
                name: "IX_Recomendeds_DestinationsID",
                table: "Recomended",
                newName: "IX_Recomended_DestinationsID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Recomended",
                table: "Recomended",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Recomended_Destinations_DestinationsID",
                table: "Recomended",
                column: "DestinationsID",
                principalTable: "Destinations",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
