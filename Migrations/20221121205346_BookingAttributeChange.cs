using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Car_Rental_System.Migrations
{
    public partial class BookingAttributeChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Brand",
                table: "Rents");

            migrationBuilder.DropColumn(
                name: "Driver_Name",
                table: "Rents");

            migrationBuilder.DropColumn(
                name: "DropOff",
                table: "Rents");

            migrationBuilder.DropColumn(
                name: "DropOff_Date",
                table: "Rents");

            migrationBuilder.DropColumn(
                name: "Model",
                table: "Rents");

            migrationBuilder.DropColumn(
                name: "PickUp",
                table: "Rents");

            migrationBuilder.DropColumn(
                name: "PickUp_Date",
                table: "Rents");

            migrationBuilder.DropColumn(
                name: "Rate",
                table: "Rents");

            migrationBuilder.DropColumn(
                name: "TotalAmount",
                table: "Rents");

            migrationBuilder.DropColumn(
                name: "TotalRun",
                table: "Rents");

            migrationBuilder.AddColumn<DateTime>(
                name: "Rent_Date",
                table: "Rents",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Return_Date",
                table: "Rents",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Rents",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Rent_Date",
                table: "Rents");

            migrationBuilder.DropColumn(
                name: "Return_Date",
                table: "Rents");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Rents");

            migrationBuilder.AddColumn<string>(
                name: "Brand",
                table: "Rents",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Driver_Name",
                table: "Rents",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DropOff",
                table: "Rents",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DropOff_Date",
                table: "Rents",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Model",
                table: "Rents",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PickUp",
                table: "Rents",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "PickUp_Date",
                table: "Rents",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Rate",
                table: "Rents",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TotalAmount",
                table: "Rents",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TotalRun",
                table: "Rents",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
