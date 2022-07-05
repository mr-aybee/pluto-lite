namespace POS_mini.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class courier_v1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Couriers",
                c => new
                    {
                        id = c.Long(nullable: false, identity: true),
                        TrackingID = c.String(maxLength: 300),
                        SaleID = c.Long(nullable: false),
                        CustomerName = c.String(maxLength: 200),
                        CustomerPhone = c.String(maxLength: 200),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Couriers");
        }
    }
}
