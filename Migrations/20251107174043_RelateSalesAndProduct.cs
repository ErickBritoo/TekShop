using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TekShop.Migrations
{
    /// <inheritdoc />
    public partial class RelateSalesAndProduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemOrders_Orders_OrderID",
                table: "ItemOrders");

            migrationBuilder.AlterColumn<int>(
                name: "OrderID",
                table: "ItemOrders",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemOrders_Orders_OrderID",
                table: "ItemOrders",
                column: "OrderID",
                principalTable: "Orders",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemOrders_Orders_OrderID",
                table: "ItemOrders");

            migrationBuilder.AlterColumn<int>(
                name: "OrderID",
                table: "ItemOrders",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemOrders_Orders_OrderID",
                table: "ItemOrders",
                column: "OrderID",
                principalTable: "Orders",
                principalColumn: "ID");
        }
    }
}
