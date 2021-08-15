using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VelhIA_API.Data.Migrations
{
    public partial class CreateResultAndVictory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MatchPlayer_Match_MatchId",
                table: "MatchPlayer");

            migrationBuilder.DropForeignKey(
                name: "FK_MatchPlayer_Player_PlayerId",
                table: "MatchPlayer");

            migrationBuilder.DropForeignKey(
                name: "FK_PlayerMove_Column_ColumnId",
                table: "PlayerMove");

            migrationBuilder.DropForeignKey(
                name: "FK_PlayerMove_Player_PlayerId",
                table: "PlayerMove");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PlayerMove",
                table: "PlayerMove");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MatchPlayer",
                table: "MatchPlayer");

            migrationBuilder.RenameTable(
                name: "PlayerMove",
                newName: "Player_Move");

            migrationBuilder.RenameTable(
                name: "MatchPlayer",
                newName: "Match_Player");

            migrationBuilder.RenameIndex(
                name: "IX_PlayerMove_PlayerId",
                table: "Player_Move",
                newName: "IX_Player_Move_PlayerId");

            migrationBuilder.RenameIndex(
                name: "IX_PlayerMove_ColumnId",
                table: "Player_Move",
                newName: "IX_Player_Move_ColumnId");

            migrationBuilder.RenameIndex(
                name: "IX_MatchPlayer_PlayerId",
                table: "Match_Player",
                newName: "IX_Match_Player_PlayerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Player_Move",
                table: "Player_Move",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Match_Player",
                table: "Match_Player",
                columns: new[] { "MatchId", "PlayerId" });

            migrationBuilder.CreateTable(
                name: "Result",
                columns: table => new
                {
                    Id = table.Column<string>(type: "VARCHAR(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LastMoveId = table.Column<string>(type: "VARCHAR(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Moves = table.Column<int>(type: "int", nullable: false),
                    MatchTime = table.Column<TimeSpan>(type: "time(6)", nullable: false),
                    MatchId = table.Column<string>(type: "VARCHAR(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Enabled = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Result", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Result_Match_MatchId",
                        column: x => x.MatchId,
                        principalTable: "Match",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Result_Player_Move_LastMoveId",
                        column: x => x.LastMoveId,
                        principalTable: "Player_Move",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Victory",
                columns: table => new
                {
                    Id = table.Column<string>(type: "VARCHAR(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Type = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Value = table.Column<int>(type: "int", nullable: false),
                    ResultId = table.Column<string>(type: "VARCHAR(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    WinnerId = table.Column<string>(type: "VARCHAR(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LoserId = table.Column<string>(type: "VARCHAR(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Enabled = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Victory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Victory_Player_LoserId",
                        column: x => x.LoserId,
                        principalTable: "Player",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Victory_Player_WinnerId",
                        column: x => x.WinnerId,
                        principalTable: "Player",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Victory_Result_ResultId",
                        column: x => x.ResultId,
                        principalTable: "Result",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Result_LastMoveId",
                table: "Result",
                column: "LastMoveId");

            migrationBuilder.CreateIndex(
                name: "IX_Result_MatchId",
                table: "Result",
                column: "MatchId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Victory_LoserId",
                table: "Victory",
                column: "LoserId");

            migrationBuilder.CreateIndex(
                name: "IX_Victory_ResultId",
                table: "Victory",
                column: "ResultId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Victory_WinnerId",
                table: "Victory",
                column: "WinnerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Match_Player_Match_MatchId",
                table: "Match_Player",
                column: "MatchId",
                principalTable: "Match",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Match_Player_Player_PlayerId",
                table: "Match_Player",
                column: "PlayerId",
                principalTable: "Player",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Player_Move_Column_ColumnId",
                table: "Player_Move",
                column: "ColumnId",
                principalTable: "Column",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Player_Move_Player_PlayerId",
                table: "Player_Move",
                column: "PlayerId",
                principalTable: "Player",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Match_Player_Match_MatchId",
                table: "Match_Player");

            migrationBuilder.DropForeignKey(
                name: "FK_Match_Player_Player_PlayerId",
                table: "Match_Player");

            migrationBuilder.DropForeignKey(
                name: "FK_Player_Move_Column_ColumnId",
                table: "Player_Move");

            migrationBuilder.DropForeignKey(
                name: "FK_Player_Move_Player_PlayerId",
                table: "Player_Move");

            migrationBuilder.DropTable(
                name: "Victory");

            migrationBuilder.DropTable(
                name: "Result");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Player_Move",
                table: "Player_Move");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Match_Player",
                table: "Match_Player");

            migrationBuilder.RenameTable(
                name: "Player_Move",
                newName: "PlayerMove");

            migrationBuilder.RenameTable(
                name: "Match_Player",
                newName: "MatchPlayer");

            migrationBuilder.RenameIndex(
                name: "IX_Player_Move_PlayerId",
                table: "PlayerMove",
                newName: "IX_PlayerMove_PlayerId");

            migrationBuilder.RenameIndex(
                name: "IX_Player_Move_ColumnId",
                table: "PlayerMove",
                newName: "IX_PlayerMove_ColumnId");

            migrationBuilder.RenameIndex(
                name: "IX_Match_Player_PlayerId",
                table: "MatchPlayer",
                newName: "IX_MatchPlayer_PlayerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PlayerMove",
                table: "PlayerMove",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MatchPlayer",
                table: "MatchPlayer",
                columns: new[] { "MatchId", "PlayerId" });

            migrationBuilder.AddForeignKey(
                name: "FK_MatchPlayer_Match_MatchId",
                table: "MatchPlayer",
                column: "MatchId",
                principalTable: "Match",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MatchPlayer_Player_PlayerId",
                table: "MatchPlayer",
                column: "PlayerId",
                principalTable: "Player",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PlayerMove_Column_ColumnId",
                table: "PlayerMove",
                column: "ColumnId",
                principalTable: "Column",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PlayerMove_Player_PlayerId",
                table: "PlayerMove",
                column: "PlayerId",
                principalTable: "Player",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
