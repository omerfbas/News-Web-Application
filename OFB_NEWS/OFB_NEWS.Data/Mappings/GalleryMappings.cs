using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OFB_NEWS.Entities.Entity;

namespace OFB_NEWS.Data.Mappings
{
    public class GalleryMappings : EntityTypeConfiguration<Gallery>
    {
        public GalleryMappings()
        {
            ToTable("Galleries");
            HasKey(x => x.Id);
        }
    }
}
