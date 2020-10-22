using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectASPCore.Migrations
{
    public partial class AddChampNotes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Notes",
                table: "Books",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Notes",
                table: "Books");
        }
    }
}
