using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectEweis.Migrations
{
    public partial class userrequest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(name: "Request");

            migrationBuilder.RenameTable(name: "Requests",newName: "Requests", newSchema: "Request");

            migrationBuilder.AddColumn<int>(
                name: "Deleted",
                schema: "Request",
                table: "Requests",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Deleted",
                schema: "Request",
                table: "Requests");

            migrationBuilder.RenameTable(
                name: "Requests",
                schema: "Request",
                newName: "Requests");
        }
    }
}