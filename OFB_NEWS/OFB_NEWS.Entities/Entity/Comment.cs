using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace OFB_NEWS.Entities.Entity
{
    public class Comment
    {
        public int Id { get; set; }
        public string CommentTitle { get; set; }
        public string CommentContent { get; set; }
        public DateTime CreateDate { get; set; }

        [ForeignKey("News")]
        public int NewsId { get; set; }
        public News News { get; set; }
        public string FullName { get; set; }
        public string Mail { get; set; }
    }
}