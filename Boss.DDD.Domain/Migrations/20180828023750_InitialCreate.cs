using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Boss.DDD.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProductSPUs",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Code = table.Column<int>(maxLength: 500, nullable: false),
                    ProductSPUName = table.Column<string>(nullable: true),
                    ProductSPUDes = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductSPUs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductSKUs",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Code = table.Column<int>(nullable: false),
                    Spec = table.Column<int>(nullable: false),
                    Unit = table.Column<int>(nullable: false),
                    PV = table.Column<decimal>(nullable: false),
                    DealerPrice = table.Column<decimal>(nullable: false),
                    Image = table.Column<byte[]>(nullable: true),
                    ProductSPUId = table.Column<Guid>(nullable: false),
                    ProductSPUName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductSKUs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductSKUs_ProductSPUs_ProductSPUId",
                        column: x => x.ProductSPUId,
                        principalTable: "ProductSPUs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductSKUs_ProductSPUId",
                table: "ProductSKUs",
                column: "ProductSPUId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductSKUs");

            migrationBuilder.DropTable(
                name: "ProductSPUs");
        }
    }
}
