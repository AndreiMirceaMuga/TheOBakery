using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheOBakery.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddCartContent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                  name: "CartContent",
                  columns: table => new
                  {
                      CartContentID = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NewId()"),
                      ProductID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                      OrderID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                  },
                  constraints: table =>
                  {
                      table.PrimaryKey("PK_CartContent", x => x.CartContentID);
                      table.ForeignKey(
                          name: "FK_CartContent_Product_ProductID",
                          column: x => x.ProductID,
                          principalTable: "Product",
                          principalColumn: "ProductID",
                          onDelete: ReferentialAction.Cascade);
                      table.ForeignKey(
                        name: "FK_CartContent_Order_OrderID",
                        column: x => x.OrderID,
                        principalTable: "Order",
                        principalColumn: "OrderID",
                        onDelete: ReferentialAction.Restrict);
                  }
                  );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(name: "CartContent");
        }
    }
}
