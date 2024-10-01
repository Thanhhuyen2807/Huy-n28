using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace demomvc.Migrations
{
    /// <inheritdoc />
    public partial class Creat_Table_Employee : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EmployeeID",
                table: "Persons",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmployeeID",
                table: "Persons");
        }
    }
}
