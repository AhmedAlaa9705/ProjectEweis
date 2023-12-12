using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectEweis.Migrations
{
    public partial class commercialtable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Post");

            migrationBuilder.CreateTable(
                name: "commercial",
                schema: "Post",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OwnerId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    partner_type = table.Column<int>(type: "int", nullable: false),
                    city_id = table.Column<int>(type: "int", nullable: false),
                    investment_cost = table.Column<int>(type: "int", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    partners_count = table.Column<int>(type: "int", nullable: false),
                    project_status = table.Column<int>(type: "int", nullable: false),
                    user_contribution = table.Column<int>(type: "int", nullable: false),
                    other_contribution = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_commercial", x => x.ID);
                    table.ForeignKey(
                        name: "FK_commercial_users_OwnerId",
                        column: x => x.OwnerId,
                        principalSchema: "Login",
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_commercial_OwnerId",
                schema: "Post",
                table: "commercial",
                column: "OwnerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "commercial",
                schema: "Post");
        }
    }
}
