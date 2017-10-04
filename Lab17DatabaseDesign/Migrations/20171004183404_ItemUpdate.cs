using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Lab17DatabaseDesign.Migrations
{
    public partial class ItemUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TravelItem_EquipmentSet_EquipmentSetID",
                table: "TravelItem");

            migrationBuilder.AlterColumn<int>(
                name: "EquipmentSetID",
                table: "TravelItem",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_TravelItem_EquipmentSet_EquipmentSetID",
                table: "TravelItem",
                column: "EquipmentSetID",
                principalTable: "EquipmentSet",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TravelItem_EquipmentSet_EquipmentSetID",
                table: "TravelItem");

            migrationBuilder.AlterColumn<int>(
                name: "EquipmentSetID",
                table: "TravelItem",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_TravelItem_EquipmentSet_EquipmentSetID",
                table: "TravelItem",
                column: "EquipmentSetID",
                principalTable: "EquipmentSet",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
