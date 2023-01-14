using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class initialCreate2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UnitOfStock",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "UnitPrice",
                table: "Products",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "UnitOfStock", "UnitPrice" },
                values: new object[] { 23, 19999.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "UnitOfStock", "UnitPrice" },
                values: new object[] { 5, 24999.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "UnitOfStock", "UnitPrice" },
                values: new object[] { 15, 20999.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                columns: new[] { "UnitOfStock", "UnitPrice" },
                values: new object[] { 30, 17999.99m });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UnitOfStock",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "UnitPrice",
                table: "Products");
        }
    }
}
