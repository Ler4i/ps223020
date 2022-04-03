using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ps223020.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nickname = table.Column<string>(nullable: true),
                    IsBoy = table.Column<bool>(nullable: false),
                    Birthday = table.Column<DateTimeOffset>(nullable: false),
                    PhoneNumberPrefix = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    password = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    AvatarUrl = table.Column<string>(nullable: true),
                    Token = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Friends",
                columns: table => new
                {
                    FirstUserId = table.Column<int>(nullable: false),
                    SecondUserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Friends", x => new { x.FirstUserId, x.SecondUserId });
                    table.ForeignKey(
                        name: "FK_Friends_Users_FirstUserId",
                        column: x => x.FirstUserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Friends_Users_SecondUserId",
                        column: x => x.SecondUserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Profiles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    HatImageUrl = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profiles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Profiles_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserMultimediaPosts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DateTimeStamp = table.Column<DateTimeOffset>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserMultimediaPosts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserMultimediaPosts_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Videos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ContentUrl = table.Column<string>(nullable: true),
                    ProfileId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Videos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Videos_Profiles_ProfileId",
                        column: x => x.ProfileId,
                        principalTable: "Profiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MultimediaPostComments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Text = table.Column<string>(nullable: true),
                    DateTimeStamp = table.Column<DateTimeOffset>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    UserMultimediaPostRtoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MultimediaPostComments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MultimediaPostComments_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MultimediaPostComments_UserMultimediaPosts_UserMultimediaPostRtoId",
                        column: x => x.UserMultimediaPostRtoId,
                        principalTable: "UserMultimediaPosts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SevedVideos",
                columns: table => new
                {
                    ProfileId = table.Column<int>(nullable: false),
                    VideoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SevedVideos", x => new { x.ProfileId, x.VideoId });
                    table.ForeignKey(
                        name: "FK_SevedVideos_Profiles_ProfileId",
                        column: x => x.ProfileId,
                        principalTable: "Profiles",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SevedVideos_Videos_VideoId",
                        column: x => x.VideoId,
                        principalTable: "Videos",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "VideoComments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Text = table.Column<string>(nullable: true),
                    DataTimeStamp = table.Column<DateTimeOffset>(nullable: false),
                    VideoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VideoComments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VideoComments_Videos_VideoId",
                        column: x => x.VideoId,
                        principalTable: "Videos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Friends_FirstUserId",
                table: "Friends",
                column: "FirstUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Friends_SecondUserId",
                table: "Friends",
                column: "SecondUserId");

            migrationBuilder.CreateIndex(
                name: "IX_MultimediaPostComments_UserId",
                table: "MultimediaPostComments",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_MultimediaPostComments_UserMultimediaPostRtoId",
                table: "MultimediaPostComments",
                column: "UserMultimediaPostRtoId");

            migrationBuilder.CreateIndex(
                name: "IX_Profiles_UserId",
                table: "Profiles",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SevedVideos_ProfileId",
                table: "SevedVideos",
                column: "ProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_SevedVideos_VideoId",
                table: "SevedVideos",
                column: "VideoId");

            migrationBuilder.CreateIndex(
                name: "IX_UserMultimediaPosts_UserId",
                table: "UserMultimediaPosts",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_VideoComments_VideoId",
                table: "VideoComments",
                column: "VideoId");

            migrationBuilder.CreateIndex(
                name: "IX_Videos_ProfileId",
                table: "Videos",
                column: "ProfileId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Friends");

            migrationBuilder.DropTable(
                name: "MultimediaPostComments");

            migrationBuilder.DropTable(
                name: "SevedVideos");

            migrationBuilder.DropTable(
                name: "VideoComments");

            migrationBuilder.DropTable(
                name: "UserMultimediaPosts");

            migrationBuilder.DropTable(
                name: "Videos");

            migrationBuilder.DropTable(
                name: "Profiles");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
