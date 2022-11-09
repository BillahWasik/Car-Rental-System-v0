using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Car_Rental_System.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Brand = table.Column<string>(nullable: true),
                    Model = table.Column<string>(nullable: true),
                    Passing_Year = table.Column<int>(nullable: false),
                    Car_Number = table.Column<string>(nullable: true),
                    Engine = table.Column<string>(nullable: true),
                    Fuel_Type = table.Column<string>(nullable: true),
                    ImagePath = table.Column<string>(nullable: true),
                    Seating_Capacity = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Drivers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Driver_Name = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Mobile_Number = table.Column<string>(nullable: true),
                    Age = table.Column<int>(nullable: false),
                    Experience = table.Column<int>(nullable: false),
                    ImagePath = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drivers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rents",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PickUp = table.Column<string>(nullable: true),
                    DropOff = table.Column<string>(nullable: true),
                    PickUp_Date = table.Column<DateTime>(nullable: false),
                    DropOff_Date = table.Column<DateTime>(nullable: false),
                    TotalRun = table.Column<int>(nullable: false),
                    Rate = table.Column<int>(nullable: false),
                    TotalAmount = table.Column<int>(nullable: false),
                    CustomerName = table.Column<string>(nullable: true),
                    Customer_Phone = table.Column<string>(nullable: true),
                    Brand = table.Column<string>(nullable: true),
                    Model = table.Column<string>(nullable: true),
                    CarId = table.Column<int>(nullable: false),
                    DriverId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rents_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "Cars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Rents_Drivers_DriverId",
                        column: x => x.DriverId,
                        principalTable: "Drivers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Rents_CarId",
                table: "Rents",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_Rents_DriverId",
                table: "Rents",
                column: "DriverId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Rents");

            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "Drivers");
        }
    }
}
