using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BabyCare.Migrations
{
    public partial class relationmig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teams_Branches_BranchId",
                table: "Teams");

            migrationBuilder.DropIndex(
                name: "IX_Teams_BranchId",
                table: "Teams");


            migrationBuilder.DropColumn(
                name: "BranchId",
                table: "Teams");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BranchId",
                table: "Teams",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ClassId",
                table: "Teams",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Teams_BranchId",
                table: "Teams",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_ClassId",
                table: "Teams",
                column: "ClassId");

            migrationBuilder.AddForeignKey(
                name: "FK_Teams_Branches_BranchId",
                table: "Teams",
                column: "BranchId",
                principalTable: "Branches",
                principalColumn: "BranchId");

            
        }
    }
}
