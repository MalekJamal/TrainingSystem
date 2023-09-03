using Microsoft.EntityFrameworkCore.Migrations;

namespace TrainingSystem.EF.Migrations
{
    public partial class AddTrainerNameToTheSessionTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TrainerLookupId",
                table: "Session",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TrainerName",
                table: "Session",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Session_TrainerLookupId",
                table: "Session",
                column: "TrainerLookupId");

            migrationBuilder.AddForeignKey(
                name: "FK_Session_Lookup_TrainerLookupId",
                table: "Session",
                column: "TrainerLookupId",
                principalTable: "Lookup",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Session_Lookup_TrainerLookupId",
                table: "Session");

            migrationBuilder.DropIndex(
                name: "IX_Session_TrainerLookupId",
                table: "Session");

            migrationBuilder.DropColumn(
                name: "TrainerLookupId",
                table: "Session");

            migrationBuilder.DropColumn(
                name: "TrainerName",
                table: "Session");
        }
    }
}
