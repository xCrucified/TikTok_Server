using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace data_access.Migrations
{
    /// <inheritdoc />
    public partial class HotFix11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SaveVideo");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e2c36d48-0057-42e1-8727-e578262f7e4e");

            migrationBuilder.AddColumn<int>(
                name: "VideoId",
                table: "Saves",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AvatarPicture", "Balance", "Birthdate", "ConcurrencyStamp", "Description", "Email", "EmailConfirmed", "Followers", "Followings", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "e83a9e3d-5235-4938-bd04-0262963ebf39", 0, null, 99999m, null, "b5202bf3-617c-4105-884f-202baf9226de", "admin", null, false, -1, 0, false, null, null, null, null, "123456789", false, "1b468e30-4a7c-4c92-afab-dfd473a32bfb", false, "admin" });

            migrationBuilder.CreateIndex(
                name: "IX_Saves_VideoId",
                table: "Saves",
                column: "VideoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Saves_Videos_VideoId",
                table: "Saves",
                column: "VideoId",
                principalTable: "Videos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Saves_Videos_VideoId",
                table: "Saves");

            migrationBuilder.DropIndex(
                name: "IX_Saves_VideoId",
                table: "Saves");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e83a9e3d-5235-4938-bd04-0262963ebf39");

            migrationBuilder.DropColumn(
                name: "VideoId",
                table: "Saves");

            migrationBuilder.CreateTable(
                name: "SaveVideo",
                columns: table => new
                {
                    SavesId = table.Column<int>(type: "int", nullable: false),
                    VideosId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SaveVideo", x => new { x.SavesId, x.VideosId });
                    table.ForeignKey(
                        name: "FK_SaveVideo_Saves_SavesId",
                        column: x => x.SavesId,
                        principalTable: "Saves",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SaveVideo_Videos_VideosId",
                        column: x => x.VideosId,
                        principalTable: "Videos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AvatarPicture", "Balance", "Birthdate", "ConcurrencyStamp", "Description", "Email", "EmailConfirmed", "Followers", "Followings", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "e2c36d48-0057-42e1-8727-e578262f7e4e", 0, null, 99999m, null, "04d096e5-6624-42ea-af13-5e9f0fa286b2", "admin", null, false, -1, 0, false, null, null, null, null, "123456789", false, "7ad418ae-a98a-40d4-b623-e1470a669343", false, "admin" });

            migrationBuilder.CreateIndex(
                name: "IX_SaveVideo_VideosId",
                table: "SaveVideo",
                column: "VideosId");
        }
    }
}
