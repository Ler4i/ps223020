using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ps223020.DataAccess.Models
{
    public class FriendsRto
    {
        public int FirstUserId { get; set; }
        public UserRto FirstUser { get; set; }

        public int SecondUserId { get; set; }
        public UserRto SecondUser { get; set; }
    }
}
