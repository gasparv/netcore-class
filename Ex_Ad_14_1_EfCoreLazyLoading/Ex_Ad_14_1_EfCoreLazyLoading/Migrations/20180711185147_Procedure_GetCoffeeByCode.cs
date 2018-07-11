using Microsoft.EntityFrameworkCore.Migrations;

namespace Ex_Ad_14_1_EfCoreLazyLoading.Migrations
{
    public partial class Procedure_GetCoffeeByCode : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
               @"CREATE PROCEDURE [dbo].[GetCoffeeByCode]
                    @CoffeeCode varchar(50)
                AS
                BEGIN
                    SET NOCOUNT ON;
                    select * from Coffee where CoffeeCode like @CoffeeCode +'%'
                END"
               );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"DROP PROCEDURE [dbo].[GetCoffeeByCode]");
        }
    }
}
