using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BasketballScores.Migrations
{
    public partial class AddScoreToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ScoreBoards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeamName1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Score1 = table.Column<int>(type: "int", nullable: false),
                    TeamName2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Score2 = table.Column<int>(type: "int", nullable: false),
                    PlayTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScoreBoards", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ScoreBoards");
        }
    }
}
