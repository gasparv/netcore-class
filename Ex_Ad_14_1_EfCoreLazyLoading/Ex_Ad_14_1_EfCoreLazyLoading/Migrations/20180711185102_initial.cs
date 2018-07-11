using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Ex_Ad_14_1_EfCoreLazyLoading.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Coffee",
                columns: table => new
                {
                    CoffeeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CoffeeCode = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Origin = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coffee", x => x.CoffeeId);
                    table.UniqueConstraint("APK_CoffeeCode", x => x.CoffeeCode);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
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
                    EmployeeCoffeeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CoffeeId = table.Column<int>(nullable: false),
                    EmployeeId = table.Column<int>(nullable: false)
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
                columns: new[] { "CoffeeId", "CoffeeCode", "Name", "Origin" },
                values: new object[,]
                {
                    { 1, "ANTIS", "Antuka", "Slovakia" },
                    { 2, "AZET", "Azera", "Turkmenistan" },
                    { 3, "PERBI", "PeruBio", "Peru" }
                });

            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "EmployeeId", "Name", "Workplace" },
                values: new object[,]
                {
                    { 1, "Vlado", "Unknown" },
                    { 2, "Janči", "KE" }
                });

            migrationBuilder.InsertData(
                table: "EmployeeCoffee",
                columns: new[] { "EmployeeCoffeeId", "CoffeeId", "EmployeeId" },
                values: new object[] { 1, 1, 1 });

            migrationBuilder.InsertData(
                table: "EmployeeCoffee",
                columns: new[] { "EmployeeCoffeeId", "CoffeeId", "EmployeeId" },
                values: new object[] { 2, 3, 1 });

            migrationBuilder.InsertData(
                table: "EmployeeCoffee",
                columns: new[] { "EmployeeCoffeeId", "CoffeeId", "EmployeeId" },
                values: new object[] { 3, 2, 2 });

            migrationBuilder.CreateIndex(
                name: "IX_Coffee_CoffeeId_CoffeeCode",
                table: "Coffee",
                columns: new[] { "CoffeeId", "CoffeeCode" });

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
