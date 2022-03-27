using Microsoft.EntityFrameworkCore;
using ps223020.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ps223020.DbContext
{
    public interface IContext : IDisposable, IAsyncDisposable
    {
        DbSet<UserRto> Users { get; set; }
        DbSet<ProfileRto> Profiles { get; set; }
        DbSet<VideoRto> Videos { get; set; }
        DbSet<SavedVideoRto> SevedVideos { get; set; }
        DbSet<VideoCommentRto> VideoComments { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
