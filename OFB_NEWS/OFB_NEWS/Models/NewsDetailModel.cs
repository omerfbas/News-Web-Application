using OFB_NEWS.Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OFB_NEWS.Models
{
    public class NewsDetailModel
    {
        public NewsDetailModel()
        {
            Comments = new List<Comment>();
        }
        public Category Category { get; set; }
        public News News { get; set; }
        public List<Comment> Comments { get; set; }
    }
}