using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HoshuSagyo.Migrations.HoshuSagyoDb
{
    public partial class 作業計画テーブルにカラム追加作業終了音声応答詳細ID作業終了音声応答詳細ID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "OnseiOtoShosaiId",
                table: "T_SagyoKeikaku",
                newName: "SagyoShuryoOnseiOtoShosaiId");

            migrationBuilder.AddColumn<int>(
                name: "SagyoKaishiOnseiOtoShosaiId",
                table: "T_SagyoKeikaku",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 7, 14, 36, 59, 497, DateTimeKind.Local).AddTicks(8869), new DateTime(2022, 7, 7, 14, 36, 59, 497, DateTimeKind.Local).AddTicks(8869) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOto",
                keyColumn: "OtoShubetsu",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 7, 14, 36, 59, 497, DateTimeKind.Local).AddTicks(8869), new DateTime(2022, 7, 7, 14, 36, 59, 497, DateTimeKind.Local).AddTicks(8869) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOto",
                keyColumn: "OtoShubetsu",
                keyValue: 3,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 7, 14, 36, 59, 497, DateTimeKind.Local).AddTicks(8869), new DateTime(2022, 7, 7, 14, 36, 59, 497, DateTimeKind.Local).AddTicks(8869) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOto",
                keyColumn: "OtoShubetsu",
                keyValue: 4,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 7, 14, 36, 59, 497, DateTimeKind.Local).AddTicks(8869), new DateTime(2022, 7, 7, 14, 36, 59, 497, DateTimeKind.Local).AddTicks(8869) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOto",
                keyColumn: "OtoShubetsu",
                keyValue: 5,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 7, 14, 36, 59, 497, DateTimeKind.Local).AddTicks(8869), new DateTime(2022, 7, 7, 14, 36, 59, 497, DateTimeKind.Local).AddTicks(8869) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 7, 14, 36, 59, 497, DateTimeKind.Local).AddTicks(8869), new DateTime(2022, 7, 7, 14, 36, 59, 497, DateTimeKind.Local).AddTicks(8869) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 7, 14, 36, 59, 497, DateTimeKind.Local).AddTicks(8869), new DateTime(2022, 7, 7, 14, 36, 59, 497, DateTimeKind.Local).AddTicks(8869) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 7, 14, 36, 59, 497, DateTimeKind.Local).AddTicks(8869), new DateTime(2022, 7, 7, 14, 36, 59, 497, DateTimeKind.Local).AddTicks(8869) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 7, 14, 36, 59, 497, DateTimeKind.Local).AddTicks(8869), new DateTime(2022, 7, 7, 14, 36, 59, 497, DateTimeKind.Local).AddTicks(8869) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 7, 14, 36, 59, 497, DateTimeKind.Local).AddTicks(8869), new DateTime(2022, 7, 7, 14, 36, 59, 497, DateTimeKind.Local).AddTicks(8869) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 7, 14, 36, 59, 497, DateTimeKind.Local).AddTicks(8869), new DateTime(2022, 7, 7, 14, 36, 59, 497, DateTimeKind.Local).AddTicks(8869) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 7, 14, 36, 59, 497, DateTimeKind.Local).AddTicks(8869), new DateTime(2022, 7, 7, 14, 36, 59, 497, DateTimeKind.Local).AddTicks(8869) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 7, 14, 36, 59, 497, DateTimeKind.Local).AddTicks(8869), new DateTime(2022, 7, 7, 14, 36, 59, 497, DateTimeKind.Local).AddTicks(8869) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 7, 14, 36, 59, 497, DateTimeKind.Local).AddTicks(8869), new DateTime(2022, 7, 7, 14, 36, 59, 497, DateTimeKind.Local).AddTicks(8869) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 7, 14, 36, 59, 497, DateTimeKind.Local).AddTicks(8869), new DateTime(2022, 7, 7, 14, 36, 59, 497, DateTimeKind.Local).AddTicks(8869) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 7, 14, 36, 59, 497, DateTimeKind.Local).AddTicks(8869), new DateTime(2022, 7, 7, 14, 36, 59, 497, DateTimeKind.Local).AddTicks(8869) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 7, 14, 36, 59, 497, DateTimeKind.Local).AddTicks(8869), new DateTime(2022, 7, 7, 14, 36, 59, 497, DateTimeKind.Local).AddTicks(8869) });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SagyoKaishiOnseiOtoShosaiId",
                table: "T_SagyoKeikaku");

            migrationBuilder.RenameColumn(
                name: "SagyoShuryoOnseiOtoShosaiId",
                table: "T_SagyoKeikaku",
                newName: "OnseiOtoShosaiId");

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 7, 14, 13, 9, 157, DateTimeKind.Local).AddTicks(9266), new DateTime(2022, 7, 7, 14, 13, 9, 157, DateTimeKind.Local).AddTicks(9266) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 7, 14, 13, 9, 157, DateTimeKind.Local).AddTicks(9266), new DateTime(2022, 7, 7, 14, 13, 9, 157, DateTimeKind.Local).AddTicks(9266) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 3,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 7, 14, 13, 9, 157, DateTimeKind.Local).AddTicks(9266), new DateTime(2022, 7, 7, 14, 13, 9, 157, DateTimeKind.Local).AddTicks(9266) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 4,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 7, 14, 13, 9, 157, DateTimeKind.Local).AddTicks(9266), new DateTime(2022, 7, 7, 14, 13, 9, 157, DateTimeKind.Local).AddTicks(9266) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 5,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 7, 14, 13, 9, 157, DateTimeKind.Local).AddTicks(9266), new DateTime(2022, 7, 7, 14, 13, 9, 157, DateTimeKind.Local).AddTicks(9266) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 6,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 7, 14, 13, 9, 157, DateTimeKind.Local).AddTicks(9266), new DateTime(2022, 7, 7, 14, 13, 9, 157, DateTimeKind.Local).AddTicks(9266) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 7,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 7, 14, 13, 9, 157, DateTimeKind.Local).AddTicks(9266), new DateTime(2022, 7, 7, 14, 13, 9, 157, DateTimeKind.Local).AddTicks(9266) });

            migrationBuilder.UpdateData(
                table: "M_Keito",
                keyColumn: "Keito",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 7, 14, 13, 9, 157, DateTimeKind.Local).AddTicks(9266), new DateTime(2022, 7, 7, 14, 13, 9, 157, DateTimeKind.Local).AddTicks(9266) });

            migrationBuilder.UpdateData(
                table: "M_Keito",
                keyColumn: "Keito",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 7, 14, 13, 9, 157, DateTimeKind.Local).AddTicks(9266), new DateTime(2022, 7, 7, 14, 13, 9, 157, DateTimeKind.Local).AddTicks(9266) });

            migrationBuilder.UpdateData(
                table: "M_Keito",
                keyColumn: "Keito",
                keyValue: 99,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 7, 14, 13, 9, 157, DateTimeKind.Local).AddTicks(9266), new DateTime(2022, 7, 7, 14, 13, 9, 157, DateTimeKind.Local).AddTicks(9266) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOto",
                keyColumn: "OtoShubetsu",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 7, 14, 13, 9, 157, DateTimeKind.Local).AddTicks(9266), new DateTime(2022, 7, 7, 14, 13, 9, 157, DateTimeKind.Local).AddTicks(9266) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOto",
                keyColumn: "OtoShubetsu",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 7, 14, 13, 9, 157, DateTimeKind.Local).AddTicks(9266), new DateTime(2022, 7, 7, 14, 13, 9, 157, DateTimeKind.Local).AddTicks(9266) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOto",
                keyColumn: "OtoShubetsu",
                keyValue: 3,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 7, 14, 13, 9, 157, DateTimeKind.Local).AddTicks(9266), new DateTime(2022, 7, 7, 14, 13, 9, 157, DateTimeKind.Local).AddTicks(9266) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOto",
                keyColumn: "OtoShubetsu",
                keyValue: 4,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 7, 14, 13, 9, 157, DateTimeKind.Local).AddTicks(9266), new DateTime(2022, 7, 7, 14, 13, 9, 157, DateTimeKind.Local).AddTicks(9266) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOto",
                keyColumn: "OtoShubetsu",
                keyValue: 5,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 7, 14, 13, 9, 157, DateTimeKind.Local).AddTicks(9266), new DateTime(2022, 7, 7, 14, 13, 9, 157, DateTimeKind.Local).AddTicks(9266) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 7, 14, 13, 9, 157, DateTimeKind.Local).AddTicks(9266), new DateTime(2022, 7, 7, 14, 13, 9, 157, DateTimeKind.Local).AddTicks(9266) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 7, 14, 13, 9, 157, DateTimeKind.Local).AddTicks(9266), new DateTime(2022, 7, 7, 14, 13, 9, 157, DateTimeKind.Local).AddTicks(9266) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 7, 14, 13, 9, 157, DateTimeKind.Local).AddTicks(9266), new DateTime(2022, 7, 7, 14, 13, 9, 157, DateTimeKind.Local).AddTicks(9266) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 7, 14, 13, 9, 157, DateTimeKind.Local).AddTicks(9266), new DateTime(2022, 7, 7, 14, 13, 9, 157, DateTimeKind.Local).AddTicks(9266) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 7, 14, 13, 9, 157, DateTimeKind.Local).AddTicks(9266), new DateTime(2022, 7, 7, 14, 13, 9, 157, DateTimeKind.Local).AddTicks(9266) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 7, 14, 13, 9, 157, DateTimeKind.Local).AddTicks(9266), new DateTime(2022, 7, 7, 14, 13, 9, 157, DateTimeKind.Local).AddTicks(9266) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 7, 14, 13, 9, 157, DateTimeKind.Local).AddTicks(9266), new DateTime(2022, 7, 7, 14, 13, 9, 157, DateTimeKind.Local).AddTicks(9266) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 7, 14, 13, 9, 157, DateTimeKind.Local).AddTicks(9266), new DateTime(2022, 7, 7, 14, 13, 9, 157, DateTimeKind.Local).AddTicks(9266) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 7, 14, 13, 9, 157, DateTimeKind.Local).AddTicks(9266), new DateTime(2022, 7, 7, 14, 13, 9, 157, DateTimeKind.Local).AddTicks(9266) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 7, 14, 13, 9, 157, DateTimeKind.Local).AddTicks(9266), new DateTime(2022, 7, 7, 14, 13, 9, 157, DateTimeKind.Local).AddTicks(9266) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 7, 14, 13, 9, 157, DateTimeKind.Local).AddTicks(9266), new DateTime(2022, 7, 7, 14, 13, 9, 157, DateTimeKind.Local).AddTicks(9266) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 7, 14, 13, 9, 157, DateTimeKind.Local).AddTicks(9266), new DateTime(2022, 7, 7, 14, 13, 9, 157, DateTimeKind.Local).AddTicks(9266) });

            migrationBuilder.UpdateData(
                table: "M_SagyoBasho",
                keyColumn: "SagyoBasho",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 7, 14, 13, 9, 157, DateTimeKind.Local).AddTicks(9266), new DateTime(2022, 7, 7, 14, 13, 9, 157, DateTimeKind.Local).AddTicks(9266) });

            migrationBuilder.UpdateData(
                table: "M_SagyoBasho",
                keyColumn: "SagyoBasho",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 7, 14, 13, 9, 157, DateTimeKind.Local).AddTicks(9266), new DateTime(2022, 7, 7, 14, 13, 9, 157, DateTimeKind.Local).AddTicks(9266) });

            migrationBuilder.UpdateData(
                table: "M_SagyoBasho",
                keyColumn: "SagyoBasho",
                keyValue: 3,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 7, 14, 13, 9, 157, DateTimeKind.Local).AddTicks(9266), new DateTime(2022, 7, 7, 14, 13, 9, 157, DateTimeKind.Local).AddTicks(9266) });

            migrationBuilder.UpdateData(
                table: "M_SagyoShubetsu",
                keyColumn: "SagyoShubetsu",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 7, 14, 13, 9, 157, DateTimeKind.Local).AddTicks(9266), new DateTime(2022, 7, 7, 14, 13, 9, 157, DateTimeKind.Local).AddTicks(9266) });

            migrationBuilder.UpdateData(
                table: "M_SagyoShubetsu",
                keyColumn: "SagyoShubetsu",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 7, 14, 13, 9, 157, DateTimeKind.Local).AddTicks(9266), new DateTime(2022, 7, 7, 14, 13, 9, 157, DateTimeKind.Local).AddTicks(9266) });

            migrationBuilder.UpdateData(
                table: "M_SagyoShubetsu",
                keyColumn: "SagyoShubetsu",
                keyValue: 3,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 7, 14, 13, 9, 157, DateTimeKind.Local).AddTicks(9266), new DateTime(2022, 7, 7, 14, 13, 9, 157, DateTimeKind.Local).AddTicks(9266) });

            migrationBuilder.UpdateData(
                table: "M_Shinchoku",
                keyColumn: "Shinchoku",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 7, 14, 13, 9, 157, DateTimeKind.Local).AddTicks(9266), new DateTime(2022, 7, 7, 14, 13, 9, 157, DateTimeKind.Local).AddTicks(9266) });

            migrationBuilder.UpdateData(
                table: "M_Shinchoku",
                keyColumn: "Shinchoku",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 7, 14, 13, 9, 157, DateTimeKind.Local).AddTicks(9266), new DateTime(2022, 7, 7, 14, 13, 9, 157, DateTimeKind.Local).AddTicks(9266) });

            migrationBuilder.UpdateData(
                table: "M_Shinchoku",
                keyColumn: "Shinchoku",
                keyValue: 3,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 7, 14, 13, 9, 157, DateTimeKind.Local).AddTicks(9266), new DateTime(2022, 7, 7, 14, 13, 9, 157, DateTimeKind.Local).AddTicks(9266) });

            migrationBuilder.UpdateData(
                table: "M_Shinchoku",
                keyColumn: "Shinchoku",
                keyValue: 4,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 7, 14, 13, 9, 157, DateTimeKind.Local).AddTicks(9266), new DateTime(2022, 7, 7, 14, 13, 9, 157, DateTimeKind.Local).AddTicks(9266) });

            migrationBuilder.UpdateData(
                table: "M_Shinchoku",
                keyColumn: "Shinchoku",
                keyValue: 5,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 7, 14, 13, 9, 157, DateTimeKind.Local).AddTicks(9266), new DateTime(2022, 7, 7, 14, 13, 9, 157, DateTimeKind.Local).AddTicks(9266) });

            migrationBuilder.UpdateData(
                table: "M_Shinchoku",
                keyColumn: "Shinchoku",
                keyValue: 6,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 7, 14, 13, 9, 157, DateTimeKind.Local).AddTicks(9266), new DateTime(2022, 7, 7, 14, 13, 9, 157, DateTimeKind.Local).AddTicks(9266) });
        }
    }
}
