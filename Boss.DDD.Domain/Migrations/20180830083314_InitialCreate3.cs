using Microsoft.EntityFrameworkCore.Migrations;

namespace Boss.DDD.Migrations
{
    public partial class InitialCreate3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Spec",
                table: "ProductSKUs",
                nullable: true,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Spec",
                table: "ProductSKUs",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
