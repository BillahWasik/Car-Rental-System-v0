using Microsoft.EntityFrameworkCore.Migrations;

namespace Car_Rental_System.Migrations
{
    public partial class addnewAttributeOnRent3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rents_Customers_CustomerId1",
                table: "Rents");

            migrationBuilder.DropIndex(
                name: "IX_Rents_CustomerId1",
                table: "Rents");

            migrationBuilder.DropColumn(
                name: "CustomerId1",
                table: "Rents");

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "Rents",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Rents_CustomerId",
                table: "Rents",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Rents_Customers_CustomerId",
                table: "Rents",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rents_Customers_CustomerId",
                table: "Rents");

            migrationBuilder.DropIndex(
                name: "IX_Rents_CustomerId",
                table: "Rents");

            migrationBuilder.AlterColumn<string>(
                name: "CustomerId",
                table: "Rents",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "CustomerId1",
                table: "Rents",
                type: "int",
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
    }
}
