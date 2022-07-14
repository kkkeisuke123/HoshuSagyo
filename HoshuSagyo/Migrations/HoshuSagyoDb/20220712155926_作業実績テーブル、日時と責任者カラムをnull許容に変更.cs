using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HoshuSagyo.Migrations.HoshuSagyoDb
{
    public partial class 作業実績テーブル日時と責任者カラムをnull許容に変更 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "SagyoKanryoNichiji",
                table: "T_SagyoJisseki",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "SagyoChakushuNichiji",
                table: "T_SagyoJisseki",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 13, 0, 59, 26, 595, DateTimeKind.Local).AddTicks(1933), new DateTime(2022, 7, 13, 0, 59, 26, 595, DateTimeKind.Local).AddTicks(1933) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 13, 0, 59, 26, 595, DateTimeKind.Local).AddTicks(1933), new DateTime(2022, 7, 13, 0, 59, 26, 595, DateTimeKind.Local).AddTicks(1933) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 3,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 13, 0, 59, 26, 595, DateTimeKind.Local).AddTicks(1933), new DateTime(2022, 7, 13, 0, 59, 26, 595, DateTimeKind.Local).AddTicks(1933) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 4,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 13, 0, 59, 26, 595, DateTimeKind.Local).AddTicks(1933), new DateTime(2022, 7, 13, 0, 59, 26, 595, DateTimeKind.Local).AddTicks(1933) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 5,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 13, 0, 59, 26, 595, DateTimeKind.Local).AddTicks(1933), new DateTime(2022, 7, 13, 0, 59, 26, 595, DateTimeKind.Local).AddTicks(1933) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 6,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 13, 0, 59, 26, 595, DateTimeKind.Local).AddTicks(1933), new DateTime(2022, 7, 13, 0, 59, 26, 595, DateTimeKind.Local).AddTicks(1933) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 7,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 13, 0, 59, 26, 595, DateTimeKind.Local).AddTicks(1933), new DateTime(2022, 7, 13, 0, 59, 26, 595, DateTimeKind.Local).AddTicks(1933) });

            migrationBuilder.UpdateData(
                table: "M_Keito",
                keyColumn: "Keito",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 13, 0, 59, 26, 595, DateTimeKind.Local).AddTicks(1933), new DateTime(2022, 7, 13, 0, 59, 26, 595, DateTimeKind.Local).AddTicks(1933) });

            migrationBuilder.UpdateData(
                table: "M_Keito",
                keyColumn: "Keito",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 13, 0, 59, 26, 595, DateTimeKind.Local).AddTicks(1933), new DateTime(2022, 7, 13, 0, 59, 26, 595, DateTimeKind.Local).AddTicks(1933) });

            migrationBuilder.UpdateData(
                table: "M_Keito",
                keyColumn: "Keito",
                keyValue: 99,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 13, 0, 59, 26, 595, DateTimeKind.Local).AddTicks(1933), new DateTime(2022, 7, 13, 0, 59, 26, 595, DateTimeKind.Local).AddTicks(1933) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOto",
                keyColumn: "OtoShubetsu",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 13, 0, 59, 26, 595, DateTimeKind.Local).AddTicks(1933), new DateTime(2022, 7, 13, 0, 59, 26, 595, DateTimeKind.Local).AddTicks(1933) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOto",
                keyColumn: "OtoShubetsu",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 13, 0, 59, 26, 595, DateTimeKind.Local).AddTicks(1933), new DateTime(2022, 7, 13, 0, 59, 26, 595, DateTimeKind.Local).AddTicks(1933) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOto",
                keyColumn: "OtoShubetsu",
                keyValue: 3,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 13, 0, 59, 26, 595, DateTimeKind.Local).AddTicks(1933), new DateTime(2022, 7, 13, 0, 59, 26, 595, DateTimeKind.Local).AddTicks(1933) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOto",
                keyColumn: "OtoShubetsu",
                keyValue: 4,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 13, 0, 59, 26, 595, DateTimeKind.Local).AddTicks(1933), new DateTime(2022, 7, 13, 0, 59, 26, 595, DateTimeKind.Local).AddTicks(1933) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 13, 0, 59, 26, 595, DateTimeKind.Local).AddTicks(1933), new DateTime(2022, 7, 13, 0, 59, 26, 595, DateTimeKind.Local).AddTicks(1933) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 13, 0, 59, 26, 595, DateTimeKind.Local).AddTicks(1933), new DateTime(2022, 7, 13, 0, 59, 26, 595, DateTimeKind.Local).AddTicks(1933) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 13, 0, 59, 26, 595, DateTimeKind.Local).AddTicks(1933), new DateTime(2022, 7, 13, 0, 59, 26, 595, DateTimeKind.Local).AddTicks(1933) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 13, 0, 59, 26, 595, DateTimeKind.Local).AddTicks(1933), new DateTime(2022, 7, 13, 0, 59, 26, 595, DateTimeKind.Local).AddTicks(1933) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 13, 0, 59, 26, 595, DateTimeKind.Local).AddTicks(1933), new DateTime(2022, 7, 13, 0, 59, 26, 595, DateTimeKind.Local).AddTicks(1933) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 13, 0, 59, 26, 595, DateTimeKind.Local).AddTicks(1933), new DateTime(2022, 7, 13, 0, 59, 26, 595, DateTimeKind.Local).AddTicks(1933) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 13, 0, 59, 26, 595, DateTimeKind.Local).AddTicks(1933), new DateTime(2022, 7, 13, 0, 59, 26, 595, DateTimeKind.Local).AddTicks(1933) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 13, 0, 59, 26, 595, DateTimeKind.Local).AddTicks(1933), new DateTime(2022, 7, 13, 0, 59, 26, 595, DateTimeKind.Local).AddTicks(1933) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 13, 0, 59, 26, 595, DateTimeKind.Local).AddTicks(1933), new DateTime(2022, 7, 13, 0, 59, 26, 595, DateTimeKind.Local).AddTicks(1933) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 13, 0, 59, 26, 595, DateTimeKind.Local).AddTicks(1933), new DateTime(2022, 7, 13, 0, 59, 26, 595, DateTimeKind.Local).AddTicks(1933) });

            migrationBuilder.UpdateData(
                table: "M_SagyoBasho",
                keyColumn: "SagyoBasho",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 13, 0, 59, 26, 595, DateTimeKind.Local).AddTicks(1933), new DateTime(2022, 7, 13, 0, 59, 26, 595, DateTimeKind.Local).AddTicks(1933) });

            migrationBuilder.UpdateData(
                table: "M_SagyoBasho",
                keyColumn: "SagyoBasho",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 13, 0, 59, 26, 595, DateTimeKind.Local).AddTicks(1933), new DateTime(2022, 7, 13, 0, 59, 26, 595, DateTimeKind.Local).AddTicks(1933) });

            migrationBuilder.UpdateData(
                table: "M_SagyoBasho",
                keyColumn: "SagyoBasho",
                keyValue: 3,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 13, 0, 59, 26, 595, DateTimeKind.Local).AddTicks(1933), new DateTime(2022, 7, 13, 0, 59, 26, 595, DateTimeKind.Local).AddTicks(1933) });

            migrationBuilder.UpdateData(
                table: "M_SagyoShubetsu",
                keyColumn: "SagyoShubetsu",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 13, 0, 59, 26, 595, DateTimeKind.Local).AddTicks(1933), new DateTime(2022, 7, 13, 0, 59, 26, 595, DateTimeKind.Local).AddTicks(1933) });

            migrationBuilder.UpdateData(
                table: "M_SagyoShubetsu",
                keyColumn: "SagyoShubetsu",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 13, 0, 59, 26, 595, DateTimeKind.Local).AddTicks(1933), new DateTime(2022, 7, 13, 0, 59, 26, 595, DateTimeKind.Local).AddTicks(1933) });

            migrationBuilder.UpdateData(
                table: "M_SagyoShubetsu",
                keyColumn: "SagyoShubetsu",
                keyValue: 3,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 13, 0, 59, 26, 595, DateTimeKind.Local).AddTicks(1933), new DateTime(2022, 7, 13, 0, 59, 26, 595, DateTimeKind.Local).AddTicks(1933) });

            migrationBuilder.UpdateData(
                table: "M_Shinchoku",
                keyColumn: "Shinchoku",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 13, 0, 59, 26, 595, DateTimeKind.Local).AddTicks(1933), new DateTime(2022, 7, 13, 0, 59, 26, 595, DateTimeKind.Local).AddTicks(1933) });

            migrationBuilder.UpdateData(
                table: "M_Shinchoku",
                keyColumn: "Shinchoku",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 13, 0, 59, 26, 595, DateTimeKind.Local).AddTicks(1933), new DateTime(2022, 7, 13, 0, 59, 26, 595, DateTimeKind.Local).AddTicks(1933) });

            migrationBuilder.UpdateData(
                table: "M_Shinchoku",
                keyColumn: "Shinchoku",
                keyValue: 3,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 13, 0, 59, 26, 595, DateTimeKind.Local).AddTicks(1933), new DateTime(2022, 7, 13, 0, 59, 26, 595, DateTimeKind.Local).AddTicks(1933) });

            migrationBuilder.UpdateData(
                table: "M_Shinchoku",
                keyColumn: "Shinchoku",
                keyValue: 4,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 13, 0, 59, 26, 595, DateTimeKind.Local).AddTicks(1933), new DateTime(2022, 7, 13, 0, 59, 26, 595, DateTimeKind.Local).AddTicks(1933) });

            migrationBuilder.UpdateData(
                table: "M_Shinchoku",
                keyColumn: "Shinchoku",
                keyValue: 5,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 13, 0, 59, 26, 595, DateTimeKind.Local).AddTicks(1933), new DateTime(2022, 7, 13, 0, 59, 26, 595, DateTimeKind.Local).AddTicks(1933) });

            migrationBuilder.UpdateData(
                table: "M_Shinchoku",
                keyColumn: "Shinchoku",
                keyValue: 6,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 13, 0, 59, 26, 595, DateTimeKind.Local).AddTicks(1933), new DateTime(2022, 7, 13, 0, 59, 26, 595, DateTimeKind.Local).AddTicks(1933) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "SagyoKanryoNichiji",
                table: "T_SagyoJisseki",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "SagyoChakushuNichiji",
                table: "T_SagyoJisseki",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 13, 0, 30, 50, 106, DateTimeKind.Local).AddTicks(2066), new DateTime(2022, 7, 13, 0, 30, 50, 106, DateTimeKind.Local).AddTicks(2066) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 13, 0, 30, 50, 106, DateTimeKind.Local).AddTicks(2066), new DateTime(2022, 7, 13, 0, 30, 50, 106, DateTimeKind.Local).AddTicks(2066) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 3,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 13, 0, 30, 50, 106, DateTimeKind.Local).AddTicks(2066), new DateTime(2022, 7, 13, 0, 30, 50, 106, DateTimeKind.Local).AddTicks(2066) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 4,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 13, 0, 30, 50, 106, DateTimeKind.Local).AddTicks(2066), new DateTime(2022, 7, 13, 0, 30, 50, 106, DateTimeKind.Local).AddTicks(2066) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 5,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 13, 0, 30, 50, 106, DateTimeKind.Local).AddTicks(2066), new DateTime(2022, 7, 13, 0, 30, 50, 106, DateTimeKind.Local).AddTicks(2066) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 6,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 13, 0, 30, 50, 106, DateTimeKind.Local).AddTicks(2066), new DateTime(2022, 7, 13, 0, 30, 50, 106, DateTimeKind.Local).AddTicks(2066) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 7,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 13, 0, 30, 50, 106, DateTimeKind.Local).AddTicks(2066), new DateTime(2022, 7, 13, 0, 30, 50, 106, DateTimeKind.Local).AddTicks(2066) });

            migrationBuilder.UpdateData(
                table: "M_Keito",
                keyColumn: "Keito",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 13, 0, 30, 50, 106, DateTimeKind.Local).AddTicks(2066), new DateTime(2022, 7, 13, 0, 30, 50, 106, DateTimeKind.Local).AddTicks(2066) });

            migrationBuilder.UpdateData(
                table: "M_Keito",
                keyColumn: "Keito",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 13, 0, 30, 50, 106, DateTimeKind.Local).AddTicks(2066), new DateTime(2022, 7, 13, 0, 30, 50, 106, DateTimeKind.Local).AddTicks(2066) });

            migrationBuilder.UpdateData(
                table: "M_Keito",
                keyColumn: "Keito",
                keyValue: 99,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 13, 0, 30, 50, 106, DateTimeKind.Local).AddTicks(2066), new DateTime(2022, 7, 13, 0, 30, 50, 106, DateTimeKind.Local).AddTicks(2066) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOto",
                keyColumn: "OtoShubetsu",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 13, 0, 30, 50, 106, DateTimeKind.Local).AddTicks(2066), new DateTime(2022, 7, 13, 0, 30, 50, 106, DateTimeKind.Local).AddTicks(2066) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOto",
                keyColumn: "OtoShubetsu",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 13, 0, 30, 50, 106, DateTimeKind.Local).AddTicks(2066), new DateTime(2022, 7, 13, 0, 30, 50, 106, DateTimeKind.Local).AddTicks(2066) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOto",
                keyColumn: "OtoShubetsu",
                keyValue: 3,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 13, 0, 30, 50, 106, DateTimeKind.Local).AddTicks(2066), new DateTime(2022, 7, 13, 0, 30, 50, 106, DateTimeKind.Local).AddTicks(2066) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOto",
                keyColumn: "OtoShubetsu",
                keyValue: 4,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 13, 0, 30, 50, 106, DateTimeKind.Local).AddTicks(2066), new DateTime(2022, 7, 13, 0, 30, 50, 106, DateTimeKind.Local).AddTicks(2066) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 13, 0, 30, 50, 106, DateTimeKind.Local).AddTicks(2066), new DateTime(2022, 7, 13, 0, 30, 50, 106, DateTimeKind.Local).AddTicks(2066) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 13, 0, 30, 50, 106, DateTimeKind.Local).AddTicks(2066), new DateTime(2022, 7, 13, 0, 30, 50, 106, DateTimeKind.Local).AddTicks(2066) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 13, 0, 30, 50, 106, DateTimeKind.Local).AddTicks(2066), new DateTime(2022, 7, 13, 0, 30, 50, 106, DateTimeKind.Local).AddTicks(2066) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 13, 0, 30, 50, 106, DateTimeKind.Local).AddTicks(2066), new DateTime(2022, 7, 13, 0, 30, 50, 106, DateTimeKind.Local).AddTicks(2066) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 13, 0, 30, 50, 106, DateTimeKind.Local).AddTicks(2066), new DateTime(2022, 7, 13, 0, 30, 50, 106, DateTimeKind.Local).AddTicks(2066) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 13, 0, 30, 50, 106, DateTimeKind.Local).AddTicks(2066), new DateTime(2022, 7, 13, 0, 30, 50, 106, DateTimeKind.Local).AddTicks(2066) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 13, 0, 30, 50, 106, DateTimeKind.Local).AddTicks(2066), new DateTime(2022, 7, 13, 0, 30, 50, 106, DateTimeKind.Local).AddTicks(2066) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 13, 0, 30, 50, 106, DateTimeKind.Local).AddTicks(2066), new DateTime(2022, 7, 13, 0, 30, 50, 106, DateTimeKind.Local).AddTicks(2066) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 13, 0, 30, 50, 106, DateTimeKind.Local).AddTicks(2066), new DateTime(2022, 7, 13, 0, 30, 50, 106, DateTimeKind.Local).AddTicks(2066) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 13, 0, 30, 50, 106, DateTimeKind.Local).AddTicks(2066), new DateTime(2022, 7, 13, 0, 30, 50, 106, DateTimeKind.Local).AddTicks(2066) });

            migrationBuilder.UpdateData(
                table: "M_SagyoBasho",
                keyColumn: "SagyoBasho",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 13, 0, 30, 50, 106, DateTimeKind.Local).AddTicks(2066), new DateTime(2022, 7, 13, 0, 30, 50, 106, DateTimeKind.Local).AddTicks(2066) });

            migrationBuilder.UpdateData(
                table: "M_SagyoBasho",
                keyColumn: "SagyoBasho",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 13, 0, 30, 50, 106, DateTimeKind.Local).AddTicks(2066), new DateTime(2022, 7, 13, 0, 30, 50, 106, DateTimeKind.Local).AddTicks(2066) });

            migrationBuilder.UpdateData(
                table: "M_SagyoBasho",
                keyColumn: "SagyoBasho",
                keyValue: 3,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 13, 0, 30, 50, 106, DateTimeKind.Local).AddTicks(2066), new DateTime(2022, 7, 13, 0, 30, 50, 106, DateTimeKind.Local).AddTicks(2066) });

            migrationBuilder.UpdateData(
                table: "M_SagyoShubetsu",
                keyColumn: "SagyoShubetsu",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 13, 0, 30, 50, 106, DateTimeKind.Local).AddTicks(2066), new DateTime(2022, 7, 13, 0, 30, 50, 106, DateTimeKind.Local).AddTicks(2066) });

            migrationBuilder.UpdateData(
                table: "M_SagyoShubetsu",
                keyColumn: "SagyoShubetsu",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 13, 0, 30, 50, 106, DateTimeKind.Local).AddTicks(2066), new DateTime(2022, 7, 13, 0, 30, 50, 106, DateTimeKind.Local).AddTicks(2066) });

            migrationBuilder.UpdateData(
                table: "M_SagyoShubetsu",
                keyColumn: "SagyoShubetsu",
                keyValue: 3,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 13, 0, 30, 50, 106, DateTimeKind.Local).AddTicks(2066), new DateTime(2022, 7, 13, 0, 30, 50, 106, DateTimeKind.Local).AddTicks(2066) });

            migrationBuilder.UpdateData(
                table: "M_Shinchoku",
                keyColumn: "Shinchoku",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 13, 0, 30, 50, 106, DateTimeKind.Local).AddTicks(2066), new DateTime(2022, 7, 13, 0, 30, 50, 106, DateTimeKind.Local).AddTicks(2066) });

            migrationBuilder.UpdateData(
                table: "M_Shinchoku",
                keyColumn: "Shinchoku",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 13, 0, 30, 50, 106, DateTimeKind.Local).AddTicks(2066), new DateTime(2022, 7, 13, 0, 30, 50, 106, DateTimeKind.Local).AddTicks(2066) });

            migrationBuilder.UpdateData(
                table: "M_Shinchoku",
                keyColumn: "Shinchoku",
                keyValue: 3,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 13, 0, 30, 50, 106, DateTimeKind.Local).AddTicks(2066), new DateTime(2022, 7, 13, 0, 30, 50, 106, DateTimeKind.Local).AddTicks(2066) });

            migrationBuilder.UpdateData(
                table: "M_Shinchoku",
                keyColumn: "Shinchoku",
                keyValue: 4,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 13, 0, 30, 50, 106, DateTimeKind.Local).AddTicks(2066), new DateTime(2022, 7, 13, 0, 30, 50, 106, DateTimeKind.Local).AddTicks(2066) });

            migrationBuilder.UpdateData(
                table: "M_Shinchoku",
                keyColumn: "Shinchoku",
                keyValue: 5,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 13, 0, 30, 50, 106, DateTimeKind.Local).AddTicks(2066), new DateTime(2022, 7, 13, 0, 30, 50, 106, DateTimeKind.Local).AddTicks(2066) });

            migrationBuilder.UpdateData(
                table: "M_Shinchoku",
                keyColumn: "Shinchoku",
                keyValue: 6,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 13, 0, 30, 50, 106, DateTimeKind.Local).AddTicks(2066), new DateTime(2022, 7, 13, 0, 30, 50, 106, DateTimeKind.Local).AddTicks(2066) });
        }
    }
}
