using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace API_Senior.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pontos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    includedAt = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    employeeId = table.Column<int>(type: "int", nullable: false),
                    employerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pontos", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Pontos",
                columns: new[] { "Id", "employeeId", "employerId", "includedAt" },
                values: new object[] { 1, 83, 111, "2022-03-15 16:30:00" });

            migrationBuilder.InsertData(
                table: "Pontos",
                columns: new[] { "Id", "employeeId", "employerId", "includedAt" },
                values: new object[] { 2, 95, 111, "2022-03-15 16:33:00" });

            migrationBuilder.InsertData(
                table: "Pontos",
                columns: new[] { "Id", "employeeId", "employerId", "includedAt" },
                values: new object[] { 3, 103, 111, "2022-03-15 16:32:00" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pontos");
        }
    }
}
