using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class changedAddressProductCustomerTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ProductDetail",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "QuantityPerUnit",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UnitInStock",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UnitsOnOrder",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "AddressInfo",
                table: "Addresses",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductDetail",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "QuantityPerUnit",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "UnitInStock",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "UnitsOnOrder",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "AddressInfo",
                table: "Addresses");
        }
    }
}
