using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TrainingSystem.EF.Migrations
{
    public partial class EditSessionTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sessions_Lookups_lookUpId",
                table: "Sessions");

            migrationBuilder.DropIndex(
                name: "IX_Sessions_lookUpId",
                table: "Sessions");

            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "Sessions");

            migrationBuilder.DropColumn(
                name: "TrainerName",
                table: "Sessions");

            migrationBuilder.DropColumn(
                name: "lookUpId",
                table: "Sessions");

            migrationBuilder.AddColumn<DateTime>(
                name: "ActualEndDate",
                table: "Sessions",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Comment",
                table: "Sessions",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "EvaluationScore",
                table: "Sessions",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<DateTime>(
                name: "ExpectedEndDate",
                table: "Sessions",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "FinalPresentationDate",
                table: "Sessions",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "ResultId",
                table: "Sessions",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StatusId",
                table: "Sessions",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TopicId",
                table: "Sessions",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TrainerNameId",
                table: "Sessions",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TypeId",
                table: "Sessions",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Sessions_ResultId",
                table: "Sessions",
                column: "ResultId");

            migrationBuilder.CreateIndex(
                name: "IX_Sessions_StatusId",
                table: "Sessions",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Sessions_TopicId",
                table: "Sessions",
                column: "TopicId");

            migrationBuilder.CreateIndex(
                name: "IX_Sessions_TrainerNameId",
                table: "Sessions",
                column: "TrainerNameId");

            migrationBuilder.CreateIndex(
                name: "IX_Sessions_TypeId",
                table: "Sessions",
                column: "TypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Sessions_Lookups_ResultId",
                table: "Sessions",
                column: "ResultId",
                principalTable: "Lookups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Sessions_Lookups_StatusId",
                table: "Sessions",
                column: "StatusId",
                principalTable: "Lookups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Sessions_Lookups_TopicId",
                table: "Sessions",
                column: "TopicId",
                principalTable: "Lookups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Sessions_Lookups_TrainerNameId",
                table: "Sessions",
                column: "TrainerNameId",
                principalTable: "Lookups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Sessions_Lookups_TypeId",
                table: "Sessions",
                column: "TypeId",
                principalTable: "Lookups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sessions_Lookups_ResultId",
                table: "Sessions");

            migrationBuilder.DropForeignKey(
                name: "FK_Sessions_Lookups_StatusId",
                table: "Sessions");

            migrationBuilder.DropForeignKey(
                name: "FK_Sessions_Lookups_TopicId",
                table: "Sessions");

            migrationBuilder.DropForeignKey(
                name: "FK_Sessions_Lookups_TrainerNameId",
                table: "Sessions");

            migrationBuilder.DropForeignKey(
                name: "FK_Sessions_Lookups_TypeId",
                table: "Sessions");

            migrationBuilder.DropIndex(
                name: "IX_Sessions_ResultId",
                table: "Sessions");

            migrationBuilder.DropIndex(
                name: "IX_Sessions_StatusId",
                table: "Sessions");

            migrationBuilder.DropIndex(
                name: "IX_Sessions_TopicId",
                table: "Sessions");

            migrationBuilder.DropIndex(
                name: "IX_Sessions_TrainerNameId",
                table: "Sessions");

            migrationBuilder.DropIndex(
                name: "IX_Sessions_TypeId",
                table: "Sessions");

            migrationBuilder.DropColumn(
                name: "ActualEndDate",
                table: "Sessions");

            migrationBuilder.DropColumn(
                name: "Comment",
                table: "Sessions");

            migrationBuilder.DropColumn(
                name: "EvaluationScore",
                table: "Sessions");

            migrationBuilder.DropColumn(
                name: "ExpectedEndDate",
                table: "Sessions");

            migrationBuilder.DropColumn(
                name: "FinalPresentationDate",
                table: "Sessions");

            migrationBuilder.DropColumn(
                name: "ResultId",
                table: "Sessions");

            migrationBuilder.DropColumn(
                name: "StatusId",
                table: "Sessions");

            migrationBuilder.DropColumn(
                name: "TopicId",
                table: "Sessions");

            migrationBuilder.DropColumn(
                name: "TrainerNameId",
                table: "Sessions");

            migrationBuilder.DropColumn(
                name: "TypeId",
                table: "Sessions");

            migrationBuilder.AddColumn<DateTime>(
                name: "EndDate",
                table: "Sessions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "TrainerName",
                table: "Sessions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "lookUpId",
                table: "Sessions",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Sessions_lookUpId",
                table: "Sessions",
                column: "lookUpId");

            migrationBuilder.AddForeignKey(
                name: "FK_Sessions_Lookups_lookUpId",
                table: "Sessions",
                column: "lookUpId",
                principalTable: "Lookups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
