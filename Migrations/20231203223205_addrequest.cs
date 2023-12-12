using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectEweis.Migrations
{
    public partial class addrequest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Requests",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RequesterId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ISpecificationsOK = table.Column<int>(type: "int", nullable: false),
                    ISAmountofMoneyOK = table.Column<int>(type: "int", nullable: false),
                    SuggestedAmount = table.Column<int>(type: "int", nullable: false),
                    commercialID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    real_estate_yesID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    real_estate_noID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Requests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Requests_commercial_commercialID",
                        column: x => x.commercialID,
                        principalSchema: "Post",
                        principalTable: "commercial",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Requests_real_estate_no_real_estate_noID",
                        column: x => x.real_estate_noID,
                        principalSchema: "Post",
                        principalTable: "real_estate_no",
                        principalColumn: "ID"
                      );
                    table.ForeignKey(
                        name: "FK_Requests_real_estate_yes_real_estate_yesID",
                        column: x => x.real_estate_yesID,
                        principalSchema: "Post",
                        principalTable: "real_estate_yes",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Requests_users_RequesterId",
                        column: x => x.RequesterId,
                        principalSchema: "Login",
                        principalTable: "users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Requests_commercialID",
                table: "Requests",
                column: "commercialID");

            migrationBuilder.CreateIndex(
                name: "IX_Requests_real_estate_noID",
                table: "Requests",
                column: "real_estate_noID");

            migrationBuilder.CreateIndex(
                name: "IX_Requests_real_estate_yesID",
                table: "Requests",
                column: "real_estate_yesID");

            migrationBuilder.CreateIndex(
                name: "IX_Requests_RequesterId",
                table: "Requests",
                column: "RequesterId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable( name: "Requests");
        }
    }
}
