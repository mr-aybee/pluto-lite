namespace POS_mini.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CustomerAccounts",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CustomerID = c.Int(nullable: false),
                        Amount = c.Double(nullable: false),
                        TransactionType = c.Int(nullable: false),
                        SaleID = c.Int(nullable: false),
                        DateTime = c.DateTime(nullable: false),
                        UserID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50),
                        Phone = c.String(maxLength: 20),
                        Email = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Expenses",
                c => new
                    {
                        id = c.Long(nullable: false, identity: true),
                        Description = c.String(maxLength: 150),
                        DateTime = c.DateTime(nullable: false),
                        UserID = c.Int(nullable: false),
                        amount = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Invoices",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        ProductID = c.Int(nullable: false),
                        PurchasePriceUnit = c.Double(nullable: false),
                        Quantity = c.Double(nullable: false),
                        UserID = c.Int(nullable: false),
                        VendorID = c.Int(nullable: false),
                        Datetime = c.DateTime(nullable: false),
                        oneTimeID = c.String(maxLength: 12),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.PlutoSettings",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        CompanyLogo = c.String(maxLength: 4000),
                        CompanyName = c.String(maxLength: 50),
                        CompanyPhone = c.String(maxLength: 20),
                        CompanyPhone2 = c.String(maxLength: 20),
                        CompanyAddress = c.String(maxLength: 200),
                        ComapnySaleNote = c.String(maxLength: 1000),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 100),
                        TypeID = c.Int(nullable: false),
                        AlertLevel = c.Int(nullable: false),
                        SalePrice = c.Double(nullable: false),
                        Barcode = c.String(maxLength: 50),
                        Description = c.String(maxLength: 150),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.ProductTypes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Type = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.SaleItems",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        ProductID = c.Int(nullable: false),
                        SaleID = c.Long(nullable: false),
                        SalePriceUnit = c.Double(nullable: false),
                        Quantity = c.Double(nullable: false),
                        Discount = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Sales",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        isWalkInCustomer = c.Boolean(nullable: false),
                        CustomerID = c.Int(nullable: false),
                        UserID = c.Int(nullable: false),
                        DateTime = c.DateTime(nullable: false),
                        TotalCash = c.Double(nullable: false),
                        CashRecieved = c.Double(nullable: false),
                        TotalDiscount = c.Double(nullable: false),
                        CashReturn = c.Double(nullable: false),
                        noOfItems = c.Int(nullable: false),
                        Type = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50),
                        Username = c.String(maxLength: 50),
                        Password = c.String(maxLength: 50),
                        Phone = c.String(maxLength: 50),
                        Rank = c.String(maxLength: 50),
                        DateTime = c.DateTime(nullable: false),
                        ExpiryDate = c.DateTime(nullable: false),
                        expiryUpdatePass = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.VendorAccounts",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        VendorID = c.Int(nullable: false),
                        InvoiceID = c.String(maxLength: 12),
                        TransactionType = c.Int(nullable: false),
                        DateTime = c.DateTime(nullable: false),
                        Amount = c.Double(nullable: false),
                        UserID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Vendors",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50),
                        Email = c.String(maxLength: 50),
                        Phone = c.String(maxLength: 50),
                        CompanyName = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Vendors");
            DropTable("dbo.VendorAccounts");
            DropTable("dbo.Users");
            DropTable("dbo.Sales");
            DropTable("dbo.SaleItems");
            DropTable("dbo.ProductTypes");
            DropTable("dbo.Products");
            DropTable("dbo.PlutoSettings");
            DropTable("dbo.Invoices");
            DropTable("dbo.Expenses");
            DropTable("dbo.Customers");
            DropTable("dbo.CustomerAccounts");
        }
    }
}
