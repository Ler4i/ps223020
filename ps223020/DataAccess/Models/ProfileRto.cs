using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ps223020.DataAccess.Models
{
    public class ProfileRto
    {
        [Key] public int Id { get; set; }
        public string HatImageUrl { get; set; }

        public int UserId { get; set; }
        public UserRto User { get; set; }

        public List<SavedVideoRto> SavedVideos { get; set; }

        public List<VideoRto> Videos { get; set; }
    }
}
