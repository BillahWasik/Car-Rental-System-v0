using Microsoft.EntityFrameworkCore.Migrations;

namespace Car_Rental_System.Migrations
{
    public partial class addnewAttributeOnRent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CustomerName",
                table: "Rents");

            migrationBuilder.DropColumn(
                name: "Customer_Phone",
                table: "Rents");

            migrationBuilder.AddColumn<string>(
                name: "CustomerId",
                table: "Rents",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CustomerId1",
                table: "Rents",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Rents_CustomerId1",
                table: "Rents",
                column: "CustomerId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Rents_Customers_CustomerId1",
                table: "Rents",
                column: "CustomerId1",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rents_Customers_CustomerId1",
                table: "Rents");

            migrationBuilder.DropIndex(
                name: "IX_Rents_CustomerId1",
                table: "Rents");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "Rents");

            migrationBuilder.DropColumn(
                name: "CustomerId1",
                table: "Rents");

            migrationBuilder.AddColumn<string>(
                name: "CustomerName",
                table: "Rents",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Customer_Phone",
                table: "Rents",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
