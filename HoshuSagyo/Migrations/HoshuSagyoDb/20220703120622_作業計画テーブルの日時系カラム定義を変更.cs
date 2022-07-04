using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HoshuSagyo.Migrations.HoshuSagyoDb
{
    public partial class 作業計画テーブルの日時系カラム定義を変更 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_T_SagyoKeikaku",
                table: "T_SagyoKeikaku");

            migrationBuilder.DropColumn(
                name: "SagyoKaishiBi",
                table: "T_SagyoKeikaku");

            migrationBuilder.DropColumn(
                name: "SagyoKaishiJikan",
                table: "T_SagyoKeikaku");

            migrationBuilder.DropColumn(
                name: "SagyoShuryoBi",
                table: "T_SagyoKeikaku");

            migrationBuilder.DropColumn(
                name: "SagyoShuryoJikan",
                table: "T_SagyoKeikaku");

            migrationBuilder.AddColumn<DateTime>(
                name: "SagyoKaishiNichiji",
                table: "T_SagyoKeikaku",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "SagyoShuryoNichiji",
                table: "T_SagyoKeikaku",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_T_SagyoKeikaku",
                table: "T_SagyoKeikaku");

            migrationBuilder.DropColumn(
                name: "SagyoKaishiNichiji",
                table: "T_SagyoKeikaku");

            migrationBuilder.DropColumn(
                name: "SagyoShuryoNichiji",
                table: "T_SagyoKeikaku");

            migrationBuilder.AddColumn<string>(
                name: "SagyoKaishiBi",
                table: "T_SagyoKeikaku",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SagyoKaishiJikan",
                table: "T_SagyoKeikaku",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SagyoShuryoBi",
                table: "T_SagyoKeikaku",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SagyoShuryoJikan",
                table: "T_SagyoKeikaku",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_T_SagyoKeikaku",
                table: "T_SagyoKeikaku",
                columns: new[] { "SagyoKaishiBi", "Keito", "Kankatsu", "SagyoShubetsu", "SagyoBasho" });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 30, 10, 9, 1, 767, DateTimeKind.Local).AddTicks(2222), new DateTime(2022, 6, 30, 10, 9, 1, 767, DateTimeKind.Local).AddTicks(2222) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 30, 10, 9, 1, 767, DateTimeKind.Local).AddTicks(2222), new DateTime(2022, 6, 30, 10, 9, 1, 767, DateTimeKind.Local).AddTicks(2222) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 3,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 30, 10, 9, 1, 767, DateTimeKind.Local).AddTicks(2222), new DateTime(2022, 6, 30, 10, 9, 1, 767, DateTimeKind.Local).AddTicks(2222) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 4,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 30, 10, 9, 1, 767, DateTimeKind.Local).AddTicks(2222), new DateTime(2022, 6, 30, 10, 9, 1, 767, DateTimeKind.Local).AddTicks(2222) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 5,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 30, 10, 9, 1, 767, DateTimeKind.Local).AddTicks(2222), new DateTime(2022, 6, 30, 10, 9, 1, 767, DateTimeKind.Local).AddTicks(2222) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 6,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 30, 10, 9, 1, 767, DateTimeKind.Local).AddTicks(2222), new DateTime(2022, 6, 30, 10, 9, 1, 767, DateTimeKind.Local).AddTicks(2222) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 7,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 30, 10, 9, 1, 767, DateTimeKind.Local).AddTicks(2222), new DateTime(2022, 6, 30, 10, 9, 1, 767, DateTimeKind.Local).AddTicks(2222) });

            migrationBuilder.UpdateData(
                table: "M_Keito",
                keyColumn: "Keito",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 30, 10, 9, 1, 767, DateTimeKind.Local).AddTicks(2222), new DateTime(2022, 6, 30, 10, 9, 1, 767, DateTimeKind.Local).AddTicks(2222) });

            migrationBuilder.UpdateData(
                table: "M_Keito",
                keyColumn: "Keito",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 30, 10, 9, 1, 767, DateTimeKind.Local).AddTicks(2222), new DateTime(2022, 6, 30, 10, 9, 1, 767, DateTimeKind.Local).AddTicks(2222) });

            migrationBuilder.UpdateData(
                table: "M_Keito",
                keyColumn: "Keito",
                keyValue: 99,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 30, 10, 9, 1, 767, DateTimeKind.Local).AddTicks(2222), new DateTime(2022, 6, 30, 10, 9, 1, 767, DateTimeKind.Local).AddTicks(2222) });

            migrationBuilder.UpdateData(
                table: "M_SagyoBasho",
                keyColumn: "SagyoBasho",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 30, 10, 9, 1, 767, DateTimeKind.Local).AddTicks(2222), new DateTime(2022, 6, 30, 10, 9, 1, 767, DateTimeKind.Local).AddTicks(2222) });

            migrationBuilder.UpdateData(
                table: "M_SagyoBasho",
                keyColumn: "SagyoBasho",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 30, 10, 9, 1, 767, DateTimeKind.Local).AddTicks(2222), new DateTime(2022, 6, 30, 10, 9, 1, 767, DateTimeKind.Local).AddTicks(2222) });

            migrationBuilder.UpdateData(
                table: "M_SagyoBasho",
                keyColumn: "SagyoBasho",
                keyValue: 3,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 30, 10, 9, 1, 767, DateTimeKind.Local).AddTicks(2222), new DateTime(2022, 6, 30, 10, 9, 1, 767, DateTimeKind.Local).AddTicks(2222) });

            migrationBuilder.UpdateData(
                table: "M_SagyoShubetsu",
                keyColumn: "SagyoShubetsu",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 30, 10, 9, 1, 767, DateTimeKind.Local).AddTicks(2222), new DateTime(2022, 6, 30, 10, 9, 1, 767, DateTimeKind.Local).AddTicks(2222) });

            migrationBuilder.UpdateData(
                table: "M_SagyoShubetsu",
                keyColumn: "SagyoShubetsu",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 30, 10, 9, 1, 767, DateTimeKind.Local).AddTicks(2222), new DateTime(2022, 6, 30, 10, 9, 1, 767, DateTimeKind.Local).AddTicks(2222) });

            migrationBuilder.UpdateData(
                table: "M_SagyoShubetsu",
                keyColumn: "SagyoShubetsu",
                keyValue: 3,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 30, 10, 9, 1, 767, DateTimeKind.Local).AddTicks(2222), new DateTime(2022, 6, 30, 10, 9, 1, 767, DateTimeKind.Local).AddTicks(2222) });
        }
    }
}
