using Microsoft.EntityFrameworkCore.Migrations;

namespace Ex_Ad_14_1_EfCoreLazyLoading.Migrations
{
    public partial class View_DrinkCoffeesCount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
                @"CREATE VIEW View_DrinkCoffeesCount AS
                SELECT c.EmployeeId, Count(*) as CoffeeCount
                from EmployeeCoffee as c
                GROUP BY c.EmployeeId"
                );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DROP VIEW View_DrinkCoffeesCount");
        }
    }
}
