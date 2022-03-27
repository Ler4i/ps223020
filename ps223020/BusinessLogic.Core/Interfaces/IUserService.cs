using ps223020.BusinessLogic.Core.Models;
using ps223020.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ps223020.BusinessLogic.Core.Interfaces
{
    public interface IUserService
    {
        Task<UserInformationBlo> Register(string phoneNumberPrefix, string phoneNumber, string password);
        Task<UserInformationBlo> Authenticate(string phoneNumberPrefix, string phoneNumber, string password);
        Task<UserInformationBlo> Get(int userId);

    }
}
