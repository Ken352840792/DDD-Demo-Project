using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Boss.DDD.Migrations
{
    public partial class InitialCreate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DealerTree",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    DealerId = table.Column<Guid>(nullable: false),
                    ParentDealerId = table.Column<Guid>(nullable: true),
                    Layer = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DealerTree", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Login",
                columns: table => new
                {
                    Code = table.Column<string>(nullable: true),
                    Id = table.Column<Guid>(nullable: false),
                    PassWord = table.Column<string>(nullable: true),
                    DealerId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Login", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Dealers",
                columns: table => new
                {
                    Code = table.Column<string>(nullable: true),
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Tel = table.Column<string>(nullable: true),
                    TotalEleMoney = table.Column<decimal>(nullable: false),
                    TotalPV = table.Column<decimal>(nullable: false),
                    JangJingMoney = table.Column<decimal>(nullable: false),
                    CardType = table.Column<int>(nullable: false),
                    Level = table.Column<int>(nullable: false),
                    SubCount = table.Column<int>(nullable: false),
                    DealerTreeId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dealers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Dealers_DealerTree_DealerTreeId",
                        column: x => x.DealerTreeId,
                        principalTable: "DealerTree",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Contact",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ContactName = table.Column<string>(nullable: true),
                    ContactTel = table.Column<string>(nullable: true),
                    sheng = table.Column<string>(nullable: true),
                    shi = table.Column<string>(nullable: true),
                    qu = table.Column<string>(nullable: true),
                    jiedao = table.Column<string>(nullable: true),
                    IsDefaultContact = table.Column<int>(nullable: false),
                    DealersId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contact", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contact_Dealers_DealersId",
                        column: x => x.DealersId,
                        principalTable: "Dealers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Contact_DealersId",
                table: "Contact",
                column: "DealersId");

            migrationBuilder.CreateIndex(
                name: "IX_Dealers_DealerTreeId",
                table: "Dealers",
                column: "DealerTreeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contact");

            migrationBuilder.DropTable(
                name: "Login");

            migrationBuilder.DropTable(
                name: "Dealers");

            migrationBuilder.DropTable(
                name: "DealerTree");
        }
    }
}