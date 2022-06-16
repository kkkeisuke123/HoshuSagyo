using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HoshuSagyo.Migrations.HoshuSagyoDb
{
    public partial class 作業計画情報関連テーブル作成 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ShimekiriZumiBi",
                table: "T_Shimekiri",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.CreateTable(
                name: "M_SagyoBasho",
                columns: table => new
                {
                    SagyoBasho = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SagyoBashoName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegisterDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_SagyoBasho", x => x.SagyoBasho);
                });

            migrationBuilder.CreateTable(
                name: "M_SagyoShubetsu",
                columns: table => new
                {
                    SagyoShubetsu = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SagyoShubetsuName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegisterDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_SagyoShubetsu", x => x.SagyoShubetsu);
                });

            migrationBuilder.CreateTable(
                name: "T_SagyoKeikaku",
                columns: table => new
                {
                    SagyoKaishiBi = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Keito = table.Column<int>(type: "int", nullable: false),
                    Kankatsu = table.Column<int>(type: "int", nullable: false),
                    SagyoShubetsu = table.Column<int>(type: "int", nullable: false),
                    SagyoBasho = table.Column<int>(type: "int", nullable: false),
                    SagyoKaishiJikan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SagyoShuryoBi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SagyoShuryoJikan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SagyoBango = table.Column<int>(type: "int", nullable: true),
                    SagyoNaiyo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JishaSekininshaMei = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JishaSagyoinSu = table.Column<int>(type: "int", nullable: true),
                    KyoryokuGaishaSekininshaMei = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KyoryokuGaishaSagyoinSu = table.Column<int>(type: "int", nullable: true),
                    RegisterDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_SagyoKeikaku", x => new { x.SagyoKaishiBi, x.Keito, x.Kankatsu, x.SagyoShubetsu, x.SagyoBasho });
                });

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

            migrationBuilder.InsertData(
                table: "M_SagyoBasho",
                columns: new[] { "SagyoBasho", "RegisterDateTime", "SagyoBashoName", "UpdateDateTime" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 6, 16, 15, 11, 42, 621, DateTimeKind.Local).AddTicks(8403), "場所A", new DateTime(2022, 6, 16, 15, 11, 42, 621, DateTimeKind.Local).AddTicks(8403) },
                    { 2, new DateTime(2022, 6, 16, 15, 11, 42, 621, DateTimeKind.Local).AddTicks(8403), "場所B", new DateTime(2022, 6, 16, 15, 11, 42, 621, DateTimeKind.Local).AddTicks(8403) },
                    { 3, new DateTime(2022, 6, 16, 15, 11, 42, 621, DateTimeKind.Local).AddTicks(8403), "場所C", new DateTime(2022, 6, 16, 15, 11, 42, 621, DateTimeKind.Local).AddTicks(8403) }
                });

            migrationBuilder.InsertData(
                table: "M_SagyoShubetsu",
                columns: new[] { "SagyoShubetsu", "RegisterDateTime", "SagyoShubetsuName", "UpdateDateTime" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 6, 16, 15, 11, 42, 621, DateTimeKind.Local).AddTicks(8403), "種別A", new DateTime(2022, 6, 16, 15, 11, 42, 621, DateTimeKind.Local).AddTicks(8403) },
                    { 2, new DateTime(2022, 6, 16, 15, 11, 42, 621, DateTimeKind.Local).AddTicks(8403), "種別B", new DateTime(2022, 6, 16, 15, 11, 42, 621, DateTimeKind.Local).AddTicks(8403) },
                    { 3, new DateTime(2022, 6, 16, 15, 11, 42, 621, DateTimeKind.Local).AddTicks(8403), "種別C", new DateTime(2022, 6, 16, 15, 11, 42, 621, DateTimeKind.Local).AddTicks(8403) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "M_SagyoBasho");

            migrationBuilder.DropTable(
                name: "M_SagyoShubetsu");

            migrationBuilder.DropTable(
                name: "T_SagyoKeikaku");

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
    }
}
