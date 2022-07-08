using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HoshuSagyo.Migrations.HoshuSagyoDb
{
    public partial class 音声応答音声応答詳細テーブルの初期データを修正 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "M_OnseiOto",
                keyColumn: "OtoShubetsu",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 12);

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
                columns: new[] { "OtoShubetsuNaiyo", "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { "共通", new DateTime(2022, 7, 8, 22, 44, 0, 376, DateTimeKind.Local).AddTicks(4373), new DateTime(2022, 7, 8, 22, 44, 0, 376, DateTimeKind.Local).AddTicks(4373) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOto",
                keyColumn: "OtoShubetsu",
                keyValue: 2,
                columns: new[] { "OtoShubetsuNaiyo", "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { "施設", new DateTime(2022, 7, 8, 22, 44, 0, 376, DateTimeKind.Local).AddTicks(4373), new DateTime(2022, 7, 8, 22, 44, 0, 376, DateTimeKind.Local).AddTicks(4373) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOto",
                keyColumn: "OtoShubetsu",
                keyValue: 3,
                columns: new[] { "OtoShubetsuNaiyo", "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { "電力", new DateTime(2022, 7, 8, 22, 44, 0, 376, DateTimeKind.Local).AddTicks(4373), new DateTime(2022, 7, 8, 22, 44, 0, 376, DateTimeKind.Local).AddTicks(4373) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOto",
                keyColumn: "OtoShubetsu",
                keyValue: 4,
                columns: new[] { "OtoShubetsuNaiyo", "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { "通信", new DateTime(2022, 7, 8, 22, 44, 0, 376, DateTimeKind.Local).AddTicks(4373), new DateTime(2022, 7, 8, 22, 44, 0, 376, DateTimeKind.Local).AddTicks(4373) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Message", "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { "関係者以外の人はいませんか", new DateTime(2022, 7, 8, 22, 44, 0, 376, DateTimeKind.Local).AddTicks(4373), new DateTime(2022, 7, 8, 22, 44, 0, 376, DateTimeKind.Local).AddTicks(4373) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Message", "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { "作業場所は間違っていませんか", new DateTime(2022, 7, 8, 22, 44, 0, 376, DateTimeKind.Local).AddTicks(4373), new DateTime(2022, 7, 8, 22, 44, 0, 376, DateTimeKind.Local).AddTicks(4373) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Message", "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { "作業員は全員揃いましたか", new DateTime(2022, 7, 8, 22, 44, 0, 376, DateTimeKind.Local).AddTicks(4373), new DateTime(2022, 7, 8, 22, 44, 0, 376, DateTimeKind.Local).AddTicks(4373) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "OtoShubetsu", "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { 1, new DateTime(2022, 7, 8, 22, 44, 0, 376, DateTimeKind.Local).AddTicks(4373), new DateTime(2022, 7, 8, 22, 44, 0, 376, DateTimeKind.Local).AddTicks(4373) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Message", "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { "施設の責任者から作業許可は出ていますか", new DateTime(2022, 7, 8, 22, 44, 0, 376, DateTimeKind.Local).AddTicks(4373), new DateTime(2022, 7, 8, 22, 44, 0, 376, DateTimeKind.Local).AddTicks(4373) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Message", "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { "各エリアの施錠は行いましたか", new DateTime(2022, 7, 8, 22, 44, 0, 376, DateTimeKind.Local).AddTicks(4373), new DateTime(2022, 7, 8, 22, 44, 0, 376, DateTimeKind.Local).AddTicks(4373) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Message", "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { "電気の供給が停止していますか", new DateTime(2022, 7, 8, 22, 44, 0, 376, DateTimeKind.Local).AddTicks(4373), new DateTime(2022, 7, 8, 22, 44, 0, 376, DateTimeKind.Local).AddTicks(4373) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Message", "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { "電気の供給を再開しましたか", new DateTime(2022, 7, 8, 22, 44, 0, 376, DateTimeKind.Local).AddTicks(4373), new DateTime(2022, 7, 8, 22, 44, 0, 376, DateTimeKind.Local).AddTicks(4373) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Message", "OtoShubetsu", "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { "通信状態をメンテナンス状態にしましたか", 4, new DateTime(2022, 7, 8, 22, 44, 0, 376, DateTimeKind.Local).AddTicks(4373), new DateTime(2022, 7, 8, 22, 44, 0, 376, DateTimeKind.Local).AddTicks(4373) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Message", "OtoShubetsu", "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { "通信状態を通常状態に戻しましたか", 4, new DateTime(2022, 7, 8, 22, 44, 0, 376, DateTimeKind.Local).AddTicks(4373), new DateTime(2022, 7, 8, 22, 44, 0, 376, DateTimeKind.Local).AddTicks(4373) });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 7, 14, 36, 59, 497, DateTimeKind.Local).AddTicks(8869), new DateTime(2022, 7, 7, 14, 36, 59, 497, DateTimeKind.Local).AddTicks(8869) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 7, 14, 36, 59, 497, DateTimeKind.Local).AddTicks(8869), new DateTime(2022, 7, 7, 14, 36, 59, 497, DateTimeKind.Local).AddTicks(8869) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 3,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 7, 14, 36, 59, 497, DateTimeKind.Local).AddTicks(8869), new DateTime(2022, 7, 7, 14, 36, 59, 497, DateTimeKind.Local).AddTicks(8869) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 4,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 7, 14, 36, 59, 497, DateTimeKind.Local).AddTicks(8869), new DateTime(2022, 7, 7, 14, 36, 59, 497, DateTimeKind.Local).AddTicks(8869) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 5,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 7, 14, 36, 59, 497, DateTimeKind.Local).AddTicks(8869), new DateTime(2022, 7, 7, 14, 36, 59, 497, DateTimeKind.Local).AddTicks(8869) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 6,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 7, 14, 36, 59, 497, DateTimeKind.Local).AddTicks(8869), new DateTime(2022, 7, 7, 14, 36, 59, 497, DateTimeKind.Local).AddTicks(8869) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 7,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 7, 14, 36, 59, 497, DateTimeKind.Local).AddTicks(8869), new DateTime(2022, 7, 7, 14, 36, 59, 497, DateTimeKind.Local).AddTicks(8869) });

            migrationBuilder.UpdateData(
                table: "M_Keito",
                keyColumn: "Keito",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 7, 14, 36, 59, 497, DateTimeKind.Local).AddTicks(8869), new DateTime(2022, 7, 7, 14, 36, 59, 497, DateTimeKind.Local).AddTicks(8869) });

            migrationBuilder.UpdateData(
                table: "M_Keito",
                keyColumn: "Keito",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 7, 14, 36, 59, 497, DateTimeKind.Local).AddTicks(8869), new DateTime(2022, 7, 7, 14, 36, 59, 497, DateTimeKind.Local).AddTicks(8869) });

            migrationBuilder.UpdateData(
                table: "M_Keito",
                keyColumn: "Keito",
                keyValue: 99,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 7, 14, 36, 59, 497, DateTimeKind.Local).AddTicks(8869), new DateTime(2022, 7, 7, 14, 36, 59, 497, DateTimeKind.Local).AddTicks(8869) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOto",
                keyColumn: "OtoShubetsu",
                keyValue: 1,
                columns: new[] { "OtoShubetsuNaiyo", "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { "作業開始", new DateTime(2022, 7, 7, 14, 36, 59, 497, DateTimeKind.Local).AddTicks(8869), new DateTime(2022, 7, 7, 14, 36, 59, 497, DateTimeKind.Local).AddTicks(8869) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOto",
                keyColumn: "OtoShubetsu",
                keyValue: 2,
                columns: new[] { "OtoShubetsuNaiyo", "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { "作業終了", new DateTime(2022, 7, 7, 14, 36, 59, 497, DateTimeKind.Local).AddTicks(8869), new DateTime(2022, 7, 7, 14, 36, 59, 497, DateTimeKind.Local).AddTicks(8869) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOto",
                keyColumn: "OtoShubetsu",
                keyValue: 3,
                columns: new[] { "OtoShubetsuNaiyo", "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { "施設", new DateTime(2022, 7, 7, 14, 36, 59, 497, DateTimeKind.Local).AddTicks(8869), new DateTime(2022, 7, 7, 14, 36, 59, 497, DateTimeKind.Local).AddTicks(8869) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOto",
                keyColumn: "OtoShubetsu",
                keyValue: 4,
                columns: new[] { "OtoShubetsuNaiyo", "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { "電力", new DateTime(2022, 7, 7, 14, 36, 59, 497, DateTimeKind.Local).AddTicks(8869), new DateTime(2022, 7, 7, 14, 36, 59, 497, DateTimeKind.Local).AddTicks(8869) });

            migrationBuilder.InsertData(
                table: "M_OnseiOto",
                columns: new[] { "OtoShubetsu", "OtoShubetsuNaiyo", "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { 5, "通信", new DateTime(2022, 7, 7, 14, 36, 59, 497, DateTimeKind.Local).AddTicks(8869), new DateTime(2022, 7, 7, 14, 36, 59, 497, DateTimeKind.Local).AddTicks(8869) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Message", "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { "周りの安全を確保しましたか", new DateTime(2022, 7, 7, 14, 36, 59, 497, DateTimeKind.Local).AddTicks(8869), new DateTime(2022, 7, 7, 14, 36, 59, 497, DateTimeKind.Local).AddTicks(8869) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Message", "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { "作業員は全員揃いましたか", new DateTime(2022, 7, 7, 14, 36, 59, 497, DateTimeKind.Local).AddTicks(8869), new DateTime(2022, 7, 7, 14, 36, 59, 497, DateTimeKind.Local).AddTicks(8869) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Message", "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { "作業場所は間違っていませんか", new DateTime(2022, 7, 7, 14, 36, 59, 497, DateTimeKind.Local).AddTicks(8869), new DateTime(2022, 7, 7, 14, 36, 59, 497, DateTimeKind.Local).AddTicks(8869) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "OtoShubetsu", "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { 2, new DateTime(2022, 7, 7, 14, 36, 59, 497, DateTimeKind.Local).AddTicks(8869), new DateTime(2022, 7, 7, 14, 36, 59, 497, DateTimeKind.Local).AddTicks(8869) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Message", "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { "機材のメンテナンスは行いましたか", new DateTime(2022, 7, 7, 14, 36, 59, 497, DateTimeKind.Local).AddTicks(8869), new DateTime(2022, 7, 7, 14, 36, 59, 497, DateTimeKind.Local).AddTicks(8869) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Message", "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { "作業の最終確認は済みましたか", new DateTime(2022, 7, 7, 14, 36, 59, 497, DateTimeKind.Local).AddTicks(8869), new DateTime(2022, 7, 7, 14, 36, 59, 497, DateTimeKind.Local).AddTicks(8869) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Message", "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { "施設の責任者から作業許可は出ていますか", new DateTime(2022, 7, 7, 14, 36, 59, 497, DateTimeKind.Local).AddTicks(8869), new DateTime(2022, 7, 7, 14, 36, 59, 497, DateTimeKind.Local).AddTicks(8869) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Message", "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { "各エリアの施錠は行いましたか", new DateTime(2022, 7, 7, 14, 36, 59, 497, DateTimeKind.Local).AddTicks(8869), new DateTime(2022, 7, 7, 14, 36, 59, 497, DateTimeKind.Local).AddTicks(8869) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Message", "OtoShubetsu", "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { "電気の供給が停止していますか", 3, new DateTime(2022, 7, 7, 14, 36, 59, 497, DateTimeKind.Local).AddTicks(8869), new DateTime(2022, 7, 7, 14, 36, 59, 497, DateTimeKind.Local).AddTicks(8869) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Message", "OtoShubetsu", "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { "電気の供給を再開しましたか", 3, new DateTime(2022, 7, 7, 14, 36, 59, 497, DateTimeKind.Local).AddTicks(8869), new DateTime(2022, 7, 7, 14, 36, 59, 497, DateTimeKind.Local).AddTicks(8869) });

            migrationBuilder.InsertData(
                table: "M_OnseiOtoShosai",
                columns: new[] { "Id", "Message", "OtoShubetsu", "RegisterDateTime", "UpdateDateTime" },
                values: new object[,]
                {
                    { 11, "通信状態をメンテナンス状態にしましたか", 3, new DateTime(2022, 7, 7, 14, 36, 59, 497, DateTimeKind.Local).AddTicks(8869), new DateTime(2022, 7, 7, 14, 36, 59, 497, DateTimeKind.Local).AddTicks(8869) },
                    { 12, "通信状態を通常状態に戻しましたか", 3, new DateTime(2022, 7, 7, 14, 36, 59, 497, DateTimeKind.Local).AddTicks(8869), new DateTime(2022, 7, 7, 14, 36, 59, 497, DateTimeKind.Local).AddTicks(8869) }
                });

            migrationBuilder.UpdateData(
                table: "M_SagyoBasho",
                keyColumn: "SagyoBasho",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 7, 14, 36, 59, 497, DateTimeKind.Local).AddTicks(8869), new DateTime(2022, 7, 7, 14, 36, 59, 497, DateTimeKind.Local).AddTicks(8869) });

            migrationBuilder.UpdateData(
                table: "M_SagyoBasho",
                keyColumn: "SagyoBasho",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 7, 14, 36, 59, 497, DateTimeKind.Local).AddTicks(8869), new DateTime(2022, 7, 7, 14, 36, 59, 497, DateTimeKind.Local).AddTicks(8869) });

            migrationBuilder.UpdateData(
                table: "M_SagyoBasho",
                keyColumn: "SagyoBasho",
                keyValue: 3,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 7, 14, 36, 59, 497, DateTimeKind.Local).AddTicks(8869), new DateTime(2022, 7, 7, 14, 36, 59, 497, DateTimeKind.Local).AddTicks(8869) });

            migrationBuilder.UpdateData(
                table: "M_SagyoShubetsu",
                keyColumn: "SagyoShubetsu",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 7, 14, 36, 59, 497, DateTimeKind.Local).AddTicks(8869), new DateTime(2022, 7, 7, 14, 36, 59, 497, DateTimeKind.Local).AddTicks(8869) });

            migrationBuilder.UpdateData(
                table: "M_SagyoShubetsu",
                keyColumn: "SagyoShubetsu",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 7, 14, 36, 59, 497, DateTimeKind.Local).AddTicks(8869), new DateTime(2022, 7, 7, 14, 36, 59, 497, DateTimeKind.Local).AddTicks(8869) });

            migrationBuilder.UpdateData(
                table: "M_SagyoShubetsu",
                keyColumn: "SagyoShubetsu",
                keyValue: 3,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 7, 14, 36, 59, 497, DateTimeKind.Local).AddTicks(8869), new DateTime(2022, 7, 7, 14, 36, 59, 497, DateTimeKind.Local).AddTicks(8869) });

            migrationBuilder.UpdateData(
                table: "M_Shinchoku",
                keyColumn: "Shinchoku",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 7, 14, 36, 59, 497, DateTimeKind.Local).AddTicks(8869), new DateTime(2022, 7, 7, 14, 36, 59, 497, DateTimeKind.Local).AddTicks(8869) });

            migrationBuilder.UpdateData(
                table: "M_Shinchoku",
                keyColumn: "Shinchoku",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 7, 14, 36, 59, 497, DateTimeKind.Local).AddTicks(8869), new DateTime(2022, 7, 7, 14, 36, 59, 497, DateTimeKind.Local).AddTicks(8869) });

            migrationBuilder.UpdateData(
                table: "M_Shinchoku",
                keyColumn: "Shinchoku",
                keyValue: 3,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 7, 14, 36, 59, 497, DateTimeKind.Local).AddTicks(8869), new DateTime(2022, 7, 7, 14, 36, 59, 497, DateTimeKind.Local).AddTicks(8869) });

            migrationBuilder.UpdateData(
                table: "M_Shinchoku",
                keyColumn: "Shinchoku",
                keyValue: 4,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 7, 14, 36, 59, 497, DateTimeKind.Local).AddTicks(8869), new DateTime(2022, 7, 7, 14, 36, 59, 497, DateTimeKind.Local).AddTicks(8869) });

            migrationBuilder.UpdateData(
                table: "M_Shinchoku",
                keyColumn: "Shinchoku",
                keyValue: 5,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 7, 14, 36, 59, 497, DateTimeKind.Local).AddTicks(8869), new DateTime(2022, 7, 7, 14, 36, 59, 497, DateTimeKind.Local).AddTicks(8869) });

            migrationBuilder.UpdateData(
                table: "M_Shinchoku",
                keyColumn: "Shinchoku",
                keyValue: 6,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 7, 14, 36, 59, 497, DateTimeKind.Local).AddTicks(8869), new DateTime(2022, 7, 7, 14, 36, 59, 497, DateTimeKind.Local).AddTicks(8869) });
        }
    }
}
