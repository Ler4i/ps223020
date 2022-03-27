using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ps223020.DataAccess.Models
{
    public class UserRto
    {
        public int Id { get; set; }
        public string Nickname { get; set; }
        public bool IsBoy { get; set; }
        public DateTimeOffset Birthday { get; set; }
        public int PhoneNumberPrefix { get; set; }
        public int PhoneNumber { get; set; }
        public string Email { get; set; }
        public string AvatarUrl { get; set; }
        public string Token { get; set; }

        public ProfileRto Profiles { get; set; }

        public List<FriendsRto> FirstUserFriends { get; set; }
        public List<FriendsRto> SecondUserFriends { get; set; }

    }
}
