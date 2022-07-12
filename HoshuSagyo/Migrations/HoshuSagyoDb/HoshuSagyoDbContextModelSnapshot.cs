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
                            RegisterDateTime = new DateTime(2022, 7, 12, 18, 16, 46, 909, DateTimeKind.Local).AddTicks(1305),
                            UpdateDateTime = new DateTime(2022, 7, 12, 18, 16, 46, 909, DateTimeKind.Local).AddTicks(1305)
                        },
                        new
                        {
                            Kankatsu = 2,
                            KankatsuName = "神奈川",
                            RegisterDateTime = new DateTime(2022, 7, 12, 18, 16, 46, 909, DateTimeKind.Local).AddTicks(1305),
                            UpdateDateTime = new DateTime(2022, 7, 12, 18, 16, 46, 909, DateTimeKind.Local).AddTicks(1305)
                        },
                        new
                        {
                            Kankatsu = 3,
                            KankatsuName = "千葉",
                            RegisterDateTime = new DateTime(2022, 7, 12, 18, 16, 46, 909, DateTimeKind.Local).AddTicks(1305),
                            UpdateDateTime = new DateTime(2022, 7, 12, 18, 16, 46, 909, DateTimeKind.Local).AddTicks(1305)
                        },
                        new
                        {
                            Kankatsu = 4,
                            KankatsuName = "埼玉",
                            RegisterDateTime = new DateTime(2022, 7, 12, 18, 16, 46, 909, DateTimeKind.Local).AddTicks(1305),
                            UpdateDateTime = new DateTime(2022, 7, 12, 18, 16, 46, 909, DateTimeKind.Local).AddTicks(1305)
                        },
                        new
                        {
                            Kankatsu = 5,
                            KankatsuName = "群馬",
                            RegisterDateTime = new DateTime(2022, 7, 12, 18, 16, 46, 909, DateTimeKind.Local).AddTicks(1305),
                            UpdateDateTime = new DateTime(2022, 7, 12, 18, 16, 46, 909, DateTimeKind.Local).AddTicks(1305)
                        },
                        new
                        {
                            Kankatsu = 6,
                            KankatsuName = "栃木",
                            RegisterDateTime = new DateTime(2022, 7, 12, 18, 16, 46, 909, DateTimeKind.Local).AddTicks(1305),
                            UpdateDateTime = new DateTime(2022, 7, 12, 18, 16, 46, 909, DateTimeKind.Local).AddTicks(1305)
                        },
                        new
                        {
                            Kankatsu = 7,
                            KankatsuName = "茨城",
                            RegisterDateTime = new DateTime(2022, 7, 12, 18, 16, 46, 909, DateTimeKind.Local).AddTicks(1305),
                            UpdateDateTime = new DateTime(2022, 7, 12, 18, 16, 46, 909, DateTimeKind.Local).AddTicks(1305)
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
                            RegisterDateTime = new DateTime(2022, 7, 12, 18, 16, 46, 909, DateTimeKind.Local).AddTicks(1305),
                            UpdateDateTime = new DateTime(2022, 7, 12, 18, 16, 46, 909, DateTimeKind.Local).AddTicks(1305)
                        },
                        new
                        {
                            Keito = 2,
                            KeitoName = "現地",
                            RegisterDateTime = new DateTime(2022, 7, 12, 18, 16, 46, 909, DateTimeKind.Local).AddTicks(1305),
                            UpdateDateTime = new DateTime(2022, 7, 12, 18, 16, 46, 909, DateTimeKind.Local).AddTicks(1305)
                        },
                        new
                        {
                            Keito = 99,
                            KeitoName = "未定",
                            RegisterDateTime = new DateTime(2022, 7, 12, 18, 16, 46, 909, DateTimeKind.Local).AddTicks(1305),
                            UpdateDateTime = new DateTime(2022, 7, 12, 18, 16, 46, 909, DateTimeKind.Local).AddTicks(1305)
                        });
                });

            modelBuilder.Entity("HoshuSagyo.Models.Master.OnseiOtoModel", b =>
                {
                    b.Property<int>("OtoShubetsu")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OtoShubetsu"), 1L, 1);

                    b.Property<string>("OtoShubetsuNaiyo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("RegisterDateTime")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("UpdateDateTime")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.HasKey("OtoShubetsu");

                    b.ToTable("M_OnseiOto");

                    b.HasData(
                        new
                        {
                            OtoShubetsu = 1,
                            OtoShubetsuNaiyo = "共通",
                            RegisterDateTime = new DateTime(2022, 7, 12, 18, 16, 46, 909, DateTimeKind.Local).AddTicks(1305),
                            UpdateDateTime = new DateTime(2022, 7, 12, 18, 16, 46, 909, DateTimeKind.Local).AddTicks(1305)
                        },
                        new
                        {
                            OtoShubetsu = 2,
                            OtoShubetsuNaiyo = "施設",
                            RegisterDateTime = new DateTime(2022, 7, 12, 18, 16, 46, 909, DateTimeKind.Local).AddTicks(1305),
                            UpdateDateTime = new DateTime(2022, 7, 12, 18, 16, 46, 909, DateTimeKind.Local).AddTicks(1305)
                        },
                        new
                        {
                            OtoShubetsu = 3,
                            OtoShubetsuNaiyo = "電力",
                            RegisterDateTime = new DateTime(2022, 7, 12, 18, 16, 46, 909, DateTimeKind.Local).AddTicks(1305),
                            UpdateDateTime = new DateTime(2022, 7, 12, 18, 16, 46, 909, DateTimeKind.Local).AddTicks(1305)
                        },
                        new
                        {
                            OtoShubetsu = 4,
                            OtoShubetsuNaiyo = "通信",
                            RegisterDateTime = new DateTime(2022, 7, 12, 18, 16, 46, 909, DateTimeKind.Local).AddTicks(1305),
                            UpdateDateTime = new DateTime(2022, 7, 12, 18, 16, 46, 909, DateTimeKind.Local).AddTicks(1305)
                        });
                });

            modelBuilder.Entity("HoshuSagyo.Models.Master.OnseiOtoShosaiModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OtoShubetsu")
                        .HasColumnType("int");

                    b.Property<DateTime?>("RegisterDateTime")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("UpdateDateTime")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("M_OnseiOtoShosai");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Message = "関係者以外の人はいませんか",
                            OtoShubetsu = 1,
                            RegisterDateTime = new DateTime(2022, 7, 12, 18, 16, 46, 909, DateTimeKind.Local).AddTicks(1305),
                            UpdateDateTime = new DateTime(2022, 7, 12, 18, 16, 46, 909, DateTimeKind.Local).AddTicks(1305)
                        },
                        new
                        {
                            Id = 2,
                            Message = "作業場所は間違っていませんか",
                            OtoShubetsu = 1,
                            RegisterDateTime = new DateTime(2022, 7, 12, 18, 16, 46, 909, DateTimeKind.Local).AddTicks(1305),
                            UpdateDateTime = new DateTime(2022, 7, 12, 18, 16, 46, 909, DateTimeKind.Local).AddTicks(1305)
                        },
                        new
                        {
                            Id = 3,
                            Message = "作業員は全員揃いましたか",
                            OtoShubetsu = 1,
                            RegisterDateTime = new DateTime(2022, 7, 12, 18, 16, 46, 909, DateTimeKind.Local).AddTicks(1305),
                            UpdateDateTime = new DateTime(2022, 7, 12, 18, 16, 46, 909, DateTimeKind.Local).AddTicks(1305)
                        },
                        new
                        {
                            Id = 4,
                            Message = "道具の忘れ物はありませんか",
                            OtoShubetsu = 1,
                            RegisterDateTime = new DateTime(2022, 7, 12, 18, 16, 46, 909, DateTimeKind.Local).AddTicks(1305),
                            UpdateDateTime = new DateTime(2022, 7, 12, 18, 16, 46, 909, DateTimeKind.Local).AddTicks(1305)
                        },
                        new
                        {
                            Id = 5,
                            Message = "施設の責任者から作業許可は出ていますか",
                            OtoShubetsu = 2,
                            RegisterDateTime = new DateTime(2022, 7, 12, 18, 16, 46, 909, DateTimeKind.Local).AddTicks(1305),
                            UpdateDateTime = new DateTime(2022, 7, 12, 18, 16, 46, 909, DateTimeKind.Local).AddTicks(1305)
                        },
                        new
                        {
                            Id = 6,
                            Message = "各エリアの施錠は行いましたか",
                            OtoShubetsu = 2,
                            RegisterDateTime = new DateTime(2022, 7, 12, 18, 16, 46, 909, DateTimeKind.Local).AddTicks(1305),
                            UpdateDateTime = new DateTime(2022, 7, 12, 18, 16, 46, 909, DateTimeKind.Local).AddTicks(1305)
                        },
                        new
                        {
                            Id = 7,
                            Message = "電気の供給が停止していますか",
                            OtoShubetsu = 3,
                            RegisterDateTime = new DateTime(2022, 7, 12, 18, 16, 46, 909, DateTimeKind.Local).AddTicks(1305),
                            UpdateDateTime = new DateTime(2022, 7, 12, 18, 16, 46, 909, DateTimeKind.Local).AddTicks(1305)
                        },
                        new
                        {
                            Id = 8,
                            Message = "電気の供給を再開しましたか",
                            OtoShubetsu = 3,
                            RegisterDateTime = new DateTime(2022, 7, 12, 18, 16, 46, 909, DateTimeKind.Local).AddTicks(1305),
                            UpdateDateTime = new DateTime(2022, 7, 12, 18, 16, 46, 909, DateTimeKind.Local).AddTicks(1305)
                        },
                        new
                        {
                            Id = 9,
                            Message = "通信状態をメンテナンス状態にしましたか",
                            OtoShubetsu = 4,
                            RegisterDateTime = new DateTime(2022, 7, 12, 18, 16, 46, 909, DateTimeKind.Local).AddTicks(1305),
                            UpdateDateTime = new DateTime(2022, 7, 12, 18, 16, 46, 909, DateTimeKind.Local).AddTicks(1305)
                        },
                        new
                        {
                            Id = 10,
                            Message = "通信状態を通常状態に戻しましたか",
                            OtoShubetsu = 4,
                            RegisterDateTime = new DateTime(2022, 7, 12, 18, 16, 46, 909, DateTimeKind.Local).AddTicks(1305),
                            UpdateDateTime = new DateTime(2022, 7, 12, 18, 16, 46, 909, DateTimeKind.Local).AddTicks(1305)
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
                            RegisterDateTime = new DateTime(2022, 7, 12, 18, 16, 46, 909, DateTimeKind.Local).AddTicks(1305),
                            SagyoBashoName = "場所A",
                            UpdateDateTime = new DateTime(2022, 7, 12, 18, 16, 46, 909, DateTimeKind.Local).AddTicks(1305)
                        },
                        new
                        {
                            SagyoBasho = 2,
                            RegisterDateTime = new DateTime(2022, 7, 12, 18, 16, 46, 909, DateTimeKind.Local).AddTicks(1305),
                            SagyoBashoName = "場所B",
                            UpdateDateTime = new DateTime(2022, 7, 12, 18, 16, 46, 909, DateTimeKind.Local).AddTicks(1305)
                        },
                        new
                        {
                            SagyoBasho = 3,
                            RegisterDateTime = new DateTime(2022, 7, 12, 18, 16, 46, 909, DateTimeKind.Local).AddTicks(1305),
                            SagyoBashoName = "場所C",
                            UpdateDateTime = new DateTime(2022, 7, 12, 18, 16, 46, 909, DateTimeKind.Local).AddTicks(1305)
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
                            RegisterDateTime = new DateTime(2022, 7, 12, 18, 16, 46, 909, DateTimeKind.Local).AddTicks(1305),
                            SagyoShubetsuName = "種別A",
                            UpdateDateTime = new DateTime(2022, 7, 12, 18, 16, 46, 909, DateTimeKind.Local).AddTicks(1305)
                        },
                        new
                        {
                            SagyoShubetsu = 2,
                            RegisterDateTime = new DateTime(2022, 7, 12, 18, 16, 46, 909, DateTimeKind.Local).AddTicks(1305),
                            SagyoShubetsuName = "種別B",
                            UpdateDateTime = new DateTime(2022, 7, 12, 18, 16, 46, 909, DateTimeKind.Local).AddTicks(1305)
                        },
                        new
                        {
                            SagyoShubetsu = 3,
                            RegisterDateTime = new DateTime(2022, 7, 12, 18, 16, 46, 909, DateTimeKind.Local).AddTicks(1305),
                            SagyoShubetsuName = "種別C",
                            UpdateDateTime = new DateTime(2022, 7, 12, 18, 16, 46, 909, DateTimeKind.Local).AddTicks(1305)
                        });
                });

            modelBuilder.Entity("HoshuSagyo.Models.Master.ShinchokuModel", b =>
                {
                    b.Property<int>("Shinchoku")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Shinchoku"), 1L, 1);

                    b.Property<DateTime?>("RegisterDateTime")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<string>("ShinchokuName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateDateTime")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.HasKey("Shinchoku");

                    b.ToTable("M_Shinchoku");

                    b.HasData(
                        new
                        {
                            Shinchoku = 1,
                            RegisterDateTime = new DateTime(2022, 7, 12, 18, 16, 46, 909, DateTimeKind.Local).AddTicks(1305),
                            ShinchokuName = "未着手",
                            UpdateDateTime = new DateTime(2022, 7, 12, 18, 16, 46, 909, DateTimeKind.Local).AddTicks(1305)
                        },
                        new
                        {
                            Shinchoku = 2,
                            RegisterDateTime = new DateTime(2022, 7, 12, 18, 16, 46, 909, DateTimeKind.Local).AddTicks(1305),
                            ShinchokuName = "着手済",
                            UpdateDateTime = new DateTime(2022, 7, 12, 18, 16, 46, 909, DateTimeKind.Local).AddTicks(1305)
                        },
                        new
                        {
                            Shinchoku = 3,
                            RegisterDateTime = new DateTime(2022, 7, 12, 18, 16, 46, 909, DateTimeKind.Local).AddTicks(1305),
                            ShinchokuName = "完了済",
                            UpdateDateTime = new DateTime(2022, 7, 12, 18, 16, 46, 909, DateTimeKind.Local).AddTicks(1305)
                        },
                        new
                        {
                            Shinchoku = 4,
                            RegisterDateTime = new DateTime(2022, 7, 12, 18, 16, 46, 909, DateTimeKind.Local).AddTicks(1305),
                            ShinchokuName = "着手遅延",
                            UpdateDateTime = new DateTime(2022, 7, 12, 18, 16, 46, 909, DateTimeKind.Local).AddTicks(1305)
                        },
                        new
                        {
                            Shinchoku = 5,
                            RegisterDateTime = new DateTime(2022, 7, 12, 18, 16, 46, 909, DateTimeKind.Local).AddTicks(1305),
                            ShinchokuName = "終了遅延",
                            UpdateDateTime = new DateTime(2022, 7, 12, 18, 16, 46, 909, DateTimeKind.Local).AddTicks(1305)
                        },
                        new
                        {
                            Shinchoku = 6,
                            RegisterDateTime = new DateTime(2022, 7, 12, 18, 16, 46, 909, DateTimeKind.Local).AddTicks(1305),
                            ShinchokuName = "中止",
                            UpdateDateTime = new DateTime(2022, 7, 12, 18, 16, 46, 909, DateTimeKind.Local).AddTicks(1305)
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

            modelBuilder.Entity("HoshuSagyo.Models.Transactions.SagyoJissekiModel", b =>
                {
                    b.Property<int>("SagyoKeikakuId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SagyoKeikakuId"), 1L, 1);

                    b.Property<DateTime?>("RegisterDateTime")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("SagyoChakushuNichiji")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("SagyoKanryoNichiji")
                        .HasColumnType("datetime2");

                    b.Property<int>("Shinchoku")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdateDateTime")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.HasKey("SagyoKeikakuId");

                    b.ToTable("T_SagyoJisseki");
                });

            modelBuilder.Entity("HoshuSagyo.Models.Transactions.SagyoKeikakuModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

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

                    b.Property<int>("SagyoKaishiOnseiOtoShosaiId")
                        .HasColumnType("int");

                    b.Property<string>("SagyoNaiyo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("SagyoShuryoNichiji")
                        .HasColumnType("datetime2");

                    b.Property<int>("SagyoShuryoOnseiOtoShosaiId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdateDateTime")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.HasKey("Id", "SagyoKaishiNichiji", "Keito", "Kankatsu", "SagyoShubetsu", "SagyoBasho");

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
