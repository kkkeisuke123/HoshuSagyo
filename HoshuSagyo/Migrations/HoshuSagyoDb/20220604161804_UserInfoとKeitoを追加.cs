using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HoshuSagyo.Migrations.HoshuSagyoDb
{
    public partial class UserInfoとKeitoを追加 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "M_Keito",
                columns: table => new
                {
                    Keito = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KeitoName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegisterDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_Keito", x => x.Keito);
                });

            migrationBuilder.CreateTable(
                name: "M_UserInfo",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Keito = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kankatsu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegisterDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_UserInfo", x => x.UserId);
                });

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

            migrationBuilder.InsertData(
                table: "M_Keito",
                columns: new[] { "Keito", "KeitoName", "RegisterDateTime", "UpdateDateTime" },
                values: new object[,]
                {
                    { 1, "指令", new DateTime(2022, 6, 5, 1, 18, 4, 108, DateTimeKind.Local).AddTicks(9099), new DateTime(2022, 6, 5, 1, 18, 4, 108, DateTimeKind.Local).AddTicks(9099) },
                    { 2, "現地", new DateTime(2022, 6, 5, 1, 18, 4, 108, DateTimeKind.Local).AddTicks(9099), new DateTime(2022, 6, 5, 1, 18, 4, 108, DateTimeKind.Local).AddTicks(9099) },
                    { 99, "未定", new DateTime(2022, 6, 5, 1, 18, 4, 108, DateTimeKind.Local).AddTicks(9099), new DateTime(2022, 6, 5, 1, 18, 4, 108, DateTimeKind.Local).AddTicks(9099) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "M_Keito");

            migrationBuilder.DropTable(
                name: "M_UserInfo");

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 1,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 1, 2, 45, 15, 71, DateTimeKind.Local).AddTicks(5793), new DateTime(2022, 6, 1, 2, 45, 15, 71, DateTimeKind.Local).AddTicks(5793) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 2,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 1, 2, 45, 15, 71, DateTimeKind.Local).AddTicks(5793), new DateTime(2022, 6, 1, 2, 45, 15, 71, DateTimeKind.Local).AddTicks(5793) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 3,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 1, 2, 45, 15, 71, DateTimeKind.Local).AddTicks(5793), new DateTime(2022, 6, 1, 2, 45, 15, 71, DateTimeKind.Local).AddTicks(5793) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 4,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 1, 2, 45, 15, 71, DateTimeKind.Local).AddTicks(5793), new DateTime(2022, 6, 1, 2, 45, 15, 71, DateTimeKind.Local).AddTicks(5793) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 5,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 1, 2, 45, 15, 71, DateTimeKind.Local).AddTicks(5793), new DateTime(2022, 6, 1, 2, 45, 15, 71, DateTimeKind.Local).AddTicks(5793) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 6,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 1, 2, 45, 15, 71, DateTimeKind.Local).AddTicks(5793), new DateTime(2022, 6, 1, 2, 45, 15, 71, DateTimeKind.Local).AddTicks(5793) });

            migrationBuilder.UpdateData(
                table: "M_Kankatsu",
                keyColumn: "Kankatsu",
                keyValue: 7,
                columns: new[] { "RegisterDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2022, 6, 1, 2, 45, 15, 71, DateTimeKind.Local).AddTicks(5793), new DateTime(2022, 6, 1, 2, 45, 15, 71, DateTimeKind.Local).AddTicks(5793) });
        }
    }
}
