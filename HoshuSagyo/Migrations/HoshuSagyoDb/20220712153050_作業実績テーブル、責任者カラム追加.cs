using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HoshuSagyo.Migrations.HoshuSagyoDb
{
    public partial class 作業実績テーブル責任者カラム追加 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SagyoChakushuSekininshaMei",
                table: "T_SagyoJisseki",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SagyoKanryoSekininshaMei",
                table: "T_SagyoJisseki",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SagyoChakushuSekininshaMei",
                table: "T_SagyoJisseki");

            migrationBuilder.DropColumn(
                name: "SagyoKanryoSekininshaMei",
                table: "T_SagyoJisseki");

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
    }
}
