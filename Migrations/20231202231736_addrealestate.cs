using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectEweis.Migrations
{
    public partial class addrealestate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "real_estate_no",
                schema: "Post",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    purpose = table.Column<int>(type: "int", nullable: false),
                    property_type = table.Column<int>(type: "int", nullable: false),
                    property_area = table.Column<int>(type: "int", nullable: false),
                    directions = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    street_width = table.Column<int>(type: "int", nullable: false),
                    negotiable = table.Column<int>(type: "int", nullable: false),
                    Neighborhood = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    needs_money = table.Column<int>(type: "int", nullable: false),
                    OwnerId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    partner_type = table.Column<int>(type: "int", nullable: false),
                    city_id = table.Column<int>(type: "int", nullable: false),
                    investment_cost = table.Column<int>(type: "int", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    partners_count = table.Column<int>(type: "int", nullable: false),
                    partnerNeighborhoods = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_real_estate_no", x => x.ID);
                    table.ForeignKey(
                        name: "FK_real_estate_no_users_OwnerId",
                        column: x => x.OwnerId,
                        principalSchema: "Login",
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "real_estate_yes",
                schema: "Post",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    purpose = table.Column<int>(type: "int", nullable: false),
                    property_type = table.Column<int>(type: "int", nullable: false),
                    property_area = table.Column<int>(type: "int", nullable: false),
                    directions = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    street_width = table.Column<int>(type: "int", nullable: false),
                    negotiable = table.Column<int>(type: "int", nullable: false),
                    partnerNeighborhoods = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    needs_money = table.Column<int>(type: "int", nullable: false),
                    OwnerId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    partner_type = table.Column<int>(type: "int", nullable: false),
                    city_id = table.Column<int>(type: "int", nullable: false),
                    investment_cost = table.Column<int>(type: "int", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    partners_count = table.Column<int>(type: "int", nullable: false),
                    images = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    plan_number = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    property_number = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    property_age = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_real_estate_yes", x => x.ID);
                    table.ForeignKey(
                        name: "FK_real_estate_yes_users_OwnerId",
                        column: x => x.OwnerId,
                        principalSchema: "Login",
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_real_estate_no_OwnerId",
                schema: "Post",
                table: "real_estate_no",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_real_estate_yes_OwnerId",
                schema: "Post",
                table: "real_estate_yes",
                column: "OwnerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "real_estate_no",
                schema: "Post");

            migrationBuilder.DropTable(
                name: "real_estate_yes",
                schema: "Post");
        }
    }
}
