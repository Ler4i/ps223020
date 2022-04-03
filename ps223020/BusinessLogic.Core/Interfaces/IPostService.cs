using ps223020.BusinessLogic.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ps223020.BusinessLogic.Core.Interfaces
{
    interface IPostService
    {
        Task<List<UserMultimediaPostBlo>> GetFeedPosts(int userId, int count, int skipCount);
        Task<List<UserMultimediaPostBlo>> GetProfilePosts(int autorId, int count, int skipCount);
        Task<int> GetProfilePostAmount(int userId);
        Task<UserMultimediaPostBlo> Add (PostAddBlo postAddBlo);
        Task<UserMultimediaPostBlo> Update(int postId, UserMultimediaPostUpdateBlo userMultimediaPostUpdateBlo);
        Task<UserMultimediaPostBlo> Delete(int  postId);


    }
}
