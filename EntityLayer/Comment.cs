using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Comment
    {
        [Key]
        public int commentId { get; set; }
        public string commentOwner { get; set; }
        public string commentDescription { get; set; }
        ICollection<Comment> Comments { get; set; }
    }
}
