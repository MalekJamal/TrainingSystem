using Microsoft.EntityFrameworkCore.Migrations;

namespace TrainingSystem.EF.Migrations
{
    public partial class EditAllTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lookups_LookupCategories_LookUpCategoryId",
                table: "Lookups");

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

            migrationBuilder.DropPrimaryKey(
                name: "PK_LookupCategories",
                table: "LookupCategories");

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

            migrationBuilder.DropColumn(
                name: "LookUpCategoryId",
                table: "LookupCategories");

            migrationBuilder.RenameColumn(
                name: "LookUpCategoryId",
                table: "Lookups",
                newName: "LookupCategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Lookups_LookUpCategoryId",
                table: "Lookups",
                newName: "IX_Lookups_LookupCategoryId");

            migrationBuilder.AddColumn<int>(
                name: "Result",
                table: "Sessions",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ResultLookupId",
                table: "Sessions",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Sessions",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StatusLookupId",
                table: "Sessions",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TrainingTopic",
                table: "Sessions",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TrainingTopicLookupId",
                table: "Sessions",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TrainingType",
                table: "Sessions",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TrainingTypeLookupId",
                table: "Sessions",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "LookupCategoryId",
                table: "Lookups",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "LookupCategories",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LookupCategories",
                table: "LookupCategories",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Sessions_ResultLookupId",
                table: "Sessions",
                column: "ResultLookupId");

            migrationBuilder.CreateIndex(
                name: "IX_Sessions_StatusLookupId",
                table: "Sessions",
                column: "StatusLookupId");

            migrationBuilder.CreateIndex(
                name: "IX_Sessions_TrainingTopicLookupId",
                table: "Sessions",
                column: "TrainingTopicLookupId");

            migrationBuilder.CreateIndex(
                name: "IX_Sessions_TrainingTypeLookupId",
                table: "Sessions",
                column: "TrainingTypeLookupId");

            migrationBuilder.AddForeignKey(
                name: "FK_Lookups_LookupCategories_LookupCategoryId",
                table: "Lookups",
                column: "LookupCategoryId",
                principalTable: "LookupCategories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sessions_Lookups_ResultLookupId",
                table: "Sessions",
                column: "ResultLookupId",
                principalTable: "Lookups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Sessions_Lookups_StatusLookupId",
                table: "Sessions",
                column: "StatusLookupId",
                principalTable: "Lookups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Sessions_Lookups_TrainingTopicLookupId",
                table: "Sessions",
                column: "TrainingTopicLookupId",
                principalTable: "Lookups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Sessions_Lookups_TrainingTypeLookupId",
                table: "Sessions",
                column: "TrainingTypeLookupId",
                principalTable: "Lookups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lookups_LookupCategories_LookupCategoryId",
                table: "Lookups");

            migrationBuilder.DropForeignKey(
                name: "FK_Sessions_Lookups_ResultLookupId",
                table: "Sessions");

            migrationBuilder.DropForeignKey(
                name: "FK_Sessions_Lookups_StatusLookupId",
                table: "Sessions");

            migrationBuilder.DropForeignKey(
                name: "FK_Sessions_Lookups_TrainingTopicLookupId",
                table: "Sessions");

            migrationBuilder.DropForeignKey(
                name: "FK_Sessions_Lookups_TrainingTypeLookupId",
                table: "Sessions");

            migrationBuilder.DropIndex(
                name: "IX_Sessions_ResultLookupId",
                table: "Sessions");

            migrationBuilder.DropIndex(
                name: "IX_Sessions_StatusLookupId",
                table: "Sessions");

            migrationBuilder.DropIndex(
                name: "IX_Sessions_TrainingTopicLookupId",
                table: "Sessions");

            migrationBuilder.DropIndex(
                name: "IX_Sessions_TrainingTypeLookupId",
                table: "Sessions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LookupCategories",
                table: "LookupCategories");

            migrationBuilder.DropColumn(
                name: "Result",
                table: "Sessions");

            migrationBuilder.DropColumn(
                name: "ResultLookupId",
                table: "Sessions");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Sessions");

            migrationBuilder.DropColumn(
                name: "StatusLookupId",
                table: "Sessions");

            migrationBuilder.DropColumn(
                name: "TrainingTopic",
                table: "Sessions");

            migrationBuilder.DropColumn(
                name: "TrainingTopicLookupId",
                table: "Sessions");

            migrationBuilder.DropColumn(
                name: "TrainingType",
                table: "Sessions");

            migrationBuilder.DropColumn(
                name: "TrainingTypeLookupId",
                table: "Sessions");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "LookupCategories");

            migrationBuilder.RenameColumn(
                name: "LookupCategoryId",
                table: "Lookups",
                newName: "LookUpCategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Lookups_LookupCategoryId",
                table: "Lookups",
                newName: "IX_Lookups_LookUpCategoryId");

            migrationBuilder.AddColumn<int>(
                name: "ResultId",
                table: "Sessions",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StatusId",
                table: "Sessions",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TopicId",
                table: "Sessions",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TrainerNameId",
                table: "Sessions",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TypeId",
                table: "Sessions",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "LookUpCategoryId",
                table: "Lookups",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "LookUpCategoryId",
                table: "LookupCategories",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LookupCategories",
                table: "LookupCategories",
                column: "LookUpCategoryId");

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
                name: "FK_Lookups_LookupCategories_LookUpCategoryId",
                table: "Lookups",
                column: "LookUpCategoryId",
                principalTable: "LookupCategories",
                principalColumn: "LookUpCategoryId",
                onDelete: ReferentialAction.Restrict);

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
    }
}
