using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HoshuSagyo.Migrations.HoshuSagyoDb
{
    public partial class 作業番号テーブル主キーの型を変更するため複合主キーを一部削除 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_T_SagyoBango",
                table: "T_SagyoBango");

            migrationBuilder.AlterColumn<string>(
                name: "Nengetsu",
                table: "T_SagyoBango",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddPrimaryKey(
                name: "PK_T_SagyoBango",
                table: "T_SagyoBango",
                columns: new[] { "Keito", "Kankatsu" });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 30, 10, 7, 55, 791, DateTimeKind.Local).AddTicks(2038), new DateTime(2022, 6, 30, 10, 7, 55, 791, DateTimeKind.Local).AddTicks(2038) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 30, 10, 7, 55, 791, DateTimeKind.Local).AddTicks(2038), new DateTime(2022, 6, 30, 10, 7, 55, 791, DateTimeKind.Local).AddTicks(2038) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 3,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 30, 10, 7, 55, 791, DateTimeKind.Local).AddTicks(2038), new DateTime(2022, 6, 30, 10, 7, 55, 791, DateTimeKind.Local).AddTicks(2038) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 4,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 30, 10, 7, 55, 791, DateTimeKind.Local).AddTicks(2038), new DateTime(2022, 6, 30, 10, 7, 55, 791, DateTimeKind.Local).AddTicks(2038) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 5,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 30, 10, 7, 55, 791, DateTimeKind.Local).AddTicks(2038), new DateTime(2022, 6, 30, 10, 7, 55, 791, DateTimeKind.Local).AddTicks(2038) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 6,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 30, 10, 7, 55, 791, DateTimeKind.Local).AddTicks(2038), new DateTime(2022, 6, 30, 10, 7, 55, 791, DateTimeKind.Local).AddTicks(2038) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 7,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 30, 10, 7, 55, 791, DateTimeKind.Local).AddTicks(2038), new DateTime(2022, 6, 30, 10, 7, 55, 791, DateTimeKind.Local).AddTicks(2038) });

            migrationBuilder.UpdateData(
                table: "M_Keito",
                keyColumn: "Keito",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 30, 10, 7, 55, 791, DateTimeKind.Local).AddTicks(2038), new DateTime(2022, 6, 30, 10, 7, 55, 791, DateTimeKind.Local).AddTicks(2038) });

            migrationBuilder.UpdateData(
                table: "M_Keito",
                keyColumn: "Keito",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 30, 10, 7, 55, 791, DateTimeKind.Local).AddTicks(2038), new DateTime(2022, 6, 30, 10, 7, 55, 791, DateTimeKind.Local).AddTicks(2038) });

            migrationBuilder.UpdateData(
                table: "M_Keito",
                keyColumn: "Keito",
                keyValue: 99,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 30, 10, 7, 55, 791, DateTimeKind.Local).AddTicks(2038), new DateTime(2022, 6, 30, 10, 7, 55, 791, DateTimeKind.Local).AddTicks(2038) });

            migrationBuilder.UpdateData(
                table: "M_SagyoBasho",
                keyColumn: "SagyoBasho",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 30, 10, 7, 55, 791, DateTimeKind.Local).AddTicks(2038), new DateTime(2022, 6, 30, 10, 7, 55, 791, DateTimeKind.Local).AddTicks(2038) });

            migrationBuilder.UpdateData(
                table: "M_SagyoBasho",
                keyColumn: "SagyoBasho",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 30, 10, 7, 55, 791, DateTimeKind.Local).AddTicks(2038), new DateTime(2022, 6, 30, 10, 7, 55, 791, DateTimeKind.Local).AddTicks(2038) });

            migrationBuilder.UpdateData(
                table: "M_SagyoBasho",
                keyColumn: "SagyoBasho",
                keyValue: 3,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 30, 10, 7, 55, 791, DateTimeKind.Local).AddTicks(2038), new DateTime(2022, 6, 30, 10, 7, 55, 791, DateTimeKind.Local).AddTicks(2038) });

            migrationBuilder.UpdateData(
                table: "M_SagyoShubetsu",
                keyColumn: "SagyoShubetsu",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 30, 10, 7, 55, 791, DateTimeKind.Local).AddTicks(2038), new DateTime(2022, 6, 30, 10, 7, 55, 791, DateTimeKind.Local).AddTicks(2038) });

            migrationBuilder.UpdateData(
                table: "M_SagyoShubetsu",
                keyColumn: "SagyoShubetsu",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 30, 10, 7, 55, 791, DateTimeKind.Local).AddTicks(2038), new DateTime(2022, 6, 30, 10, 7, 55, 791, DateTimeKind.Local).AddTicks(2038) });

            migrationBuilder.UpdateData(
                table: "M_SagyoShubetsu",
                keyColumn: "SagyoShubetsu",
                keyValue: 3,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 30, 10, 7, 55, 791, DateTimeKind.Local).AddTicks(2038), new DateTime(2022, 6, 30, 10, 7, 55, 791, DateTimeKind.Local).AddTicks(2038) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_T_SagyoBango",
                table: "T_SagyoBango");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Nengetsu",
                table: "T_SagyoBango",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_T_SagyoBango",
                table: "T_SagyoBango",
                columns: new[] { "Nengetsu", "Keito", "Kankatsu" });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 30, 9, 58, 26, 464, DateTimeKind.Local).AddTicks(55), new DateTime(2022, 6, 30, 9, 58, 26, 464, DateTimeKind.Local).AddTicks(55) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 30, 9, 58, 26, 464, DateTimeKind.Local).AddTicks(55), new DateTime(2022, 6, 30, 9, 58, 26, 464, DateTimeKind.Local).AddTicks(55) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 3,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 30, 9, 58, 26, 464, DateTimeKind.Local).AddTicks(55), new DateTime(2022, 6, 30, 9, 58, 26, 464, DateTimeKind.Local).AddTicks(55) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 4,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 30, 9, 58, 26, 464, DateTimeKind.Local).AddTicks(55), new DateTime(2022, 6, 30, 9, 58, 26, 464, DateTimeKind.Local).AddTicks(55) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 5,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 30, 9, 58, 26, 464, DateTimeKind.Local).AddTicks(55), new DateTime(2022, 6, 30, 9, 58, 26, 464, DateTimeKind.Local).AddTicks(55) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 6,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 30, 9, 58, 26, 464, DateTimeKind.Local).AddTicks(55), new DateTime(2022, 6, 30, 9, 58, 26, 464, DateTimeKind.Local).AddTicks(55) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 7,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 30, 9, 58, 26, 464, DateTimeKind.Local).AddTicks(55), new DateTime(2022, 6, 30, 9, 58, 26, 464, DateTimeKind.Local).AddTicks(55) });

            migrationBuilder.UpdateData(
                table: "M_Keito",
                keyColumn: "Keito",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 30, 9, 58, 26, 464, DateTimeKind.Local).AddTicks(55), new DateTime(2022, 6, 30, 9, 58, 26, 464, DateTimeKind.Local).AddTicks(55) });

            migrationBuilder.UpdateData(
                table: "M_Keito",
                keyColumn: "Keito",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 30, 9, 58, 26, 464, DateTimeKind.Local).AddTicks(55), new DateTime(2022, 6, 30, 9, 58, 26, 464, DateTimeKind.Local).AddTicks(55) });

            migrationBuilder.UpdateData(
                table: "M_Keito",
                keyColumn: "Keito",
                keyValue: 99,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 30, 9, 58, 26, 464, DateTimeKind.Local).AddTicks(55), new DateTime(2022, 6, 30, 9, 58, 26, 464, DateTimeKind.Local).AddTicks(55) });

            migrationBuilder.UpdateData(
                table: "M_SagyoBasho",
                keyColumn: "SagyoBasho",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 30, 9, 58, 26, 464, DateTimeKind.Local).AddTicks(55), new DateTime(2022, 6, 30, 9, 58, 26, 464, DateTimeKind.Local).AddTicks(55) });

            migrationBuilder.UpdateData(
                table: "M_SagyoBasho",
                keyColumn: "SagyoBasho",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 30, 9, 58, 26, 464, DateTimeKind.Local).AddTicks(55), new DateTime(2022, 6, 30, 9, 58, 26, 464, DateTimeKind.Local).AddTicks(55) });

            migrationBuilder.UpdateData(
                table: "M_SagyoBasho",
                keyColumn: "SagyoBasho",
                keyValue: 3,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 30, 9, 58, 26, 464, DateTimeKind.Local).AddTicks(55), new DateTime(2022, 6, 30, 9, 58, 26, 464, DateTimeKind.Local).AddTicks(55) });

            migrationBuilder.UpdateData(
                table: "M_SagyoShubetsu",
                keyColumn: "SagyoShubetsu",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 30, 9, 58, 26, 464, DateTimeKind.Local).AddTicks(55), new DateTime(2022, 6, 30, 9, 58, 26, 464, DateTimeKind.Local).AddTicks(55) });

            migrationBuilder.UpdateData(
                table: "M_SagyoShubetsu",
                keyColumn: "SagyoShubetsu",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 30, 9, 58, 26, 464, DateTimeKind.Local).AddTicks(55), new DateTime(2022, 6, 30, 9, 58, 26, 464, DateTimeKind.Local).AddTicks(55) });

            migrationBuilder.UpdateData(
                table: "M_SagyoShubetsu",
                keyColumn: "SagyoShubetsu",
                keyValue: 3,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 30, 9, 58, 26, 464, DateTimeKind.Local).AddTicks(55), new DateTime(2022, 6, 30, 9, 58, 26, 464, DateTimeKind.Local).AddTicks(55) });
        }
    }
}
