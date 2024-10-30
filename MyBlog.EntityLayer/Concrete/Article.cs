﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.EntityLayer.Concrete
{
    public class Article
    {
        public int ActicleId { get; set; }
        public string Title { get; set; }
        //public int CategoryId { get; set; }
        //public Category Category { get; set; }
        public DateTime CreateDate { get; set; }
        public string CoverImageUrl { get; set; }
        public string MainImageUrl { get; set; }
    }
}
