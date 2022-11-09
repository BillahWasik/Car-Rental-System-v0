using Microsoft.EntityFrameworkCore.Migrations;

namespace Car_Rental_System.Migrations
{
    public partial class Init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Driver_Name",
                table: "Rents",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Driver_Name",
                table: "Rents");
        }
    }
}
