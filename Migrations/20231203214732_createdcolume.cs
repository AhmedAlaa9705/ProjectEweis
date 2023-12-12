using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectEweis.Migrations
{
    public partial class createdcolume : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                schema: "Post",
                table: "real_estate_yes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Deleted",
                schema: "Post",
                table: "real_estate_yes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                schema: "Post",
                table: "real_estate_no",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Deleted",
                schema: "Post",
                table: "real_estate_no",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                schema: "Post",
                table: "commercial",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Deleted",
                schema: "Post",
                table: "commercial",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateCreated",
                schema: "Post",
                table: "real_estate_yes");

            migrationBuilder.DropColumn(
                name: "Deleted",
                schema: "Post",
                table: "real_estate_yes");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                schema: "Post",
                table: "real_estate_no");

            migrationBuilder.DropColumn(
                name: "Deleted",
                schema: "Post",
                table: "real_estate_no");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                schema: "Post",
                table: "commercial");

            migrationBuilder.DropColumn(
                name: "Deleted",
                schema: "Post",
                table: "commercial");
        }
    }
}
