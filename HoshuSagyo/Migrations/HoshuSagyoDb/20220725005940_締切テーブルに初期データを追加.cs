using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HoshuSagyo.Migrations.HoshuSagyoDb
{
    public partial class 締切テーブルに初期データを追加 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 25, 9, 59, 40, 544, DateTimeKind.Local).AddTicks(9038), new DateTime(2022, 7, 25, 9, 59, 40, 544, DateTimeKind.Local).AddTicks(9038) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 25, 9, 59, 40, 544, DateTimeKind.Local).AddTicks(9040), new DateTime(2022, 7, 25, 9, 59, 40, 544, DateTimeKind.Local).AddTicks(9040) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 3,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 25, 9, 59, 40, 544, DateTimeKind.Local).AddTicks(9040), new DateTime(2022, 7, 25, 9, 59, 40, 544, DateTimeKind.Local).AddTicks(9040) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 4,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 25, 9, 59, 40, 544, DateTimeKind.Local).AddTicks(9041), new DateTime(2022, 7, 25, 9, 59, 40, 544, DateTimeKind.Local).AddTicks(9041) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 5,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 25, 9, 59, 40, 544, DateTimeKind.Local).AddTicks(9042), new DateTime(2022, 7, 25, 9, 59, 40, 544, DateTimeKind.Local).AddTicks(9042) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 6,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 25, 9, 59, 40, 544, DateTimeKind.Local).AddTicks(9042), new DateTime(2022, 7, 25, 9, 59, 40, 544, DateTimeKind.Local).AddTicks(9042) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 7,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 25, 9, 59, 40, 544, DateTimeKind.Local).AddTicks(9043), new DateTime(2022, 7, 25, 9, 59, 40, 544, DateTimeKind.Local).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "M_Keito",
                keyColumn: "Keito",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 25, 9, 59, 40, 544, DateTimeKind.Local).AddTicks(8954), new DateTime(2022, 7, 25, 9, 59, 40, 544, DateTimeKind.Local).AddTicks(8954) });

            migrationBuilder.UpdateData(
                table: "M_Keito",
                keyColumn: "Keito",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 25, 9, 59, 40, 544, DateTimeKind.Local).AddTicks(8967), new DateTime(2022, 7, 25, 9, 59, 40, 544, DateTimeKind.Local).AddTicks(8967) });

            migrationBuilder.UpdateData(
                table: "M_Keito",
                keyColumn: "Keito",
                keyValue: 99,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 25, 9, 59, 40, 544, DateTimeKind.Local).AddTicks(8968), new DateTime(2022, 7, 25, 9, 59, 40, 544, DateTimeKind.Local).AddTicks(8968) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOto",
                keyColumn: "OtoShubetsu",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 25, 9, 59, 40, 544, DateTimeKind.Local).AddTicks(9084), new DateTime(2022, 7, 25, 9, 59, 40, 544, DateTimeKind.Local).AddTicks(9084) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOto",
                keyColumn: "OtoShubetsu",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 25, 9, 59, 40, 544, DateTimeKind.Local).AddTicks(9085), new DateTime(2022, 7, 25, 9, 59, 40, 544, DateTimeKind.Local).AddTicks(9085) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOto",
                keyColumn: "OtoShubetsu",
                keyValue: 3,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 25, 9, 59, 40, 544, DateTimeKind.Local).AddTicks(9086), new DateTime(2022, 7, 25, 9, 59, 40, 544, DateTimeKind.Local).AddTicks(9086) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOto",
                keyColumn: "OtoShubetsu",
                keyValue: 4,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 25, 9, 59, 40, 544, DateTimeKind.Local).AddTicks(9087), new DateTime(2022, 7, 25, 9, 59, 40, 544, DateTimeKind.Local).AddTicks(9087) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 25, 9, 59, 40, 544, DateTimeKind.Local).AddTicks(9096), new DateTime(2022, 7, 25, 9, 59, 40, 544, DateTimeKind.Local).AddTicks(9096) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 25, 9, 59, 40, 544, DateTimeKind.Local).AddTicks(9097), new DateTime(2022, 7, 25, 9, 59, 40, 544, DateTimeKind.Local).AddTicks(9097) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 25, 9, 59, 40, 544, DateTimeKind.Local).AddTicks(9098), new DateTime(2022, 7, 25, 9, 59, 40, 544, DateTimeKind.Local).AddTicks(9098) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 25, 9, 59, 40, 544, DateTimeKind.Local).AddTicks(9099), new DateTime(2022, 7, 25, 9, 59, 40, 544, DateTimeKind.Local).AddTicks(9099) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 25, 9, 59, 40, 544, DateTimeKind.Local).AddTicks(9121), new DateTime(2022, 7, 25, 9, 59, 40, 544, DateTimeKind.Local).AddTicks(9121) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 25, 9, 59, 40, 544, DateTimeKind.Local).AddTicks(9122), new DateTime(2022, 7, 25, 9, 59, 40, 544, DateTimeKind.Local).AddTicks(9122) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 25, 9, 59, 40, 544, DateTimeKind.Local).AddTicks(9123), new DateTime(2022, 7, 25, 9, 59, 40, 544, DateTimeKind.Local).AddTicks(9123) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 25, 9, 59, 40, 544, DateTimeKind.Local).AddTicks(9124), new DateTime(2022, 7, 25, 9, 59, 40, 544, DateTimeKind.Local).AddTicks(9124) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 25, 9, 59, 40, 544, DateTimeKind.Local).AddTicks(9125), new DateTime(2022, 7, 25, 9, 59, 40, 544, DateTimeKind.Local).AddTicks(9125) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 25, 9, 59, 40, 544, DateTimeKind.Local).AddTicks(9125), new DateTime(2022, 7, 25, 9, 59, 40, 544, DateTimeKind.Local).AddTicks(9125) });

            migrationBuilder.UpdateData(
                table: "M_SagyoBasho",
                keyColumn: "SagyoBasho",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 25, 9, 59, 40, 544, DateTimeKind.Local).AddTicks(9072), new DateTime(2022, 7, 25, 9, 59, 40, 544, DateTimeKind.Local).AddTicks(9072) });

            migrationBuilder.UpdateData(
                table: "M_SagyoBasho",
                keyColumn: "SagyoBasho",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 25, 9, 59, 40, 544, DateTimeKind.Local).AddTicks(9073), new DateTime(2022, 7, 25, 9, 59, 40, 544, DateTimeKind.Local).AddTicks(9073) });

            migrationBuilder.UpdateData(
                table: "M_SagyoBasho",
                keyColumn: "SagyoBasho",
                keyValue: 3,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 25, 9, 59, 40, 544, DateTimeKind.Local).AddTicks(9073), new DateTime(2022, 7, 25, 9, 59, 40, 544, DateTimeKind.Local).AddTicks(9073) });

            migrationBuilder.UpdateData(
                table: "M_SagyoShubetsu",
                keyColumn: "SagyoShubetsu",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 25, 9, 59, 40, 544, DateTimeKind.Local).AddTicks(9059), new DateTime(2022, 7, 25, 9, 59, 40, 544, DateTimeKind.Local).AddTicks(9059) });

            migrationBuilder.UpdateData(
                table: "M_SagyoShubetsu",
                keyColumn: "SagyoShubetsu",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 25, 9, 59, 40, 544, DateTimeKind.Local).AddTicks(9060), new DateTime(2022, 7, 25, 9, 59, 40, 544, DateTimeKind.Local).AddTicks(9060) });

            migrationBuilder.UpdateData(
                table: "M_SagyoShubetsu",
                keyColumn: "SagyoShubetsu",
                keyValue: 3,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 25, 9, 59, 40, 544, DateTimeKind.Local).AddTicks(9060), new DateTime(2022, 7, 25, 9, 59, 40, 544, DateTimeKind.Local).AddTicks(9060) });

            migrationBuilder.UpdateData(
                table: "M_Shinchoku",
                keyColumn: "Shinchoku",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 25, 9, 59, 40, 544, DateTimeKind.Local).AddTicks(9138), new DateTime(2022, 7, 25, 9, 59, 40, 544, DateTimeKind.Local).AddTicks(9138) });

            migrationBuilder.UpdateData(
                table: "M_Shinchoku",
                keyColumn: "Shinchoku",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 25, 9, 59, 40, 544, DateTimeKind.Local).AddTicks(9139), new DateTime(2022, 7, 25, 9, 59, 40, 544, DateTimeKind.Local).AddTicks(9139) });

            migrationBuilder.UpdateData(
                table: "M_Shinchoku",
                keyColumn: "Shinchoku",
                keyValue: 3,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 25, 9, 59, 40, 544, DateTimeKind.Local).AddTicks(9140), new DateTime(2022, 7, 25, 9, 59, 40, 544, DateTimeKind.Local).AddTicks(9140) });

            migrationBuilder.UpdateData(
                table: "M_Shinchoku",
                keyColumn: "Shinchoku",
                keyValue: 4,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 25, 9, 59, 40, 544, DateTimeKind.Local).AddTicks(9142), new DateTime(2022, 7, 25, 9, 59, 40, 544, DateTimeKind.Local).AddTicks(9142) });

            migrationBuilder.UpdateData(
                table: "M_Shinchoku",
                keyColumn: "Shinchoku",
                keyValue: 5,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 25, 9, 59, 40, 544, DateTimeKind.Local).AddTicks(9142), new DateTime(2022, 7, 25, 9, 59, 40, 544, DateTimeKind.Local).AddTicks(9142) });

            migrationBuilder.UpdateData(
                table: "M_Shinchoku",
                keyColumn: "Shinchoku",
                keyValue: 6,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 25, 9, 59, 40, 544, DateTimeKind.Local).AddTicks(9143), new DateTime(2022, 7, 25, 9, 59, 40, 544, DateTimeKind.Local).AddTicks(9143) });

            migrationBuilder.InsertData(
                table: "T_Shimekiri",
                columns: new[] { "Kankatsu", "RegisterDateTime", "ShimekiriZumiBi", "UpdateDateTime" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 7, 25, 9, 59, 40, 544, DateTimeKind.Local).AddTicks(9158), new DateTime(2022, 7, 25, 9, 59, 40, 544, DateTimeKind.Local).AddTicks(9159), new DateTime(2022, 7, 25, 9, 59, 40, 544, DateTimeKind.Local).AddTicks(9158) },
                    { 2, new DateTime(2022, 7, 25, 9, 59, 40, 544, DateTimeKind.Local).AddTicks(9161), new DateTime(2022, 7, 25, 9, 59, 40, 544, DateTimeKind.Local).AddTicks(9162), new DateTime(2022, 7, 25, 9, 59, 40, 544, DateTimeKind.Local).AddTicks(9161) },
                    { 3, new DateTime(2022, 7, 25, 9, 59, 40, 544, DateTimeKind.Local).AddTicks(9162), new DateTime(2022, 7, 25, 9, 59, 40, 544, DateTimeKind.Local).AddTicks(9163), new DateTime(2022, 7, 25, 9, 59, 40, 544, DateTimeKind.Local).AddTicks(9162) },
                    { 4, new DateTime(2022, 7, 25, 9, 59, 40, 544, DateTimeKind.Local).AddTicks(9163), new DateTime(2022, 7, 25, 9, 59, 40, 544, DateTimeKind.Local).AddTicks(9164), new DateTime(2022, 7, 25, 9, 59, 40, 544, DateTimeKind.Local).AddTicks(9163) },
                    { 5, new DateTime(2022, 7, 25, 9, 59, 40, 544, DateTimeKind.Local).AddTicks(9164), new DateTime(2022, 7, 25, 9, 59, 40, 544, DateTimeKind.Local).AddTicks(9165), new DateTime(2022, 7, 25, 9, 59, 40, 544, DateTimeKind.Local).AddTicks(9164) },
                    { 6, new DateTime(2022, 7, 25, 9, 59, 40, 544, DateTimeKind.Local).AddTicks(9165), new DateTime(2022, 7, 25, 9, 59, 40, 544, DateTimeKind.Local).AddTicks(9166), new DateTime(2022, 7, 25, 9, 59, 40, 544, DateTimeKind.Local).AddTicks(9165) }
                });

            migrationBuilder.InsertData(
                table: "T_Shimekiri",
                columns: new[] { "Kankatsu", "RegisterDateTime", "ShimekiriZumiBi", "UpdateDateTime" },
                values: new object[] { 7, new DateTime(2022, 7, 25, 9, 59, 40, 544, DateTimeKind.Local).AddTicks(9166), new DateTime(2022, 7, 25, 9, 59, 40, 544, DateTimeKind.Local).AddTicks(9167), new DateTime(2022, 7, 25, 9, 59, 40, 544, DateTimeKind.Local).AddTicks(9166) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "T_Shimekiri",
                keyColumn: "Kankatsu",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "T_Shimekiri",
                keyColumn: "Kankatsu",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "T_Shimekiri",
                keyColumn: "Kankatsu",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "T_Shimekiri",
                keyColumn: "Kankatsu",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "T_Shimekiri",
                keyColumn: "Kankatsu",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "T_Shimekiri",
                keyColumn: "Kankatsu",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "T_Shimekiri",
                keyColumn: "Kankatsu",
                keyValue: 7);

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 25, 9, 50, 33, 815, DateTimeKind.Local).AddTicks(8903), new DateTime(2022, 7, 25, 9, 50, 33, 815, DateTimeKind.Local).AddTicks(8903) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 25, 9, 50, 33, 815, DateTimeKind.Local).AddTicks(8905), new DateTime(2022, 7, 25, 9, 50, 33, 815, DateTimeKind.Local).AddTicks(8905) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 3,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 25, 9, 50, 33, 815, DateTimeKind.Local).AddTicks(8906), new DateTime(2022, 7, 25, 9, 50, 33, 815, DateTimeKind.Local).AddTicks(8906) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 4,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 25, 9, 50, 33, 815, DateTimeKind.Local).AddTicks(8906), new DateTime(2022, 7, 25, 9, 50, 33, 815, DateTimeKind.Local).AddTicks(8906) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 5,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 25, 9, 50, 33, 815, DateTimeKind.Local).AddTicks(8907), new DateTime(2022, 7, 25, 9, 50, 33, 815, DateTimeKind.Local).AddTicks(8907) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 6,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 25, 9, 50, 33, 815, DateTimeKind.Local).AddTicks(8907), new DateTime(2022, 7, 25, 9, 50, 33, 815, DateTimeKind.Local).AddTicks(8907) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 7,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 25, 9, 50, 33, 815, DateTimeKind.Local).AddTicks(8908), new DateTime(2022, 7, 25, 9, 50, 33, 815, DateTimeKind.Local).AddTicks(8908) });

            migrationBuilder.UpdateData(
                table: "M_Keito",
                keyColumn: "Keito",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 25, 9, 50, 33, 815, DateTimeKind.Local).AddTicks(8828), new DateTime(2022, 7, 25, 9, 50, 33, 815, DateTimeKind.Local).AddTicks(8828) });

            migrationBuilder.UpdateData(
                table: "M_Keito",
                keyColumn: "Keito",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 25, 9, 50, 33, 815, DateTimeKind.Local).AddTicks(8832), new DateTime(2022, 7, 25, 9, 50, 33, 815, DateTimeKind.Local).AddTicks(8832) });

            migrationBuilder.UpdateData(
                table: "M_Keito",
                keyColumn: "Keito",
                keyValue: 99,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 25, 9, 50, 33, 815, DateTimeKind.Local).AddTicks(8833), new DateTime(2022, 7, 25, 9, 50, 33, 815, DateTimeKind.Local).AddTicks(8833) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOto",
                keyColumn: "OtoShubetsu",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 25, 9, 50, 33, 815, DateTimeKind.Local).AddTicks(8949), new DateTime(2022, 7, 25, 9, 50, 33, 815, DateTimeKind.Local).AddTicks(8949) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOto",
                keyColumn: "OtoShubetsu",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 25, 9, 50, 33, 815, DateTimeKind.Local).AddTicks(8951), new DateTime(2022, 7, 25, 9, 50, 33, 815, DateTimeKind.Local).AddTicks(8951) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOto",
                keyColumn: "OtoShubetsu",
                keyValue: 3,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 25, 9, 50, 33, 815, DateTimeKind.Local).AddTicks(8951), new DateTime(2022, 7, 25, 9, 50, 33, 815, DateTimeKind.Local).AddTicks(8951) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOto",
                keyColumn: "OtoShubetsu",
                keyValue: 4,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 25, 9, 50, 33, 815, DateTimeKind.Local).AddTicks(8952), new DateTime(2022, 7, 25, 9, 50, 33, 815, DateTimeKind.Local).AddTicks(8952) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 25, 9, 50, 33, 815, DateTimeKind.Local).AddTicks(8960), new DateTime(2022, 7, 25, 9, 50, 33, 815, DateTimeKind.Local).AddTicks(8960) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 25, 9, 50, 33, 815, DateTimeKind.Local).AddTicks(8961), new DateTime(2022, 7, 25, 9, 50, 33, 815, DateTimeKind.Local).AddTicks(8961) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 25, 9, 50, 33, 815, DateTimeKind.Local).AddTicks(8962), new DateTime(2022, 7, 25, 9, 50, 33, 815, DateTimeKind.Local).AddTicks(8962) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 25, 9, 50, 33, 815, DateTimeKind.Local).AddTicks(8962), new DateTime(2022, 7, 25, 9, 50, 33, 815, DateTimeKind.Local).AddTicks(8962) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 25, 9, 50, 33, 815, DateTimeKind.Local).AddTicks(8963), new DateTime(2022, 7, 25, 9, 50, 33, 815, DateTimeKind.Local).AddTicks(8963) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 25, 9, 50, 33, 815, DateTimeKind.Local).AddTicks(8964), new DateTime(2022, 7, 25, 9, 50, 33, 815, DateTimeKind.Local).AddTicks(8964) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 25, 9, 50, 33, 815, DateTimeKind.Local).AddTicks(8964), new DateTime(2022, 7, 25, 9, 50, 33, 815, DateTimeKind.Local).AddTicks(8964) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 25, 9, 50, 33, 815, DateTimeKind.Local).AddTicks(8965), new DateTime(2022, 7, 25, 9, 50, 33, 815, DateTimeKind.Local).AddTicks(8965) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 25, 9, 50, 33, 815, DateTimeKind.Local).AddTicks(8966), new DateTime(2022, 7, 25, 9, 50, 33, 815, DateTimeKind.Local).AddTicks(8966) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 25, 9, 50, 33, 815, DateTimeKind.Local).AddTicks(8967), new DateTime(2022, 7, 25, 9, 50, 33, 815, DateTimeKind.Local).AddTicks(8967) });

            migrationBuilder.UpdateData(
                table: "M_SagyoBasho",
                keyColumn: "SagyoBasho",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 25, 9, 50, 33, 815, DateTimeKind.Local).AddTicks(8938), new DateTime(2022, 7, 25, 9, 50, 33, 815, DateTimeKind.Local).AddTicks(8938) });

            migrationBuilder.UpdateData(
                table: "M_SagyoBasho",
                keyColumn: "SagyoBasho",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 25, 9, 50, 33, 815, DateTimeKind.Local).AddTicks(8939), new DateTime(2022, 7, 25, 9, 50, 33, 815, DateTimeKind.Local).AddTicks(8939) });

            migrationBuilder.UpdateData(
                table: "M_SagyoBasho",
                keyColumn: "SagyoBasho",
                keyValue: 3,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 25, 9, 50, 33, 815, DateTimeKind.Local).AddTicks(8940), new DateTime(2022, 7, 25, 9, 50, 33, 815, DateTimeKind.Local).AddTicks(8940) });

            migrationBuilder.UpdateData(
                table: "M_SagyoShubetsu",
                keyColumn: "SagyoShubetsu",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 25, 9, 50, 33, 815, DateTimeKind.Local).AddTicks(8923), new DateTime(2022, 7, 25, 9, 50, 33, 815, DateTimeKind.Local).AddTicks(8923) });

            migrationBuilder.UpdateData(
                table: "M_SagyoShubetsu",
                keyColumn: "SagyoShubetsu",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 25, 9, 50, 33, 815, DateTimeKind.Local).AddTicks(8925), new DateTime(2022, 7, 25, 9, 50, 33, 815, DateTimeKind.Local).AddTicks(8925) });

            migrationBuilder.UpdateData(
                table: "M_SagyoShubetsu",
                keyColumn: "SagyoShubetsu",
                keyValue: 3,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 25, 9, 50, 33, 815, DateTimeKind.Local).AddTicks(8926), new DateTime(2022, 7, 25, 9, 50, 33, 815, DateTimeKind.Local).AddTicks(8926) });

            migrationBuilder.UpdateData(
                table: "M_Shinchoku",
                keyColumn: "Shinchoku",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 25, 9, 50, 33, 815, DateTimeKind.Local).AddTicks(9007), new DateTime(2022, 7, 25, 9, 50, 33, 815, DateTimeKind.Local).AddTicks(9007) });

            migrationBuilder.UpdateData(
                table: "M_Shinchoku",
                keyColumn: "Shinchoku",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 25, 9, 50, 33, 815, DateTimeKind.Local).AddTicks(9009), new DateTime(2022, 7, 25, 9, 50, 33, 815, DateTimeKind.Local).AddTicks(9009) });

            migrationBuilder.UpdateData(
                table: "M_Shinchoku",
                keyColumn: "Shinchoku",
                keyValue: 3,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 25, 9, 50, 33, 815, DateTimeKind.Local).AddTicks(9010), new DateTime(2022, 7, 25, 9, 50, 33, 815, DateTimeKind.Local).AddTicks(9010) });

            migrationBuilder.UpdateData(
                table: "M_Shinchoku",
                keyColumn: "Shinchoku",
                keyValue: 4,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 25, 9, 50, 33, 815, DateTimeKind.Local).AddTicks(9010), new DateTime(2022, 7, 25, 9, 50, 33, 815, DateTimeKind.Local).AddTicks(9010) });

            migrationBuilder.UpdateData(
                table: "M_Shinchoku",
                keyColumn: "Shinchoku",
                keyValue: 5,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 25, 9, 50, 33, 815, DateTimeKind.Local).AddTicks(9011), new DateTime(2022, 7, 25, 9, 50, 33, 815, DateTimeKind.Local).AddTicks(9011) });

            migrationBuilder.UpdateData(
                table: "M_Shinchoku",
                keyColumn: "Shinchoku",
                keyValue: 6,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 25, 9, 50, 33, 815, DateTimeKind.Local).AddTicks(9012), new DateTime(2022, 7, 25, 9, 50, 33, 815, DateTimeKind.Local).AddTicks(9012) });
        }
    }
}
