using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ps223020.DataAccess.Models
{
    public class SavedVideoRto
    {
        public int ProfileId { get; set; }
        public ProfileRto Profile { get; set; }

        public int VideoId { get; set; }
        public VideoRto Video { get; set; }
    }
}
