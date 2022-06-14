﻿// <auto-generated />
using System;
using HoshuSagyo.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HoshuSagyo.Migrations.HoshuSagyoDb
{
    [DbContext(typeof(HoshuSagyoDbContext))]
    partial class HoshuSagyoDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("HoshuSagyo.Models.Master.KankatsuModel", b =>
                {
                    b.Property<int>("Kankatsu")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Kankatsu"), 1L, 1);

                    b.Property<string>("KankatsuName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("RegisterDateTime")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("UpdateDateTime")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.HasKey("Kankatsu");

                    b.ToTable("M_Kankatsu");

                    b.HasData(
                        new
                        {
                            Kankatsu = 1,
                            KankatsuName = "東京",
                            RegisterDateTime = new DateTime(2022, 6, 10, 20, 51, 5, 492, DateTimeKind.Local).AddTicks(5713),
                            UpdateDateTime = new DateTime(2022, 6, 10, 20, 51, 5, 492, DateTimeKind.Local).AddTicks(5713)
                        },
                        new
                        {
                            Kankatsu = 2,
                            KankatsuName = "神奈川",
                            RegisterDateTime = new DateTime(2022, 6, 10, 20, 51, 5, 492, DateTimeKind.Local).AddTicks(5713),
                            UpdateDateTime = new DateTime(2022, 6, 10, 20, 51, 5, 492, DateTimeKind.Local).AddTicks(5713)
                        },
                        new
                        {
                            Kankatsu = 3,
                            KankatsuName = "千葉",
                            RegisterDateTime = new DateTime(2022, 6, 10, 20, 51, 5, 492, DateTimeKind.Local).AddTicks(5713),
                            UpdateDateTime = new DateTime(2022, 6, 10, 20, 51, 5, 492, DateTimeKind.Local).AddTicks(5713)
                        },
                        new
                        {
                            Kankatsu = 4,
                            KankatsuName = "埼玉",
                            RegisterDateTime = new DateTime(2022, 6, 10, 20, 51, 5, 492, DateTimeKind.Local).AddTicks(5713),
                            UpdateDateTime = new DateTime(2022, 6, 10, 20, 51, 5, 492, DateTimeKind.Local).AddTicks(5713)
                        },
                        new
                        {
                            Kankatsu = 5,
                            KankatsuName = "群馬",
                            RegisterDateTime = new DateTime(2022, 6, 10, 20, 51, 5, 492, DateTimeKind.Local).AddTicks(5713),
                            UpdateDateTime = new DateTime(2022, 6, 10, 20, 51, 5, 492, DateTimeKind.Local).AddTicks(5713)
                        },
                        new
                        {
                            Kankatsu = 6,
                            KankatsuName = "栃木",
                            RegisterDateTime = new DateTime(2022, 6, 10, 20, 51, 5, 492, DateTimeKind.Local).AddTicks(5713),
                            UpdateDateTime = new DateTime(2022, 6, 10, 20, 51, 5, 492, DateTimeKind.Local).AddTicks(5713)
                        },
                        new
                        {
                            Kankatsu = 7,
                            KankatsuName = "茨城",
                            RegisterDateTime = new DateTime(2022, 6, 10, 20, 51, 5, 492, DateTimeKind.Local).AddTicks(5713),
                            UpdateDateTime = new DateTime(2022, 6, 10, 20, 51, 5, 492, DateTimeKind.Local).AddTicks(5713)
                        });
                });

            modelBuilder.Entity("HoshuSagyo.Models.Master.KeitoModel", b =>
                {
                    b.Property<int>("Keito")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Keito"), 1L, 1);

                    b.Property<string>("KeitoName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("RegisterDateTime")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("UpdateDateTime")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.HasKey("Keito");

                    b.ToTable("M_Keito");

                    b.HasData(
                        new
                        {
                            Keito = 1,
                            KeitoName = "指令",
                            RegisterDateTime = new DateTime(2022, 6, 10, 20, 51, 5, 492, DateTimeKind.Local).AddTicks(5713),
                            UpdateDateTime = new DateTime(2022, 6, 10, 20, 51, 5, 492, DateTimeKind.Local).AddTicks(5713)
                        },
                        new
                        {
                            Keito = 2,
                            KeitoName = "現地",
                            RegisterDateTime = new DateTime(2022, 6, 10, 20, 51, 5, 492, DateTimeKind.Local).AddTicks(5713),
                            UpdateDateTime = new DateTime(2022, 6, 10, 20, 51, 5, 492, DateTimeKind.Local).AddTicks(5713)
                        },
                        new
                        {
                            Keito = 99,
                            KeitoName = "未定",
                            RegisterDateTime = new DateTime(2022, 6, 10, 20, 51, 5, 492, DateTimeKind.Local).AddTicks(5713),
                            UpdateDateTime = new DateTime(2022, 6, 10, 20, 51, 5, 492, DateTimeKind.Local).AddTicks(5713)
                        });
                });

            modelBuilder.Entity("HoshuSagyo.Models.Master.UserInfoModel", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Kankatsu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Keito")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("RegisterDateTime")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("UpdateDateTime")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.HasKey("UserId");

                    b.ToTable("M_UserInfo");
                });

            modelBuilder.Entity("HoshuSagyo.Models.Transactions.ShimekiriModel", b =>
                {
                    b.Property<int>("Keito")
                        .HasColumnType("int");

                    b.Property<int>("Kankatsu")
                        .HasColumnType("int");

                    b.Property<DateTime?>("RegisterDateTime")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ShimekiriZumiBi")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("UpdateDateTime")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.HasKey("Keito", "Kankatsu");

                    b.ToTable("T_Shimekiri");
                });
#pragma warning restore 612, 618
        }
    }
}
