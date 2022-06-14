using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HoshuSagyo.Migrations.HoshuSagyoDb
{
    public partial class 締切情報テーブルの主キーを変更した : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_T_Shimekiri",
                table: "T_Shimekiri");

            migrationBuilder.AddPrimaryKey(
                name: "PK_T_Shimekiri",
                table: "T_Shimekiri",
                columns: new[] { "Keito", "Kankatsu" });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 10, 20, 51, 5, 492, DateTimeKind.Local).AddTicks(5713), new DateTime(2022, 6, 10, 20, 51, 5, 492, DateTimeKind.Local).AddTicks(5713) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 10, 20, 51, 5, 492, DateTimeKind.Local).AddTicks(5713), new DateTime(2022, 6, 10, 20, 51, 5, 492, DateTimeKind.Local).AddTicks(5713) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 3,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 10, 20, 51, 5, 492, DateTimeKind.Local).AddTicks(5713), new DateTime(2022, 6, 10, 20, 51, 5, 492, DateTimeKind.Local).AddTicks(5713) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 4,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 10, 20, 51, 5, 492, DateTimeKind.Local).AddTicks(5713), new DateTime(2022, 6, 10, 20, 51, 5, 492, DateTimeKind.Local).AddTicks(5713) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 5,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 10, 20, 51, 5, 492, DateTimeKind.Local).AddTicks(5713), new DateTime(2022, 6, 10, 20, 51, 5, 492, DateTimeKind.Local).AddTicks(5713) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 6,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 10, 20, 51, 5, 492, DateTimeKind.Local).AddTicks(5713), new DateTime(2022, 6, 10, 20, 51, 5, 492, DateTimeKind.Local).AddTicks(5713) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 7,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 10, 20, 51, 5, 492, DateTimeKind.Local).AddTicks(5713), new DateTime(2022, 6, 10, 20, 51, 5, 492, DateTimeKind.Local).AddTicks(5713) });

            migrationBuilder.UpdateData(
                table: "M_Keito",
                keyColumn: "Keito",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 10, 20, 51, 5, 492, DateTimeKind.Local).AddTicks(5713), new DateTime(2022, 6, 10, 20, 51, 5, 492, DateTimeKind.Local).AddTicks(5713) });

            migrationBuilder.UpdateData(
                table: "M_Keito",
                keyColumn: "Keito",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 10, 20, 51, 5, 492, DateTimeKind.Local).AddTicks(5713), new DateTime(2022, 6, 10, 20, 51, 5, 492, DateTimeKind.Local).AddTicks(5713) });

            migrationBuilder.UpdateData(
                table: "M_Keito",
                keyColumn: "Keito",
                keyValue: 99,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 10, 20, 51, 5, 492, DateTimeKind.Local).AddTicks(5713), new DateTime(2022, 6, 10, 20, 51, 5, 492, DateTimeKind.Local).AddTicks(5713) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_T_Shimekiri",
                table: "T_Shimekiri");

            migrationBuilder.AddPrimaryKey(
                name: "PK_T_Shimekiri",
                table: "T_Shimekiri",
                column: "ShimekiriZumiBi");

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 5, 1, 18, 4, 108, DateTimeKind.Local).AddTicks(9099), new DateTime(2022, 6, 5, 1, 18, 4, 108, DateTimeKind.Local).AddTicks(9099) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 5, 1, 18, 4, 108, DateTimeKind.Local).AddTicks(9099), new DateTime(2022, 6, 5, 1, 18, 4, 108, DateTimeKind.Local).AddTicks(9099) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 3,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 5, 1, 18, 4, 108, DateTimeKind.Local).AddTicks(9099), new DateTime(2022, 6, 5, 1, 18, 4, 108, DateTimeKind.Local).AddTicks(9099) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 4,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 5, 1, 18, 4, 108, DateTimeKind.Local).AddTicks(9099), new DateTime(2022, 6, 5, 1, 18, 4, 108, DateTimeKind.Local).AddTicks(9099) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 5,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 5, 1, 18, 4, 108, DateTimeKind.Local).AddTicks(9099), new DateTime(2022, 6, 5, 1, 18, 4, 108, DateTimeKind.Local).AddTicks(9099) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 6,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 5, 1, 18, 4, 108, DateTimeKind.Local).AddTicks(9099), new DateTime(2022, 6, 5, 1, 18, 4, 108, DateTimeKind.Local).AddTicks(9099) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 7,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 5, 1, 18, 4, 108, DateTimeKind.Local).AddTicks(9099), new DateTime(2022, 6, 5, 1, 18, 4, 108, DateTimeKind.Local).AddTicks(9099) });

            migrationBuilder.UpdateData(
                table: "M_Keito",
                keyColumn: "Keito",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 5, 1, 18, 4, 108, DateTimeKind.Local).AddTicks(9099), new DateTime(2022, 6, 5, 1, 18, 4, 108, DateTimeKind.Local).AddTicks(9099) });

            migrationBuilder.UpdateData(
                table: "M_Keito",
                keyColumn: "Keito",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 5, 1, 18, 4, 108, DateTimeKind.Local).AddTicks(9099), new DateTime(2022, 6, 5, 1, 18, 4, 108, DateTimeKind.Local).AddTicks(9099) });

            migrationBuilder.UpdateData(
                table: "M_Keito",
                keyColumn: "Keito",
                keyValue: 99,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 5, 1, 18, 4, 108, DateTimeKind.Local).AddTicks(9099), new DateTime(2022, 6, 5, 1, 18, 4, 108, DateTimeKind.Local).AddTicks(9099) });
        }
    }
}
