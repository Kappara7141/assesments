namespace EF_Customerdemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateProduct : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        cid = c.Int(nullable: false, identity: true),
                        cname = c.String(),
                        clist = c.String(),
                        
                    })
                .PrimaryKey(t => t.cid);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        pid = c.Int(nullable: false, identity: true),
                        pname = c.String(),
                        price = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.pid);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Products");
            DropTable("dbo.Customers");
        }
    }
}
