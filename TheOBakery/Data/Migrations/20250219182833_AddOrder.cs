using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheOBakery.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddOrder : Migration
    {
        /// <inheritdoc />
        public enum PaymentStatus
        {
            Completed = 1,
            Pending = 2,
            Canceled = 3
        }
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.CreateTable(
               name: "Order",
               columns: table => new
               {
                   OrderID = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NewId()"),
                   CustomerID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                   ProductID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                   Quantity = table.Column<int>(type: "int", nullable: false),
                   StatusOfPayment = table.Column<int>(nullable: false)
               },
               constraints: table =>
               {
                   table.PrimaryKey("PK_Order", x => x.OrderID);
                   table.ForeignKey(
                       name: "FK_Order_Customer_CustomerID",
                       column: x => x.CustomerID,
                       principalTable: "Customer",
                       principalColumn: "CustomerID",
                       onDelete: ReferentialAction.Cascade);
                   table.ForeignKey(
                       name: "FK_Order_Product_ProductID",
                       column: x => x.ProductID,
                       principalTable: "Product",
                       principalColumn: "ProductID",
                       onDelete: ReferentialAction.Cascade);
               }
               );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(name: "Order");
        }
    }
}
