using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectEweis.Migrations
{
    public partial class addPartnership_proposal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Partnership_Proposals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Islocation_suitable = table.Column<bool>(type: "bit", nullable: false),
                    Ispartnership_amount_appropriate = table.Column<bool>(type: "bit", nullable: false),
                    Amount = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Partnership_Proposals", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Partnership_Proposals");
        }
    }
}
