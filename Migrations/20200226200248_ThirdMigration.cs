using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WedProj.Migrations
{
    public partial class ThirdMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Weddings",
                columns: table => new
                {
                    WedId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Wedder_One = table.Column<string>(nullable: false),
                    Wedder_Two = table.Column<string>(nullable: false),
                    WeddingDate = table.Column<DateTime>(nullable: false),
                    WeddingAddress = table.Column<string>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weddings", x => x.WedId);
                });

            migrationBuilder.CreateTable(
                name: "Assocs",
                columns: table => new
                {
                    AssocId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UId = table.Column<int>(nullable: false),
                    WId = table.Column<int>(nullable: false),
                    PersonUserId = table.Column<int>(nullable: true),
                    EventWedId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assocs", x => x.AssocId);
                    table.ForeignKey(
                        name: "FK_Assocs_Weddings_EventWedId",
                        column: x => x.EventWedId,
                        principalTable: "Weddings",
                        principalColumn: "WedId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Assocs_Users_PersonUserId",
                        column: x => x.PersonUserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Assocs_EventWedId",
                table: "Assocs",
                column: "EventWedId");

            migrationBuilder.CreateIndex(
                name: "IX_Assocs_PersonUserId",
                table: "Assocs",
                column: "PersonUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Assocs");

            migrationBuilder.DropTable(
                name: "Weddings");
        }
    }
}
