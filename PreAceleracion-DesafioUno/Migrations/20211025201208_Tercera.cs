using Microsoft.EntityFrameworkCore.Migrations;

namespace PreAceleracion_DesafioUno.Migrations
{
    public partial class Tercera : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "Socialmedia",
                table: "Users",
                columns: new[] { "Id", "Email", "Name", "Password" },
                values: new object[] { 1, "admin@user.com", "Admin", "1234" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Socialmedia",
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
