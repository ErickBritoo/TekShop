using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TekShop.Migrations
{
    /// <inheritdoc />
    public partial class RenameColumnCategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "Categories",
                newName: "Name");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Categories",
                newName: "Nome");
        }
    }
}
