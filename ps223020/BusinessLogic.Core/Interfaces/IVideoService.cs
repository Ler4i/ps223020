using ps223020.BusinessLogic.Core.Models;
using ps223020.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ps223020.BusinessLogic.Core.Interfaces
{
    interface IVideoService
    {
        Task<VideoInformationBlo> Get(int videoId);
        Task<VideoInformationBlo> Add(int profileId, string contentUrl);

    }
}
