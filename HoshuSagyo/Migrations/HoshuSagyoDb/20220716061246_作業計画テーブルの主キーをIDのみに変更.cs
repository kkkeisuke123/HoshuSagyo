using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HoshuSagyo.Migrations.HoshuSagyoDb
{
    public partial class 作業計画テーブルの主キーをIDのみに変更 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_T_SagyoKeikaku",
                table: "T_SagyoKeikaku");

            migrationBuilder.AddPrimaryKey(
                name: "PK_T_SagyoKeikaku",
                table: "T_SagyoKeikaku",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 16, 15, 12, 45, 739, DateTimeKind.Local).AddTicks(7780), new DateTime(2022, 7, 16, 15, 12, 45, 739, DateTimeKind.Local).AddTicks(7780) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 16, 15, 12, 45, 739, DateTimeKind.Local).AddTicks(7780), new DateTime(2022, 7, 16, 15, 12, 45, 739, DateTimeKind.Local).AddTicks(7780) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 3,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 16, 15, 12, 45, 739, DateTimeKind.Local).AddTicks(7780), new DateTime(2022, 7, 16, 15, 12, 45, 739, DateTimeKind.Local).AddTicks(7780) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 4,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 16, 15, 12, 45, 739, DateTimeKind.Local).AddTicks(7780), new DateTime(2022, 7, 16, 15, 12, 45, 739, DateTimeKind.Local).AddTicks(7780) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 5,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 16, 15, 12, 45, 739, DateTimeKind.Local).AddTicks(7780), new DateTime(2022, 7, 16, 15, 12, 45, 739, DateTimeKind.Local).AddTicks(7780) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 6,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 16, 15, 12, 45, 739, DateTimeKind.Local).AddTicks(7780), new DateTime(2022, 7, 16, 15, 12, 45, 739, DateTimeKind.Local).AddTicks(7780) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 7,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 16, 15, 12, 45, 739, DateTimeKind.Local).AddTicks(7780), new DateTime(2022, 7, 16, 15, 12, 45, 739, DateTimeKind.Local).AddTicks(7780) });

            migrationBuilder.UpdateData(
                table: "M_Keito",
                keyColumn: "Keito",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 16, 15, 12, 45, 739, DateTimeKind.Local).AddTicks(7780), new DateTime(2022, 7, 16, 15, 12, 45, 739, DateTimeKind.Local).AddTicks(7780) });

            migrationBuilder.UpdateData(
                table: "M_Keito",
                keyColumn: "Keito",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 16, 15, 12, 45, 739, DateTimeKind.Local).AddTicks(7780), new DateTime(2022, 7, 16, 15, 12, 45, 739, DateTimeKind.Local).AddTicks(7780) });

            migrationBuilder.UpdateData(
                table: "M_Keito",
                keyColumn: "Keito",
                keyValue: 99,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 16, 15, 12, 45, 739, DateTimeKind.Local).AddTicks(7780), new DateTime(2022, 7, 16, 15, 12, 45, 739, DateTimeKind.Local).AddTicks(7780) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOto",
                keyColumn: "OtoShubetsu",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 16, 15, 12, 45, 739, DateTimeKind.Local).AddTicks(7780), new DateTime(2022, 7, 16, 15, 12, 45, 739, DateTimeKind.Local).AddTicks(7780) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOto",
                keyColumn: "OtoShubetsu",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 16, 15, 12, 45, 739, DateTimeKind.Local).AddTicks(7780), new DateTime(2022, 7, 16, 15, 12, 45, 739, DateTimeKind.Local).AddTicks(7780) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOto",
                keyColumn: "OtoShubetsu",
                keyValue: 3,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 16, 15, 12, 45, 739, DateTimeKind.Local).AddTicks(7780), new DateTime(2022, 7, 16, 15, 12, 45, 739, DateTimeKind.Local).AddTicks(7780) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOto",
                keyColumn: "OtoShubetsu",
                keyValue: 4,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 16, 15, 12, 45, 739, DateTimeKind.Local).AddTicks(7780), new DateTime(2022, 7, 16, 15, 12, 45, 739, DateTimeKind.Local).AddTicks(7780) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 16, 15, 12, 45, 739, DateTimeKind.Local).AddTicks(7780), new DateTime(2022, 7, 16, 15, 12, 45, 739, DateTimeKind.Local).AddTicks(7780) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 16, 15, 12, 45, 739, DateTimeKind.Local).AddTicks(7780), new DateTime(2022, 7, 16, 15, 12, 45, 739, DateTimeKind.Local).AddTicks(7780) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 16, 15, 12, 45, 739, DateTimeKind.Local).AddTicks(7780), new DateTime(2022, 7, 16, 15, 12, 45, 739, DateTimeKind.Local).AddTicks(7780) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 16, 15, 12, 45, 739, DateTimeKind.Local).AddTicks(7780), new DateTime(2022, 7, 16, 15, 12, 45, 739, DateTimeKind.Local).AddTicks(7780) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 16, 15, 12, 45, 739, DateTimeKind.Local).AddTicks(7780), new DateTime(2022, 7, 16, 15, 12, 45, 739, DateTimeKind.Local).AddTicks(7780) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 16, 15, 12, 45, 739, DateTimeKind.Local).AddTicks(7780), new DateTime(2022, 7, 16, 15, 12, 45, 739, DateTimeKind.Local).AddTicks(7780) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 16, 15, 12, 45, 739, DateTimeKind.Local).AddTicks(7780), new DateTime(2022, 7, 16, 15, 12, 45, 739, DateTimeKind.Local).AddTicks(7780) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 16, 15, 12, 45, 739, DateTimeKind.Local).AddTicks(7780), new DateTime(2022, 7, 16, 15, 12, 45, 739, DateTimeKind.Local).AddTicks(7780) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 16, 15, 12, 45, 739, DateTimeKind.Local).AddTicks(7780), new DateTime(2022, 7, 16, 15, 12, 45, 739, DateTimeKind.Local).AddTicks(7780) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 16, 15, 12, 45, 739, DateTimeKind.Local).AddTicks(7780), new DateTime(2022, 7, 16, 15, 12, 45, 739, DateTimeKind.Local).AddTicks(7780) });

            migrationBuilder.UpdateData(
                table: "M_SagyoBasho",
                keyColumn: "SagyoBasho",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 16, 15, 12, 45, 739, DateTimeKind.Local).AddTicks(7780), new DateTime(2022, 7, 16, 15, 12, 45, 739, DateTimeKind.Local).AddTicks(7780) });

            migrationBuilder.UpdateData(
                table: "M_SagyoBasho",
                keyColumn: "SagyoBasho",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 16, 15, 12, 45, 739, DateTimeKind.Local).AddTicks(7780), new DateTime(2022, 7, 16, 15, 12, 45, 739, DateTimeKind.Local).AddTicks(7780) });

            migrationBuilder.UpdateData(
                table: "M_SagyoBasho",
                keyColumn: "SagyoBasho",
                keyValue: 3,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 16, 15, 12, 45, 739, DateTimeKind.Local).AddTicks(7780), new DateTime(2022, 7, 16, 15, 12, 45, 739, DateTimeKind.Local).AddTicks(7780) });

            migrationBuilder.UpdateData(
                table: "M_SagyoShubetsu",
                keyColumn: "SagyoShubetsu",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 16, 15, 12, 45, 739, DateTimeKind.Local).AddTicks(7780), new DateTime(2022, 7, 16, 15, 12, 45, 739, DateTimeKind.Local).AddTicks(7780) });

            migrationBuilder.UpdateData(
                table: "M_SagyoShubetsu",
                keyColumn: "SagyoShubetsu",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 16, 15, 12, 45, 739, DateTimeKind.Local).AddTicks(7780), new DateTime(2022, 7, 16, 15, 12, 45, 739, DateTimeKind.Local).AddTicks(7780) });

            migrationBuilder.UpdateData(
                table: "M_SagyoShubetsu",
                keyColumn: "SagyoShubetsu",
                keyValue: 3,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 16, 15, 12, 45, 739, DateTimeKind.Local).AddTicks(7780), new DateTime(2022, 7, 16, 15, 12, 45, 739, DateTimeKind.Local).AddTicks(7780) });

            migrationBuilder.UpdateData(
                table: "M_Shinchoku",
                keyColumn: "Shinchoku",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 16, 15, 12, 45, 739, DateTimeKind.Local).AddTicks(7780), new DateTime(2022, 7, 16, 15, 12, 45, 739, DateTimeKind.Local).AddTicks(7780) });

            migrationBuilder.UpdateData(
                table: "M_Shinchoku",
                keyColumn: "Shinchoku",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 16, 15, 12, 45, 739, DateTimeKind.Local).AddTicks(7780), new DateTime(2022, 7, 16, 15, 12, 45, 739, DateTimeKind.Local).AddTicks(7780) });

            migrationBuilder.UpdateData(
                table: "M_Shinchoku",
                keyColumn: "Shinchoku",
                keyValue: 3,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 16, 15, 12, 45, 739, DateTimeKind.Local).AddTicks(7780), new DateTime(2022, 7, 16, 15, 12, 45, 739, DateTimeKind.Local).AddTicks(7780) });

            migrationBuilder.UpdateData(
                table: "M_Shinchoku",
                keyColumn: "Shinchoku",
                keyValue: 4,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 16, 15, 12, 45, 739, DateTimeKind.Local).AddTicks(7780), new DateTime(2022, 7, 16, 15, 12, 45, 739, DateTimeKind.Local).AddTicks(7780) });

            migrationBuilder.UpdateData(
                table: "M_Shinchoku",
                keyColumn: "Shinchoku",
                keyValue: 5,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 16, 15, 12, 45, 739, DateTimeKind.Local).AddTicks(7780), new DateTime(2022, 7, 16, 15, 12, 45, 739, DateTimeKind.Local).AddTicks(7780) });

            migrationBuilder.UpdateData(
                table: "M_Shinchoku",
                keyColumn: "Shinchoku",
                keyValue: 6,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 16, 15, 12, 45, 739, DateTimeKind.Local).AddTicks(7780), new DateTime(2022, 7, 16, 15, 12, 45, 739, DateTimeKind.Local).AddTicks(7780) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_T_SagyoKeikaku",
                table: "T_SagyoKeikaku");

            migrationBuilder.AddPrimaryKey(
                name: "PK_T_SagyoKeikaku",
                table: "T_SagyoKeikaku",
                columns: new[] { "Id", "SagyoKaishiNichiji", "Keito", "Kankatsu", "SagyoShubetsu", "SagyoBasho" });

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
    }
}
