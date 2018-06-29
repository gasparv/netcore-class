using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Ex_14_EfCore_CodeFirst.Migrations.SQLite
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
                values: new object[] { new Guid("f1da593a-2ff2-4099-b2dc-79ab97607aea"), "Robusta", "AntukaCoffee" });

            migrationBuilder.InsertData(
                table: "Coffee",
                columns: new[] { "CoffeeId", "Brand", "Name" },
                values: new object[] { new Guid("bfe3d302-f8cb-413b-9a87-09d2664e23fc"), "Robusta", "Sandbox" });

            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "EmployeeId", "Name", "Workplace" },
                values: new object[] { new Guid("590033cf-6b52-4422-9a50-e00cd386a74a"), "Mauni Wakanatihiko", "Honolulu" });

            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "EmployeeId", "Name", "Workplace" },
                values: new object[] { new Guid("d02e5db9-0710-484e-ab96-b3f5676c4a3a"), "István Bača", "Pohronská polhora" });

            migrationBuilder.InsertData(
                table: "EmployeeCoffee",
                columns: new[] { "EmployeeCoffeeId", "CoffeeId", "EmployeeId" },
                values: new object[] { new Guid("ba0e6705-3a35-4592-abed-3b82da1da47a"), new Guid("bfe3d302-f8cb-413b-9a87-09d2664e23fc"), new Guid("590033cf-6b52-4422-9a50-e00cd386a74a") });

            migrationBuilder.InsertData(
                table: "EmployeeCoffee",
                columns: new[] { "EmployeeCoffeeId", "CoffeeId", "EmployeeId" },
                values: new object[] { new Guid("2bdc6280-79a2-4e94-b2a5-834849215e8c"), new Guid("f1da593a-2ff2-4099-b2dc-79ab97607aea"), new Guid("d02e5db9-0710-484e-ab96-b3f5676c4a3a") });

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
