using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectASPCore.Migrations
{
    public partial class AddChampStateOrderPlaced : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderPlaced",
                table: "Orders",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "Orders",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "State",
                table: "Orders");

            migrationBuilder.AlterColumn<decimal>(
                name: "OrderPlaced",
                table: "Orders",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(DateTime));
        }
    }
}
