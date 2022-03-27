using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ps223020.DataAccess.Models
{
    public class VideoCommentRto
    {
        public int VideoCommentId { get; set; }
        public string Text { get; set; }
        public DateTimeOffset DataTimeStamp { get; set; }

        public int VideoId { get; set; }
        public VideoRto Video { get; set; }
    }
}
