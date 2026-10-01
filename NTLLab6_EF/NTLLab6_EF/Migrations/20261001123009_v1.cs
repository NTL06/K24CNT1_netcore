using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NTLLab6_EF.Migrations
{
    /// <inheritdoc />
    public partial class v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    NTLId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NTLName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.NTLId);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    NTLId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NTLName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    NTLImage = table.Column<string>(type: "varchar(150)", nullable: false),
                    NTLPrice = table.Column<float>(type: "real", nullable: false),
                    NTLSalePrice = table.Column<float>(type: "real", nullable: false),
                    NTLStatus = table.Column<byte>(type: "tinyint", nullable: false),
                    NTLDescriptions = table.Column<string>(type: "ntext", maxLength: 1000, nullable: false),
                    NTLCategoryId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.NTLId);
                    table.ForeignKey(
                        name: "FK_Product_Category_NTLCategoryId",
                        column: x => x.NTLCategoryId,
                        principalTable: "Category",
                        principalColumn: "NTLId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Product_NTLCategoryId",
                table: "Product",
                column: "NTLCategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Category");
        }
    }
}
