using ps223020.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ps223020.BusinessLogic.Core.Interfaces
{
    public interface ISavedVideoService
    {
        Task<SavedVideoRto> Add(int videoId);
        Task<SavedVideoRto> Delete(int VideoId);
    }
}
