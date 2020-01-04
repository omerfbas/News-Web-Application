using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OFB_NEWS.Entities.Entity;

namespace OFB_NEWS.Data.Mappings
{
    public class CommentMappings : EntityTypeConfiguration<Comment>
    {
        public CommentMappings()
        {
            ToTable("Comments");
            HasKey(x => x.Id);
        }
    }
}
