using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class initialCreate4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Ordereds_OrderedId",
                table: "OrderDetails");

            migrationBuilder.DropTable(
                name: "Ordereds");

            migrationBuilder.RenameColumn(
                name: "OrderedId",
                table: "OrderDetails",
                newName: "OrderId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderDetails_OrderedId",
                table: "OrderDetails",
                newName: "IX_OrderDetails_OrderId");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PostalCode",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "Shipped",
                table: "Orders",
                type: "bit",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 1,
                column: "BillDate",
                value: new DateTime(2023, 1, 30, 21, 30, 38, 738, DateTimeKind.Local).AddTicks(9185));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1,
                columns: new[] { "Address", "City", "Country", "Email", "FirstName", "LastName", "OrderDate", "Phone", "PostalCode", "ShipDate", "Shipped" },
                values: new object[] { "Kadırgalar cd. İstanbul", "İstanbul", "Türkiye", "mano@gmail.com", "Münir", "Erkar", new DateTime(2023, 1, 30, 21, 30, 38, 738, DateTimeKind.Local).AddTicks(9309), "05554879878", "34444", new DateTime(2023, 1, 30, 21, 30, 38, 738, DateTimeKind.Local).AddTicks(9313), true });

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Orders_OrderId",
                table: "OrderDetails",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "OrderId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Orders_OrderId",
                table: "OrderDetails");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "PostalCode",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Shipped",
                table: "Orders");

            migrationBuilder.RenameColumn(
                name: "OrderId",
                table: "OrderDetails",
                newName: "OrderedId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderDetails_OrderId",
                table: "OrderDetails",
                newName: "IX_OrderDetails_OrderedId");

            migrationBuilder.CreateTable(
                name: "Ordereds",
                columns: table => new
                {
                    OrderedId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Shipped = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ordereds", x => x.OrderedId);
                    table.ForeignKey(
                        name: "FK_Ordereds_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 1,
                column: "BillDate",
                value: new DateTime(2023, 1, 30, 20, 50, 50, 896, DateTimeKind.Local).AddTicks(4553));

            migrationBuilder.InsertData(
                table: "Ordereds",
                columns: new[] { "OrderedId", "Address", "City", "Country", "CustomerId", "Email", "FirstName", "LastName", "OrderDate", "Phone", "PostalCode", "Shipped" },
                values: new object[] { 1, "Kadırgalar cd. İstanbul", "İstanbul", "Türkiye", 1, "mano@gmail.com", "Münir", "Erkar", new DateTime(2023, 1, 30, 20, 50, 50, 896, DateTimeKind.Local).AddTicks(4743), "05554879878", "34444", true });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1,
                columns: new[] { "OrderDate", "ShipDate" },
                values: new object[] { new DateTime(2023, 1, 30, 20, 50, 50, 896, DateTimeKind.Local).AddTicks(4885), new DateTime(2023, 1, 30, 20, 50, 50, 896, DateTimeKind.Local).AddTicks(4886) });

            migrationBuilder.CreateIndex(
                name: "IX_Ordereds_CustomerId",
                table: "Ordereds",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Ordereds_OrderedId",
                table: "OrderDetails",
                column: "OrderedId",
                principalTable: "Ordereds",
                principalColumn: "OrderedId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
