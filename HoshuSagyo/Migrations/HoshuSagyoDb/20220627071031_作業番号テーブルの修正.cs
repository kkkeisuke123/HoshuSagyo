using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HoshuSagyo.Migrations.HoshuSagyoDb
{
    public partial class 作業番号テーブルの修正 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SagyoKaishiBi",
                table: "T_SagyoBango",
                newName: "SagyoBi");

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 10, 31, 750, DateTimeKind.Local).AddTicks(6724), new DateTime(2022, 6, 27, 16, 10, 31, 750, DateTimeKind.Local).AddTicks(6724) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 10, 31, 750, DateTimeKind.Local).AddTicks(6724), new DateTime(2022, 6, 27, 16, 10, 31, 750, DateTimeKind.Local).AddTicks(6724) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 3,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 10, 31, 750, DateTimeKind.Local).AddTicks(6724), new DateTime(2022, 6, 27, 16, 10, 31, 750, DateTimeKind.Local).AddTicks(6724) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 4,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 10, 31, 750, DateTimeKind.Local).AddTicks(6724), new DateTime(2022, 6, 27, 16, 10, 31, 750, DateTimeKind.Local).AddTicks(6724) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 5,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 10, 31, 750, DateTimeKind.Local).AddTicks(6724), new DateTime(2022, 6, 27, 16, 10, 31, 750, DateTimeKind.Local).AddTicks(6724) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 6,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 10, 31, 750, DateTimeKind.Local).AddTicks(6724), new DateTime(2022, 6, 27, 16, 10, 31, 750, DateTimeKind.Local).AddTicks(6724) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 7,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 10, 31, 750, DateTimeKind.Local).AddTicks(6724), new DateTime(2022, 6, 27, 16, 10, 31, 750, DateTimeKind.Local).AddTicks(6724) });

            migrationBuilder.UpdateData(
                table: "M_Keito",
                keyColumn: "Keito",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 10, 31, 750, DateTimeKind.Local).AddTicks(6724), new DateTime(2022, 6, 27, 16, 10, 31, 750, DateTimeKind.Local).AddTicks(6724) });

            migrationBuilder.UpdateData(
                table: "M_Keito",
                keyColumn: "Keito",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 10, 31, 750, DateTimeKind.Local).AddTicks(6724), new DateTime(2022, 6, 27, 16, 10, 31, 750, DateTimeKind.Local).AddTicks(6724) });

            migrationBuilder.UpdateData(
                table: "M_Keito",
                keyColumn: "Keito",
                keyValue: 99,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 10, 31, 750, DateTimeKind.Local).AddTicks(6724), new DateTime(2022, 6, 27, 16, 10, 31, 750, DateTimeKind.Local).AddTicks(6724) });

            migrationBuilder.UpdateData(
                table: "M_SagyoBasho",
                keyColumn: "SagyoBasho",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 10, 31, 750, DateTimeKind.Local).AddTicks(6724), new DateTime(2022, 6, 27, 16, 10, 31, 750, DateTimeKind.Local).AddTicks(6724) });

            migrationBuilder.UpdateData(
                table: "M_SagyoBasho",
                keyColumn: "SagyoBasho",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 10, 31, 750, DateTimeKind.Local).AddTicks(6724), new DateTime(2022, 6, 27, 16, 10, 31, 750, DateTimeKind.Local).AddTicks(6724) });

            migrationBuilder.UpdateData(
                table: "M_SagyoBasho",
                keyColumn: "SagyoBasho",
                keyValue: 3,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 10, 31, 750, DateTimeKind.Local).AddTicks(6724), new DateTime(2022, 6, 27, 16, 10, 31, 750, DateTimeKind.Local).AddTicks(6724) });

            migrationBuilder.UpdateData(
                table: "M_SagyoShubetsu",
                keyColumn: "SagyoShubetsu",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 10, 31, 750, DateTimeKind.Local).AddTicks(6724), new DateTime(2022, 6, 27, 16, 10, 31, 750, DateTimeKind.Local).AddTicks(6724) });

            migrationBuilder.UpdateData(
                table: "M_SagyoShubetsu",
                keyColumn: "SagyoShubetsu",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 10, 31, 750, DateTimeKind.Local).AddTicks(6724), new DateTime(2022, 6, 27, 16, 10, 31, 750, DateTimeKind.Local).AddTicks(6724) });

            migrationBuilder.UpdateData(
                table: "M_SagyoShubetsu",
                keyColumn: "SagyoShubetsu",
                keyValue: 3,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 10, 31, 750, DateTimeKind.Local).AddTicks(6724), new DateTime(2022, 6, 27, 16, 10, 31, 750, DateTimeKind.Local).AddTicks(6724) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SagyoBi",
                table: "T_SagyoBango",
                newName: "SagyoKaishiBi");

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 27, 15, 12, 25, 733, DateTimeKind.Local).AddTicks(4244), new DateTime(2022, 6, 27, 15, 12, 25, 733, DateTimeKind.Local).AddTicks(4244) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 27, 15, 12, 25, 733, DateTimeKind.Local).AddTicks(4244), new DateTime(2022, 6, 27, 15, 12, 25, 733, DateTimeKind.Local).AddTicks(4244) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 3,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 27, 15, 12, 25, 733, DateTimeKind.Local).AddTicks(4244), new DateTime(2022, 6, 27, 15, 12, 25, 733, DateTimeKind.Local).AddTicks(4244) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 4,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 27, 15, 12, 25, 733, DateTimeKind.Local).AddTicks(4244), new DateTime(2022, 6, 27, 15, 12, 25, 733, DateTimeKind.Local).AddTicks(4244) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 5,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 27, 15, 12, 25, 733, DateTimeKind.Local).AddTicks(4244), new DateTime(2022, 6, 27, 15, 12, 25, 733, DateTimeKind.Local).AddTicks(4244) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 6,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 27, 15, 12, 25, 733, DateTimeKind.Local).AddTicks(4244), new DateTime(2022, 6, 27, 15, 12, 25, 733, DateTimeKind.Local).AddTicks(4244) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 7,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 27, 15, 12, 25, 733, DateTimeKind.Local).AddTicks(4244), new DateTime(2022, 6, 27, 15, 12, 25, 733, DateTimeKind.Local).AddTicks(4244) });

            migrationBuilder.UpdateData(
                table: "M_Keito",
                keyColumn: "Keito",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 27, 15, 12, 25, 733, DateTimeKind.Local).AddTicks(4244), new DateTime(2022, 6, 27, 15, 12, 25, 733, DateTimeKind.Local).AddTicks(4244) });

            migrationBuilder.UpdateData(
                table: "M_Keito",
                keyColumn: "Keito",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 27, 15, 12, 25, 733, DateTimeKind.Local).AddTicks(4244), new DateTime(2022, 6, 27, 15, 12, 25, 733, DateTimeKind.Local).AddTicks(4244) });

            migrationBuilder.UpdateData(
                table: "M_Keito",
                keyColumn: "Keito",
                keyValue: 99,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 27, 15, 12, 25, 733, DateTimeKind.Local).AddTicks(4244), new DateTime(2022, 6, 27, 15, 12, 25, 733, DateTimeKind.Local).AddTicks(4244) });

            migrationBuilder.UpdateData(
                table: "M_SagyoBasho",
                keyColumn: "SagyoBasho",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 27, 15, 12, 25, 733, DateTimeKind.Local).AddTicks(4244), new DateTime(2022, 6, 27, 15, 12, 25, 733, DateTimeKind.Local).AddTicks(4244) });

            migrationBuilder.UpdateData(
                table: "M_SagyoBasho",
                keyColumn: "SagyoBasho",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 27, 15, 12, 25, 733, DateTimeKind.Local).AddTicks(4244), new DateTime(2022, 6, 27, 15, 12, 25, 733, DateTimeKind.Local).AddTicks(4244) });

            migrationBuilder.UpdateData(
                table: "M_SagyoBasho",
                keyColumn: "SagyoBasho",
                keyValue: 3,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 27, 15, 12, 25, 733, DateTimeKind.Local).AddTicks(4244), new DateTime(2022, 6, 27, 15, 12, 25, 733, DateTimeKind.Local).AddTicks(4244) });

            migrationBuilder.UpdateData(
                table: "M_SagyoShubetsu",
                keyColumn: "SagyoShubetsu",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 27, 15, 12, 25, 733, DateTimeKind.Local).AddTicks(4244), new DateTime(2022, 6, 27, 15, 12, 25, 733, DateTimeKind.Local).AddTicks(4244) });

            migrationBuilder.UpdateData(
                table: "M_SagyoShubetsu",
                keyColumn: "SagyoShubetsu",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 27, 15, 12, 25, 733, DateTimeKind.Local).AddTicks(4244), new DateTime(2022, 6, 27, 15, 12, 25, 733, DateTimeKind.Local).AddTicks(4244) });

            migrationBuilder.UpdateData(
                table: "M_SagyoShubetsu",
                keyColumn: "SagyoShubetsu",
                keyValue: 3,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 27, 15, 12, 25, 733, DateTimeKind.Local).AddTicks(4244), new DateTime(2022, 6, 27, 15, 12, 25, 733, DateTimeKind.Local).AddTicks(4244) });
        }
    }
}
