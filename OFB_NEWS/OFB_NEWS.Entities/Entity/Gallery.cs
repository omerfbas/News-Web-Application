using System.ComponentModel.DataAnnotations.Schema;

namespace OFB_NEWS.Entities.Entity
{
    public class Gallery
    {
        public int Id { get; set; }
        public string ImagePath { get; set; }
        [ForeignKey("News")]
        public int NewsId { get; set; }
        public News News { get; set; }
    }
}