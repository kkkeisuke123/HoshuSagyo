﻿// <auto-generated />
using System;
using HoshuSagyo.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HoshuSagyo.Migrations.HoshuSagyoDb
{
    [DbContext(typeof(HoshuSagyoDbContext))]
    [Migration("20220703120622_作業計画テーブルの日時系カラム定義を変更")]
    partial class 作業計画テーブルの日時系カラム定義を変更
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
                            RegisterDateTime = new DateTime(2022, 7, 3, 21, 6, 21, 997, DateTimeKind.Local).AddTicks(5212),
                            UpdateDateTime = new DateTime(2022, 7, 3, 21, 6, 21, 997, DateTimeKind.Local).AddTicks(5212)
                        },
                        new
                        {
                            Kankatsu = 2,
                            KankatsuName = "神奈川",
                            RegisterDateTime = new DateTime(2022, 7, 3, 21, 6, 21, 997, DateTimeKind.Local).AddTicks(5212),
                            UpdateDateTime = new DateTime(2022, 7, 3, 21, 6, 21, 997, DateTimeKind.Local).AddTicks(5212)
                        },
                        new
                        {
                            Kankatsu = 3,
                            KankatsuName = "千葉",
                            RegisterDateTime = new DateTime(2022, 7, 3, 21, 6, 21, 997, DateTimeKind.Local).AddTicks(5212),
                            UpdateDateTime = new DateTime(2022, 7, 3, 21, 6, 21, 997, DateTimeKind.Local).AddTicks(5212)
                        },
                        new
                        {
                            Kankatsu = 4,
                            KankatsuName = "埼玉",
                            RegisterDateTime = new DateTime(2022, 7, 3, 21, 6, 21, 997, DateTimeKind.Local).AddTicks(5212),
                            UpdateDateTime = new DateTime(2022, 7, 3, 21, 6, 21, 997, DateTimeKind.Local).AddTicks(5212)
                        },
                        new
                        {
                            Kankatsu = 5,
                            KankatsuName = "群馬",
                            RegisterDateTime = new DateTime(2022, 7, 3, 21, 6, 21, 997, DateTimeKind.Local).AddTicks(5212),
                            UpdateDateTime = new DateTime(2022, 7, 3, 21, 6, 21, 997, DateTimeKind.Local).AddTicks(5212)
                        },
                        new
                        {
                            Kankatsu = 6,
                            KankatsuName = "栃木",
                            RegisterDateTime = new DateTime(2022, 7, 3, 21, 6, 21, 997, DateTimeKind.Local).AddTicks(5212),
                            UpdateDateTime = new DateTime(2022, 7, 3, 21, 6, 21, 997, DateTimeKind.Local).AddTicks(5212)
                        },
                        new
                        {
                            Kankatsu = 7,
                            KankatsuName = "茨城",
                            RegisterDateTime = new DateTime(2022, 7, 3, 21, 6, 21, 997, DateTimeKind.Local).AddTicks(5212),
                            UpdateDateTime = new DateTime(2022, 7, 3, 21, 6, 21, 997, DateTimeKind.Local).AddTicks(5212)
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
                            RegisterDateTime = new DateTime(2022, 7, 3, 21, 6, 21, 997, DateTimeKind.Local).AddTicks(5212),
                            UpdateDateTime = new DateTime(2022, 7, 3, 21, 6, 21, 997, DateTimeKind.Local).AddTicks(5212)
                        },
                        new
                        {
                            Keito = 2,
                            KeitoName = "現地",
                            RegisterDateTime = new DateTime(2022, 7, 3, 21, 6, 21, 997, DateTimeKind.Local).AddTicks(5212),
                            UpdateDateTime = new DateTime(2022, 7, 3, 21, 6, 21, 997, DateTimeKind.Local).AddTicks(5212)
                        },
                        new
                        {
                            Keito = 99,
                            KeitoName = "未定",
                            RegisterDateTime = new DateTime(2022, 7, 3, 21, 6, 21, 997, DateTimeKind.Local).AddTicks(5212),
                            UpdateDateTime = new DateTime(2022, 7, 3, 21, 6, 21, 997, DateTimeKind.Local).AddTicks(5212)
                        });
                });

            modelBuilder.Entity("HoshuSagyo.Models.Master.SagyoBashoModel", b =>
                {
                    b.Property<int>("SagyoBasho")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SagyoBasho"), 1L, 1);

                    b.Property<DateTime?>("RegisterDateTime")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<string>("SagyoBashoName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateDateTime")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.HasKey("SagyoBasho");

                    b.ToTable("M_SagyoBasho");

                    b.HasData(
                        new
                        {
                            SagyoBasho = 1,
                            RegisterDateTime = new DateTime(2022, 7, 3, 21, 6, 21, 997, DateTimeKind.Local).AddTicks(5212),
                            SagyoBashoName = "場所A",
                            UpdateDateTime = new DateTime(2022, 7, 3, 21, 6, 21, 997, DateTimeKind.Local).AddTicks(5212)
                        },
                        new
                        {
                            SagyoBasho = 2,
                            RegisterDateTime = new DateTime(2022, 7, 3, 21, 6, 21, 997, DateTimeKind.Local).AddTicks(5212),
                            SagyoBashoName = "場所B",
                            UpdateDateTime = new DateTime(2022, 7, 3, 21, 6, 21, 997, DateTimeKind.Local).AddTicks(5212)
                        },
                        new
                        {
                            SagyoBasho = 3,
                            RegisterDateTime = new DateTime(2022, 7, 3, 21, 6, 21, 997, DateTimeKind.Local).AddTicks(5212),
                            SagyoBashoName = "場所C",
                            UpdateDateTime = new DateTime(2022, 7, 3, 21, 6, 21, 997, DateTimeKind.Local).AddTicks(5212)
                        });
                });

            modelBuilder.Entity("HoshuSagyo.Models.Master.SagyoShubetsuModel", b =>
                {
                    b.Property<int>("SagyoShubetsu")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SagyoShubetsu"), 1L, 1);

                    b.Property<DateTime?>("RegisterDateTime")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<string>("SagyoShubetsuName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateDateTime")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.HasKey("SagyoShubetsu");

                    b.ToTable("M_SagyoShubetsu");

                    b.HasData(
                        new
                        {
                            SagyoShubetsu = 1,
                            RegisterDateTime = new DateTime(2022, 7, 3, 21, 6, 21, 997, DateTimeKind.Local).AddTicks(5212),
                            SagyoShubetsuName = "種別A",
                            UpdateDateTime = new DateTime(2022, 7, 3, 21, 6, 21, 997, DateTimeKind.Local).AddTicks(5212)
                        },
                        new
                        {
                            SagyoShubetsu = 2,
                            RegisterDateTime = new DateTime(2022, 7, 3, 21, 6, 21, 997, DateTimeKind.Local).AddTicks(5212),
                            SagyoShubetsuName = "種別B",
                            UpdateDateTime = new DateTime(2022, 7, 3, 21, 6, 21, 997, DateTimeKind.Local).AddTicks(5212)
                        },
                        new
                        {
                            SagyoShubetsu = 3,
                            RegisterDateTime = new DateTime(2022, 7, 3, 21, 6, 21, 997, DateTimeKind.Local).AddTicks(5212),
                            SagyoShubetsuName = "種別C",
                            UpdateDateTime = new DateTime(2022, 7, 3, 21, 6, 21, 997, DateTimeKind.Local).AddTicks(5212)
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

            modelBuilder.Entity("HoshuSagyo.Models.Transactions.SagyoBangoModel", b =>
                {
                    b.Property<string>("Nengetsu")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Keito")
                        .HasColumnType("int");

                    b.Property<int>("Kankatsu")
                        .HasColumnType("int");

                    b.Property<DateTime?>("RegisterDateTime")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<int>("SaishuBango")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdateDateTime")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.HasKey("Nengetsu", "Keito", "Kankatsu");

                    b.ToTable("T_SagyoBango");
                });

            modelBuilder.Entity("HoshuSagyo.Models.Transactions.SagyoKeikakuModel", b =>
                {
                    b.Property<DateTime>("SagyoKaishiNichiji")
                        .HasColumnType("datetime2");

                    b.Property<int>("Keito")
                        .HasColumnType("int");

                    b.Property<int>("Kankatsu")
                        .HasColumnType("int");

                    b.Property<int>("SagyoShubetsu")
                        .HasColumnType("int");

                    b.Property<int>("SagyoBasho")
                        .HasColumnType("int");

                    b.Property<int?>("JishaSagyoinSu")
                        .HasColumnType("int");

                    b.Property<string>("JishaSekininshaMei")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("KyoryokuGaishaSagyoinSu")
                        .HasColumnType("int");

                    b.Property<string>("KyoryokuGaishaSekininshaMei")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("RegisterDateTime")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<int?>("SagyoBango")
                        .HasColumnType("int");

                    b.Property<string>("SagyoNaiyo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("SagyoShuryoNichiji")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("UpdateDateTime")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.HasKey("SagyoKaishiNichiji", "Keito", "Kankatsu", "SagyoShubetsu", "SagyoBasho");

                    b.ToTable("T_SagyoKeikaku");
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
