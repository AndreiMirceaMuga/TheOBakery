using Microsoft.EntityFrameworkCore.Migrations;
using System;

#nullable disable

namespace TheOBakery.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddCustomer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    CustomerID = table.Column<Guid>(type:"uniqueidentifier",nullable: false, defaultValueSql:"NewId()"),
                    Name = table.Column<string>(type: "nvarchar(256)",nullable: false),
                    Email = table.Column<string>(type: "nvarchar(256)",nullable: false),
                    Phone= table.Column<string>(type: "nvarchar(20)",nullable: false) 
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.CustomerID);
                }
                );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(name: "Customer");
        }
    }
}
