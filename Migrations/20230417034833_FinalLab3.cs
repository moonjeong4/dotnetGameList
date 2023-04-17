using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace lab3.Migrations
{
    /// <inheritdoc />
    public partial class FinalLab3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MailingAddress",
                table: "Users",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "phone",
                table: "Users",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MailingAddress",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "phone",
                table: "Users");
        }
    }
}
