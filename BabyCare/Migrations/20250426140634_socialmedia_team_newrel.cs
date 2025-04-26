using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BabyCare.Migrations
{
    public partial class socialmedia_team_newrel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SocialMedias_Teams_TeamId",
                table: "SocialMedias");

            migrationBuilder.DropIndex(
                name: "IX_SocialMedias_TeamId",
                table: "SocialMedias");

            migrationBuilder.DropColumn(
                name: "TeamId",
                table: "SocialMedias");

            migrationBuilder.AddColumn<int>(
                name: "SocialMediaId",
                table: "Teams",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Teams_SocialMediaId",
                table: "Teams",
                column: "SocialMediaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Teams_SocialMedias_SocialMediaId",
                table: "Teams",
                column: "SocialMediaId",
                principalTable: "SocialMedias",
                principalColumn: "SocialMediaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teams_SocialMedias_SocialMediaId",
                table: "Teams");

            migrationBuilder.DropIndex(
                name: "IX_Teams_SocialMediaId",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "SocialMediaId",
                table: "Teams");

            migrationBuilder.AddColumn<int>(
                name: "TeamId",
                table: "SocialMedias",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SocialMedias_TeamId",
                table: "SocialMedias",
                column: "TeamId");

            migrationBuilder.AddForeignKey(
                name: "FK_SocialMedias_Teams_TeamId",
                table: "SocialMedias",
                column: "TeamId",
                principalTable: "Teams",
                principalColumn: "TeamId");
        }
    }
}
