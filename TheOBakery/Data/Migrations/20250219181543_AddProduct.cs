using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheOBakery.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddProduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
               name: "Product",
               columns: table => new
               {
                   ProductID = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NewId()"),
                   NameOfProduct = table.Column<string>(type: "nvarchar(256)", nullable: false),
                   Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                   Price = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                   Kcal = table.Column<int>(type: "int", nullable: true),
                   ImageURL = table.Column<string>(type: "nvarchar(max)", nullable: true)
               },
               constraints: table =>
               {
                   table.PrimaryKey("PK_Product", x => x.ProductID);
               }
               );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(name: "Product");
        }
    }
}
