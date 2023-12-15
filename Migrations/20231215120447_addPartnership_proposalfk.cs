using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectEweis.Migrations
{
    public partial class addPartnership_proposalfk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Partnership_Proposals",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Partnership_Proposals_UserId",
                table: "Partnership_Proposals",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Partnership_Proposals_users_UserId",
                table: "Partnership_Proposals",
                column: "UserId",
                principalSchema: "Login",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Partnership_Proposals_users_UserId",
                table: "Partnership_Proposals");

            migrationBuilder.DropIndex(
                name: "IX_Partnership_Proposals_UserId",
                table: "Partnership_Proposals");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Partnership_Proposals");
        }
    }
}
