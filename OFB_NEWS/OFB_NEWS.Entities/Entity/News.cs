using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace OFB_NEWS.Entities.Entity
{
    public class News
    {
        public News()
        {
            Galleries = new HashSet<Gallery>();
            Comments = new HashSet<Comment>();
        }
        public int Id { get; set; }
        public string NewsTitle { get; set; }

        public string NewsContent { get; set; }
        public DateTime CreateDate { get; set; }
        public int Like { get; set; }
        public int ViewsCounter { get; set; }
        public ICollection<Gallery> Galleries { get; set; }

        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}