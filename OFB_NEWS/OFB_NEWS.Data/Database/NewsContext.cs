using OFB_NEWS.Data.Mappings;
using OFB_NEWS.Entities.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OFB_NEWS.Data.Database
{
    public class NewsContext : DbContext
    {
        public NewsContext()
            : base("defaultConnection")
        {
            //alternatif 
            //@ isareti burada ozel karakterleri kullanmamizi sagliyor.
            //Database.Connection.ConnectionString = @"Server=OMER\MSSQLSERVER01;Database=NewsDB;Trusted_connection=true;";

            var id = System.Data.Entity.SqlServer.SqlProviderServices.Instance;
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Gallery> Galleries { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            this.Configuration.LazyLoadingEnabled = false;

            modelBuilder.Configurations.Add(new CategoryMappings());
            modelBuilder.Configurations.Add(new CommentMappings());
            modelBuilder.Configurations.Add(new GalleryMappings());
            modelBuilder.Configurations.Add(new NewsMappings());
            modelBuilder.Configurations.Add(new UserMappings());
        }

       
    }
}
