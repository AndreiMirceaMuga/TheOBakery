using Microsoft.EntityFrameworkCore.Migrations;


#nullable disable

namespace TheOBakery.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddPayment : Migration
    {
        public enum PaymentStatus
        {
            Completed = 1,
            Pending = 2,
            Canceled = 3
        }
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.CreateTable(
               name: "Payment",
               columns: table => new
               {
                   PaymentID = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NewId()"),
                   CustomerID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                   Total = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                   Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                   StatusOfPayment = table.Column<int>(nullable: false)
               },
               constraints: table =>
               {
                   table.PrimaryKey("PK_Payment", x => x.PaymentID);
                   table.ForeignKey(
                       name: "FK_Payment_Customer_CustomerID",
                       column: x => x.CustomerID,
                       principalTable: "Customer",
                       principalColumn: "CustomerID",
                       onDelete: ReferentialAction.Cascade);
                   
               }
               );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(name: "Payment");
        }
    }
}
