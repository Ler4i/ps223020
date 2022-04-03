using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ps223020.DataAccess.Models
{
    [Table("UserMultimediaPost")]
    public class UserMultimediaPostRto
    {
        public int Id { get; set; }
        public DateTimeOffset DateTimeStamp { get; set; }
        public string Description { get; set; }
        public bool IsDelete { get; set; }

        public int UserId { get; set; }
        public UserRto User { get; set; }

        public List<MultimediaPostCommentRto> MultimediaComments { get; set; }
    }
}
