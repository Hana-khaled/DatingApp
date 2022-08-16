using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class seedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "appUsers",
                columns: new[] { "ID", "UserName" },
                values: new object[] { 1, "Mark" });

            migrationBuilder.InsertData(
                table: "appUsers",
                columns: new[] { "ID", "UserName" },
                values: new object[] { 2, "John" });

            migrationBuilder.InsertData(
                table: "appUsers",
                columns: new[] { "ID", "UserName" },
                values: new object[] { 3, "Alex" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "appUsers",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "appUsers",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "appUsers",
                keyColumn: "ID",
                keyValue: 3);
        }
    }
}
