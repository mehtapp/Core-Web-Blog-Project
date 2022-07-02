using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public  class Comment
    {
        [Key]
        public int CommentID { get; set; }
        public string CommentUserName { get; set; }
        public string CommentTitle { get; set; }
        public string CommentContent { get; set; }
        public DateTime CommnetDate { get; set; }
        public bool CommmentStatus { get; set; }
        public int BlogID { get; set; } //ilişki blogla
        public List<Blog> Blogs { get; set; } //ilişki blogla
        



    }
}
