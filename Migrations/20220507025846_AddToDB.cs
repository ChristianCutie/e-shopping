using Microsoft.EntityFrameworkCore.Migrations;

namespace e_shopping.Migrations
{
    public partial class AddToDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DisplayOrder",
                table: "categories");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "categories");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "categories",
                newName: "OrderID");

            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "categories",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PaymentMode",
                table: "categories",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PaymentStatus",
                table: "categories",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "ProductCost",
                table: "categories",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "StartDate",
                table: "categories",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FullName",
                table: "categories");

            migrationBuilder.DropColumn(
                name: "PaymentMode",
                table: "categories");

            migrationBuilder.DropColumn(
                name: "PaymentStatus",
                table: "categories");

            migrationBuilder.DropColumn(
                name: "ProductCost",
                table: "categories");

            migrationBuilder.DropColumn(
                name: "StartDate",
                table: "categories");

            migrationBuilder.RenameColumn(
                name: "OrderID",
                table: "categories",
                newName: "id");

            migrationBuilder.AddColumn<string>(
                name: "DisplayOrder",
                table: "categories",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "categories",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
