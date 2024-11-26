using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZyfraVar2.Migrations
{
    /// <inheritdoc />
    public partial class initMigr2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Sessions",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Owner",
                table: "Sessions",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Sessions");

            migrationBuilder.DropColumn(
                name: "Owner",
                table: "Sessions");
        }
    }
}
