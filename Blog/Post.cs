using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Blog
{
    public class Post
    {
        [Key]
        public Guid PostId { get; set; }
        public DateTime Date { get; set; }
        public string Text { get; set; }
    }
}
