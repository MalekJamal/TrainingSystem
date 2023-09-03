using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TrainingSystem.EF.Migrations
{
    public partial class Updatetables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropPrimaryKey(
                name: "PK_Sessions",
                table: "Sessions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Lookups",
                table: "Lookups");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LookupCategories",
                table: "LookupCategories");

            migrationBuilder.RenameTable(
                name: "Sessions",
                newName: "Session");

            migrationBuilder.RenameTable(
                name: "Lookups",
                newName: "Lookup");

            migrationBuilder.RenameTable(
                name: "LookupCategories",
                newName: "LookupCategory");

            migrationBuilder.RenameIndex(
                name: "IX_Sessions_TrainingTypeLookupId",
                table: "Session",
                newName: "IX_Session_TrainingTypeLookupId");

            migrationBuilder.RenameIndex(
                name: "IX_Sessions_TrainingTopicLookupId",
                table: "Session",
                newName: "IX_Session_TrainingTopicLookupId");

            migrationBuilder.RenameIndex(
                name: "IX_Sessions_StatusLookupId",
                table: "Session",
                newName: "IX_Session_StatusLookupId");

            migrationBuilder.RenameIndex(
                name: "IX_Sessions_ResultLookupId",
                table: "Session",
                newName: "IX_Session_ResultLookupId");

            migrationBuilder.RenameIndex(
                name: "IX_Lookups_LookupCategoryId",
                table: "Lookup",
                newName: "IX_Lookup_LookupCategoryId");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Session",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Lookup",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "LookupCategory",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Session",
                table: "Session",
                column: "SessionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Lookup",
                table: "Lookup",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LookupCategory",
                table: "LookupCategory",
                column: "CategoryId");

            migrationBuilder.InsertData(
                table: "LookupCategory",
                columns: new[] { "CategoryId", "Code", "CreatedBy", "CreatedOn", "Description", "IsActive", "IsDeleted", "ModifyBy", "ModifyOn", "NameAr", "NameEn" },
                values: new object[,]
                {
                    { 100, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "نوع التدريب", "Training Type" },
                    { 200, 2, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "موضوعات التدريب", "Training Topics" },
                    { 300, 3, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "حالة التدريب", "Training Status" },
                    { 400, 4, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "نتيجة التدريب", "Training Result" }
                });

            migrationBuilder.InsertData(
                table: "Lookup",
                columns: new[] { "Id", "Code", "CreatedBy", "CreatedOn", "Description", "IsActive", "IsDeleted", "LookupCategoryId", "ModifyBy", "ModifyOn", "NameAr", "NameEn" },
                values: new object[,]
                {
                    { 1, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, false, 100, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "عمل", "Work" },
                    { 15, 2, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, false, 400, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "معلق", "On_Hold" },
                    { 14, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, false, 400, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "الانضمام إلى فريق TPS", "Joining_TPS_Team" },
                    { 13, 3, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, false, 300, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "مكتمل", "Finished" },
                    { 12, 2, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, false, 300, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "قيد الانتظار", "Pending" },
                    { 11, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, false, 300, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "نشط", "Active" },
                    { 10, 8, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, false, 200, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "الذكاء الاصطناعي", "AI" },
                    { 16, 3, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, false, 400, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "مرفوض", "Rejected" },
                    { 9, 7, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, false, 200, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "المالية", "Finance" },
                    { 7, 5, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, false, 200, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "واجهة المستخدم وتجربة المستخدم", "UI_UX" },
                    { 6, 4, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, false, 200, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "بنية الأنظمة", "Infrastructure" },
                    { 5, 3, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, false, 200, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "مراقبة الجودة", "QualityControl" },
                    { 4, 2, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, false, 200, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "محلل أعمال", "BusinessAnalyst" },
                    { 3, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, false, 200, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), ".Net", "DotNet" },
                    { 2, 2, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, false, 100, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "جامعة", "University" },
                    { 8, 6, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, false, 200, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "الموارد البشرية", "HumanResources" },
                    { 17, 4, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, false, 400, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "استقال", "Quit" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Lookup_LookupCategory_LookupCategoryId",
                table: "Lookup",
                column: "LookupCategoryId",
                principalTable: "LookupCategory",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Session_Lookup_ResultLookupId",
                table: "Session",
                column: "ResultLookupId",
                principalTable: "Lookup",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Session_Lookup_StatusLookupId",
                table: "Session",
                column: "StatusLookupId",
                principalTable: "Lookup",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Session_Lookup_TrainingTopicLookupId",
                table: "Session",
                column: "TrainingTopicLookupId",
                principalTable: "Lookup",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Session_Lookup_TrainingTypeLookupId",
                table: "Session",
                column: "TrainingTypeLookupId",
                principalTable: "Lookup",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lookup_LookupCategory_LookupCategoryId",
                table: "Lookup");

            migrationBuilder.DropForeignKey(
                name: "FK_Session_Lookup_ResultLookupId",
                table: "Session");

            migrationBuilder.DropForeignKey(
                name: "FK_Session_Lookup_StatusLookupId",
                table: "Session");

            migrationBuilder.DropForeignKey(
                name: "FK_Session_Lookup_TrainingTopicLookupId",
                table: "Session");

            migrationBuilder.DropForeignKey(
                name: "FK_Session_Lookup_TrainingTypeLookupId",
                table: "Session");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Session",
                table: "Session");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LookupCategory",
                table: "LookupCategory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Lookup",
                table: "Lookup");

            migrationBuilder.DeleteData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "LookupCategory",
                keyColumn: "CategoryId",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "LookupCategory",
                keyColumn: "CategoryId",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "LookupCategory",
                keyColumn: "CategoryId",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "LookupCategory",
                keyColumn: "CategoryId",
                keyValue: 400);

            migrationBuilder.RenameTable(
                name: "Session",
                newName: "Sessions");

            migrationBuilder.RenameTable(
                name: "LookupCategory",
                newName: "LookupCategories");

            migrationBuilder.RenameTable(
                name: "Lookup",
                newName: "Lookups");

            migrationBuilder.RenameIndex(
                name: "IX_Session_TrainingTypeLookupId",
                table: "Sessions",
                newName: "IX_Sessions_TrainingTypeLookupId");

            migrationBuilder.RenameIndex(
                name: "IX_Session_TrainingTopicLookupId",
                table: "Sessions",
                newName: "IX_Sessions_TrainingTopicLookupId");

            migrationBuilder.RenameIndex(
                name: "IX_Session_StatusLookupId",
                table: "Sessions",
                newName: "IX_Sessions_StatusLookupId");

            migrationBuilder.RenameIndex(
                name: "IX_Session_ResultLookupId",
                table: "Sessions",
                newName: "IX_Sessions_ResultLookupId");

            migrationBuilder.RenameIndex(
                name: "IX_Lookup_LookupCategoryId",
                table: "Lookups",
                newName: "IX_Lookups_LookupCategoryId");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Sessions",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "LookupCategories",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Lookups",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sessions",
                table: "Sessions",
                column: "SessionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LookupCategories",
                table: "LookupCategories",
                column: "CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Lookups",
                table: "Lookups",
                column: "Id");

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
    }
}
