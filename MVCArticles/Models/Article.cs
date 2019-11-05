using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCArticles.Models
{
    public class Article
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string Content { get; set; }
        public List<string> Tags { get; set; }

    }
}
