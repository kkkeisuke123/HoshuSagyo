using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HoshuSagyo.Migrations.HoshuSagyoDb
{
    public partial class 作業番号テーブルを追加 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_T_Shimekiri",
                table: "T_Shimekiri");

            migrationBuilder.RenameTable(
                name: "T_Shimekiri",
                newName: "ShimekiriModel");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ShimekiriModel",
                table: "ShimekiriModel",
                columns: new[] { "Keito", "Kankatsu" });

            migrationBuilder.CreateTable(
                name: "SagyoBangoModel",
                columns: table => new
                {
                    SagyoKaishiBi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Keito = table.Column<int>(type: "int", nullable: false),
                    Kankatsu = table.Column<int>(type: "int", nullable: false),
                    SaishuBango = table.Column<int>(type: "int", nullable: false),
                    RegisterDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SagyoBangoModel", x => new { x.SagyoKaishiBi, x.Keito, x.Kankatsu });
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SagyoBangoModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ShimekiriModel",
                table: "ShimekiriModel");

            migrationBuilder.RenameTable(
                name: "ShimekiriModel",
                newName: "T_Shimekiri");

            migrationBuilder.AddPrimaryKey(
                name: "PK_T_Shimekiri",
                table: "T_Shimekiri",
                columns: new[] { "Keito", "Kankatsu" });

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
    }
}
