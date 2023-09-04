using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TrainingSystem.EF.Migrations
{
    public partial class EditTableFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedBy", "CreatedOn", "Description", "IsActive" },
                values: new object[] { "Malek Hamdan", new DateTime(2023, 9, 3, 15, 56, 17, 422, DateTimeKind.Local).AddTicks(8482), "", true });

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedBy", "CreatedOn", "Description", "IsActive" },
                values: new object[] { "Malek Hamdan", new DateTime(2023, 9, 3, 15, 56, 17, 422, DateTimeKind.Local).AddTicks(8850), "", true });

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedBy", "CreatedOn", "Description", "IsActive" },
                values: new object[] { "Malek Hamdan", new DateTime(2023, 9, 3, 15, 56, 17, 422, DateTimeKind.Local).AddTicks(8867), "", true });

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedBy", "CreatedOn", "Description", "IsActive" },
                values: new object[] { "Malek Hamdan", new DateTime(2023, 9, 3, 15, 56, 17, 422, DateTimeKind.Local).AddTicks(8870), "", true });

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedBy", "CreatedOn", "Description", "IsActive" },
                values: new object[] { "Malek Hamdan", new DateTime(2023, 9, 3, 15, 56, 17, 422, DateTimeKind.Local).AddTicks(8872), "", true });

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedBy", "CreatedOn", "Description", "IsActive" },
                values: new object[] { "Malek Hamdan", new DateTime(2023, 9, 3, 15, 56, 17, 422, DateTimeKind.Local).AddTicks(8875), "", true });

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedBy", "CreatedOn", "Description", "IsActive" },
                values: new object[] { "Malek Hamdan", new DateTime(2023, 9, 3, 15, 56, 17, 422, DateTimeKind.Local).AddTicks(8878), "", true });

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedBy", "CreatedOn", "Description", "IsActive" },
                values: new object[] { "Malek Hamdan", new DateTime(2023, 9, 3, 15, 56, 17, 422, DateTimeKind.Local).AddTicks(8882), "", true });

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedBy", "CreatedOn", "Description", "IsActive" },
                values: new object[] { "Malek Hamdan", new DateTime(2023, 9, 3, 15, 56, 17, 422, DateTimeKind.Local).AddTicks(8885), "", true });

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedBy", "CreatedOn", "Description", "IsActive" },
                values: new object[] { "Malek Hamdan", new DateTime(2023, 9, 3, 15, 56, 17, 422, DateTimeKind.Local).AddTicks(8888), "", true });

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedBy", "CreatedOn", "Description", "IsActive" },
                values: new object[] { "Malek Hamdan", new DateTime(2023, 9, 3, 15, 56, 17, 422, DateTimeKind.Local).AddTicks(8891), "", true });

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedBy", "CreatedOn", "Description", "IsActive" },
                values: new object[] { "Malek Hamdan", new DateTime(2023, 9, 3, 15, 56, 17, 422, DateTimeKind.Local).AddTicks(8894), "", true });

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedBy", "CreatedOn", "Description", "IsActive" },
                values: new object[] { "Malek Hamdan", new DateTime(2023, 9, 3, 15, 56, 17, 422, DateTimeKind.Local).AddTicks(8896), "", true });

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedBy", "CreatedOn", "Description", "IsActive" },
                values: new object[] { "Malek Hamdan", new DateTime(2023, 9, 3, 15, 56, 17, 422, DateTimeKind.Local).AddTicks(8899), "", true });

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedBy", "CreatedOn", "Description", "IsActive" },
                values: new object[] { "Malek Hamdan", new DateTime(2023, 9, 3, 15, 56, 17, 422, DateTimeKind.Local).AddTicks(8901), "", true });

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedBy", "CreatedOn", "Description", "IsActive" },
                values: new object[] { "Malek Hamdan", new DateTime(2023, 9, 3, 15, 56, 17, 422, DateTimeKind.Local).AddTicks(8903), "", true });

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedBy", "CreatedOn", "Description", "IsActive" },
                values: new object[] { "Malek Hamdan", new DateTime(2023, 9, 3, 15, 56, 17, 422, DateTimeKind.Local).AddTicks(8905), "", true });

            migrationBuilder.UpdateData(
                table: "LookupCategory",
                keyColumn: "CategoryId",
                keyValue: 100,
                columns: new[] { "CreatedBy", "CreatedOn", "Description", "IsActive" },
                values: new object[] { "Malek Hamdan", new DateTime(2023, 9, 3, 15, 56, 17, 420, DateTimeKind.Local).AddTicks(466), "Training Type That TPS Provided", true });

            migrationBuilder.UpdateData(
                table: "LookupCategory",
                keyColumn: "CategoryId",
                keyValue: 200,
                columns: new[] { "CreatedBy", "CreatedOn", "Description", "IsActive" },
                values: new object[] { "Malek Hamdan", new DateTime(2023, 9, 3, 15, 56, 17, 421, DateTimeKind.Local).AddTicks(2891), "Training Topics That TPS Provided", true });

            migrationBuilder.UpdateData(
                table: "LookupCategory",
                keyColumn: "CategoryId",
                keyValue: 300,
                columns: new[] { "CreatedBy", "CreatedOn", "Description", "IsActive" },
                values: new object[] { "Malek Hamdan", new DateTime(2023, 9, 3, 15, 56, 17, 421, DateTimeKind.Local).AddTicks(2947), "Training Status", true });

            migrationBuilder.UpdateData(
                table: "LookupCategory",
                keyColumn: "CategoryId",
                keyValue: 400,
                columns: new[] { "CreatedBy", "CreatedOn", "Description", "IsActive" },
                values: new object[] { "Malek Hamdan", new DateTime(2023, 9, 3, 15, 56, 17, 421, DateTimeKind.Local).AddTicks(2952), "Training Result", true });

            migrationBuilder.InsertData(
                table: "LookupCategory",
                columns: new[] { "CategoryId", "Code", "CreatedBy", "CreatedOn", "Description", "IsActive", "IsDeleted", "ModifyBy", "ModifyOn", "NameAr", "NameEn" },
                values: new object[,]
                {
                    { 600, 6, "Malek Hamdan", new DateTime(2023, 9, 3, 15, 56, 17, 421, DateTimeKind.Local).AddTicks(2957), "Training Year That TPS Provided", true, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "السنة", "Year" },
                    { 500, 5, "Malek Hamdan", new DateTime(2023, 9, 3, 15, 56, 17, 421, DateTimeKind.Local).AddTicks(2954), "Trainer Name", true, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "أسم المدرب", "Trainer Name" }
                });

            migrationBuilder.InsertData(
                table: "Lookup",
                columns: new[] { "Id", "Code", "CreatedBy", "CreatedOn", "Description", "IsActive", "IsDeleted", "LookupCategoryId", "ModifyBy", "ModifyOn", "NameAr", "NameEn" },
                values: new object[,]
                {
                    { 18, 1, "Malek Hamdan", new DateTime(2023, 9, 3, 15, 56, 17, 422, DateTimeKind.Local).AddTicks(8908), "", true, false, 500, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "خالد سلامة", "Khalid_Salameh" },
                    { 32, 7, "Malek Hamdan", new DateTime(2023, 9, 3, 15, 56, 17, 422, DateTimeKind.Local).AddTicks(8940), "", true, false, 600, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Year2029", "Year2029" },
                    { 31, 6, "Malek Hamdan", new DateTime(2023, 9, 3, 15, 56, 17, 422, DateTimeKind.Local).AddTicks(8938), "", true, false, 600, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Year2028", "Year2028" },
                    { 30, 5, "Malek Hamdan", new DateTime(2023, 9, 3, 15, 56, 17, 422, DateTimeKind.Local).AddTicks(8935), "", true, false, 600, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Year2027", "Year2027" },
                    { 29, 4, "Malek Hamdan", new DateTime(2023, 9, 3, 15, 56, 17, 422, DateTimeKind.Local).AddTicks(8933), "", true, false, 600, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Year2026", "Year2026" },
                    { 28, 3, "Malek Hamdan", new DateTime(2023, 9, 3, 15, 56, 17, 422, DateTimeKind.Local).AddTicks(8931), "", true, false, 600, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Year2025", "Year2025" },
                    { 27, 2, "Malek Hamdan", new DateTime(2023, 9, 3, 15, 56, 17, 422, DateTimeKind.Local).AddTicks(8929), "", true, false, 600, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Year2024", "Year2024" },
                    { 33, 8, "Malek Hamdan", new DateTime(2023, 9, 3, 15, 56, 17, 422, DateTimeKind.Local).AddTicks(8942), "", true, false, 600, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Year2030", "Year2030" },
                    { 26, 1, "Malek Hamdan", new DateTime(2023, 9, 3, 15, 56, 17, 422, DateTimeKind.Local).AddTicks(8926), "", true, false, 600, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Year2023", "Year2023" },
                    { 24, 7, "Malek Hamdan", new DateTime(2023, 9, 3, 15, 56, 17, 422, DateTimeKind.Local).AddTicks(8922), "", true, false, 500, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "زكريا لافي", "Zakaria_Lafi" },
                    { 23, 6, "Malek Hamdan", new DateTime(2023, 9, 3, 15, 56, 17, 422, DateTimeKind.Local).AddTicks(8920), "", true, false, 500, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "صفاء", "Safaa" },
                    { 22, 5, "Malek Hamdan", new DateTime(2023, 9, 3, 15, 56, 17, 422, DateTimeKind.Local).AddTicks(8918), "", true, false, 500, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "محمد عبده", "Mohammad_Ibdah" },
                    { 21, 4, "Malek Hamdan", new DateTime(2023, 9, 3, 15, 56, 17, 422, DateTimeKind.Local).AddTicks(8915), "", true, false, 500, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "محمد حماد", "Mohammad_Hamad" },
                    { 20, 3, "Malek Hamdan", new DateTime(2023, 9, 3, 15, 56, 17, 422, DateTimeKind.Local).AddTicks(8913), "", true, false, 500, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "مريم السعداوي", "Mariam_AlSadawi" },
                    { 19, 2, "Malek Hamdan", new DateTime(2023, 9, 3, 15, 56, 17, 422, DateTimeKind.Local).AddTicks(8911), "", true, false, 500, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "لميس حوراني", "Lamees_Hourani" },
                    { 25, 8, "Malek Hamdan", new DateTime(2023, 9, 3, 15, 56, 17, 422, DateTimeKind.Local).AddTicks(8924), "", true, false, 500, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "أحمد سويلم", "Ahmed_Sweilem" },
                    { 34, 9, "Malek Hamdan", new DateTime(2023, 9, 3, 15, 56, 17, 422, DateTimeKind.Local).AddTicks(8944), "", true, false, 600, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Year2031", "Year2031" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "LookupCategory",
                keyColumn: "CategoryId",
                keyValue: 500);

            migrationBuilder.DeleteData(
                table: "LookupCategory",
                keyColumn: "CategoryId",
                keyValue: 600);

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedBy", "CreatedOn", "Description", "IsActive" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false });

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedBy", "CreatedOn", "Description", "IsActive" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false });

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedBy", "CreatedOn", "Description", "IsActive" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false });

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedBy", "CreatedOn", "Description", "IsActive" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false });

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedBy", "CreatedOn", "Description", "IsActive" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false });

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedBy", "CreatedOn", "Description", "IsActive" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false });

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedBy", "CreatedOn", "Description", "IsActive" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false });

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedBy", "CreatedOn", "Description", "IsActive" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false });

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedBy", "CreatedOn", "Description", "IsActive" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false });

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedBy", "CreatedOn", "Description", "IsActive" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false });

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedBy", "CreatedOn", "Description", "IsActive" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false });

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedBy", "CreatedOn", "Description", "IsActive" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false });

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedBy", "CreatedOn", "Description", "IsActive" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false });

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedBy", "CreatedOn", "Description", "IsActive" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false });

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedBy", "CreatedOn", "Description", "IsActive" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false });

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedBy", "CreatedOn", "Description", "IsActive" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false });

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedBy", "CreatedOn", "Description", "IsActive" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false });

            migrationBuilder.UpdateData(
                table: "LookupCategory",
                keyColumn: "CategoryId",
                keyValue: 100,
                columns: new[] { "CreatedBy", "CreatedOn", "Description", "IsActive" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false });

            migrationBuilder.UpdateData(
                table: "LookupCategory",
                keyColumn: "CategoryId",
                keyValue: 200,
                columns: new[] { "CreatedBy", "CreatedOn", "Description", "IsActive" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false });

            migrationBuilder.UpdateData(
                table: "LookupCategory",
                keyColumn: "CategoryId",
                keyValue: 300,
                columns: new[] { "CreatedBy", "CreatedOn", "Description", "IsActive" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false });

            migrationBuilder.UpdateData(
                table: "LookupCategory",
                keyColumn: "CategoryId",
                keyValue: 400,
                columns: new[] { "CreatedBy", "CreatedOn", "Description", "IsActive" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false });
        }
    }
}
