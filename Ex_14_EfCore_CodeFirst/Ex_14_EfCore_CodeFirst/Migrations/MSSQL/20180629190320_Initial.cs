using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Ex_14_EfCore_CodeFirst.Migrations.MSSQL
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Coffee",
                columns: table => new
                {
                    CoffeeId = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Brand = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coffee", x => x.CoffeeId);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    EmployeeId = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Workplace = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.EmployeeId);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeCoffee",
                columns: table => new
                {
                    EmployeeCoffeeId = table.Column<Guid>(nullable: false),
                    EmployeeId = table.Column<Guid>(nullable: false),
                    CoffeeId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeCoffee", x => x.EmployeeCoffeeId);
                    table.ForeignKey(
                        name: "FK_EmployeeCoffee_Coffee_CoffeeId",
                        column: x => x.CoffeeId,
                        principalTable: "Coffee",
                        principalColumn: "CoffeeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeCoffee_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Coffee",
                columns: new[] { "CoffeeId", "Brand", "Name" },
                values: new object[,]
                {
                    { new Guid("68035d83-1eee-4cce-8527-093c0d68b5a6"), "Robusta", "AntukaCoffee" },
                    { new Guid("1cb2eca2-debb-4502-b7b9-dc4cef01c8c9"), "Robusta", "Sandbox" }
                });

            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "EmployeeId", "Name", "Workplace" },
                values: new object[,]
                {
                    { new Guid("fe24c765-8f90-4fac-af4f-98923b422bb2"), "Mauni Wakanatihiko", "Honolulu" },
                    { new Guid("b3aaee28-ade8-4858-bfdc-d50a594b84aa"), "István Bača", "Pohronská polhora" }
                });

            migrationBuilder.InsertData(
                table: "EmployeeCoffee",
                columns: new[] { "EmployeeCoffeeId", "CoffeeId", "EmployeeId" },
                values: new object[] { new Guid("891b5cbb-0557-47f3-93e5-d800fccd221f"), new Guid("1cb2eca2-debb-4502-b7b9-dc4cef01c8c9"), new Guid("fe24c765-8f90-4fac-af4f-98923b422bb2") });

            migrationBuilder.InsertData(
                table: "EmployeeCoffee",
                columns: new[] { "EmployeeCoffeeId", "CoffeeId", "EmployeeId" },
                values: new object[] { new Guid("e79cf848-227d-446f-b6b3-f1ba65ba0d8f"), new Guid("68035d83-1eee-4cce-8527-093c0d68b5a6"), new Guid("b3aaee28-ade8-4858-bfdc-d50a594b84aa") });

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeCoffee_CoffeeId",
                table: "EmployeeCoffee",
                column: "CoffeeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeCoffee_EmployeeId",
                table: "EmployeeCoffee",
                column: "EmployeeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeeCoffee");

            migrationBuilder.DropTable(
                name: "Coffee");

            migrationBuilder.DropTable(
                name: "Employee");
        }
    }
}
