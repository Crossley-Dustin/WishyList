﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WishyList.Api.Models;

namespace WishyList.Api.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WishyList.Models.Group", b =>
                {
                    b.Property<int>("GroupId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("InsertDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GroupId");

                    b.ToTable("Groups");

                    b.HasData(
                        new
                        {
                            GroupId = 1,
                            InsertDate = new DateTime(2021, 5, 21, 1, 17, 11, 101, DateTimeKind.Local).AddTicks(2737),
                            Name = "Group A"
                        },
                        new
                        {
                            GroupId = 2,
                            InsertDate = new DateTime(2021, 5, 21, 1, 17, 11, 101, DateTimeKind.Local).AddTicks(3838),
                            Name = "Group B"
                        },
                        new
                        {
                            GroupId = 3,
                            InsertDate = new DateTime(2021, 5, 21, 1, 17, 11, 101, DateTimeKind.Local).AddTicks(3910),
                            Name = "Group C"
                        },
                        new
                        {
                            GroupId = 4,
                            InsertDate = new DateTime(2021, 5, 21, 1, 17, 11, 101, DateTimeKind.Local).AddTicks(3959),
                            Name = "Group D"
                        });
                });

            modelBuilder.Entity("WishyList.Models.Member", b =>
                {
                    b.Property<int>("MemberId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("InsertDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("LastGroupId")
                        .HasColumnType("int");

                    b.Property<int>("LastListId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MemberId");

                    b.ToTable("Members");

                    b.HasData(
                        new
                        {
                            MemberId = 1,
                            Email = "john1@example.com",
                            InsertDate = new DateTime(2021, 5, 21, 1, 17, 11, 90, DateTimeKind.Local).AddTicks(6253),
                            LastGroupId = 1,
                            LastListId = 1,
                            Name = "John One"
                        },
                        new
                        {
                            MemberId = 2,
                            Email = "suzie2@example.com",
                            InsertDate = new DateTime(2021, 5, 21, 1, 17, 11, 100, DateTimeKind.Local).AddTicks(9290),
                            LastGroupId = 1,
                            LastListId = 1,
                            Name = "Suzie Two"
                        },
                        new
                        {
                            MemberId = 3,
                            Email = "pete3@example.com",
                            InsertDate = new DateTime(2021, 5, 21, 1, 17, 11, 100, DateTimeKind.Local).AddTicks(9860),
                            LastGroupId = 1,
                            LastListId = 1,
                            Name = "Pete Three"
                        },
                        new
                        {
                            MemberId = 4,
                            Email = "jill4@example.com",
                            InsertDate = new DateTime(2021, 5, 21, 1, 17, 11, 100, DateTimeKind.Local).AddTicks(9917),
                            LastGroupId = 1,
                            LastListId = 1,
                            Name = "Jill Four"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
