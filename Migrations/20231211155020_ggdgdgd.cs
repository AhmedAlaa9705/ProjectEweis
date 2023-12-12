using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectEweis.Migrations
{
    public partial class ggdgdgd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_commercial_users_OwnerId",
                schema: "Post",
                table: "commercial");

            migrationBuilder.DropForeignKey(
                name: "FK_real_estate_no_users_OwnerId",
                schema: "Post",
                table: "real_estate_no");

            migrationBuilder.DropForeignKey(
                name: "FK_real_estate_yes_users_OwnerId",
                schema: "Post",
                table: "real_estate_yes");

            migrationBuilder.DropForeignKey(
                name: "FK_Requests_users_RequesterId",
                schema: "Request",
                table: "Requests");

            migrationBuilder.AlterColumn<string>(
                name: "RequesterId",
                schema: "Request",
                table: "Requests",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "OwnerId",
                schema: "Post",
                table: "real_estate_yes",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "OwnerId",
                schema: "Post",
                table: "real_estate_no",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "OwnerId",
                schema: "Post",
                table: "commercial",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddForeignKey(
                name: "FK_commercial_users_OwnerId",
                schema: "Post",
                table: "commercial",
                column: "OwnerId",
                principalSchema: "Login",
                principalTable: "users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_real_estate_no_users_OwnerId",
                schema: "Post",
                table: "real_estate_no",
                column: "OwnerId",
                principalSchema: "Login",
                principalTable: "users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_real_estate_yes_users_OwnerId",
                schema: "Post",
                table: "real_estate_yes",
                column: "OwnerId",
                principalSchema: "Login",
                principalTable: "users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Requests_users_RequesterId",
                schema: "Request",
                table: "Requests",
                column: "RequesterId",
                principalSchema: "Login",
                principalTable: "users",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_commercial_users_OwnerId",
                schema: "Post",
                table: "commercial");

            migrationBuilder.DropForeignKey(
                name: "FK_real_estate_no_users_OwnerId",
                schema: "Post",
                table: "real_estate_no");

            migrationBuilder.DropForeignKey(
                name: "FK_real_estate_yes_users_OwnerId",
                schema: "Post",
                table: "real_estate_yes");

            migrationBuilder.DropForeignKey(
                name: "FK_Requests_users_RequesterId",
                schema: "Request",
                table: "Requests");

            migrationBuilder.AlterColumn<string>(
                name: "RequesterId",
                schema: "Request",
                table: "Requests",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "OwnerId",
                schema: "Post",
                table: "real_estate_yes",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "OwnerId",
                schema: "Post",
                table: "real_estate_no",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "OwnerId",
                schema: "Post",
                table: "commercial",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_commercial_users_OwnerId",
                schema: "Post",
                table: "commercial",
                column: "OwnerId",
                principalSchema: "Login",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_real_estate_no_users_OwnerId",
                schema: "Post",
                table: "real_estate_no",
                column: "OwnerId",
                principalSchema: "Login",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_real_estate_yes_users_OwnerId",
                schema: "Post",
                table: "real_estate_yes",
                column: "OwnerId",
                principalSchema: "Login",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Requests_users_RequesterId",
                schema: "Request",
                table: "Requests",
                column: "RequesterId",
                principalSchema: "Login",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
