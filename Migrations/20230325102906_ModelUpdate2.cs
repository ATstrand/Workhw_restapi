using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _24._03workapp.Migrations
{
    /// <inheritdoc />
    public partial class ModelUpdate2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isProduction",
                table: "Devices");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "isProduction",
                table: "Devices",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);
        }
    }
}
