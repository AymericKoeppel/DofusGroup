﻿// <auto-generated />
using DofusGroup.Data.DB;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DofusGroup.Migrations
{
    [DbContext(typeof(DofusContext))]
    partial class DofusContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7");

            modelBuilder.Entity("DofusGroup.Shared.FKModels.DungeonUser", b =>
                {
                    b.Property<int>("DungeonId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("DungeonId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("DungeonUsers");
                });

            modelBuilder.Entity("DofusGroup.Shared.Models.Class", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ImgSource")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Class");
                });

            modelBuilder.Entity("DofusGroup.Shared.Models.Dungeon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Boss")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ImgSource")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Niveau")
                        .HasColumnType("TEXT");

                    b.Property<string>("Position")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Dungeons");
                });

            modelBuilder.Entity("DofusGroup.Shared.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ClassId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Level")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ClassId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("DofusGroup.Shared.FKModels.DungeonUser", b =>
                {
                    b.HasOne("DofusGroup.Shared.Models.Dungeon", "Dungeon")
                        .WithMany("DungeonUsers")
                        .HasForeignKey("DungeonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DofusGroup.Shared.Models.User", "User")
                        .WithMany("DungeonUsers")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DofusGroup.Shared.Models.User", b =>
                {
                    b.HasOne("DofusGroup.Shared.Models.Class", "Class")
                        .WithMany()
                        .HasForeignKey("ClassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
