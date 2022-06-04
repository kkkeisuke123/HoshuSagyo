using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HoshuSagyo.Migrations.HoshuSagyoDb
{
    public partial class addkankatsumaster : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "M_Kankatsu",
                columns: table => new
                {
                    Kankatsu = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KankatsuName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegisterDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_Kankatsu", x => x.Kankatsu);
                });

            migrationBuilder.InsertData(
                table: "M_Kankatsu",
                columns: new[] { "Kankatsu", "KankatsuName", "RegisterDateTime", "UpdateDateTime" },
                values: new object[,]
                {
                    { 1, "東京", new DateTime(2022, 6, 1, 2, 45, 15, 71, DateTimeKind.Local).AddTicks(5793), new DateTime(2022, 6, 1, 2, 45, 15, 71, DateTimeKind.Local).AddTicks(5793) },
                    { 2, "神奈川", new DateTime(2022, 6, 1, 2, 45, 15, 71, DateTimeKind.Local).AddTicks(5793), new DateTime(2022, 6, 1, 2, 45, 15, 71, DateTimeKind.Local).AddTicks(5793) },
                    { 3, "千葉", new DateTime(2022, 6, 1, 2, 45, 15, 71, DateTimeKind.Local).AddTicks(5793), new DateTime(2022, 6, 1, 2, 45, 15, 71, DateTimeKind.Local).AddTicks(5793) },
                    { 4, "埼玉", new DateTime(2022, 6, 1, 2, 45, 15, 71, DateTimeKind.Local).AddTicks(5793), new DateTime(2022, 6, 1, 2, 45, 15, 71, DateTimeKind.Local).AddTicks(5793) },
                    { 5, "群馬", new DateTime(2022, 6, 1, 2, 45, 15, 71, DateTimeKind.Local).AddTicks(5793), new DateTime(2022, 6, 1, 2, 45, 15, 71, DateTimeKind.Local).AddTicks(5793) },
                    { 6, "栃木", new DateTime(2022, 6, 1, 2, 45, 15, 71, DateTimeKind.Local).AddTicks(5793), new DateTime(2022, 6, 1, 2, 45, 15, 71, DateTimeKind.Local).AddTicks(5793) },
                    { 7, "茨城", new DateTime(2022, 6, 1, 2, 45, 15, 71, DateTimeKind.Local).AddTicks(5793), new DateTime(2022, 6, 1, 2, 45, 15, 71, DateTimeKind.Local).AddTicks(5793) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "M_Kankatsu");
        }
    }
}
