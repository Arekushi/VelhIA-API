using Microsoft.EntityFrameworkCore.Migrations;

namespace VelhIA_API.Data.Migrations
{
    public partial class FixAlgorithmTypeNameField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Value",
                table: "Victory");

            migrationBuilder.RenameColumn(
                name: "AlgoritmType",
                table: "Player",
                newName: "AlgorithmType");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AlgorithmType",
                table: "Player",
                newName: "AlgoritmType");

            migrationBuilder.AddColumn<int>(
                name: "Value",
                table: "Victory",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
