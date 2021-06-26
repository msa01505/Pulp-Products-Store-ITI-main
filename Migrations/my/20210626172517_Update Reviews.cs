using Microsoft.EntityFrameworkCore.Migrations;

namespace Pulp.Migrations.my
{
    public partial class UpdateReviews : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Buyers_BuyerUserID",
                table: "Reviews");

            migrationBuilder.DropIndex(
                name: "IX_Reviews_BuyerUserID",
                table: "Reviews");

            migrationBuilder.DropColumn(
                name: "BuyerUserID",
                table: "Reviews");

            migrationBuilder.RenameColumn(
                name: "UserID",
                table: "Reviews",
                newName: "BuyerID");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_BuyerID",
                table: "Reviews",
                column: "BuyerID");

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Buyers_BuyerID",
                table: "Reviews",
                column: "BuyerID",
                principalTable: "Buyers",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Buyers_BuyerID",
                table: "Reviews");

            migrationBuilder.DropIndex(
                name: "IX_Reviews_BuyerID",
                table: "Reviews");

            migrationBuilder.RenameColumn(
                name: "BuyerID",
                table: "Reviews",
                newName: "UserID");

            migrationBuilder.AddColumn<int>(
                name: "BuyerUserID",
                table: "Reviews",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_BuyerUserID",
                table: "Reviews",
                column: "BuyerUserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Buyers_BuyerUserID",
                table: "Reviews",
                column: "BuyerUserID",
                principalTable: "Buyers",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
