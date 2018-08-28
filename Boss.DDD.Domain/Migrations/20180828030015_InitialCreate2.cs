using Microsoft.EntityFrameworkCore.Migrations;

namespace Boss.DDD.Migrations
{
    public partial class InitialCreate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "ProductSPUs",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(int),
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "ProductSKUs",
                nullable: true,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Code",
                table: "ProductSPUs",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<int>(
                name: "Code",
                table: "ProductSKUs",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
