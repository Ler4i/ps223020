using Microsoft.EntityFrameworkCore;
using ps223020.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ps223020.DbContext
{
    public class Context : Microsoft.EntityFrameworkCore.DbContext, IContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }

        public DbSet<UserRto> Users { get; set; }
        public DbSet<ProfileRto> Profiles { get; set; }
        public DbSet<VideoRto> Videos { get; set; }
        public DbSet<SavedVideoRto> SevedVideos { get; set; }
        public DbSet<VideoCommentRto> VideoComments { get; set; }
        public DbSet<FriendsRto> Friends { get; set; }
        public DbSet<UserMultimediaPostRto> UserMultimediaPosts { get; set; }
        public DbSet<MultimediaPostCommentRto> MultimediaPostComments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SavedVideoRto>(builder =>
            {
                builder.HasKey(e => new
                {
                    e.ProfileId,
                    e.VideoId
                });
                builder.HasIndex(e => e.ProfileId);
                builder.HasIndex(e => e.VideoId);

                builder.HasOne<VideoRto>(e => e.Video)
                    .WithMany(e => e.SavedVideos)
                    .HasForeignKey(e => e.VideoId)
                    .OnDelete(DeleteBehavior.NoAction)
                    .IsRequired();

                builder.HasOne<ProfileRto>(e => e.Profile)
                    .WithMany(e => e.SavedVideos)
                    .HasForeignKey(e => e.ProfileId)
                    .OnDelete(DeleteBehavior.NoAction)
                    .IsRequired();
            });


            modelBuilder.Entity<FriendsRto>(builder =>
            {
                builder.HasKey(e => new
                {
                    e.FirstUserId,
                    e.SecondUserId
                });
                builder.HasIndex(e => e.FirstUserId);
                builder.HasIndex(e => e.SecondUserId);

                builder.HasOne<UserRto>(e => e.FirstUser)
                    .WithMany(e => e.FirstUserFriends)
                    .HasForeignKey(e => e.FirstUserId)
                    .OnDelete(DeleteBehavior.NoAction)
                    .IsRequired();

                builder.HasOne<UserRto>(e => e.SecondUser)
                    .WithMany(e => e.SecondUserFriends)
                    .HasForeignKey(e => e.SecondUserId)
                    .OnDelete(DeleteBehavior.NoAction)
                    .IsRequired();
            });
        }
    }
}
