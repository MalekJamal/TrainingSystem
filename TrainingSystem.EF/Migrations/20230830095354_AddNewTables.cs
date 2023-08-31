using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TrainingSystem.EF.Migrations
{
    public partial class AddNewTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "LookupCategories",
                columns: table => new
                {
                    LookUpCategoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(maxLength: 10, nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifyBy = table.Column<string>(maxLength: 10, nullable: true),
                    ModifyOn = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Code = table.Column<int>(nullable: false),
                    NameEn = table.Column<string>(nullable: false),
                    NameAr = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LookupCategories", x => x.LookUpCategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Lookups",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(maxLength: 10, nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifyBy = table.Column<string>(maxLength: 10, nullable: true),
                    ModifyOn = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Code = table.Column<int>(nullable: false),
                    NameEn = table.Column<string>(nullable: false),
                    NameAr = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    LookUpCategoryId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lookups", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Lookups_LookupCategories_LookUpCategoryId",
                        column: x => x.LookUpCategoryId,
                        principalTable: "LookupCategories",
                        principalColumn: "LookUpCategoryId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Sessions",
                columns: table => new
                {
                    SessionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(maxLength: 10, nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifyBy = table.Column<string>(maxLength: 10, nullable: true),
                    ModifyOn = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    Year = table.Column<string>(nullable: false),
                    TraineeName = table.Column<string>(nullable: false),
                    TrainerName = table.Column<string>(nullable: true),
                    lookUpId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sessions", x => x.SessionId);
                    table.ForeignKey(
                        name: "FK_Sessions_Lookups_lookUpId",
                        column: x => x.lookUpId,
                        principalTable: "Lookups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Lookups_LookUpCategoryId",
                table: "Lookups",
                column: "LookUpCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Sessions_lookUpId",
                table: "Sessions",
                column: "lookUpId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sessions");

            migrationBuilder.DropTable(
                name: "Lookups");

            migrationBuilder.DropTable(
                name: "LookupCategories");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FullName",
                table: "AspNetUsers");
        }
    }
}
