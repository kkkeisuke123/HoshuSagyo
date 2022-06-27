using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HoshuSagyo.Migrations.HoshuSagyoDb
{
    public partial class DBContextの修正 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ShimekiriModel",
                table: "ShimekiriModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SagyoBangoModel",
                table: "SagyoBangoModel");

            migrationBuilder.RenameTable(
                name: "ShimekiriModel",
                newName: "T_Shimekiri");

            migrationBuilder.RenameTable(
                name: "SagyoBangoModel",
                newName: "T_SagyoBango");

            migrationBuilder.AddPrimaryKey(
                name: "PK_T_Shimekiri",
                table: "T_Shimekiri",
                columns: new[] { "Keito", "Kankatsu" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_T_SagyoBango",
                table: "T_SagyoBango",
                columns: new[] { "SagyoKaishiBi", "Keito", "Kankatsu" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_T_Shimekiri",
                table: "T_Shimekiri");

            migrationBuilder.DropPrimaryKey(
                name: "PK_T_SagyoBango",
                table: "T_SagyoBango");

            migrationBuilder.RenameTable(
                name: "T_Shimekiri",
                newName: "ShimekiriModel");

            migrationBuilder.RenameTable(
                name: "T_SagyoBango",
                newName: "SagyoBangoModel");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ShimekiriModel",
                table: "ShimekiriModel",
                columns: new[] { "Keito", "Kankatsu" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_SagyoBangoModel",
                table: "SagyoBangoModel",
                columns: new[] { "SagyoKaishiBi", "Keito", "Kankatsu" });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 27, 15, 6, 0, 852, DateTimeKind.Local).AddTicks(1731), new DateTime(2022, 6, 27, 15, 6, 0, 852, DateTimeKind.Local).AddTicks(1731) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 27, 15, 6, 0, 852, DateTimeKind.Local).AddTicks(1731), new DateTime(2022, 6, 27, 15, 6, 0, 852, DateTimeKind.Local).AddTicks(1731) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 3,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 27, 15, 6, 0, 852, DateTimeKind.Local).AddTicks(1731), new DateTime(2022, 6, 27, 15, 6, 0, 852, DateTimeKind.Local).AddTicks(1731) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 4,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 27, 15, 6, 0, 852, DateTimeKind.Local).AddTicks(1731), new DateTime(2022, 6, 27, 15, 6, 0, 852, DateTimeKind.Local).AddTicks(1731) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 5,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 27, 15, 6, 0, 852, DateTimeKind.Local).AddTicks(1731), new DateTime(2022, 6, 27, 15, 6, 0, 852, DateTimeKind.Local).AddTicks(1731) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 6,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 27, 15, 6, 0, 852, DateTimeKind.Local).AddTicks(1731), new DateTime(2022, 6, 27, 15, 6, 0, 852, DateTimeKind.Local).AddTicks(1731) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 7,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 27, 15, 6, 0, 852, DateTimeKind.Local).AddTicks(1731), new DateTime(2022, 6, 27, 15, 6, 0, 852, DateTimeKind.Local).AddTicks(1731) });

            migrationBuilder.UpdateData(
                table: "M_Keito",
                keyColumn: "Keito",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 27, 15, 6, 0, 852, DateTimeKind.Local).AddTicks(1731), new DateTime(2022, 6, 27, 15, 6, 0, 852, DateTimeKind.Local).AddTicks(1731) });

            migrationBuilder.UpdateData(
                table: "M_Keito",
                keyColumn: "Keito",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 27, 15, 6, 0, 852, DateTimeKind.Local).AddTicks(1731), new DateTime(2022, 6, 27, 15, 6, 0, 852, DateTimeKind.Local).AddTicks(1731) });

            migrationBuilder.UpdateData(
                table: "M_Keito",
                keyColumn: "Keito",
                keyValue: 99,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 27, 15, 6, 0, 852, DateTimeKind.Local).AddTicks(1731), new DateTime(2022, 6, 27, 15, 6, 0, 852, DateTimeKind.Local).AddTicks(1731) });

            migrationBuilder.UpdateData(
                table: "M_SagyoBasho",
                keyColumn: "SagyoBasho",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 27, 15, 6, 0, 852, DateTimeKind.Local).AddTicks(1731), new DateTime(2022, 6, 27, 15, 6, 0, 852, DateTimeKind.Local).AddTicks(1731) });

            migrationBuilder.UpdateData(
                table: "M_SagyoBasho",
                keyColumn: "SagyoBasho",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 27, 15, 6, 0, 852, DateTimeKind.Local).AddTicks(1731), new DateTime(2022, 6, 27, 15, 6, 0, 852, DateTimeKind.Local).AddTicks(1731) });

            migrationBuilder.UpdateData(
                table: "M_SagyoBasho",
                keyColumn: "SagyoBasho",
                keyValue: 3,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 27, 15, 6, 0, 852, DateTimeKind.Local).AddTicks(1731), new DateTime(2022, 6, 27, 15, 6, 0, 852, DateTimeKind.Local).AddTicks(1731) });

            migrationBuilder.UpdateData(
                table: "M_SagyoShubetsu",
                keyColumn: "SagyoShubetsu",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 27, 15, 6, 0, 852, DateTimeKind.Local).AddTicks(1731), new DateTime(2022, 6, 27, 15, 6, 0, 852, DateTimeKind.Local).AddTicks(1731) });

            migrationBuilder.UpdateData(
                table: "M_SagyoShubetsu",
                keyColumn: "SagyoShubetsu",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 27, 15, 6, 0, 852, DateTimeKind.Local).AddTicks(1731), new DateTime(2022, 6, 27, 15, 6, 0, 852, DateTimeKind.Local).AddTicks(1731) });

            migrationBuilder.UpdateData(
                table: "M_SagyoShubetsu",
                keyColumn: "SagyoShubetsu",
                keyValue: 3,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 27, 15, 6, 0, 852, DateTimeKind.Local).AddTicks(1731), new DateTime(2022, 6, 27, 15, 6, 0, 852, DateTimeKind.Local).AddTicks(1731) });
        }
    }
}
