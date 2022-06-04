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
    [Migration("20220531174515_add kankatsu master")]
    partial class addkankatsumaster
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
                            RegisterDateTime = new DateTime(2022, 6, 1, 2, 45, 15, 71, DateTimeKind.Local).AddTicks(5793),
                            UpdateDateTime = new DateTime(2022, 6, 1, 2, 45, 15, 71, DateTimeKind.Local).AddTicks(5793)
                        },
                        new
                        {
                            Kankatsu = 2,
                            KankatsuName = "神奈川",
                            RegisterDateTime = new DateTime(2022, 6, 1, 2, 45, 15, 71, DateTimeKind.Local).AddTicks(5793),
                            UpdateDateTime = new DateTime(2022, 6, 1, 2, 45, 15, 71, DateTimeKind.Local).AddTicks(5793)
                        },
                        new
                        {
                            Kankatsu = 3,
                            KankatsuName = "千葉",
                            RegisterDateTime = new DateTime(2022, 6, 1, 2, 45, 15, 71, DateTimeKind.Local).AddTicks(5793),
                            UpdateDateTime = new DateTime(2022, 6, 1, 2, 45, 15, 71, DateTimeKind.Local).AddTicks(5793)
                        },
                        new
                        {
                            Kankatsu = 4,
                            KankatsuName = "埼玉",
                            RegisterDateTime = new DateTime(2022, 6, 1, 2, 45, 15, 71, DateTimeKind.Local).AddTicks(5793),
                            UpdateDateTime = new DateTime(2022, 6, 1, 2, 45, 15, 71, DateTimeKind.Local).AddTicks(5793)
                        },
                        new
                        {
                            Kankatsu = 5,
                            KankatsuName = "群馬",
                            RegisterDateTime = new DateTime(2022, 6, 1, 2, 45, 15, 71, DateTimeKind.Local).AddTicks(5793),
                            UpdateDateTime = new DateTime(2022, 6, 1, 2, 45, 15, 71, DateTimeKind.Local).AddTicks(5793)
                        },
                        new
                        {
                            Kankatsu = 6,
                            KankatsuName = "栃木",
                            RegisterDateTime = new DateTime(2022, 6, 1, 2, 45, 15, 71, DateTimeKind.Local).AddTicks(5793),
                            UpdateDateTime = new DateTime(2022, 6, 1, 2, 45, 15, 71, DateTimeKind.Local).AddTicks(5793)
                        },
                        new
                        {
                            Kankatsu = 7,
                            KankatsuName = "茨城",
                            RegisterDateTime = new DateTime(2022, 6, 1, 2, 45, 15, 71, DateTimeKind.Local).AddTicks(5793),
                            UpdateDateTime = new DateTime(2022, 6, 1, 2, 45, 15, 71, DateTimeKind.Local).AddTicks(5793)
                        });
                });

            modelBuilder.Entity("HoshuSagyo.Models.Transactions.ShimekiriModel", b =>
                {
                    b.Property<DateTime?>("ShimekiriZumiBi")
                        .HasColumnType("datetime2");

                    b.Property<int>("Kankatsu")
                        .HasColumnType("int");

                    b.Property<int>("Keito")
                        .HasColumnType("int");

                    b.Property<DateTime?>("RegisterDateTime")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("UpdateDateTime")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.HasKey("ShimekiriZumiBi");

                    b.ToTable("T_Shimekiri");
                });
#pragma warning restore 612, 618
        }
    }
}