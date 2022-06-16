using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HoshuSagyo.Migrations.HoshuSagyoDb
{
    public partial class 締切情報テーブル定義修正 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ShimekiriZumiBi",
                table: "T_Shimekiri",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 16, 15, 14, 56, 993, DateTimeKind.Local).AddTicks(2096), new DateTime(2022, 6, 16, 15, 14, 56, 993, DateTimeKind.Local).AddTicks(2096) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 16, 15, 14, 56, 993, DateTimeKind.Local).AddTicks(2096), new DateTime(2022, 6, 16, 15, 14, 56, 993, DateTimeKind.Local).AddTicks(2096) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 3,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 16, 15, 14, 56, 993, DateTimeKind.Local).AddTicks(2096), new DateTime(2022, 6, 16, 15, 14, 56, 993, DateTimeKind.Local).AddTicks(2096) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 4,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 16, 15, 14, 56, 993, DateTimeKind.Local).AddTicks(2096), new DateTime(2022, 6, 16, 15, 14, 56, 993, DateTimeKind.Local).AddTicks(2096) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 5,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 16, 15, 14, 56, 993, DateTimeKind.Local).AddTicks(2096), new DateTime(2022, 6, 16, 15, 14, 56, 993, DateTimeKind.Local).AddTicks(2096) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 6,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 16, 15, 14, 56, 993, DateTimeKind.Local).AddTicks(2096), new DateTime(2022, 6, 16, 15, 14, 56, 993, DateTimeKind.Local).AddTicks(2096) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 7,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 16, 15, 14, 56, 993, DateTimeKind.Local).AddTicks(2096), new DateTime(2022, 6, 16, 15, 14, 56, 993, DateTimeKind.Local).AddTicks(2096) });

            migrationBuilder.UpdateData(
                table: "M_Keito",
                keyColumn: "Keito",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 16, 15, 14, 56, 993, DateTimeKind.Local).AddTicks(2096), new DateTime(2022, 6, 16, 15, 14, 56, 993, DateTimeKind.Local).AddTicks(2096) });

            migrationBuilder.UpdateData(
                table: "M_Keito",
                keyColumn: "Keito",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 16, 15, 14, 56, 993, DateTimeKind.Local).AddTicks(2096), new DateTime(2022, 6, 16, 15, 14, 56, 993, DateTimeKind.Local).AddTicks(2096) });

            migrationBuilder.UpdateData(
                table: "M_Keito",
                keyColumn: "Keito",
                keyValue: 99,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 16, 15, 14, 56, 993, DateTimeKind.Local).AddTicks(2096), new DateTime(2022, 6, 16, 15, 14, 56, 993, DateTimeKind.Local).AddTicks(2096) });

            migrationBuilder.UpdateData(
                table: "M_SagyoBasho",
                keyColumn: "SagyoBasho",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 16, 15, 14, 56, 993, DateTimeKind.Local).AddTicks(2096), new DateTime(2022, 6, 16, 15, 14, 56, 993, DateTimeKind.Local).AddTicks(2096) });

            migrationBuilder.UpdateData(
                table: "M_SagyoBasho",
                keyColumn: "SagyoBasho",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 16, 15, 14, 56, 993, DateTimeKind.Local).AddTicks(2096), new DateTime(2022, 6, 16, 15, 14, 56, 993, DateTimeKind.Local).AddTicks(2096) });

            migrationBuilder.UpdateData(
                table: "M_SagyoBasho",
                keyColumn: "SagyoBasho",
                keyValue: 3,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 16, 15, 14, 56, 993, DateTimeKind.Local).AddTicks(2096), new DateTime(2022, 6, 16, 15, 14, 56, 993, DateTimeKind.Local).AddTicks(2096) });

            migrationBuilder.UpdateData(
                table: "M_SagyoShubetsu",
                keyColumn: "SagyoShubetsu",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 16, 15, 14, 56, 993, DateTimeKind.Local).AddTicks(2096), new DateTime(2022, 6, 16, 15, 14, 56, 993, DateTimeKind.Local).AddTicks(2096) });

            migrationBuilder.UpdateData(
                table: "M_SagyoShubetsu",
                keyColumn: "SagyoShubetsu",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 16, 15, 14, 56, 993, DateTimeKind.Local).AddTicks(2096), new DateTime(2022, 6, 16, 15, 14, 56, 993, DateTimeKind.Local).AddTicks(2096) });

            migrationBuilder.UpdateData(
                table: "M_SagyoShubetsu",
                keyColumn: "SagyoShubetsu",
                keyValue: 3,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 16, 15, 14, 56, 993, DateTimeKind.Local).AddTicks(2096), new DateTime(2022, 6, 16, 15, 14, 56, 993, DateTimeKind.Local).AddTicks(2096) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ShimekiriZumiBi",
                table: "T_Shimekiri",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 16, 15, 11, 42, 621, DateTimeKind.Local).AddTicks(8403), new DateTime(2022, 6, 16, 15, 11, 42, 621, DateTimeKind.Local).AddTicks(8403) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 16, 15, 11, 42, 621, DateTimeKind.Local).AddTicks(8403), new DateTime(2022, 6, 16, 15, 11, 42, 621, DateTimeKind.Local).AddTicks(8403) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 3,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 16, 15, 11, 42, 621, DateTimeKind.Local).AddTicks(8403), new DateTime(2022, 6, 16, 15, 11, 42, 621, DateTimeKind.Local).AddTicks(8403) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 4,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 16, 15, 11, 42, 621, DateTimeKind.Local).AddTicks(8403), new DateTime(2022, 6, 16, 15, 11, 42, 621, DateTimeKind.Local).AddTicks(8403) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 5,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 16, 15, 11, 42, 621, DateTimeKind.Local).AddTicks(8403), new DateTime(2022, 6, 16, 15, 11, 42, 621, DateTimeKind.Local).AddTicks(8403) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 6,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 16, 15, 11, 42, 621, DateTimeKind.Local).AddTicks(8403), new DateTime(2022, 6, 16, 15, 11, 42, 621, DateTimeKind.Local).AddTicks(8403) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 7,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 16, 15, 11, 42, 621, DateTimeKind.Local).AddTicks(8403), new DateTime(2022, 6, 16, 15, 11, 42, 621, DateTimeKind.Local).AddTicks(8403) });

            migrationBuilder.UpdateData(
                table: "M_Keito",
                keyColumn: "Keito",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 16, 15, 11, 42, 621, DateTimeKind.Local).AddTicks(8403), new DateTime(2022, 6, 16, 15, 11, 42, 621, DateTimeKind.Local).AddTicks(8403) });

            migrationBuilder.UpdateData(
                table: "M_Keito",
                keyColumn: "Keito",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 16, 15, 11, 42, 621, DateTimeKind.Local).AddTicks(8403), new DateTime(2022, 6, 16, 15, 11, 42, 621, DateTimeKind.Local).AddTicks(8403) });

            migrationBuilder.UpdateData(
                table: "M_Keito",
                keyColumn: "Keito",
                keyValue: 99,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 16, 15, 11, 42, 621, DateTimeKind.Local).AddTicks(8403), new DateTime(2022, 6, 16, 15, 11, 42, 621, DateTimeKind.Local).AddTicks(8403) });

            migrationBuilder.UpdateData(
                table: "M_SagyoBasho",
                keyColumn: "SagyoBasho",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 16, 15, 11, 42, 621, DateTimeKind.Local).AddTicks(8403), new DateTime(2022, 6, 16, 15, 11, 42, 621, DateTimeKind.Local).AddTicks(8403) });

            migrationBuilder.UpdateData(
                table: "M_SagyoBasho",
                keyColumn: "SagyoBasho",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 16, 15, 11, 42, 621, DateTimeKind.Local).AddTicks(8403), new DateTime(2022, 6, 16, 15, 11, 42, 621, DateTimeKind.Local).AddTicks(8403) });

            migrationBuilder.UpdateData(
                table: "M_SagyoBasho",
                keyColumn: "SagyoBasho",
                keyValue: 3,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 16, 15, 11, 42, 621, DateTimeKind.Local).AddTicks(8403), new DateTime(2022, 6, 16, 15, 11, 42, 621, DateTimeKind.Local).AddTicks(8403) });

            migrationBuilder.UpdateData(
                table: "M_SagyoShubetsu",
                keyColumn: "SagyoShubetsu",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 16, 15, 11, 42, 621, DateTimeKind.Local).AddTicks(8403), new DateTime(2022, 6, 16, 15, 11, 42, 621, DateTimeKind.Local).AddTicks(8403) });

            migrationBuilder.UpdateData(
                table: "M_SagyoShubetsu",
                keyColumn: "SagyoShubetsu",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 16, 15, 11, 42, 621, DateTimeKind.Local).AddTicks(8403), new DateTime(2022, 6, 16, 15, 11, 42, 621, DateTimeKind.Local).AddTicks(8403) });

            migrationBuilder.UpdateData(
                table: "M_SagyoShubetsu",
                keyColumn: "SagyoShubetsu",
                keyValue: 3,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 16, 15, 11, 42, 621, DateTimeKind.Local).AddTicks(8403), new DateTime(2022, 6, 16, 15, 11, 42, 621, DateTimeKind.Local).AddTicks(8403) });
        }
    }
}
