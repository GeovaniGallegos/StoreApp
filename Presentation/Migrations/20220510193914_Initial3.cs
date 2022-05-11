using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Presentation.Migrations
{
    public partial class Initial3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Strores_StoreId",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Strores",
                table: "Strores");

            migrationBuilder.RenameTable(
                name: "Strores",
                newName: "Stores");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Stores",
                table: "Stores",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Stores_StoreId",
                table: "Products",
                column: "StoreId",
                principalTable: "Stores",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Stores_StoreId",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Stores",
                table: "Stores");

            migrationBuilder.RenameTable(
                name: "Stores",
                newName: "Strores");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Strores",
                table: "Strores",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Strores_StoreId",
                table: "Products",
                column: "StoreId",
                principalTable: "Strores",
                principalColumn: "Id");
        }
    }
}
