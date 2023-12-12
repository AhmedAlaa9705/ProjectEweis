using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectEweis.Migrations
{
    public partial class addAplicationuser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Fname",
                schema: "Login",
                table: "users");

            migrationBuilder.DropColumn(
                name: "Lname",
                schema: "Login",
                table: "users");

            migrationBuilder.DropColumn(
                name: "pathphoto",
                schema: "Login",
                table: "users");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                schema: "Login",
                table: "users",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                schema: "Login",
                table: "users",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                schema: "Login",
                table: "users");

            migrationBuilder.DropColumn(
                name: "LastName",
                schema: "Login",
                table: "users");

            migrationBuilder.AddColumn<string>(
                name: "Fname",
                schema: "Login",
                table: "users",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Lname",
                schema: "Login",
                table: "users",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "pathphoto",
                schema: "Login",
                table: "users",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "");
        }
    }
}
