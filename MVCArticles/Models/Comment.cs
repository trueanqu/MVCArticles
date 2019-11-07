using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCArticles.Models
{
    public class Comment
    {
        public long Id { get; set; }
        public long ArticleId { get; set; }
        public string Author { get; set; }
        public string CommentText { get; set; }
        public long Likes { get; set; }
    }
}
