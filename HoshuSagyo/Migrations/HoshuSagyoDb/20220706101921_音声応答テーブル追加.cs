using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HoshuSagyo.Migrations.HoshuSagyoDb
{
    public partial class 音声応答テーブル追加 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "M_OnseiOto",
                columns: table => new
                {
                    OtoShubetsu = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OtoShubetsuNaiyo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegisterDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_OnseiOto", x => x.OtoShubetsu);
                });

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

            migrationBuilder.InsertData(
                table: "M_OnseiOto",
                columns: new[] { "OtoShubetsu", "OtoShubetsuNaiyo", "RegisterDateTime", "UpdateDateTime" },
                values: new object[,]
                {
                    { 1, "作業開始", new DateTime(2022, 7, 6, 19, 19, 21, 303, DateTimeKind.Local).AddTicks(1947), new DateTime(2022, 7, 6, 19, 19, 21, 303, DateTimeKind.Local).AddTicks(1947) },
                    { 2, "作業終了", new DateTime(2022, 7, 6, 19, 19, 21, 303, DateTimeKind.Local).AddTicks(1947), new DateTime(2022, 7, 6, 19, 19, 21, 303, DateTimeKind.Local).AddTicks(1947) },
                    { 3, "施設", new DateTime(2022, 7, 6, 19, 19, 21, 303, DateTimeKind.Local).AddTicks(1947), new DateTime(2022, 7, 6, 19, 19, 21, 303, DateTimeKind.Local).AddTicks(1947) },
                    { 4, "電力", new DateTime(2022, 7, 6, 19, 19, 21, 303, DateTimeKind.Local).AddTicks(1947), new DateTime(2022, 7, 6, 19, 19, 21, 303, DateTimeKind.Local).AddTicks(1947) },
                    { 5, "通信", new DateTime(2022, 7, 6, 19, 19, 21, 303, DateTimeKind.Local).AddTicks(1947), new DateTime(2022, 7, 6, 19, 19, 21, 303, DateTimeKind.Local).AddTicks(1947) }
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "M_OnseiOto");

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 4, 11, 10, 12, 32, DateTimeKind.Local).AddTicks(3576), new DateTime(2022, 7, 4, 11, 10, 12, 32, DateTimeKind.Local).AddTicks(3576) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 4, 11, 10, 12, 32, DateTimeKind.Local).AddTicks(3576), new DateTime(2022, 7, 4, 11, 10, 12, 32, DateTimeKind.Local).AddTicks(3576) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 3,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 4, 11, 10, 12, 32, DateTimeKind.Local).AddTicks(3576), new DateTime(2022, 7, 4, 11, 10, 12, 32, DateTimeKind.Local).AddTicks(3576) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 4,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 4, 11, 10, 12, 32, DateTimeKind.Local).AddTicks(3576), new DateTime(2022, 7, 4, 11, 10, 12, 32, DateTimeKind.Local).AddTicks(3576) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 5,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 4, 11, 10, 12, 32, DateTimeKind.Local).AddTicks(3576), new DateTime(2022, 7, 4, 11, 10, 12, 32, DateTimeKind.Local).AddTicks(3576) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 6,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 4, 11, 10, 12, 32, DateTimeKind.Local).AddTicks(3576), new DateTime(2022, 7, 4, 11, 10, 12, 32, DateTimeKind.Local).AddTicks(3576) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 7,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 4, 11, 10, 12, 32, DateTimeKind.Local).AddTicks(3576), new DateTime(2022, 7, 4, 11, 10, 12, 32, DateTimeKind.Local).AddTicks(3576) });

            migrationBuilder.UpdateData(
                table: "M_Keito",
                keyColumn: "Keito",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 4, 11, 10, 12, 32, DateTimeKind.Local).AddTicks(3576), new DateTime(2022, 7, 4, 11, 10, 12, 32, DateTimeKind.Local).AddTicks(3576) });

            migrationBuilder.UpdateData(
                table: "M_Keito",
                keyColumn: "Keito",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 4, 11, 10, 12, 32, DateTimeKind.Local).AddTicks(3576), new DateTime(2022, 7, 4, 11, 10, 12, 32, DateTimeKind.Local).AddTicks(3576) });

            migrationBuilder.UpdateData(
                table: "M_Keito",
                keyColumn: "Keito",
                keyValue: 99,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 4, 11, 10, 12, 32, DateTimeKind.Local).AddTicks(3576), new DateTime(2022, 7, 4, 11, 10, 12, 32, DateTimeKind.Local).AddTicks(3576) });

            migrationBuilder.UpdateData(
                table: "M_SagyoBasho",
                keyColumn: "SagyoBasho",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 4, 11, 10, 12, 32, DateTimeKind.Local).AddTicks(3576), new DateTime(2022, 7, 4, 11, 10, 12, 32, DateTimeKind.Local).AddTicks(3576) });

            migrationBuilder.UpdateData(
                table: "M_SagyoBasho",
                keyColumn: "SagyoBasho",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 4, 11, 10, 12, 32, DateTimeKind.Local).AddTicks(3576), new DateTime(2022, 7, 4, 11, 10, 12, 32, DateTimeKind.Local).AddTicks(3576) });

            migrationBuilder.UpdateData(
                table: "M_SagyoBasho",
                keyColumn: "SagyoBasho",
                keyValue: 3,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 4, 11, 10, 12, 32, DateTimeKind.Local).AddTicks(3576), new DateTime(2022, 7, 4, 11, 10, 12, 32, DateTimeKind.Local).AddTicks(3576) });

            migrationBuilder.UpdateData(
                table: "M_SagyoShubetsu",
                keyColumn: "SagyoShubetsu",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 4, 11, 10, 12, 32, DateTimeKind.Local).AddTicks(3576), new DateTime(2022, 7, 4, 11, 10, 12, 32, DateTimeKind.Local).AddTicks(3576) });

            migrationBuilder.UpdateData(
                table: "M_SagyoShubetsu",
                keyColumn: "SagyoShubetsu",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 4, 11, 10, 12, 32, DateTimeKind.Local).AddTicks(3576), new DateTime(2022, 7, 4, 11, 10, 12, 32, DateTimeKind.Local).AddTicks(3576) });

            migrationBuilder.UpdateData(
                table: "M_SagyoShubetsu",
                keyColumn: "SagyoShubetsu",
                keyValue: 3,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 4, 11, 10, 12, 32, DateTimeKind.Local).AddTicks(3576), new DateTime(2022, 7, 4, 11, 10, 12, 32, DateTimeKind.Local).AddTicks(3576) });
        }
    }
}
