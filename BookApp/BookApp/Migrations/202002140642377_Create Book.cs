namespace BookApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateBook : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Authors",
                c => new
                    {
                        aid = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        adress = c.String(),
                    })
                .PrimaryKey(t => t.aid);
            
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        bid = c.Int(nullable: false, identity: true),
                        title = c.String(),
                        price = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.bid);
            
            CreateTable(
                "dbo.Details",
                c => new
                    {
                        bid = c.Int(nullable: false, identity: true),
                        aid = c.Int(nullable: false),
                        book_bid = c.Int(),
                    })
                .PrimaryKey(t => t.bid)
                .ForeignKey("dbo.Authors", t => t.aid, cascadeDelete: true)
                .ForeignKey("dbo.Books", t => t.book_bid)
                .Index(t => t.aid)
                .Index(t => t.book_bid);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Details", "book_bid", "dbo.Books");
            DropForeignKey("dbo.Details", "aid", "dbo.Authors");
            DropIndex("dbo.Details", new[] { "book_bid" });
            DropIndex("dbo.Details", new[] { "aid" });
            DropTable("dbo.Details");
            DropTable("dbo.Books");
            DropTable("dbo.Authors");
        }
    }
}
