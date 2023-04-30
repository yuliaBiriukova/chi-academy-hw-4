using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HW_4.Migrations
{
    /// <inheritdoc />
    public partial class UpdateColumnNames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Developer",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Developer",
                newName: "email");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "name",
                table: "Developer",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "email",
                table: "Developer",
                newName: "Email");
        }
    }
}
