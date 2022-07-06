using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HoshuSagyo.Migrations.HoshuSagyoDb
{
    public partial class 進捗テーブル追加 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "M_Shinchoku",
                columns: table => new
                {
                    Shinchoku = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShinchokuName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegisterDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_Shinchoku", x => x.Shinchoku);
                });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 6, 21, 57, 44, 487, DateTimeKind.Local).AddTicks(5362), new DateTime(2022, 7, 6, 21, 57, 44, 487, DateTimeKind.Local).AddTicks(5362) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 6, 21, 57, 44, 487, DateTimeKind.Local).AddTicks(5362), new DateTime(2022, 7, 6, 21, 57, 44, 487, DateTimeKind.Local).AddTicks(5362) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 3,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 6, 21, 57, 44, 487, DateTimeKind.Local).AddTicks(5362), new DateTime(2022, 7, 6, 21, 57, 44, 487, DateTimeKind.Local).AddTicks(5362) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 4,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 6, 21, 57, 44, 487, DateTimeKind.Local).AddTicks(5362), new DateTime(2022, 7, 6, 21, 57, 44, 487, DateTimeKind.Local).AddTicks(5362) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 5,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 6, 21, 57, 44, 487, DateTimeKind.Local).AddTicks(5362), new DateTime(2022, 7, 6, 21, 57, 44, 487, DateTimeKind.Local).AddTicks(5362) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 6,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 6, 21, 57, 44, 487, DateTimeKind.Local).AddTicks(5362), new DateTime(2022, 7, 6, 21, 57, 44, 487, DateTimeKind.Local).AddTicks(5362) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 7,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 6, 21, 57, 44, 487, DateTimeKind.Local).AddTicks(5362), new DateTime(2022, 7, 6, 21, 57, 44, 487, DateTimeKind.Local).AddTicks(5362) });

            migrationBuilder.UpdateData(
                table: "M_Keito",
                keyColumn: "Keito",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 6, 21, 57, 44, 487, DateTimeKind.Local).AddTicks(5362), new DateTime(2022, 7, 6, 21, 57, 44, 487, DateTimeKind.Local).AddTicks(5362) });

            migrationBuilder.UpdateData(
                table: "M_Keito",
                keyColumn: "Keito",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 6, 21, 57, 44, 487, DateTimeKind.Local).AddTicks(5362), new DateTime(2022, 7, 6, 21, 57, 44, 487, DateTimeKind.Local).AddTicks(5362) });

            migrationBuilder.UpdateData(
                table: "M_Keito",
                keyColumn: "Keito",
                keyValue: 99,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 6, 21, 57, 44, 487, DateTimeKind.Local).AddTicks(5362), new DateTime(2022, 7, 6, 21, 57, 44, 487, DateTimeKind.Local).AddTicks(5362) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOto",
                keyColumn: "OtoShubetsu",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 6, 21, 57, 44, 487, DateTimeKind.Local).AddTicks(5362), new DateTime(2022, 7, 6, 21, 57, 44, 487, DateTimeKind.Local).AddTicks(5362) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOto",
                keyColumn: "OtoShubetsu",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 6, 21, 57, 44, 487, DateTimeKind.Local).AddTicks(5362), new DateTime(2022, 7, 6, 21, 57, 44, 487, DateTimeKind.Local).AddTicks(5362) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOto",
                keyColumn: "OtoShubetsu",
                keyValue: 3,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 6, 21, 57, 44, 487, DateTimeKind.Local).AddTicks(5362), new DateTime(2022, 7, 6, 21, 57, 44, 487, DateTimeKind.Local).AddTicks(5362) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOto",
                keyColumn: "OtoShubetsu",
                keyValue: 4,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 6, 21, 57, 44, 487, DateTimeKind.Local).AddTicks(5362), new DateTime(2022, 7, 6, 21, 57, 44, 487, DateTimeKind.Local).AddTicks(5362) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOto",
                keyColumn: "OtoShubetsu",
                keyValue: 5,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 6, 21, 57, 44, 487, DateTimeKind.Local).AddTicks(5362), new DateTime(2022, 7, 6, 21, 57, 44, 487, DateTimeKind.Local).AddTicks(5362) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 6, 21, 57, 44, 487, DateTimeKind.Local).AddTicks(5362), new DateTime(2022, 7, 6, 21, 57, 44, 487, DateTimeKind.Local).AddTicks(5362) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 6, 21, 57, 44, 487, DateTimeKind.Local).AddTicks(5362), new DateTime(2022, 7, 6, 21, 57, 44, 487, DateTimeKind.Local).AddTicks(5362) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 6, 21, 57, 44, 487, DateTimeKind.Local).AddTicks(5362), new DateTime(2022, 7, 6, 21, 57, 44, 487, DateTimeKind.Local).AddTicks(5362) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 6, 21, 57, 44, 487, DateTimeKind.Local).AddTicks(5362), new DateTime(2022, 7, 6, 21, 57, 44, 487, DateTimeKind.Local).AddTicks(5362) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 6, 21, 57, 44, 487, DateTimeKind.Local).AddTicks(5362), new DateTime(2022, 7, 6, 21, 57, 44, 487, DateTimeKind.Local).AddTicks(5362) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 6, 21, 57, 44, 487, DateTimeKind.Local).AddTicks(5362), new DateTime(2022, 7, 6, 21, 57, 44, 487, DateTimeKind.Local).AddTicks(5362) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 6, 21, 57, 44, 487, DateTimeKind.Local).AddTicks(5362), new DateTime(2022, 7, 6, 21, 57, 44, 487, DateTimeKind.Local).AddTicks(5362) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 6, 21, 57, 44, 487, DateTimeKind.Local).AddTicks(5362), new DateTime(2022, 7, 6, 21, 57, 44, 487, DateTimeKind.Local).AddTicks(5362) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 6, 21, 57, 44, 487, DateTimeKind.Local).AddTicks(5362), new DateTime(2022, 7, 6, 21, 57, 44, 487, DateTimeKind.Local).AddTicks(5362) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 6, 21, 57, 44, 487, DateTimeKind.Local).AddTicks(5362), new DateTime(2022, 7, 6, 21, 57, 44, 487, DateTimeKind.Local).AddTicks(5362) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 6, 21, 57, 44, 487, DateTimeKind.Local).AddTicks(5362), new DateTime(2022, 7, 6, 21, 57, 44, 487, DateTimeKind.Local).AddTicks(5362) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 6, 21, 57, 44, 487, DateTimeKind.Local).AddTicks(5362), new DateTime(2022, 7, 6, 21, 57, 44, 487, DateTimeKind.Local).AddTicks(5362) });

            migrationBuilder.UpdateData(
                table: "M_SagyoBasho",
                keyColumn: "SagyoBasho",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 6, 21, 57, 44, 487, DateTimeKind.Local).AddTicks(5362), new DateTime(2022, 7, 6, 21, 57, 44, 487, DateTimeKind.Local).AddTicks(5362) });

            migrationBuilder.UpdateData(
                table: "M_SagyoBasho",
                keyColumn: "SagyoBasho",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 6, 21, 57, 44, 487, DateTimeKind.Local).AddTicks(5362), new DateTime(2022, 7, 6, 21, 57, 44, 487, DateTimeKind.Local).AddTicks(5362) });

            migrationBuilder.UpdateData(
                table: "M_SagyoBasho",
                keyColumn: "SagyoBasho",
                keyValue: 3,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 6, 21, 57, 44, 487, DateTimeKind.Local).AddTicks(5362), new DateTime(2022, 7, 6, 21, 57, 44, 487, DateTimeKind.Local).AddTicks(5362) });

            migrationBuilder.UpdateData(
                table: "M_SagyoShubetsu",
                keyColumn: "SagyoShubetsu",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 6, 21, 57, 44, 487, DateTimeKind.Local).AddTicks(5362), new DateTime(2022, 7, 6, 21, 57, 44, 487, DateTimeKind.Local).AddTicks(5362) });

            migrationBuilder.UpdateData(
                table: "M_SagyoShubetsu",
                keyColumn: "SagyoShubetsu",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 6, 21, 57, 44, 487, DateTimeKind.Local).AddTicks(5362), new DateTime(2022, 7, 6, 21, 57, 44, 487, DateTimeKind.Local).AddTicks(5362) });

            migrationBuilder.UpdateData(
                table: "M_SagyoShubetsu",
                keyColumn: "SagyoShubetsu",
                keyValue: 3,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 6, 21, 57, 44, 487, DateTimeKind.Local).AddTicks(5362), new DateTime(2022, 7, 6, 21, 57, 44, 487, DateTimeKind.Local).AddTicks(5362) });

            migrationBuilder.InsertData(
                table: "M_Shinchoku",
                columns: new[] { "Shinchoku", "RegisterDateTime", "ShinchokuName", "UpdateDateTime" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 7, 6, 21, 57, 44, 487, DateTimeKind.Local).AddTicks(5362), "未着手", new DateTime(2022, 7, 6, 21, 57, 44, 487, DateTimeKind.Local).AddTicks(5362) },
                    { 2, new DateTime(2022, 7, 6, 21, 57, 44, 487, DateTimeKind.Local).AddTicks(5362), "着手済", new DateTime(2022, 7, 6, 21, 57, 44, 487, DateTimeKind.Local).AddTicks(5362) },
                    { 3, new DateTime(2022, 7, 6, 21, 57, 44, 487, DateTimeKind.Local).AddTicks(5362), "完了済", new DateTime(2022, 7, 6, 21, 57, 44, 487, DateTimeKind.Local).AddTicks(5362) },
                    { 4, new DateTime(2022, 7, 6, 21, 57, 44, 487, DateTimeKind.Local).AddTicks(5362), "着手遅延", new DateTime(2022, 7, 6, 21, 57, 44, 487, DateTimeKind.Local).AddTicks(5362) },
                    { 5, new DateTime(2022, 7, 6, 21, 57, 44, 487, DateTimeKind.Local).AddTicks(5362), "終了遅延", new DateTime(2022, 7, 6, 21, 57, 44, 487, DateTimeKind.Local).AddTicks(5362) },
                    { 6, new DateTime(2022, 7, 6, 21, 57, 44, 487, DateTimeKind.Local).AddTicks(5362), "中止", new DateTime(2022, 7, 6, 21, 57, 44, 487, DateTimeKind.Local).AddTicks(5362) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "M_Shinchoku");

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

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 6, 19, 38, 42, 610, DateTimeKind.Local).AddTicks(424), new DateTime(2022, 7, 6, 19, 38, 42, 610, DateTimeKind.Local).AddTicks(424) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 6, 19, 38, 42, 610, DateTimeKind.Local).AddTicks(424), new DateTime(2022, 7, 6, 19, 38, 42, 610, DateTimeKind.Local).AddTicks(424) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 6, 19, 38, 42, 610, DateTimeKind.Local).AddTicks(424), new DateTime(2022, 7, 6, 19, 38, 42, 610, DateTimeKind.Local).AddTicks(424) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 6, 19, 38, 42, 610, DateTimeKind.Local).AddTicks(424), new DateTime(2022, 7, 6, 19, 38, 42, 610, DateTimeKind.Local).AddTicks(424) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 6, 19, 38, 42, 610, DateTimeKind.Local).AddTicks(424), new DateTime(2022, 7, 6, 19, 38, 42, 610, DateTimeKind.Local).AddTicks(424) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 6, 19, 38, 42, 610, DateTimeKind.Local).AddTicks(424), new DateTime(2022, 7, 6, 19, 38, 42, 610, DateTimeKind.Local).AddTicks(424) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 6, 19, 38, 42, 610, DateTimeKind.Local).AddTicks(424), new DateTime(2022, 7, 6, 19, 38, 42, 610, DateTimeKind.Local).AddTicks(424) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 6, 19, 38, 42, 610, DateTimeKind.Local).AddTicks(424), new DateTime(2022, 7, 6, 19, 38, 42, 610, DateTimeKind.Local).AddTicks(424) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 6, 19, 38, 42, 610, DateTimeKind.Local).AddTicks(424), new DateTime(2022, 7, 6, 19, 38, 42, 610, DateTimeKind.Local).AddTicks(424) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 6, 19, 38, 42, 610, DateTimeKind.Local).AddTicks(424), new DateTime(2022, 7, 6, 19, 38, 42, 610, DateTimeKind.Local).AddTicks(424) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 6, 19, 38, 42, 610, DateTimeKind.Local).AddTicks(424), new DateTime(2022, 7, 6, 19, 38, 42, 610, DateTimeKind.Local).AddTicks(424) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 6, 19, 38, 42, 610, DateTimeKind.Local).AddTicks(424), new DateTime(2022, 7, 6, 19, 38, 42, 610, DateTimeKind.Local).AddTicks(424) });

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
    }
}
