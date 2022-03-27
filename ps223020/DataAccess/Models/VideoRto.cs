using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ps223020.DataAccess.Models
{
    public class VideoRto
    {
        public int Id { get; set; }
        public string ContentUrl { get; set; }
        
        public List<VideoCommentRto> VideoComments { get; set; }
        
        public List<SavedVideoRto> SavedVideos { get; set; }


        public int ProfileId { get; set; }
        public ProfileRto Profile { get; set; }
    }
}
