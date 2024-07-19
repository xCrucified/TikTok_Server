using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace data_access.Migrations
{
    /// <inheritdoc />
    public partial class test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comment_Videos_VideoId",
                table: "Comment");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e83a9e3d-5235-4938-bd04-0262963ebf39");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AvatarPicture", "Balance", "Birthdate", "ConcurrencyStamp", "Description", "Email", "EmailConfirmed", "Followers", "Followings", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "1d3879cb-4cc9-440a-a881-74afce1e8b3d", 0, null, 99999m, null, "b0fab207-1f23-432c-8aee-dbd0c4c7a6ca", "admin", null, false, -1, 0, false, null, null, null, null, "123456789", false, "371134d9-f9d9-440c-920f-3cc8e0a55fe4", false, "admin" });

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_Videos_VideoId",
                table: "Comment",
                column: "VideoId",
                principalTable: "Videos",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comment_Videos_VideoId",
                table: "Comment");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1d3879cb-4cc9-440a-a881-74afce1e8b3d");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AvatarPicture", "Balance", "Birthdate", "ConcurrencyStamp", "Description", "Email", "EmailConfirmed", "Followers", "Followings", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "e83a9e3d-5235-4938-bd04-0262963ebf39", 0, null, 99999m, null, "b5202bf3-617c-4105-884f-202baf9226de", "admin", null, false, -1, 0, false, null, null, null, null, "123456789", false, "1b468e30-4a7c-4c92-afab-dfd473a32bfb", false, "admin" });

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_Videos_VideoId",
                table: "Comment",
                column: "VideoId",
                principalTable: "Videos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
