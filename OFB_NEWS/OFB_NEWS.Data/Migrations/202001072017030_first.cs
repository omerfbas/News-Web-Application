namespace OFB_NEWS.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(maxLength: 250, unicode: false),
                        ParentId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.ParentId)
                .Index(t => t.ParentId);
            
            CreateTable(
                "dbo.News",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NewsTitle = c.String(),
                        NewsContent = c.String(),
                        CreateDate = c.DateTime(nullable: false),
                        Like = c.Int(nullable: false),
                        ViewsCounter = c.Int(nullable: false),
                        CategoryId = c.Int(nullable: false),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.CategoryId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Comments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CommentTitle = c.String(),
                        CommentContent = c.String(),
                        CreateDate = c.DateTime(nullable: false),
                        NewsId = c.Int(nullable: false),
                        FullName = c.String(),
                        Mail = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.News", t => t.NewsId, cascadeDelete: true)
                .Index(t => t.NewsId);
            
            CreateTable(
                "dbo.Galleries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ImagePath = c.String(),
                        NewsId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.News", t => t.NewsId, cascadeDelete: true)
                .Index(t => t.NewsId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FullName = c.String(),
                        Mail = c.String(),
                        Password = c.String(),
                        RoleId = c.Int(nullable: false),
                        Role = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Categories", "ParentId", "dbo.Categories");
            DropForeignKey("dbo.News", "UserId", "dbo.Users");
            DropForeignKey("dbo.Galleries", "NewsId", "dbo.News");
            DropForeignKey("dbo.Comments", "NewsId", "dbo.News");
            DropForeignKey("dbo.News", "CategoryId", "dbo.Categories");
            DropIndex("dbo.Galleries", new[] { "NewsId" });
            DropIndex("dbo.Comments", new[] { "NewsId" });
            DropIndex("dbo.News", new[] { "UserId" });
            DropIndex("dbo.News", new[] { "CategoryId" });
            DropIndex("dbo.Categories", new[] { "ParentId" });
            DropTable("dbo.Users");
            DropTable("dbo.Galleries");
            DropTable("dbo.Comments");
            DropTable("dbo.News");
            DropTable("dbo.Categories");
        }
    }
}
