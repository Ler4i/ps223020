using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ps223020.DataAccess.Models
{
    [Table("MultimediaPostComment")]
    public class MultimediaPostCommentRto
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public DateTimeOffset DateTimeStamp { get; set; }

        public int UserId { get; set; }
        public UserRto User { get; set; }

        public int UserMultimediaPostRtoId { get; set; }
        public UserMultimediaPostRto UserMultimediaPostRto { get; set; }
    }
}
