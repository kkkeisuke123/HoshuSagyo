using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HoshuSagyo.Migrations.HoshuSagyoDb
{
    public partial class 不要なので作業番号テーブルから系統カラムを削除した : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_T_SagyoBango",
                table: "T_SagyoBango");

            migrationBuilder.DropColumn(
                name: "Keito",
                table: "T_SagyoBango");

            migrationBuilder.AddPrimaryKey(
                name: "PK_T_SagyoBango",
                table: "T_SagyoBango",
                columns: new[] { "Nengetsu", "Kankatsu" });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 24, 21, 27, 49, 295, DateTimeKind.Local).AddTicks(798), new DateTime(2022, 7, 24, 21, 27, 49, 295, DateTimeKind.Local).AddTicks(798) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 24, 21, 27, 49, 295, DateTimeKind.Local).AddTicks(798), new DateTime(2022, 7, 24, 21, 27, 49, 295, DateTimeKind.Local).AddTicks(798) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 3,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 24, 21, 27, 49, 295, DateTimeKind.Local).AddTicks(798), new DateTime(2022, 7, 24, 21, 27, 49, 295, DateTimeKind.Local).AddTicks(798) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 4,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 24, 21, 27, 49, 295, DateTimeKind.Local).AddTicks(798), new DateTime(2022, 7, 24, 21, 27, 49, 295, DateTimeKind.Local).AddTicks(798) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 5,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 24, 21, 27, 49, 295, DateTimeKind.Local).AddTicks(798), new DateTime(2022, 7, 24, 21, 27, 49, 295, DateTimeKind.Local).AddTicks(798) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 6,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 24, 21, 27, 49, 295, DateTimeKind.Local).AddTicks(798), new DateTime(2022, 7, 24, 21, 27, 49, 295, DateTimeKind.Local).AddTicks(798) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 7,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 24, 21, 27, 49, 295, DateTimeKind.Local).AddTicks(798), new DateTime(2022, 7, 24, 21, 27, 49, 295, DateTimeKind.Local).AddTicks(798) });

            migrationBuilder.UpdateData(
                table: "M_Keito",
                keyColumn: "Keito",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 24, 21, 27, 49, 295, DateTimeKind.Local).AddTicks(798), new DateTime(2022, 7, 24, 21, 27, 49, 295, DateTimeKind.Local).AddTicks(798) });

            migrationBuilder.UpdateData(
                table: "M_Keito",
                keyColumn: "Keito",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 24, 21, 27, 49, 295, DateTimeKind.Local).AddTicks(798), new DateTime(2022, 7, 24, 21, 27, 49, 295, DateTimeKind.Local).AddTicks(798) });

            migrationBuilder.UpdateData(
                table: "M_Keito",
                keyColumn: "Keito",
                keyValue: 99,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 24, 21, 27, 49, 295, DateTimeKind.Local).AddTicks(798), new DateTime(2022, 7, 24, 21, 27, 49, 295, DateTimeKind.Local).AddTicks(798) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOto",
                keyColumn: "OtoShubetsu",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 24, 21, 27, 49, 295, DateTimeKind.Local).AddTicks(798), new DateTime(2022, 7, 24, 21, 27, 49, 295, DateTimeKind.Local).AddTicks(798) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOto",
                keyColumn: "OtoShubetsu",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 24, 21, 27, 49, 295, DateTimeKind.Local).AddTicks(798), new DateTime(2022, 7, 24, 21, 27, 49, 295, DateTimeKind.Local).AddTicks(798) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOto",
                keyColumn: "OtoShubetsu",
                keyValue: 3,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 24, 21, 27, 49, 295, DateTimeKind.Local).AddTicks(798), new DateTime(2022, 7, 24, 21, 27, 49, 295, DateTimeKind.Local).AddTicks(798) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOto",
                keyColumn: "OtoShubetsu",
                keyValue: 4,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 24, 21, 27, 49, 295, DateTimeKind.Local).AddTicks(798), new DateTime(2022, 7, 24, 21, 27, 49, 295, DateTimeKind.Local).AddTicks(798) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 24, 21, 27, 49, 295, DateTimeKind.Local).AddTicks(798), new DateTime(2022, 7, 24, 21, 27, 49, 295, DateTimeKind.Local).AddTicks(798) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 24, 21, 27, 49, 295, DateTimeKind.Local).AddTicks(798), new DateTime(2022, 7, 24, 21, 27, 49, 295, DateTimeKind.Local).AddTicks(798) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 24, 21, 27, 49, 295, DateTimeKind.Local).AddTicks(798), new DateTime(2022, 7, 24, 21, 27, 49, 295, DateTimeKind.Local).AddTicks(798) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 24, 21, 27, 49, 295, DateTimeKind.Local).AddTicks(798), new DateTime(2022, 7, 24, 21, 27, 49, 295, DateTimeKind.Local).AddTicks(798) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 24, 21, 27, 49, 295, DateTimeKind.Local).AddTicks(798), new DateTime(2022, 7, 24, 21, 27, 49, 295, DateTimeKind.Local).AddTicks(798) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 24, 21, 27, 49, 295, DateTimeKind.Local).AddTicks(798), new DateTime(2022, 7, 24, 21, 27, 49, 295, DateTimeKind.Local).AddTicks(798) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 24, 21, 27, 49, 295, DateTimeKind.Local).AddTicks(798), new DateTime(2022, 7, 24, 21, 27, 49, 295, DateTimeKind.Local).AddTicks(798) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 24, 21, 27, 49, 295, DateTimeKind.Local).AddTicks(798), new DateTime(2022, 7, 24, 21, 27, 49, 295, DateTimeKind.Local).AddTicks(798) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 24, 21, 27, 49, 295, DateTimeKind.Local).AddTicks(798), new DateTime(2022, 7, 24, 21, 27, 49, 295, DateTimeKind.Local).AddTicks(798) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 24, 21, 27, 49, 295, DateTimeKind.Local).AddTicks(798), new DateTime(2022, 7, 24, 21, 27, 49, 295, DateTimeKind.Local).AddTicks(798) });

            migrationBuilder.UpdateData(
                table: "M_SagyoBasho",
                keyColumn: "SagyoBasho",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 24, 21, 27, 49, 295, DateTimeKind.Local).AddTicks(798), new DateTime(2022, 7, 24, 21, 27, 49, 295, DateTimeKind.Local).AddTicks(798) });

            migrationBuilder.UpdateData(
                table: "M_SagyoBasho",
                keyColumn: "SagyoBasho",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 24, 21, 27, 49, 295, DateTimeKind.Local).AddTicks(798), new DateTime(2022, 7, 24, 21, 27, 49, 295, DateTimeKind.Local).AddTicks(798) });

            migrationBuilder.UpdateData(
                table: "M_SagyoBasho",
                keyColumn: "SagyoBasho",
                keyValue: 3,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 24, 21, 27, 49, 295, DateTimeKind.Local).AddTicks(798), new DateTime(2022, 7, 24, 21, 27, 49, 295, DateTimeKind.Local).AddTicks(798) });

            migrationBuilder.UpdateData(
                table: "M_SagyoShubetsu",
                keyColumn: "SagyoShubetsu",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 24, 21, 27, 49, 295, DateTimeKind.Local).AddTicks(798), new DateTime(2022, 7, 24, 21, 27, 49, 295, DateTimeKind.Local).AddTicks(798) });

            migrationBuilder.UpdateData(
                table: "M_SagyoShubetsu",
                keyColumn: "SagyoShubetsu",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 24, 21, 27, 49, 295, DateTimeKind.Local).AddTicks(798), new DateTime(2022, 7, 24, 21, 27, 49, 295, DateTimeKind.Local).AddTicks(798) });

            migrationBuilder.UpdateData(
                table: "M_SagyoShubetsu",
                keyColumn: "SagyoShubetsu",
                keyValue: 3,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 24, 21, 27, 49, 295, DateTimeKind.Local).AddTicks(798), new DateTime(2022, 7, 24, 21, 27, 49, 295, DateTimeKind.Local).AddTicks(798) });

            migrationBuilder.UpdateData(
                table: "M_Shinchoku",
                keyColumn: "Shinchoku",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 24, 21, 27, 49, 295, DateTimeKind.Local).AddTicks(798), new DateTime(2022, 7, 24, 21, 27, 49, 295, DateTimeKind.Local).AddTicks(798) });

            migrationBuilder.UpdateData(
                table: "M_Shinchoku",
                keyColumn: "Shinchoku",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 24, 21, 27, 49, 295, DateTimeKind.Local).AddTicks(798), new DateTime(2022, 7, 24, 21, 27, 49, 295, DateTimeKind.Local).AddTicks(798) });

            migrationBuilder.UpdateData(
                table: "M_Shinchoku",
                keyColumn: "Shinchoku",
                keyValue: 3,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 24, 21, 27, 49, 295, DateTimeKind.Local).AddTicks(798), new DateTime(2022, 7, 24, 21, 27, 49, 295, DateTimeKind.Local).AddTicks(798) });

            migrationBuilder.UpdateData(
                table: "M_Shinchoku",
                keyColumn: "Shinchoku",
                keyValue: 4,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 24, 21, 27, 49, 295, DateTimeKind.Local).AddTicks(798), new DateTime(2022, 7, 24, 21, 27, 49, 295, DateTimeKind.Local).AddTicks(798) });

            migrationBuilder.UpdateData(
                table: "M_Shinchoku",
                keyColumn: "Shinchoku",
                keyValue: 5,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 24, 21, 27, 49, 295, DateTimeKind.Local).AddTicks(798), new DateTime(2022, 7, 24, 21, 27, 49, 295, DateTimeKind.Local).AddTicks(798) });

            migrationBuilder.UpdateData(
                table: "M_Shinchoku",
                keyColumn: "Shinchoku",
                keyValue: 6,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 24, 21, 27, 49, 295, DateTimeKind.Local).AddTicks(798), new DateTime(2022, 7, 24, 21, 27, 49, 295, DateTimeKind.Local).AddTicks(798) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_T_SagyoBango",
                table: "T_SagyoBango");

            migrationBuilder.AddColumn<int>(
                name: "Keito",
                table: "T_SagyoBango",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_T_SagyoBango",
                table: "T_SagyoBango",
                columns: new[] { "Nengetsu", "Keito", "Kankatsu" });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 20, 17, 45, 53, 630, DateTimeKind.Local).AddTicks(9398), new DateTime(2022, 7, 20, 17, 45, 53, 630, DateTimeKind.Local).AddTicks(9398) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 20, 17, 45, 53, 630, DateTimeKind.Local).AddTicks(9398), new DateTime(2022, 7, 20, 17, 45, 53, 630, DateTimeKind.Local).AddTicks(9398) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 3,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 20, 17, 45, 53, 630, DateTimeKind.Local).AddTicks(9398), new DateTime(2022, 7, 20, 17, 45, 53, 630, DateTimeKind.Local).AddTicks(9398) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 4,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 20, 17, 45, 53, 630, DateTimeKind.Local).AddTicks(9398), new DateTime(2022, 7, 20, 17, 45, 53, 630, DateTimeKind.Local).AddTicks(9398) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 5,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 20, 17, 45, 53, 630, DateTimeKind.Local).AddTicks(9398), new DateTime(2022, 7, 20, 17, 45, 53, 630, DateTimeKind.Local).AddTicks(9398) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 6,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 20, 17, 45, 53, 630, DateTimeKind.Local).AddTicks(9398), new DateTime(2022, 7, 20, 17, 45, 53, 630, DateTimeKind.Local).AddTicks(9398) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 7,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 20, 17, 45, 53, 630, DateTimeKind.Local).AddTicks(9398), new DateTime(2022, 7, 20, 17, 45, 53, 630, DateTimeKind.Local).AddTicks(9398) });

            migrationBuilder.UpdateData(
                table: "M_Keito",
                keyColumn: "Keito",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 20, 17, 45, 53, 630, DateTimeKind.Local).AddTicks(9398), new DateTime(2022, 7, 20, 17, 45, 53, 630, DateTimeKind.Local).AddTicks(9398) });

            migrationBuilder.UpdateData(
                table: "M_Keito",
                keyColumn: "Keito",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 20, 17, 45, 53, 630, DateTimeKind.Local).AddTicks(9398), new DateTime(2022, 7, 20, 17, 45, 53, 630, DateTimeKind.Local).AddTicks(9398) });

            migrationBuilder.UpdateData(
                table: "M_Keito",
                keyColumn: "Keito",
                keyValue: 99,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 20, 17, 45, 53, 630, DateTimeKind.Local).AddTicks(9398), new DateTime(2022, 7, 20, 17, 45, 53, 630, DateTimeKind.Local).AddTicks(9398) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOto",
                keyColumn: "OtoShubetsu",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 20, 17, 45, 53, 630, DateTimeKind.Local).AddTicks(9398), new DateTime(2022, 7, 20, 17, 45, 53, 630, DateTimeKind.Local).AddTicks(9398) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOto",
                keyColumn: "OtoShubetsu",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 20, 17, 45, 53, 630, DateTimeKind.Local).AddTicks(9398), new DateTime(2022, 7, 20, 17, 45, 53, 630, DateTimeKind.Local).AddTicks(9398) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOto",
                keyColumn: "OtoShubetsu",
                keyValue: 3,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 20, 17, 45, 53, 630, DateTimeKind.Local).AddTicks(9398), new DateTime(2022, 7, 20, 17, 45, 53, 630, DateTimeKind.Local).AddTicks(9398) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOto",
                keyColumn: "OtoShubetsu",
                keyValue: 4,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 20, 17, 45, 53, 630, DateTimeKind.Local).AddTicks(9398), new DateTime(2022, 7, 20, 17, 45, 53, 630, DateTimeKind.Local).AddTicks(9398) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 20, 17, 45, 53, 630, DateTimeKind.Local).AddTicks(9398), new DateTime(2022, 7, 20, 17, 45, 53, 630, DateTimeKind.Local).AddTicks(9398) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 20, 17, 45, 53, 630, DateTimeKind.Local).AddTicks(9398), new DateTime(2022, 7, 20, 17, 45, 53, 630, DateTimeKind.Local).AddTicks(9398) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 20, 17, 45, 53, 630, DateTimeKind.Local).AddTicks(9398), new DateTime(2022, 7, 20, 17, 45, 53, 630, DateTimeKind.Local).AddTicks(9398) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 20, 17, 45, 53, 630, DateTimeKind.Local).AddTicks(9398), new DateTime(2022, 7, 20, 17, 45, 53, 630, DateTimeKind.Local).AddTicks(9398) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 20, 17, 45, 53, 630, DateTimeKind.Local).AddTicks(9398), new DateTime(2022, 7, 20, 17, 45, 53, 630, DateTimeKind.Local).AddTicks(9398) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 20, 17, 45, 53, 630, DateTimeKind.Local).AddTicks(9398), new DateTime(2022, 7, 20, 17, 45, 53, 630, DateTimeKind.Local).AddTicks(9398) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 20, 17, 45, 53, 630, DateTimeKind.Local).AddTicks(9398), new DateTime(2022, 7, 20, 17, 45, 53, 630, DateTimeKind.Local).AddTicks(9398) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 20, 17, 45, 53, 630, DateTimeKind.Local).AddTicks(9398), new DateTime(2022, 7, 20, 17, 45, 53, 630, DateTimeKind.Local).AddTicks(9398) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 20, 17, 45, 53, 630, DateTimeKind.Local).AddTicks(9398), new DateTime(2022, 7, 20, 17, 45, 53, 630, DateTimeKind.Local).AddTicks(9398) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 20, 17, 45, 53, 630, DateTimeKind.Local).AddTicks(9398), new DateTime(2022, 7, 20, 17, 45, 53, 630, DateTimeKind.Local).AddTicks(9398) });

            migrationBuilder.UpdateData(
                table: "M_SagyoBasho",
                keyColumn: "SagyoBasho",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 20, 17, 45, 53, 630, DateTimeKind.Local).AddTicks(9398), new DateTime(2022, 7, 20, 17, 45, 53, 630, DateTimeKind.Local).AddTicks(9398) });

            migrationBuilder.UpdateData(
                table: "M_SagyoBasho",
                keyColumn: "SagyoBasho",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 20, 17, 45, 53, 630, DateTimeKind.Local).AddTicks(9398), new DateTime(2022, 7, 20, 17, 45, 53, 630, DateTimeKind.Local).AddTicks(9398) });

            migrationBuilder.UpdateData(
                table: "M_SagyoBasho",
                keyColumn: "SagyoBasho",
                keyValue: 3,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 20, 17, 45, 53, 630, DateTimeKind.Local).AddTicks(9398), new DateTime(2022, 7, 20, 17, 45, 53, 630, DateTimeKind.Local).AddTicks(9398) });

            migrationBuilder.UpdateData(
                table: "M_SagyoShubetsu",
                keyColumn: "SagyoShubetsu",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 20, 17, 45, 53, 630, DateTimeKind.Local).AddTicks(9398), new DateTime(2022, 7, 20, 17, 45, 53, 630, DateTimeKind.Local).AddTicks(9398) });

            migrationBuilder.UpdateData(
                table: "M_SagyoShubetsu",
                keyColumn: "SagyoShubetsu",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 20, 17, 45, 53, 630, DateTimeKind.Local).AddTicks(9398), new DateTime(2022, 7, 20, 17, 45, 53, 630, DateTimeKind.Local).AddTicks(9398) });

            migrationBuilder.UpdateData(
                table: "M_SagyoShubetsu",
                keyColumn: "SagyoShubetsu",
                keyValue: 3,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 20, 17, 45, 53, 630, DateTimeKind.Local).AddTicks(9398), new DateTime(2022, 7, 20, 17, 45, 53, 630, DateTimeKind.Local).AddTicks(9398) });

            migrationBuilder.UpdateData(
                table: "M_Shinchoku",
                keyColumn: "Shinchoku",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 20, 17, 45, 53, 630, DateTimeKind.Local).AddTicks(9398), new DateTime(2022, 7, 20, 17, 45, 53, 630, DateTimeKind.Local).AddTicks(9398) });

            migrationBuilder.UpdateData(
                table: "M_Shinchoku",
                keyColumn: "Shinchoku",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 20, 17, 45, 53, 630, DateTimeKind.Local).AddTicks(9398), new DateTime(2022, 7, 20, 17, 45, 53, 630, DateTimeKind.Local).AddTicks(9398) });

            migrationBuilder.UpdateData(
                table: "M_Shinchoku",
                keyColumn: "Shinchoku",
                keyValue: 3,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 20, 17, 45, 53, 630, DateTimeKind.Local).AddTicks(9398), new DateTime(2022, 7, 20, 17, 45, 53, 630, DateTimeKind.Local).AddTicks(9398) });

            migrationBuilder.UpdateData(
                table: "M_Shinchoku",
                keyColumn: "Shinchoku",
                keyValue: 4,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 20, 17, 45, 53, 630, DateTimeKind.Local).AddTicks(9398), new DateTime(2022, 7, 20, 17, 45, 53, 630, DateTimeKind.Local).AddTicks(9398) });

            migrationBuilder.UpdateData(
                table: "M_Shinchoku",
                keyColumn: "Shinchoku",
                keyValue: 5,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 20, 17, 45, 53, 630, DateTimeKind.Local).AddTicks(9398), new DateTime(2022, 7, 20, 17, 45, 53, 630, DateTimeKind.Local).AddTicks(9398) });

            migrationBuilder.UpdateData(
                table: "M_Shinchoku",
                keyColumn: "Shinchoku",
                keyValue: 6,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 20, 17, 45, 53, 630, DateTimeKind.Local).AddTicks(9398), new DateTime(2022, 7, 20, 17, 45, 53, 630, DateTimeKind.Local).AddTicks(9398) });
        }
    }
}
