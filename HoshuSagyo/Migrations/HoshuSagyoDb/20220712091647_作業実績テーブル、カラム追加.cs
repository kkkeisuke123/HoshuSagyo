using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HoshuSagyo.Migrations.HoshuSagyoDb
{
    public partial class 作業実績テーブルカラム追加 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "SagyoChakushuNichiji",
                table: "T_SagyoJisseki",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "SagyoKanryoNichiji",
                table: "T_SagyoJisseki",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 12, 18, 16, 46, 909, DateTimeKind.Local).AddTicks(1305), new DateTime(2022, 7, 12, 18, 16, 46, 909, DateTimeKind.Local).AddTicks(1305) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 12, 18, 16, 46, 909, DateTimeKind.Local).AddTicks(1305), new DateTime(2022, 7, 12, 18, 16, 46, 909, DateTimeKind.Local).AddTicks(1305) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 3,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 12, 18, 16, 46, 909, DateTimeKind.Local).AddTicks(1305), new DateTime(2022, 7, 12, 18, 16, 46, 909, DateTimeKind.Local).AddTicks(1305) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 4,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 12, 18, 16, 46, 909, DateTimeKind.Local).AddTicks(1305), new DateTime(2022, 7, 12, 18, 16, 46, 909, DateTimeKind.Local).AddTicks(1305) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 5,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 12, 18, 16, 46, 909, DateTimeKind.Local).AddTicks(1305), new DateTime(2022, 7, 12, 18, 16, 46, 909, DateTimeKind.Local).AddTicks(1305) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 6,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 12, 18, 16, 46, 909, DateTimeKind.Local).AddTicks(1305), new DateTime(2022, 7, 12, 18, 16, 46, 909, DateTimeKind.Local).AddTicks(1305) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 7,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 12, 18, 16, 46, 909, DateTimeKind.Local).AddTicks(1305), new DateTime(2022, 7, 12, 18, 16, 46, 909, DateTimeKind.Local).AddTicks(1305) });

            migrationBuilder.UpdateData(
                table: "M_Keito",
                keyColumn: "Keito",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 12, 18, 16, 46, 909, DateTimeKind.Local).AddTicks(1305), new DateTime(2022, 7, 12, 18, 16, 46, 909, DateTimeKind.Local).AddTicks(1305) });

            migrationBuilder.UpdateData(
                table: "M_Keito",
                keyColumn: "Keito",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 12, 18, 16, 46, 909, DateTimeKind.Local).AddTicks(1305), new DateTime(2022, 7, 12, 18, 16, 46, 909, DateTimeKind.Local).AddTicks(1305) });

            migrationBuilder.UpdateData(
                table: "M_Keito",
                keyColumn: "Keito",
                keyValue: 99,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 12, 18, 16, 46, 909, DateTimeKind.Local).AddTicks(1305), new DateTime(2022, 7, 12, 18, 16, 46, 909, DateTimeKind.Local).AddTicks(1305) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOto",
                keyColumn: "OtoShubetsu",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 12, 18, 16, 46, 909, DateTimeKind.Local).AddTicks(1305), new DateTime(2022, 7, 12, 18, 16, 46, 909, DateTimeKind.Local).AddTicks(1305) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOto",
                keyColumn: "OtoShubetsu",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 12, 18, 16, 46, 909, DateTimeKind.Local).AddTicks(1305), new DateTime(2022, 7, 12, 18, 16, 46, 909, DateTimeKind.Local).AddTicks(1305) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOto",
                keyColumn: "OtoShubetsu",
                keyValue: 3,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 12, 18, 16, 46, 909, DateTimeKind.Local).AddTicks(1305), new DateTime(2022, 7, 12, 18, 16, 46, 909, DateTimeKind.Local).AddTicks(1305) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOto",
                keyColumn: "OtoShubetsu",
                keyValue: 4,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 12, 18, 16, 46, 909, DateTimeKind.Local).AddTicks(1305), new DateTime(2022, 7, 12, 18, 16, 46, 909, DateTimeKind.Local).AddTicks(1305) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 12, 18, 16, 46, 909, DateTimeKind.Local).AddTicks(1305), new DateTime(2022, 7, 12, 18, 16, 46, 909, DateTimeKind.Local).AddTicks(1305) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 12, 18, 16, 46, 909, DateTimeKind.Local).AddTicks(1305), new DateTime(2022, 7, 12, 18, 16, 46, 909, DateTimeKind.Local).AddTicks(1305) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 12, 18, 16, 46, 909, DateTimeKind.Local).AddTicks(1305), new DateTime(2022, 7, 12, 18, 16, 46, 909, DateTimeKind.Local).AddTicks(1305) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 12, 18, 16, 46, 909, DateTimeKind.Local).AddTicks(1305), new DateTime(2022, 7, 12, 18, 16, 46, 909, DateTimeKind.Local).AddTicks(1305) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 12, 18, 16, 46, 909, DateTimeKind.Local).AddTicks(1305), new DateTime(2022, 7, 12, 18, 16, 46, 909, DateTimeKind.Local).AddTicks(1305) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 12, 18, 16, 46, 909, DateTimeKind.Local).AddTicks(1305), new DateTime(2022, 7, 12, 18, 16, 46, 909, DateTimeKind.Local).AddTicks(1305) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 12, 18, 16, 46, 909, DateTimeKind.Local).AddTicks(1305), new DateTime(2022, 7, 12, 18, 16, 46, 909, DateTimeKind.Local).AddTicks(1305) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 12, 18, 16, 46, 909, DateTimeKind.Local).AddTicks(1305), new DateTime(2022, 7, 12, 18, 16, 46, 909, DateTimeKind.Local).AddTicks(1305) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 12, 18, 16, 46, 909, DateTimeKind.Local).AddTicks(1305), new DateTime(2022, 7, 12, 18, 16, 46, 909, DateTimeKind.Local).AddTicks(1305) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 12, 18, 16, 46, 909, DateTimeKind.Local).AddTicks(1305), new DateTime(2022, 7, 12, 18, 16, 46, 909, DateTimeKind.Local).AddTicks(1305) });

            migrationBuilder.UpdateData(
                table: "M_SagyoBasho",
                keyColumn: "SagyoBasho",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 12, 18, 16, 46, 909, DateTimeKind.Local).AddTicks(1305), new DateTime(2022, 7, 12, 18, 16, 46, 909, DateTimeKind.Local).AddTicks(1305) });

            migrationBuilder.UpdateData(
                table: "M_SagyoBasho",
                keyColumn: "SagyoBasho",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 12, 18, 16, 46, 909, DateTimeKind.Local).AddTicks(1305), new DateTime(2022, 7, 12, 18, 16, 46, 909, DateTimeKind.Local).AddTicks(1305) });

            migrationBuilder.UpdateData(
                table: "M_SagyoBasho",
                keyColumn: "SagyoBasho",
                keyValue: 3,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 12, 18, 16, 46, 909, DateTimeKind.Local).AddTicks(1305), new DateTime(2022, 7, 12, 18, 16, 46, 909, DateTimeKind.Local).AddTicks(1305) });

            migrationBuilder.UpdateData(
                table: "M_SagyoShubetsu",
                keyColumn: "SagyoShubetsu",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 12, 18, 16, 46, 909, DateTimeKind.Local).AddTicks(1305), new DateTime(2022, 7, 12, 18, 16, 46, 909, DateTimeKind.Local).AddTicks(1305) });

            migrationBuilder.UpdateData(
                table: "M_SagyoShubetsu",
                keyColumn: "SagyoShubetsu",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 12, 18, 16, 46, 909, DateTimeKind.Local).AddTicks(1305), new DateTime(2022, 7, 12, 18, 16, 46, 909, DateTimeKind.Local).AddTicks(1305) });

            migrationBuilder.UpdateData(
                table: "M_SagyoShubetsu",
                keyColumn: "SagyoShubetsu",
                keyValue: 3,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 12, 18, 16, 46, 909, DateTimeKind.Local).AddTicks(1305), new DateTime(2022, 7, 12, 18, 16, 46, 909, DateTimeKind.Local).AddTicks(1305) });

            migrationBuilder.UpdateData(
                table: "M_Shinchoku",
                keyColumn: "Shinchoku",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 12, 18, 16, 46, 909, DateTimeKind.Local).AddTicks(1305), new DateTime(2022, 7, 12, 18, 16, 46, 909, DateTimeKind.Local).AddTicks(1305) });

            migrationBuilder.UpdateData(
                table: "M_Shinchoku",
                keyColumn: "Shinchoku",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 12, 18, 16, 46, 909, DateTimeKind.Local).AddTicks(1305), new DateTime(2022, 7, 12, 18, 16, 46, 909, DateTimeKind.Local).AddTicks(1305) });

            migrationBuilder.UpdateData(
                table: "M_Shinchoku",
                keyColumn: "Shinchoku",
                keyValue: 3,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 12, 18, 16, 46, 909, DateTimeKind.Local).AddTicks(1305), new DateTime(2022, 7, 12, 18, 16, 46, 909, DateTimeKind.Local).AddTicks(1305) });

            migrationBuilder.UpdateData(
                table: "M_Shinchoku",
                keyColumn: "Shinchoku",
                keyValue: 4,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 12, 18, 16, 46, 909, DateTimeKind.Local).AddTicks(1305), new DateTime(2022, 7, 12, 18, 16, 46, 909, DateTimeKind.Local).AddTicks(1305) });

            migrationBuilder.UpdateData(
                table: "M_Shinchoku",
                keyColumn: "Shinchoku",
                keyValue: 5,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 12, 18, 16, 46, 909, DateTimeKind.Local).AddTicks(1305), new DateTime(2022, 7, 12, 18, 16, 46, 909, DateTimeKind.Local).AddTicks(1305) });

            migrationBuilder.UpdateData(
                table: "M_Shinchoku",
                keyColumn: "Shinchoku",
                keyValue: 6,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 12, 18, 16, 46, 909, DateTimeKind.Local).AddTicks(1305), new DateTime(2022, 7, 12, 18, 16, 46, 909, DateTimeKind.Local).AddTicks(1305) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SagyoChakushuNichiji",
                table: "T_SagyoJisseki");

            migrationBuilder.DropColumn(
                name: "SagyoKanryoNichiji",
                table: "T_SagyoJisseki");

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 8, 22, 44, 0, 376, DateTimeKind.Local).AddTicks(4373), new DateTime(2022, 7, 8, 22, 44, 0, 376, DateTimeKind.Local).AddTicks(4373) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 8, 22, 44, 0, 376, DateTimeKind.Local).AddTicks(4373), new DateTime(2022, 7, 8, 22, 44, 0, 376, DateTimeKind.Local).AddTicks(4373) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 3,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 8, 22, 44, 0, 376, DateTimeKind.Local).AddTicks(4373), new DateTime(2022, 7, 8, 22, 44, 0, 376, DateTimeKind.Local).AddTicks(4373) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 4,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 8, 22, 44, 0, 376, DateTimeKind.Local).AddTicks(4373), new DateTime(2022, 7, 8, 22, 44, 0, 376, DateTimeKind.Local).AddTicks(4373) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 5,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 8, 22, 44, 0, 376, DateTimeKind.Local).AddTicks(4373), new DateTime(2022, 7, 8, 22, 44, 0, 376, DateTimeKind.Local).AddTicks(4373) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 6,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 8, 22, 44, 0, 376, DateTimeKind.Local).AddTicks(4373), new DateTime(2022, 7, 8, 22, 44, 0, 376, DateTimeKind.Local).AddTicks(4373) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 7,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 8, 22, 44, 0, 376, DateTimeKind.Local).AddTicks(4373), new DateTime(2022, 7, 8, 22, 44, 0, 376, DateTimeKind.Local).AddTicks(4373) });

            migrationBuilder.UpdateData(
                table: "M_Keito",
                keyColumn: "Keito",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 8, 22, 44, 0, 376, DateTimeKind.Local).AddTicks(4373), new DateTime(2022, 7, 8, 22, 44, 0, 376, DateTimeKind.Local).AddTicks(4373) });

            migrationBuilder.UpdateData(
                table: "M_Keito",
                keyColumn: "Keito",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 8, 22, 44, 0, 376, DateTimeKind.Local).AddTicks(4373), new DateTime(2022, 7, 8, 22, 44, 0, 376, DateTimeKind.Local).AddTicks(4373) });

            migrationBuilder.UpdateData(
                table: "M_Keito",
                keyColumn: "Keito",
                keyValue: 99,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 8, 22, 44, 0, 376, DateTimeKind.Local).AddTicks(4373), new DateTime(2022, 7, 8, 22, 44, 0, 376, DateTimeKind.Local).AddTicks(4373) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOto",
                keyColumn: "OtoShubetsu",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 8, 22, 44, 0, 376, DateTimeKind.Local).AddTicks(4373), new DateTime(2022, 7, 8, 22, 44, 0, 376, DateTimeKind.Local).AddTicks(4373) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOto",
                keyColumn: "OtoShubetsu",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 8, 22, 44, 0, 376, DateTimeKind.Local).AddTicks(4373), new DateTime(2022, 7, 8, 22, 44, 0, 376, DateTimeKind.Local).AddTicks(4373) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOto",
                keyColumn: "OtoShubetsu",
                keyValue: 3,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 8, 22, 44, 0, 376, DateTimeKind.Local).AddTicks(4373), new DateTime(2022, 7, 8, 22, 44, 0, 376, DateTimeKind.Local).AddTicks(4373) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOto",
                keyColumn: "OtoShubetsu",
                keyValue: 4,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 8, 22, 44, 0, 376, DateTimeKind.Local).AddTicks(4373), new DateTime(2022, 7, 8, 22, 44, 0, 376, DateTimeKind.Local).AddTicks(4373) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 8, 22, 44, 0, 376, DateTimeKind.Local).AddTicks(4373), new DateTime(2022, 7, 8, 22, 44, 0, 376, DateTimeKind.Local).AddTicks(4373) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 8, 22, 44, 0, 376, DateTimeKind.Local).AddTicks(4373), new DateTime(2022, 7, 8, 22, 44, 0, 376, DateTimeKind.Local).AddTicks(4373) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 8, 22, 44, 0, 376, DateTimeKind.Local).AddTicks(4373), new DateTime(2022, 7, 8, 22, 44, 0, 376, DateTimeKind.Local).AddTicks(4373) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 8, 22, 44, 0, 376, DateTimeKind.Local).AddTicks(4373), new DateTime(2022, 7, 8, 22, 44, 0, 376, DateTimeKind.Local).AddTicks(4373) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 8, 22, 44, 0, 376, DateTimeKind.Local).AddTicks(4373), new DateTime(2022, 7, 8, 22, 44, 0, 376, DateTimeKind.Local).AddTicks(4373) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 8, 22, 44, 0, 376, DateTimeKind.Local).AddTicks(4373), new DateTime(2022, 7, 8, 22, 44, 0, 376, DateTimeKind.Local).AddTicks(4373) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 8, 22, 44, 0, 376, DateTimeKind.Local).AddTicks(4373), new DateTime(2022, 7, 8, 22, 44, 0, 376, DateTimeKind.Local).AddTicks(4373) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 8, 22, 44, 0, 376, DateTimeKind.Local).AddTicks(4373), new DateTime(2022, 7, 8, 22, 44, 0, 376, DateTimeKind.Local).AddTicks(4373) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 8, 22, 44, 0, 376, DateTimeKind.Local).AddTicks(4373), new DateTime(2022, 7, 8, 22, 44, 0, 376, DateTimeKind.Local).AddTicks(4373) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 8, 22, 44, 0, 376, DateTimeKind.Local).AddTicks(4373), new DateTime(2022, 7, 8, 22, 44, 0, 376, DateTimeKind.Local).AddTicks(4373) });

            migrationBuilder.UpdateData(
                table: "M_SagyoBasho",
                keyColumn: "SagyoBasho",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 8, 22, 44, 0, 376, DateTimeKind.Local).AddTicks(4373), new DateTime(2022, 7, 8, 22, 44, 0, 376, DateTimeKind.Local).AddTicks(4373) });

            migrationBuilder.UpdateData(
                table: "M_SagyoBasho",
                keyColumn: "SagyoBasho",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 8, 22, 44, 0, 376, DateTimeKind.Local).AddTicks(4373), new DateTime(2022, 7, 8, 22, 44, 0, 376, DateTimeKind.Local).AddTicks(4373) });

            migrationBuilder.UpdateData(
                table: "M_SagyoBasho",
                keyColumn: "SagyoBasho",
                keyValue: 3,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 8, 22, 44, 0, 376, DateTimeKind.Local).AddTicks(4373), new DateTime(2022, 7, 8, 22, 44, 0, 376, DateTimeKind.Local).AddTicks(4373) });

            migrationBuilder.UpdateData(
                table: "M_SagyoShubetsu",
                keyColumn: "SagyoShubetsu",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 8, 22, 44, 0, 376, DateTimeKind.Local).AddTicks(4373), new DateTime(2022, 7, 8, 22, 44, 0, 376, DateTimeKind.Local).AddTicks(4373) });

            migrationBuilder.UpdateData(
                table: "M_SagyoShubetsu",
                keyColumn: "SagyoShubetsu",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 8, 22, 44, 0, 376, DateTimeKind.Local).AddTicks(4373), new DateTime(2022, 7, 8, 22, 44, 0, 376, DateTimeKind.Local).AddTicks(4373) });

            migrationBuilder.UpdateData(
                table: "M_SagyoShubetsu",
                keyColumn: "SagyoShubetsu",
                keyValue: 3,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 8, 22, 44, 0, 376, DateTimeKind.Local).AddTicks(4373), new DateTime(2022, 7, 8, 22, 44, 0, 376, DateTimeKind.Local).AddTicks(4373) });

            migrationBuilder.UpdateData(
                table: "M_Shinchoku",
                keyColumn: "Shinchoku",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 8, 22, 44, 0, 376, DateTimeKind.Local).AddTicks(4373), new DateTime(2022, 7, 8, 22, 44, 0, 376, DateTimeKind.Local).AddTicks(4373) });

            migrationBuilder.UpdateData(
                table: "M_Shinchoku",
                keyColumn: "Shinchoku",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 8, 22, 44, 0, 376, DateTimeKind.Local).AddTicks(4373), new DateTime(2022, 7, 8, 22, 44, 0, 376, DateTimeKind.Local).AddTicks(4373) });

            migrationBuilder.UpdateData(
                table: "M_Shinchoku",
                keyColumn: "Shinchoku",
                keyValue: 3,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 8, 22, 44, 0, 376, DateTimeKind.Local).AddTicks(4373), new DateTime(2022, 7, 8, 22, 44, 0, 376, DateTimeKind.Local).AddTicks(4373) });

            migrationBuilder.UpdateData(
                table: "M_Shinchoku",
                keyColumn: "Shinchoku",
                keyValue: 4,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 8, 22, 44, 0, 376, DateTimeKind.Local).AddTicks(4373), new DateTime(2022, 7, 8, 22, 44, 0, 376, DateTimeKind.Local).AddTicks(4373) });

            migrationBuilder.UpdateData(
                table: "M_Shinchoku",
                keyColumn: "Shinchoku",
                keyValue: 5,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 8, 22, 44, 0, 376, DateTimeKind.Local).AddTicks(4373), new DateTime(2022, 7, 8, 22, 44, 0, 376, DateTimeKind.Local).AddTicks(4373) });

            migrationBuilder.UpdateData(
                table: "M_Shinchoku",
                keyColumn: "Shinchoku",
                keyValue: 6,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 8, 22, 44, 0, 376, DateTimeKind.Local).AddTicks(4373), new DateTime(2022, 7, 8, 22, 44, 0, 376, DateTimeKind.Local).AddTicks(4373) });
        }
    }
}
