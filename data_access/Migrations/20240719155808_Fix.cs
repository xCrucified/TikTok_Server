using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace data_access.Migrations
{
    /// <inheritdoc />
    public partial class Fix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "61d2eeef-e0b9-48eb-b791-8cde62f13fa6");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AvatarPicture", "Balance", "Birthdate", "ConcurrencyStamp", "Description", "Email", "EmailConfirmed", "Followers", "Followings", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "7c23b683-6679-4c61-a0f0-e9d9c369103c", 0, null, 99999m, null, "ffe54afe-8dfe-44aa-ad64-8a372d0c81a8", "admin", null, false, -1, 0, false, null, null, null, null, "123456789", false, "42032901-9f70-4490-a773-722ce84cac3a", false, "admin" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7c23b683-6679-4c61-a0f0-e9d9c369103c");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AvatarPicture", "Balance", "Birthdate", "ConcurrencyStamp", "Description", "Email", "EmailConfirmed", "Followers", "Followings", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "61d2eeef-e0b9-48eb-b791-8cde62f13fa6", 0, null, 99999m, null, "18029ce6-a73e-4c75-8db3-e5607b35da6c", "admin", null, false, -1, 0, false, null, null, null, null, "123456789", false, "3f05a65f-c0cc-4cea-a9a8-c75a6bfef0d1", false, "admin" });
        }
    }
}
