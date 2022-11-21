using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Car_Rental_System.Migrations
{
    public partial class AttributeChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "Drivers");

            migrationBuilder.DropColumn(
                name: "Experience",
                table: "Drivers");

            migrationBuilder.DropColumn(
                name: "Car_Number",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "Engine",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "Passing_Year",
                table: "Cars");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Drivers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "District",
                table: "Drivers",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Driving_Year",
                table: "Drivers",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "AddedDate",
                table: "Cars",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "DailyHirePrice",
                table: "Cars",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Registration_Number",
                table: "Cars",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Registration_Year",
                table: "Cars",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "City",
                table: "Drivers");

            migrationBuilder.DropColumn(
                name: "District",
                table: "Drivers");

            migrationBuilder.DropColumn(
                name: "Driving_Year",
                table: "Drivers");

            migrationBuilder.DropColumn(
                name: "AddedDate",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "DailyHirePrice",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "Registration_Number",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "Registration_Year",
                table: "Cars");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Drivers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Experience",
                table: "Drivers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Car_Number",
                table: "Cars",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Engine",
                table: "Cars",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Passing_Year",
                table: "Cars",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
