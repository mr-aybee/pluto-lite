using System.Data.Entity;
using System.Data.SqlServerCe;

namespace POS_mini.Models
{
    class DBEntities : DbContext
    {
        public const string conStringHome = @"Data Source=D:\Repos\pluto-lite\pluto-lite\PlutoDB.sdf;Password=malik@1234";
        public const string conStringDeploy = @"Data Source=|DataDirectory|\PlutoDB.sdf;Password=malik@1234";
        
        public static string conString
        {
            get { return conStringDeploy; }
        }

        public DBEntities() : base(new SqlCeConnection(conString), contextOwnsConnection: true)
        { }

        public virtual DbSet<CustomerAccount> CustomerAccounts { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Invoice> Invoices { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductType> ProductTypes { get; set; }
        public virtual DbSet<Sale> Sales { get; set; }
        public virtual DbSet<SaleItem> SaleItems { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<VendorAccount> VendorAccounts { get; set; }
        public virtual DbSet<Vendor> Vendors { get; set; }
        public virtual DbSet<PlutoSettings> PlutoSettings { get; set; }
        public virtual DbSet<Expense> Expenses { get; set; }
        public virtual DbSet<Courier> Couriers { get; set; }
    }
}
