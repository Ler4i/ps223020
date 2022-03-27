using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ps223020.BusinessLogic.Core.Models
{
    public class UserInformationBlo
    {
        public string Nickname { get; set; }
        public bool IsBoy { get; set; }
        public DateTimeOffset Birthday { get; set; }
        public string PhoneNumberPrefix { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string AvatarUrl { get; set; }
    }
}
