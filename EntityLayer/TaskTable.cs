using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class TaskTable
    {
        [Key]
        public int taskId { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string owner { get; set; }
        public int status { get; set; }
        public int commentId { get; set; }
        public Comment Comment { get; set; }

    }
}
