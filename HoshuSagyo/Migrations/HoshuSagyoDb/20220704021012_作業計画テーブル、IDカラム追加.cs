using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HoshuSagyo.Migrations.HoshuSagyoDb
{
    public partial class 作業計画テーブルIDカラム追加 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_T_SagyoKeikaku",
                table: "T_SagyoKeikaku");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "T_SagyoKeikaku",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_T_SagyoKeikaku",
                table: "T_SagyoKeikaku",
                columns: new[] { "Id", "SagyoKaishiNichiji", "Keito", "Kankatsu", "SagyoShubetsu", "SagyoBasho" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_T_SagyoKeikaku",
                table: "T_SagyoKeikaku");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "T_SagyoKeikaku");

            migrationBuilder.AddPrimaryKey(
                name: "PK_T_SagyoKeikaku",
                table: "T_SagyoKeikaku",
                columns: new[] { "SagyoKaishiNichiji", "Keito", "Kankatsu", "SagyoShubetsu", "SagyoBasho" });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 3, 21, 6, 21, 997, DateTimeKind.Local).AddTicks(5212), new DateTime(2022, 7, 3, 21, 6, 21, 997, DateTimeKind.Local).AddTicks(5212) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 3, 21, 6, 21, 997, DateTimeKind.Local).AddTicks(5212), new DateTime(2022, 7, 3, 21, 6, 21, 997, DateTimeKind.Local).AddTicks(5212) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 3,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 3, 21, 6, 21, 997, DateTimeKind.Local).AddTicks(5212), new DateTime(2022, 7, 3, 21, 6, 21, 997, DateTimeKind.Local).AddTicks(5212) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 4,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 3, 21, 6, 21, 997, DateTimeKind.Local).AddTicks(5212), new DateTime(2022, 7, 3, 21, 6, 21, 997, DateTimeKind.Local).AddTicks(5212) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 5,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 3, 21, 6, 21, 997, DateTimeKind.Local).AddTicks(5212), new DateTime(2022, 7, 3, 21, 6, 21, 997, DateTimeKind.Local).AddTicks(5212) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 6,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 3, 21, 6, 21, 997, DateTimeKind.Local).AddTicks(5212), new DateTime(2022, 7, 3, 21, 6, 21, 997, DateTimeKind.Local).AddTicks(5212) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 7,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 3, 21, 6, 21, 997, DateTimeKind.Local).AddTicks(5212), new DateTime(2022, 7, 3, 21, 6, 21, 997, DateTimeKind.Local).AddTicks(5212) });

            migrationBuilder.UpdateData(
                table: "M_Keito",
                keyColumn: "Keito",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 3, 21, 6, 21, 997, DateTimeKind.Local).AddTicks(5212), new DateTime(2022, 7, 3, 21, 6, 21, 997, DateTimeKind.Local).AddTicks(5212) });

            migrationBuilder.UpdateData(
                table: "M_Keito",
                keyColumn: "Keito",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 3, 21, 6, 21, 997, DateTimeKind.Local).AddTicks(5212), new DateTime(2022, 7, 3, 21, 6, 21, 997, DateTimeKind.Local).AddTicks(5212) });

            migrationBuilder.UpdateData(
                table: "M_Keito",
                keyColumn: "Keito",
                keyValue: 99,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 3, 21, 6, 21, 997, DateTimeKind.Local).AddTicks(5212), new DateTime(2022, 7, 3, 21, 6, 21, 997, DateTimeKind.Local).AddTicks(5212) });

            migrationBuilder.UpdateData(
                table: "M_SagyoBasho",
                keyColumn: "SagyoBasho",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 3, 21, 6, 21, 997, DateTimeKind.Local).AddTicks(5212), new DateTime(2022, 7, 3, 21, 6, 21, 997, DateTimeKind.Local).AddTicks(5212) });

            migrationBuilder.UpdateData(
                table: "M_SagyoBasho",
                keyColumn: "SagyoBasho",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 3, 21, 6, 21, 997, DateTimeKind.Local).AddTicks(5212), new DateTime(2022, 7, 3, 21, 6, 21, 997, DateTimeKind.Local).AddTicks(5212) });

            migrationBuilder.UpdateData(
                table: "M_SagyoBasho",
                keyColumn: "SagyoBasho",
                keyValue: 3,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 3, 21, 6, 21, 997, DateTimeKind.Local).AddTicks(5212), new DateTime(2022, 7, 3, 21, 6, 21, 997, DateTimeKind.Local).AddTicks(5212) });

            migrationBuilder.UpdateData(
                table: "M_SagyoShubetsu",
                keyColumn: "SagyoShubetsu",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 3, 21, 6, 21, 997, DateTimeKind.Local).AddTicks(5212), new DateTime(2022, 7, 3, 21, 6, 21, 997, DateTimeKind.Local).AddTicks(5212) });

            migrationBuilder.UpdateData(
                table: "M_SagyoShubetsu",
                keyColumn: "SagyoShubetsu",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 3, 21, 6, 21, 997, DateTimeKind.Local).AddTicks(5212), new DateTime(2022, 7, 3, 21, 6, 21, 997, DateTimeKind.Local).AddTicks(5212) });

            migrationBuilder.UpdateData(
                table: "M_SagyoShubetsu",
                keyColumn: "SagyoShubetsu",
                keyValue: 3,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 3, 21, 6, 21, 997, DateTimeKind.Local).AddTicks(5212), new DateTime(2022, 7, 3, 21, 6, 21, 997, DateTimeKind.Local).AddTicks(5212) });
        }
    }
}
