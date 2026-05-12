using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sakany.Migrations
{
    /// <inheritdoc />
    public partial class FixWishlistMapping : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Request_ClientID",
                table: "Request");

            migrationBuilder.AddColumn<string>(
                name: "PropertyID1",
                table: "Wishlist",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Request",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "GETDATE()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.CreateIndex(
                name: "IX_Wishlist_PropertyID1",
                table: "Wishlist",
                column: "PropertyID1");

            migrationBuilder.CreateIndex(
                name: "IX_Request_ClientID_PropertyID",
                table: "Request",
                columns: new[] { "ClientID", "PropertyID" },
                unique: true,
                filter: "[Status] = 0");

            migrationBuilder.AddForeignKey(
                name: "FK_Wishlist_Property_PropertyID1",
                table: "Wishlist",
                column: "PropertyID1",
                principalTable: "Property",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Wishlist_Property_PropertyID1",
                table: "Wishlist");

            migrationBuilder.DropIndex(
                name: "IX_Wishlist_PropertyID1",
                table: "Wishlist");

            migrationBuilder.DropIndex(
                name: "IX_Request_ClientID_PropertyID",
                table: "Request");

            migrationBuilder.DropColumn(
                name: "PropertyID1",
                table: "Wishlist");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Request",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValueSql: "GETDATE()");

            migrationBuilder.CreateIndex(
                name: "IX_Request_ClientID",
                table: "Request",
                column: "ClientID");
        }
    }
}
