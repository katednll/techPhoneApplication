using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace techPhoneApplication.Data.Migrations
{
    /// <inheritdoc />
    public partial class addconversion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "ConvertedPrice",
                table: "Product",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ConvertedPrice",
                table: "Product");
        }
    }
}
