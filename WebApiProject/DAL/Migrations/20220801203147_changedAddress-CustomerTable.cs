using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class changedAddressCustomerTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "Addresses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_CustomerId",
                table: "Addresses",
                column: "CustomerId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_Customers_CustomerId",
                table: "Addresses",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_Customers_CustomerId",
                table: "Addresses");

            migrationBuilder.DropIndex(
                name: "IX_Addresses_CustomerId",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "Addresses");
        }
    }
}
