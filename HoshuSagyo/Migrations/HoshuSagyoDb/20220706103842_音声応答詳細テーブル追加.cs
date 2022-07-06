using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HoshuSagyo.Migrations.HoshuSagyoDb
{
    public partial class 音声応答詳細テーブル追加 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "M_OnseiOtoShosai",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OtoShubetsu = table.Column<int>(type: "int", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegisterDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_OnseiOtoShosai", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 6, 19, 38, 42, 610, DateTimeKind.Local).AddTicks(424), new DateTime(2022, 7, 6, 19, 38, 42, 610, DateTimeKind.Local).AddTicks(424) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 6, 19, 38, 42, 610, DateTimeKind.Local).AddTicks(424), new DateTime(2022, 7, 6, 19, 38, 42, 610, DateTimeKind.Local).AddTicks(424) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 3,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 6, 19, 38, 42, 610, DateTimeKind.Local).AddTicks(424), new DateTime(2022, 7, 6, 19, 38, 42, 610, DateTimeKind.Local).AddTicks(424) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 4,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 6, 19, 38, 42, 610, DateTimeKind.Local).AddTicks(424), new DateTime(2022, 7, 6, 19, 38, 42, 610, DateTimeKind.Local).AddTicks(424) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 5,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 6, 19, 38, 42, 610, DateTimeKind.Local).AddTicks(424), new DateTime(2022, 7, 6, 19, 38, 42, 610, DateTimeKind.Local).AddTicks(424) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 6,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 6, 19, 38, 42, 610, DateTimeKind.Local).AddTicks(424), new DateTime(2022, 7, 6, 19, 38, 42, 610, DateTimeKind.Local).AddTicks(424) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 7,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 6, 19, 38, 42, 610, DateTimeKind.Local).AddTicks(424), new DateTime(2022, 7, 6, 19, 38, 42, 610, DateTimeKind.Local).AddTicks(424) });

            migrationBuilder.UpdateData(
                table: "M_Keito",
                keyColumn: "Keito",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 6, 19, 38, 42, 610, DateTimeKind.Local).AddTicks(424), new DateTime(2022, 7, 6, 19, 38, 42, 610, DateTimeKind.Local).AddTicks(424) });

            migrationBuilder.UpdateData(
                table: "M_Keito",
                keyColumn: "Keito",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 6, 19, 38, 42, 610, DateTimeKind.Local).AddTicks(424), new DateTime(2022, 7, 6, 19, 38, 42, 610, DateTimeKind.Local).AddTicks(424) });

            migrationBuilder.UpdateData(
                table: "M_Keito",
                keyColumn: "Keito",
                keyValue: 99,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 6, 19, 38, 42, 610, DateTimeKind.Local).AddTicks(424), new DateTime(2022, 7, 6, 19, 38, 42, 610, DateTimeKind.Local).AddTicks(424) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOto",
                keyColumn: "OtoShubetsu",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 6, 19, 38, 42, 610, DateTimeKind.Local).AddTicks(424), new DateTime(2022, 7, 6, 19, 38, 42, 610, DateTimeKind.Local).AddTicks(424) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOto",
                keyColumn: "OtoShubetsu",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 6, 19, 38, 42, 610, DateTimeKind.Local).AddTicks(424), new DateTime(2022, 7, 6, 19, 38, 42, 610, DateTimeKind.Local).AddTicks(424) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOto",
                keyColumn: "OtoShubetsu",
                keyValue: 3,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 6, 19, 38, 42, 610, DateTimeKind.Local).AddTicks(424), new DateTime(2022, 7, 6, 19, 38, 42, 610, DateTimeKind.Local).AddTicks(424) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOto",
                keyColumn: "OtoShubetsu",
                keyValue: 4,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 6, 19, 38, 42, 610, DateTimeKind.Local).AddTicks(424), new DateTime(2022, 7, 6, 19, 38, 42, 610, DateTimeKind.Local).AddTicks(424) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOto",
                keyColumn: "OtoShubetsu",
                keyValue: 5,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 6, 19, 38, 42, 610, DateTimeKind.Local).AddTicks(424), new DateTime(2022, 7, 6, 19, 38, 42, 610, DateTimeKind.Local).AddTicks(424) });

            migrationBuilder.InsertData(
                table: "M_OnseiOtoShosai",
                columns: new[] { "Id", "Message", "OtoShubetsu", "RegisterDateTime", "UpdateDateTime" },
                values: new object[,]
                {
                    { 1, "周りの安全を確保しましたか", 1, new DateTime(2022, 7, 6, 19, 38, 42, 610, DateTimeKind.Local).AddTicks(424), new DateTime(2022, 7, 6, 19, 38, 42, 610, DateTimeKind.Local).AddTicks(424) },
                    { 2, "作業員は全員揃いましたか", 1, new DateTime(2022, 7, 6, 19, 38, 42, 610, DateTimeKind.Local).AddTicks(424), new DateTime(2022, 7, 6, 19, 38, 42, 610, DateTimeKind.Local).AddTicks(424) },
                    { 3, "作業場所は間違っていませんか", 1, new DateTime(2022, 7, 6, 19, 38, 42, 610, DateTimeKind.Local).AddTicks(424), new DateTime(2022, 7, 6, 19, 38, 42, 610, DateTimeKind.Local).AddTicks(424) },
                    { 4, "道具の忘れ物はありませんか", 2, new DateTime(2022, 7, 6, 19, 38, 42, 610, DateTimeKind.Local).AddTicks(424), new DateTime(2022, 7, 6, 19, 38, 42, 610, DateTimeKind.Local).AddTicks(424) },
                    { 5, "機材のメンテナンスは行いましたか", 2, new DateTime(2022, 7, 6, 19, 38, 42, 610, DateTimeKind.Local).AddTicks(424), new DateTime(2022, 7, 6, 19, 38, 42, 610, DateTimeKind.Local).AddTicks(424) },
                    { 6, "作業の最終確認は済みましたか", 2, new DateTime(2022, 7, 6, 19, 38, 42, 610, DateTimeKind.Local).AddTicks(424), new DateTime(2022, 7, 6, 19, 38, 42, 610, DateTimeKind.Local).AddTicks(424) },
                    { 7, "施設の責任者から作業許可は出ていますか", 3, new DateTime(2022, 7, 6, 19, 38, 42, 610, DateTimeKind.Local).AddTicks(424), new DateTime(2022, 7, 6, 19, 38, 42, 610, DateTimeKind.Local).AddTicks(424) },
                    { 8, "各エリアの施錠は行いましたか", 3, new DateTime(2022, 7, 6, 19, 38, 42, 610, DateTimeKind.Local).AddTicks(424), new DateTime(2022, 7, 6, 19, 38, 42, 610, DateTimeKind.Local).AddTicks(424) },
                    { 9, "電気の供給が停止していますか", 3, new DateTime(2022, 7, 6, 19, 38, 42, 610, DateTimeKind.Local).AddTicks(424), new DateTime(2022, 7, 6, 19, 38, 42, 610, DateTimeKind.Local).AddTicks(424) },
                    { 10, "電気の供給を再開しましたか", 3, new DateTime(2022, 7, 6, 19, 38, 42, 610, DateTimeKind.Local).AddTicks(424), new DateTime(2022, 7, 6, 19, 38, 42, 610, DateTimeKind.Local).AddTicks(424) },
                    { 11, "通信状態をメンテナンス状態にしましたか", 3, new DateTime(2022, 7, 6, 19, 38, 42, 610, DateTimeKind.Local).AddTicks(424), new DateTime(2022, 7, 6, 19, 38, 42, 610, DateTimeKind.Local).AddTicks(424) },
                    { 12, "通信状態を通常状態に戻しましたか", 3, new DateTime(2022, 7, 6, 19, 38, 42, 610, DateTimeKind.Local).AddTicks(424), new DateTime(2022, 7, 6, 19, 38, 42, 610, DateTimeKind.Local).AddTicks(424) }
                });

            migrationBuilder.UpdateData(
                table: "M_SagyoBasho",
                keyColumn: "SagyoBasho",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 6, 19, 38, 42, 610, DateTimeKind.Local).AddTicks(424), new DateTime(2022, 7, 6, 19, 38, 42, 610, DateTimeKind.Local).AddTicks(424) });

            migrationBuilder.UpdateData(
                table: "M_SagyoBasho",
                keyColumn: "SagyoBasho",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 6, 19, 38, 42, 610, DateTimeKind.Local).AddTicks(424), new DateTime(2022, 7, 6, 19, 38, 42, 610, DateTimeKind.Local).AddTicks(424) });

            migrationBuilder.UpdateData(
                table: "M_SagyoBasho",
                keyColumn: "SagyoBasho",
                keyValue: 3,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 6, 19, 38, 42, 610, DateTimeKind.Local).AddTicks(424), new DateTime(2022, 7, 6, 19, 38, 42, 610, DateTimeKind.Local).AddTicks(424) });

            migrationBuilder.UpdateData(
                table: "M_SagyoShubetsu",
                keyColumn: "SagyoShubetsu",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 6, 19, 38, 42, 610, DateTimeKind.Local).AddTicks(424), new DateTime(2022, 7, 6, 19, 38, 42, 610, DateTimeKind.Local).AddTicks(424) });

            migrationBuilder.UpdateData(
                table: "M_SagyoShubetsu",
                keyColumn: "SagyoShubetsu",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 6, 19, 38, 42, 610, DateTimeKind.Local).AddTicks(424), new DateTime(2022, 7, 6, 19, 38, 42, 610, DateTimeKind.Local).AddTicks(424) });

            migrationBuilder.UpdateData(
                table: "M_SagyoShubetsu",
                keyColumn: "SagyoShubetsu",
                keyValue: 3,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 6, 19, 38, 42, 610, DateTimeKind.Local).AddTicks(424), new DateTime(2022, 7, 6, 19, 38, 42, 610, DateTimeKind.Local).AddTicks(424) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "M_OnseiOtoShosai");

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 6, 19, 19, 21, 303, DateTimeKind.Local).AddTicks(1947), new DateTime(2022, 7, 6, 19, 19, 21, 303, DateTimeKind.Local).AddTicks(1947) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 6, 19, 19, 21, 303, DateTimeKind.Local).AddTicks(1947), new DateTime(2022, 7, 6, 19, 19, 21, 303, DateTimeKind.Local).AddTicks(1947) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 3,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 6, 19, 19, 21, 303, DateTimeKind.Local).AddTicks(1947), new DateTime(2022, 7, 6, 19, 19, 21, 303, DateTimeKind.Local).AddTicks(1947) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 4,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 6, 19, 19, 21, 303, DateTimeKind.Local).AddTicks(1947), new DateTime(2022, 7, 6, 19, 19, 21, 303, DateTimeKind.Local).AddTicks(1947) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 5,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 6, 19, 19, 21, 303, DateTimeKind.Local).AddTicks(1947), new DateTime(2022, 7, 6, 19, 19, 21, 303, DateTimeKind.Local).AddTicks(1947) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 6,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 6, 19, 19, 21, 303, DateTimeKind.Local).AddTicks(1947), new DateTime(2022, 7, 6, 19, 19, 21, 303, DateTimeKind.Local).AddTicks(1947) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 7,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 6, 19, 19, 21, 303, DateTimeKind.Local).AddTicks(1947), new DateTime(2022, 7, 6, 19, 19, 21, 303, DateTimeKind.Local).AddTicks(1947) });

            migrationBuilder.UpdateData(
                table: "M_Keito",
                keyColumn: "Keito",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 6, 19, 19, 21, 303, DateTimeKind.Local).AddTicks(1947), new DateTime(2022, 7, 6, 19, 19, 21, 303, DateTimeKind.Local).AddTicks(1947) });

            migrationBuilder.UpdateData(
                table: "M_Keito",
                keyColumn: "Keito",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 6, 19, 19, 21, 303, DateTimeKind.Local).AddTicks(1947), new DateTime(2022, 7, 6, 19, 19, 21, 303, DateTimeKind.Local).AddTicks(1947) });

            migrationBuilder.UpdateData(
                table: "M_Keito",
                keyColumn: "Keito",
                keyValue: 99,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 6, 19, 19, 21, 303, DateTimeKind.Local).AddTicks(1947), new DateTime(2022, 7, 6, 19, 19, 21, 303, DateTimeKind.Local).AddTicks(1947) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOto",
                keyColumn: "OtoShubetsu",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 6, 19, 19, 21, 303, DateTimeKind.Local).AddTicks(1947), new DateTime(2022, 7, 6, 19, 19, 21, 303, DateTimeKind.Local).AddTicks(1947) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOto",
                keyColumn: "OtoShubetsu",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 6, 19, 19, 21, 303, DateTimeKind.Local).AddTicks(1947), new DateTime(2022, 7, 6, 19, 19, 21, 303, DateTimeKind.Local).AddTicks(1947) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOto",
                keyColumn: "OtoShubetsu",
                keyValue: 3,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 6, 19, 19, 21, 303, DateTimeKind.Local).AddTicks(1947), new DateTime(2022, 7, 6, 19, 19, 21, 303, DateTimeKind.Local).AddTicks(1947) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOto",
                keyColumn: "OtoShubetsu",
                keyValue: 4,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 6, 19, 19, 21, 303, DateTimeKind.Local).AddTicks(1947), new DateTime(2022, 7, 6, 19, 19, 21, 303, DateTimeKind.Local).AddTicks(1947) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOto",
                keyColumn: "OtoShubetsu",
                keyValue: 5,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 6, 19, 19, 21, 303, DateTimeKind.Local).AddTicks(1947), new DateTime(2022, 7, 6, 19, 19, 21, 303, DateTimeKind.Local).AddTicks(1947) });

            migrationBuilder.UpdateData(
                table: "M_SagyoBasho",
                keyColumn: "SagyoBasho",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 6, 19, 19, 21, 303, DateTimeKind.Local).AddTicks(1947), new DateTime(2022, 7, 6, 19, 19, 21, 303, DateTimeKind.Local).AddTicks(1947) });

            migrationBuilder.UpdateData(
                table: "M_SagyoBasho",
                keyColumn: "SagyoBasho",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 6, 19, 19, 21, 303, DateTimeKind.Local).AddTicks(1947), new DateTime(2022, 7, 6, 19, 19, 21, 303, DateTimeKind.Local).AddTicks(1947) });

            migrationBuilder.UpdateData(
                table: "M_SagyoBasho",
                keyColumn: "SagyoBasho",
                keyValue: 3,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 6, 19, 19, 21, 303, DateTimeKind.Local).AddTicks(1947), new DateTime(2022, 7, 6, 19, 19, 21, 303, DateTimeKind.Local).AddTicks(1947) });

            migrationBuilder.UpdateData(
                table: "M_SagyoShubetsu",
                keyColumn: "SagyoShubetsu",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 6, 19, 19, 21, 303, DateTimeKind.Local).AddTicks(1947), new DateTime(2022, 7, 6, 19, 19, 21, 303, DateTimeKind.Local).AddTicks(1947) });

            migrationBuilder.UpdateData(
                table: "M_SagyoShubetsu",
                keyColumn: "SagyoShubetsu",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 6, 19, 19, 21, 303, DateTimeKind.Local).AddTicks(1947), new DateTime(2022, 7, 6, 19, 19, 21, 303, DateTimeKind.Local).AddTicks(1947) });

            migrationBuilder.UpdateData(
                table: "M_SagyoShubetsu",
                keyColumn: "SagyoShubetsu",
                keyValue: 3,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 6, 19, 19, 21, 303, DateTimeKind.Local).AddTicks(1947), new DateTime(2022, 7, 6, 19, 19, 21, 303, DateTimeKind.Local).AddTicks(1947) });
        }
    }
}
