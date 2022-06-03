using Microsoft.EntityFrameworkCore.Migrations;

namespace e_shopping.Migrations
{
    public partial class UpdateRegToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ConPassword",
                table: "registers",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ConPassword",
                table: "registers");
        }
    }
}
