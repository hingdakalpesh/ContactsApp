using Microsoft.EntityFrameworkCore.Migrations;

namespace ContactsApi.Migrations
{
    public partial class AddCompanyData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Company",
                table: "Contacts",
                type: "nvarchar(50)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Contacts",
                type: "nvarchar(4000)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Industry",
                table: "Contacts",
                type: "nvarchar(50)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Logo",
                table: "Contacts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Tags",
                table: "Contacts",
                type: "nvarchar(4000)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Company",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "Industry",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "Logo",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "Tags",
                table: "Contacts");
        }
    }
}
