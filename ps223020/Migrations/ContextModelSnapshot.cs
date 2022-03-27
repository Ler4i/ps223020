﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ps223020.DbContext;

namespace ps223020.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.21");

            modelBuilder.Entity("ps223020.DataAccess.Models.FriendsRto", b =>
                {
                    b.Property<int>("FirstUserId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SecondUserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("FirstUserId", "SecondUserId");

                    b.HasIndex("FirstUserId");

                    b.HasIndex("SecondUserId");

                    b.ToTable("Friends");
                });

            modelBuilder.Entity("ps223020.DataAccess.Models.ProfileRto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("HatImageUrl")
                        .HasColumnType("TEXT");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Profiles");
                });

            modelBuilder.Entity("ps223020.DataAccess.Models.SavedVideoRto", b =>
                {
                    b.Property<int>("ProfileId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("VideoId")
                        .HasColumnType("INTEGER");

                    b.HasKey("ProfileId", "VideoId");

                    b.HasIndex("ProfileId");

                    b.HasIndex("VideoId");

                    b.ToTable("SevedVideos");
                });

            modelBuilder.Entity("ps223020.DataAccess.Models.UserRto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AvatarUrl")
                        .HasColumnType("TEXT");

                    b.Property<DateTimeOffset>("Birthday")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsBoy")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nickname")
                        .HasColumnType("TEXT");

                    b.Property<int>("PhoneNumber")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PhoneNumberPrefix")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Token")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ps223020.DataAccess.Models.VideoCommentRto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset>("DataTimeStamp")
                        .HasColumnType("TEXT");

                    b.Property<string>("Text")
                        .HasColumnType("TEXT");

                    b.Property<int>("VideoId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("VideoId");

                    b.ToTable("VideoComments");
                });

            modelBuilder.Entity("ps223020.DataAccess.Models.VideoRto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ContentUrl")
                        .HasColumnType("TEXT");

                    b.Property<int>("ProfileId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ProfileId");

                    b.ToTable("Videos");
                });

            modelBuilder.Entity("ps223020.DataAccess.Models.FriendsRto", b =>
                {
                    b.HasOne("ps223020.DataAccess.Models.UserRto", "FirstUser")
                        .WithMany("FirstUserFriends")
                        .HasForeignKey("FirstUserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("ps223020.DataAccess.Models.UserRto", "SecondUser")
                        .WithMany("SecondUserFriends")
                        .HasForeignKey("SecondUserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("ps223020.DataAccess.Models.ProfileRto", b =>
                {
                    b.HasOne("ps223020.DataAccess.Models.UserRto", "User")
                        .WithOne("Profiles")
                        .HasForeignKey("ps223020.DataAccess.Models.ProfileRto", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ps223020.DataAccess.Models.SavedVideoRto", b =>
                {
                    b.HasOne("ps223020.DataAccess.Models.ProfileRto", "Profile")
                        .WithMany("SavedVideos")
                        .HasForeignKey("ProfileId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("ps223020.DataAccess.Models.VideoRto", "Video")
                        .WithMany("SavedVideos")
                        .HasForeignKey("VideoId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("ps223020.DataAccess.Models.VideoCommentRto", b =>
                {
                    b.HasOne("ps223020.DataAccess.Models.VideoRto", "Video")
                        .WithMany("VideoComments")
                        .HasForeignKey("VideoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ps223020.DataAccess.Models.VideoRto", b =>
                {
                    b.HasOne("ps223020.DataAccess.Models.ProfileRto", "Profile")
                        .WithMany("Videos")
                        .HasForeignKey("ProfileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
