using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HoshuSagyo.Migrations.HoshuSagyoDb
{
    public partial class 締切テーブルの系統カラムを削除するために複合主キーから除外した : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "T_Shimekiri",
                columns: table => new
                {
                    ShimekiriZumiBi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Kankatsu = table.Column<int>(type: "int", nullable: false),
                    Keito = table.Column<int>(type: "int", nullable: false),
                    RegisterDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_Shimekiri", x => x.ShimekiriZumiBi);
                });

            migrationBuilder.DropPrimaryKey(
                name: "PK_T_Shimekiri",
                table: "T_Shimekiri");

            migrationBuilder.DropColumn(
                name: "Keito",
                table: "T_Shimekiri");

            migrationBuilder.AddColumn<string>(
                name: "Dummy",
                table: "T_Shimekiri",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_T_Shimekiri",
                table: "T_Shimekiri",
                column: "Dummy");

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 24, 23, 35, 16, 275, DateTimeKind.Local).AddTicks(4077), new DateTime(2022, 7, 24, 23, 35, 16, 275, DateTimeKind.Local).AddTicks(4077) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 24, 23, 35, 16, 275, DateTimeKind.Local).AddTicks(4077), new DateTime(2022, 7, 24, 23, 35, 16, 275, DateTimeKind.Local).AddTicks(4077) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 3,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 24, 23, 35, 16, 275, DateTimeKind.Local).AddTicks(4077), new DateTime(2022, 7, 24, 23, 35, 16, 275, DateTimeKind.Local).AddTicks(4077) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 4,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 24, 23, 35, 16, 275, DateTimeKind.Local).AddTicks(4077), new DateTime(2022, 7, 24, 23, 35, 16, 275, DateTimeKind.Local).AddTicks(4077) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 5,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 24, 23, 35, 16, 275, DateTimeKind.Local).AddTicks(4077), new DateTime(2022, 7, 24, 23, 35, 16, 275, DateTimeKind.Local).AddTicks(4077) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 6,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 24, 23, 35, 16, 275, DateTimeKind.Local).AddTicks(4077), new DateTime(2022, 7, 24, 23, 35, 16, 275, DateTimeKind.Local).AddTicks(4077) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 7,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 24, 23, 35, 16, 275, DateTimeKind.Local).AddTicks(4077), new DateTime(2022, 7, 24, 23, 35, 16, 275, DateTimeKind.Local).AddTicks(4077) });

            migrationBuilder.UpdateData(
                table: "M_Keito",
                keyColumn: "Keito",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 24, 23, 35, 16, 275, DateTimeKind.Local).AddTicks(4077), new DateTime(2022, 7, 24, 23, 35, 16, 275, DateTimeKind.Local).AddTicks(4077) });

            migrationBuilder.UpdateData(
                table: "M_Keito",
                keyColumn: "Keito",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 24, 23, 35, 16, 275, DateTimeKind.Local).AddTicks(4077), new DateTime(2022, 7, 24, 23, 35, 16, 275, DateTimeKind.Local).AddTicks(4077) });

            migrationBuilder.UpdateData(
                table: "M_Keito",
                keyColumn: "Keito",
                keyValue: 99,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 24, 23, 35, 16, 275, DateTimeKind.Local).AddTicks(4077), new DateTime(2022, 7, 24, 23, 35, 16, 275, DateTimeKind.Local).AddTicks(4077) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOto",
                keyColumn: "OtoShubetsu",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 24, 23, 35, 16, 275, DateTimeKind.Local).AddTicks(4077), new DateTime(2022, 7, 24, 23, 35, 16, 275, DateTimeKind.Local).AddTicks(4077) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOto",
                keyColumn: "OtoShubetsu",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 24, 23, 35, 16, 275, DateTimeKind.Local).AddTicks(4077), new DateTime(2022, 7, 24, 23, 35, 16, 275, DateTimeKind.Local).AddTicks(4077) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOto",
                keyColumn: "OtoShubetsu",
                keyValue: 3,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 24, 23, 35, 16, 275, DateTimeKind.Local).AddTicks(4077), new DateTime(2022, 7, 24, 23, 35, 16, 275, DateTimeKind.Local).AddTicks(4077) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOto",
                keyColumn: "OtoShubetsu",
                keyValue: 4,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 24, 23, 35, 16, 275, DateTimeKind.Local).AddTicks(4077), new DateTime(2022, 7, 24, 23, 35, 16, 275, DateTimeKind.Local).AddTicks(4077) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 24, 23, 35, 16, 275, DateTimeKind.Local).AddTicks(4077), new DateTime(2022, 7, 24, 23, 35, 16, 275, DateTimeKind.Local).AddTicks(4077) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 24, 23, 35, 16, 275, DateTimeKind.Local).AddTicks(4077), new DateTime(2022, 7, 24, 23, 35, 16, 275, DateTimeKind.Local).AddTicks(4077) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 24, 23, 35, 16, 275, DateTimeKind.Local).AddTicks(4077), new DateTime(2022, 7, 24, 23, 35, 16, 275, DateTimeKind.Local).AddTicks(4077) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 24, 23, 35, 16, 275, DateTimeKind.Local).AddTicks(4077), new DateTime(2022, 7, 24, 23, 35, 16, 275, DateTimeKind.Local).AddTicks(4077) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 24, 23, 35, 16, 275, DateTimeKind.Local).AddTicks(4077), new DateTime(2022, 7, 24, 23, 35, 16, 275, DateTimeKind.Local).AddTicks(4077) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 24, 23, 35, 16, 275, DateTimeKind.Local).AddTicks(4077), new DateTime(2022, 7, 24, 23, 35, 16, 275, DateTimeKind.Local).AddTicks(4077) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 24, 23, 35, 16, 275, DateTimeKind.Local).AddTicks(4077), new DateTime(2022, 7, 24, 23, 35, 16, 275, DateTimeKind.Local).AddTicks(4077) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 24, 23, 35, 16, 275, DateTimeKind.Local).AddTicks(4077), new DateTime(2022, 7, 24, 23, 35, 16, 275, DateTimeKind.Local).AddTicks(4077) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 24, 23, 35, 16, 275, DateTimeKind.Local).AddTicks(4077), new DateTime(2022, 7, 24, 23, 35, 16, 275, DateTimeKind.Local).AddTicks(4077) });

            migrationBuilder.UpdateData(
                table: "M_OnseiOtoShosai",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 24, 23, 35, 16, 275, DateTimeKind.Local).AddTicks(4077), new DateTime(2022, 7, 24, 23, 35, 16, 275, DateTimeKind.Local).AddTicks(4077) });

            migrationBuilder.UpdateData(
                table: "M_SagyoBasho",
                keyColumn: "SagyoBasho",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 24, 23, 35, 16, 275, DateTimeKind.Local).AddTicks(4077), new DateTime(2022, 7, 24, 23, 35, 16, 275, DateTimeKind.Local).AddTicks(4077) });

            migrationBuilder.UpdateData(
                table: "M_SagyoBasho",
                keyColumn: "SagyoBasho",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 24, 23, 35, 16, 275, DateTimeKind.Local).AddTicks(4077), new DateTime(2022, 7, 24, 23, 35, 16, 275, DateTimeKind.Local).AddTicks(4077) });

            migrationBuilder.UpdateData(
                table: "M_SagyoBasho",
                keyColumn: "SagyoBasho",
                keyValue: 3,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 24, 23, 35, 16, 275, DateTimeKind.Local).AddTicks(4077), new DateTime(2022, 7, 24, 23, 35, 16, 275, DateTimeKind.Local).AddTicks(4077) });

            migrationBuilder.UpdateData(
                table: "M_SagyoShubetsu",
                keyColumn: "SagyoShubetsu",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 24, 23, 35, 16, 275, DateTimeKind.Local).AddTicks(4077), new DateTime(2022, 7, 24, 23, 35, 16, 275, DateTimeKind.Local).AddTicks(4077) });

            migrationBuilder.UpdateData(
                table: "M_SagyoShubetsu",
                keyColumn: "SagyoShubetsu",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 24, 23, 35, 16, 275, DateTimeKind.Local).AddTicks(4077), new DateTime(2022, 7, 24, 23, 35, 16, 275, DateTimeKind.Local).AddTicks(4077) });

            migrationBuilder.UpdateData(
                table: "M_SagyoShubetsu",
                keyColumn: "SagyoShubetsu",
                keyValue: 3,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 24, 23, 35, 16, 275, DateTimeKind.Local).AddTicks(4077), new DateTime(2022, 7, 24, 23, 35, 16, 275, DateTimeKind.Local).AddTicks(4077) });

            migrationBuilder.UpdateData(
                table: "M_Shinchoku",
                keyColumn: "Shinchoku",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 24, 23, 35, 16, 275, DateTimeKind.Local).AddTicks(4077), new DateTime(2022, 7, 24, 23, 35, 16, 275, DateTimeKind.Local).AddTicks(4077) });

            migrationBuilder.UpdateData(
                table: "M_Shinchoku",
                keyColumn: "Shinchoku",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 24, 23, 35, 16, 275, DateTimeKind.Local).AddTicks(4077), new DateTime(2022, 7, 24, 23, 35, 16, 275, DateTimeKind.Local).AddTicks(4077) });

            migrationBuilder.UpdateData(
                table: "M_Shinchoku",
                keyColumn: "Shinchoku",
                keyValue: 3,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 24, 23, 35, 16, 275, DateTimeKind.Local).AddTicks(4077), new DateTime(2022, 7, 24, 23, 35, 16, 275, DateTimeKind.Local).AddTicks(4077) });

            migrationBuilder.UpdateData(
                table: "M_Shinchoku",
                keyColumn: "Shinchoku",
                keyValue: 4,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 24, 23, 35, 16, 275, DateTimeKind.Local).AddTicks(4077), new DateTime(2022, 7, 24, 23, 35, 16, 275, DateTimeKind.Local).AddTicks(4077) });

            migrationBuilder.UpdateData(
                table: "M_Shinchoku",
                keyColumn: "Shinchoku",
                keyValue: 5,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 24, 23, 35, 16, 275, DateTimeKind.Local).AddTicks(4077), new DateTime(2022, 7, 24, 23, 35, 16, 275, DateTimeKind.Local).AddTicks(4077) });

            migrationBuilder.UpdateData(
                table: "M_Shinchoku",
                keyColumn: "Shinchoku",
                keyValue: 6,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 7, 24, 23, 35, 16, 275, DateTimeKind.Local).AddTicks(4077), new DateTime(2022, 7, 24, 23, 35, 16, 275, DateTimeKind.Local).AddTicks(4077) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "T_Shimekiri");

            migrationBuilder.DropPrimaryKey(
                name: "PK_T_Shimekiri",
                table: "T_Shimekiri");

            migrationBuilder.DropColumn(
                name: "Dummy",
                table: "T_Shimekiri");

            migrationBuilder.AddColumn<int>(
                name: "Keito",
                table: "T_Shimekiri",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_T_Shimekiri",
                table: "T_Shimekiri",
                columns: new[] { "Keito", "Kankatsu" });

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
    }
}
