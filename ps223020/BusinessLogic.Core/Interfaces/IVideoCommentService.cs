using ps223020.BusinessLogic.Core.Models;
using ps223020.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ps223020.BusinessLogic.Core.Interfaces
{
    public interface IVideoCommentService
    {
        Task<VideoCommentsInformationBlo> Add(int videoId, string text);
        Task<VideoCommentsInformationBlo> Delete(int videoId);
        Task<VideoCommentsInformationBlo> Change(int videoId, string text);
    }
}
