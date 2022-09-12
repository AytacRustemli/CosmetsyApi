using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class OrderTracking : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OrderTrackingId",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "OrdersTracking",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdersTracking", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_OrderTrackingId",
                table: "Orders",
                column: "OrderTrackingId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_OrdersTracking_OrderTrackingId",
                table: "Orders",
                column: "OrderTrackingId",
                principalTable: "OrdersTracking",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_OrdersTracking_OrderTrackingId",
                table: "Orders");

            migrationBuilder.DropTable(
                name: "OrdersTracking");

            migrationBuilder.DropIndex(
                name: "IX_Orders_OrderTrackingId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "OrderTrackingId",
                table: "Orders");
        }
    }
}
