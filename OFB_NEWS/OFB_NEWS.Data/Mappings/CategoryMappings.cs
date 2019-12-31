using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OFB_NEWS.Entities.Entity;

namespace OFB_NEWS.Data.Mappings
{
    public class CategoryMappings : EntityTypeConfiguration<Category>
    {
        public CategoryMappings()
        {
            ToTable("Categories");
            HasKey(x => x.Id);
            Property(x => x.CategoryName).HasColumnType("varchar").HasMaxLength(250);

            //Self Join
            HasMany(x => x.SubCategories).WithOptional().HasForeignKey(g => g.ParentId);
        }
    }
}
