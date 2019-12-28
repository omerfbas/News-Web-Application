using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OFB_NEWS.Entities.Entity
{
    public class Category
    {
        public Category()
        {
            SubCategories = new HashSet<Category>();
            News = new HashSet<News>();
        }

        public int Id { get; set; }
        public string CategoryName { get; set; }
        public int? ParentId { get; set; }

        public ICollection<Category> SubCategories { get; set; }
        public ICollection<News> News { get; set; }
        
    }
}
