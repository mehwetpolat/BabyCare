using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BabyCare.Migrations
{
    public partial class new_relations_teamclass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teams_Classes_ClassId",
                table: "Teams");

            migrationBuilder.DropIndex(
                name: "IX_Teams_ClassId",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "ClassId",
                table: "Teams");

            migrationBuilder.AddColumn<int>(
                name: "TeamId",
                table: "Classes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Classes_TeamId",
                table: "Classes",
                column: "TeamId");

            migrationBuilder.AddForeignKey(
                name: "FK_Classes_Teams_TeamId",
                table: "Classes",
                column: "TeamId",
                principalTable: "Teams",
                principalColumn: "TeamId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Classes_Teams_TeamId",
                table: "Classes");

            migrationBuilder.DropIndex(
                name: "IX_Classes_TeamId",
                table: "Classes");

            migrationBuilder.DropColumn(
                name: "TeamId",
                table: "Classes");

            migrationBuilder.AddColumn<int>(
                name: "ClassId",
                table: "Teams",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Teams_ClassId",
                table: "Teams",
                column: "ClassId");

            migrationBuilder.AddForeignKey(
                name: "FK_Teams_Classes_ClassId",
                table: "Teams",
                column: "ClassId",
                principalTable: "Classes",
                principalColumn: "ClassId");
        }
    }
}
