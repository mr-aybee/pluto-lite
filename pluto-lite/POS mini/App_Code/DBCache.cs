using System;
using System.Collections.Generic;
using System.Linq;

namespace POS_mini.App_Code
{
    public static class DBCache
    {
        static Models.DBEntities db = new Models.DBEntities();

        public static List<Models.Sale> Sales
        {
            get
            {
                return db.Sales.ToList();
            }
        }
        public static List<Models.SaleItem> SaleItems
        {
            get
            {
                return db.SaleItems.ToList();
            }
        }
        public static List<Models.User> User
        {
            get
            {
                return db.Users.ToList();
            }
        }
        public static List<Models.Invoice> Invoices
        {
            get
            {
                return db.Invoices.ToList();
            }
        }
        public static List<Models.Customer> Customers
        {
            get
            {
                return db.Customers.ToList();
            }
        }
        public static List<Models.CustomerAccount> CustomerAccounts
        {
            get
            {
                return db.CustomerAccounts.ToList();
            }
        }
        public static List<Models.Product> Products
        {
            get
            {
                return db.Products.ToList();
            }
        }
        public static List<Models.ProductType> ProductTypes
        {
            get
            {
                return db.ProductTypes.ToList();
            }
        }
        public static List<Models.Vendor> Vendors
        {
            get
            {
                return db.Vendors.ToList();
            }
        }
        public static List<Models.VendorAccount> VendorAccounts
        {
            get
            {
                return db.VendorAccounts.ToList();
            }
        }

    }

    public class DBStorage
    {
        public List<Models.Vendor> Vendors { get; set; }
        public List<Models.VendorAccount> VendorAccounts { get; set; }
        public List<Models.Sale> Sales { get; set; }
        public List<Models.SaleItem> SaleItems { get; set; }
        public List<Models.User> Users { get; set; }
        public List<Models.Product> Products { get; set; }
        public List<Models.ProductType> ProductTypes { get; set; }
        public List<Models.Invoice> Invoices { get; set; }
        public List<Models.Customer> Customers { get; set; }
        public List<Models.CustomerAccount> CustomerAccounts { get; set; }
        public DateTime DataUpto { get; set; }
    }

}
