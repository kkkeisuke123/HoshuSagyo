using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HoshuSagyo.Migrations.HoshuSagyoDb
{
    public partial class 締切テーブルの初期データを修正 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 25, 14, 59, 43, 965, DateTimeKind.Local).AddTicks(9510), new DateTime(2022, 7, 25, 14, 59, 43, 965, DateTimeKind.Local).AddTicks(9510) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 25, 14, 59, 43, 965, DateTimeKind.Local).AddTicks(9511), new DateTime(2022, 7, 25, 14, 59, 43, 965, DateTimeKind.Local).AddTicks(9511) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 3,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 25, 14, 59, 43, 965, DateTimeKind.Local).AddTicks(9512), new DateTime(2022, 7, 25, 14, 59, 43, 965, DateTimeKind.Local).AddTicks(9512) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 4,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 25, 14, 59, 43, 965, DateTimeKind.Local).AddTicks(9512), new DateTime(2022, 7, 25, 14, 59, 43, 965, DateTimeKind.Local).AddTicks(9512) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 5,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 25, 14, 59, 43, 965, DateTimeKind.Local).AddTicks(9513), new DateTime(2022, 7, 25, 14, 59, 43, 965, DateTimeKind.Local).AddTicks(9513) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 6,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 25, 14, 59, 43, 965, DateTimeKind.Local).AddTicks(9514), new DateTime(2022, 7, 25, 14, 59, 43, 965, DateTimeKind.Local).AddTicks(9514) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 7,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 25, 14, 59, 43, 965, DateTimeKind.Local).AddTicks(9514), new DateTime(2022, 7, 25, 14, 59, 43, 965, DateTimeKind.Local).AddTicks(9514) });

            migrationBuilder.UpdateData(
                table: "M_Keito",
                keyColumn: "Keito",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 25, 14, 59, 43, 965, DateTimeKind.Local).AddTicks(9398), new DateTime(2022, 7, 25, 14, 59, 43, 965, DateTimeKind.Local).AddTicks(9398) });

            migrationBuilder.UpdateData(
                table: "M_Keito",
                keyColumn: "Keito",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 25, 14, 59, 43, 965, DateTimeKind.Local).AddTicks(9411), new DateTime(2022, 7, 25, 14, 59, 43, 965, DateTimeKind.Local).AddTicks(9411) });

            migrationBuilder.UpdateData(
                table: "M_Keito",
                keyColumn: "Keito",
                keyValue: 99,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 25, 14, 59, 43, 965, DateTimeKind.Local).AddTicks(9412), new DateTime(2022, 7, 25, 14, 59, 43, 965, DateTimeKind.Local).AddTicks(9412) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOto",
                keyColumn: "OtoShubetsu",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 25, 14, 59, 43, 965, DateTimeKind.Local).AddTicks(9593), new DateTime(2022, 7, 25, 14, 59, 43, 965, DateTimeKind.Local).AddTicks(9593) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOto",
                keyColumn: "OtoShubetsu",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 25, 14, 59, 43, 965, DateTimeKind.Local).AddTicks(9594), new DateTime(2022, 7, 25, 14, 59, 43, 965, DateTimeKind.Local).AddTicks(9594) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOto",
                keyColumn: "OtoShubetsu",
                keyValue: 3,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 25, 14, 59, 43, 965, DateTimeKind.Local).AddTicks(9595), new DateTime(2022, 7, 25, 14, 59, 43, 965, DateTimeKind.Local).AddTicks(9595) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOto",
                keyColumn: "OtoShubetsu",
                keyValue: 4,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 25, 14, 59, 43, 965, DateTimeKind.Local).AddTicks(9595), new DateTime(2022, 7, 25, 14, 59, 43, 965, DateTimeKind.Local).AddTicks(9595) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 25, 14, 59, 43, 965, DateTimeKind.Local).AddTicks(9604), new DateTime(2022, 7, 25, 14, 59, 43, 965, DateTimeKind.Local).AddTicks(9604) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 25, 14, 59, 43, 965, DateTimeKind.Local).AddTicks(9606), new DateTime(2022, 7, 25, 14, 59, 43, 965, DateTimeKind.Local).AddTicks(9606) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 25, 14, 59, 43, 965, DateTimeKind.Local).AddTicks(9606), new DateTime(2022, 7, 25, 14, 59, 43, 965, DateTimeKind.Local).AddTicks(9606) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 25, 14, 59, 43, 965, DateTimeKind.Local).AddTicks(9607), new DateTime(2022, 7, 25, 14, 59, 43, 965, DateTimeKind.Local).AddTicks(9607) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 25, 14, 59, 43, 965, DateTimeKind.Local).AddTicks(9608), new DateTime(2022, 7, 25, 14, 59, 43, 965, DateTimeKind.Local).AddTicks(9608) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 25, 14, 59, 43, 965, DateTimeKind.Local).AddTicks(9608), new DateTime(2022, 7, 25, 14, 59, 43, 965, DateTimeKind.Local).AddTicks(9608) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 25, 14, 59, 43, 965, DateTimeKind.Local).AddTicks(9609), new DateTime(2022, 7, 25, 14, 59, 43, 965, DateTimeKind.Local).AddTicks(9609) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 25, 14, 59, 43, 965, DateTimeKind.Local).AddTicks(9610), new DateTime(2022, 7, 25, 14, 59, 43, 965, DateTimeKind.Local).AddTicks(9610) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 25, 14, 59, 43, 965, DateTimeKind.Local).AddTicks(9610), new DateTime(2022, 7, 25, 14, 59, 43, 965, DateTimeKind.Local).AddTicks(9610) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 25, 14, 59, 43, 965, DateTimeKind.Local).AddTicks(9611), new DateTime(2022, 7, 25, 14, 59, 43, 965, DateTimeKind.Local).AddTicks(9611) });

            migrationBuilder.UpdateData(
                table: "M_SagyoBasho",
                keyColumn: "SagyoBasho",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 25, 14, 59, 43, 965, DateTimeKind.Local).AddTicks(9541), new DateTime(2022, 7, 25, 14, 59, 43, 965, DateTimeKind.Local).AddTicks(9541) });

            migrationBuilder.UpdateData(
                table: "M_SagyoBasho",
                keyColumn: "SagyoBasho",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 25, 14, 59, 43, 965, DateTimeKind.Local).AddTicks(9543), new DateTime(2022, 7, 25, 14, 59, 43, 965, DateTimeKind.Local).AddTicks(9543) });

            migrationBuilder.UpdateData(
                table: "M_SagyoBasho",
                keyColumn: "SagyoBasho",
                keyValue: 3,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 25, 14, 59, 43, 965, DateTimeKind.Local).AddTicks(9544), new DateTime(2022, 7, 25, 14, 59, 43, 965, DateTimeKind.Local).AddTicks(9544) });

            migrationBuilder.UpdateData(
                table: "M_SagyoShubetsu",
                keyColumn: "SagyoShubetsu",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 25, 14, 59, 43, 965, DateTimeKind.Local).AddTicks(9530), new DateTime(2022, 7, 25, 14, 59, 43, 965, DateTimeKind.Local).AddTicks(9530) });

            migrationBuilder.UpdateData(
                table: "M_SagyoShubetsu",
                keyColumn: "SagyoShubetsu",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 25, 14, 59, 43, 965, DateTimeKind.Local).AddTicks(9531), new DateTime(2022, 7, 25, 14, 59, 43, 965, DateTimeKind.Local).AddTicks(9531) });

            migrationBuilder.UpdateData(
                table: "M_SagyoShubetsu",
                keyColumn: "SagyoShubetsu",
                keyValue: 3,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 25, 14, 59, 43, 965, DateTimeKind.Local).AddTicks(9532), new DateTime(2022, 7, 25, 14, 59, 43, 965, DateTimeKind.Local).AddTicks(9532) });

            migrationBuilder.UpdateData(
                table: "M_Shinchoku",
                keyColumn: "Shinchoku",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 25, 14, 59, 43, 965, DateTimeKind.Local).AddTicks(9622), new DateTime(2022, 7, 25, 14, 59, 43, 965, DateTimeKind.Local).AddTicks(9622) });

            migrationBuilder.UpdateData(
                table: "M_Shinchoku",
                keyColumn: "Shinchoku",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 25, 14, 59, 43, 965, DateTimeKind.Local).AddTicks(9624), new DateTime(2022, 7, 25, 14, 59, 43, 965, DateTimeKind.Local).AddTicks(9624) });

            migrationBuilder.UpdateData(
                table: "M_Shinchoku",
                keyColumn: "Shinchoku",
                keyValue: 3,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 25, 14, 59, 43, 965, DateTimeKind.Local).AddTicks(9625), new DateTime(2022, 7, 25, 14, 59, 43, 965, DateTimeKind.Local).AddTicks(9625) });

            migrationBuilder.UpdateData(
                table: "M_Shinchoku",
                keyColumn: "Shinchoku",
                keyValue: 4,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 25, 14, 59, 43, 965, DateTimeKind.Local).AddTicks(9626), new DateTime(2022, 7, 25, 14, 59, 43, 965, DateTimeKind.Local).AddTicks(9626) });

            migrationBuilder.UpdateData(
                table: "M_Shinchoku",
                keyColumn: "Shinchoku",
                keyValue: 5,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 25, 14, 59, 43, 965, DateTimeKind.Local).AddTicks(9626), new DateTime(2022, 7, 25, 14, 59, 43, 965, DateTimeKind.Local).AddTicks(9626) });

            migrationBuilder.UpdateData(
                table: "M_Shinchoku",
                keyColumn: "Shinchoku",
                keyValue: 6,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 25, 14, 59, 43, 965, DateTimeKind.Local).AddTicks(9627), new DateTime(2022, 7, 25, 14, 59, 43, 965, DateTimeKind.Local).AddTicks(9627) });

            migrationBuilder.UpdateData(
                table: "T_Shimekiri",
                keyColumn: "Kankatsu",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "ShimekiriZumiBi", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 25, 14, 59, 43, 965, DateTimeKind.Local).AddTicks(9640), new DateTime(2022, 7, 25, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 7, 25, 14, 59, 43, 965, DateTimeKind.Local).AddTicks(9640) });

            migrationBuilder.UpdateData(
                table: "T_Shimekiri",
                keyColumn: "Kankatsu",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "ShimekiriZumiBi", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 25, 14, 59, 43, 965, DateTimeKind.Local).AddTicks(9642), new DateTime(2022, 7, 25, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 7, 25, 14, 59, 43, 965, DateTimeKind.Local).AddTicks(9642) });

            migrationBuilder.UpdateData(
                table: "T_Shimekiri",
                keyColumn: "Kankatsu",
                keyValue: 3,
                columns: new[] { "RegisterDateTime", "ShimekiriZumiBi", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 25, 14, 59, 43, 965, DateTimeKind.Local).AddTicks(9644), new DateTime(2022, 7, 25, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 7, 25, 14, 59, 43, 965, DateTimeKind.Local).AddTicks(9644) });

            migrationBuilder.UpdateData(
                table: "T_Shimekiri",
                keyColumn: "Kankatsu",
                keyValue: 4,
                columns: new[] { "RegisterDateTime", "ShimekiriZumiBi", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 25, 14, 59, 43, 965, DateTimeKind.Local).AddTicks(9645), new DateTime(2022, 7, 25, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 7, 25, 14, 59, 43, 965, DateTimeKind.Local).AddTicks(9645) });

            migrationBuilder.UpdateData(
                table: "T_Shimekiri",
                keyColumn: "Kankatsu",
                keyValue: 5,
                columns: new[] { "RegisterDateTime", "ShimekiriZumiBi", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 25, 14, 59, 43, 965, DateTimeKind.Local).AddTicks(9646), new DateTime(2022, 7, 25, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 7, 25, 14, 59, 43, 965, DateTimeKind.Local).AddTicks(9646) });

            migrationBuilder.UpdateData(
                table: "T_Shimekiri",
                keyColumn: "Kankatsu",
                keyValue: 6,
                columns: new[] { "RegisterDateTime", "ShimekiriZumiBi", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 25, 14, 59, 43, 965, DateTimeKind.Local).AddTicks(9647), new DateTime(2022, 7, 25, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 7, 25, 14, 59, 43, 965, DateTimeKind.Local).AddTicks(9647) });

            migrationBuilder.UpdateData(
                table: "T_Shimekiri",
                keyColumn: "Kankatsu",
                keyValue: 7,
                columns: new[] { "RegisterDateTime", "ShimekiriZumiBi", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 25, 14, 59, 43, 965, DateTimeKind.Local).AddTicks(9648), new DateTime(2022, 7, 25, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 7, 25, 14, 59, 43, 965, DateTimeKind.Local).AddTicks(9648) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "T_Shimekiri",
                keyColumn: "Kankatsu",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "ShimekiriZumiBi", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 25, 9, 59, 40, 544, DateTimeKind.Local).AddTicks(9158), new DateTime(2022, 7, 25, 9, 59, 40, 544, DateTimeKind.Local).AddTicks(9159), new DateTime(2022, 7, 25, 9, 59, 40, 544, DateTimeKind.Local).AddTicks(9158) });

            migrationBuilder.UpdateData(
                table: "T_Shimekiri",
                keyColumn: "Kankatsu",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "ShimekiriZumiBi", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 25, 9, 59, 40, 544, DateTimeKind.Local).AddTicks(9161), new DateTime(2022, 7, 25, 9, 59, 40, 544, DateTimeKind.Local).AddTicks(9162), new DateTime(2022, 7, 25, 9, 59, 40, 544, DateTimeKind.Local).AddTicks(9161) });

            migrationBuilder.UpdateData(
                table: "T_Shimekiri",
                keyColumn: "Kankatsu",
                keyValue: 3,
                columns: new[] { "RegisterDateTime", "ShimekiriZumiBi", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 25, 9, 59, 40, 544, DateTimeKind.Local).AddTicks(9162), new DateTime(2022, 7, 25, 9, 59, 40, 544, DateTimeKind.Local).AddTicks(9163), new DateTime(2022, 7, 25, 9, 59, 40, 544, DateTimeKind.Local).AddTicks(9162) });

            migrationBuilder.UpdateData(
                table: "T_Shimekiri",
                keyColumn: "Kankatsu",
                keyValue: 4,
                columns: new[] { "RegisterDateTime", "ShimekiriZumiBi", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 25, 9, 59, 40, 544, DateTimeKind.Local).AddTicks(9163), new DateTime(2022, 7, 25, 9, 59, 40, 544, DateTimeKind.Local).AddTicks(9164), new DateTime(2022, 7, 25, 9, 59, 40, 544, DateTimeKind.Local).AddTicks(9163) });

            migrationBuilder.UpdateData(
                table: "T_Shimekiri",
                keyColumn: "Kankatsu",
                keyValue: 5,
                columns: new[] { "RegisterDateTime", "ShimekiriZumiBi", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 25, 9, 59, 40, 544, DateTimeKind.Local).AddTicks(9164), new DateTime(2022, 7, 25, 9, 59, 40, 544, DateTimeKind.Local).AddTicks(9165), new DateTime(2022, 7, 25, 9, 59, 40, 544, DateTimeKind.Local).AddTicks(9164) });

            migrationBuilder.UpdateData(
                table: "T_Shimekiri",
                keyColumn: "Kankatsu",
                keyValue: 6,
                columns: new[] { "RegisterDateTime", "ShimekiriZumiBi", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 25, 9, 59, 40, 544, DateTimeKind.Local).AddTicks(9165), new DateTime(2022, 7, 25, 9, 59, 40, 544, DateTimeKind.Local).AddTicks(9166), new DateTime(2022, 7, 25, 9, 59, 40, 544, DateTimeKind.Local).AddTicks(9165) });

            migrationBuilder.UpdateData(
                table: "T_Shimekiri",
                keyColumn: "Kankatsu",
                keyValue: 7,
                columns: new[] { "RegisterDateTime", "ShimekiriZumiBi", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 25, 9, 59, 40, 544, DateTimeKind.Local).AddTicks(9166), new DateTime(2022, 7, 25, 9, 59, 40, 544, DateTimeKind.Local).AddTicks(9167), new DateTime(2022, 7, 25, 9, 59, 40, 544, DateTimeKind.Local).AddTicks(9166) });
        }
    }
}
