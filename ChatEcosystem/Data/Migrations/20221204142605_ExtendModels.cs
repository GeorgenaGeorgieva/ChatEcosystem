using Microsoft.EntityFrameworkCore.Migrations;

namespace ChatEcosystem.Data.Migrations
{
    public partial class ExtendModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "RecieverId",
                table: "Messages",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsOnline",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Messages_RecieverId",
                table: "Messages",
                column: "RecieverId");

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_AspNetUsers_RecieverId",
                table: "Messages",
                column: "RecieverId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Messages_AspNetUsers_RecieverId",
                table: "Messages");

            migrationBuilder.DropIndex(
                name: "IX_Messages_RecieverId",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "RecieverId",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "IsOnline",
                table: "AspNetUsers");
        }
    }
}
