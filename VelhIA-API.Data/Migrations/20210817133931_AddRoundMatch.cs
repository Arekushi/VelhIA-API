using Microsoft.EntityFrameworkCore.Migrations;

namespace VelhIA_API.Data.Migrations
{
    public partial class AddRoundMatch : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Round",
                table: "Match",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Round",
                table: "Match");
        }
    }
}
