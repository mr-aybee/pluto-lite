using System;
using System.ComponentModel.DataAnnotations;

namespace POS_mini.Models
{

    public class Customer
    {
        public int ID { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(20)]
        public string Phone { get; set; }
        [StringLength(100)]
        public string Email { get; set; }
    }

    public class CustomerAccount
    {
        public int ID { get; set; }
        public int CustomerID { get; set; }
        public double Amount { get; set; }
        public App_Code.Constants.TransactionType TransactionType { get; set; }
        public int SaleID { get; set; }
        public DateTime DateTime { get; set; }
        public int UserID { get; set; }
    }


    public class Invoice
    {
        public long ID { get; set; }
        public int ProductID { get; set; }
        public double PurchasePriceUnit { get; set; }
        public double Quantity { get; set; }
        public int UserID { get; set; }
        public int VendorID { get; set; }
        public DateTime Datetime { get; set; }
        [StringLength(12)]
        public string oneTimeID { get; set; }
    }

    public class Product
    {
        public int ID { get; set; }
        [StringLength(100)]
        public string Name { get; set; }
        public int TypeID { get; set; }
        public int AlertLevel { get; set; }
        public double SalePrice { get; set; }
        [StringLength(50)]
        public string Barcode { get; set; }
        [StringLength(150)]
        public string Description { get; set; }
    }

    public class ProductType
    {
        public int ID { get; set; }
        [StringLength(50)]
        public string Type { get; set; }
    }


    public class Sale
    {
        public long ID { get; set; }
        public bool isWalkInCustomer { get; set; }
        public int CustomerID { get; set; }
        public int UserID { get; set; }
        public DateTime DateTime { get; set; }
        public double TotalCash { get; set; }
        public double CashRecieved { get; set; }
        public double TotalDiscount { get; set; }
        public double CashReturn { get; set; }
        public int noOfItems { get; set; }
        public App_Code.Constants.SaleType Type { get; set; }
    }


    public class SaleItem
    {
        public long ID { get; set; }
        public int ProductID { get; set; }
        public long SaleID { get; set; }
        public double SalePriceUnit { get; set; }
        public double Quantity { get; set; }
        public double Discount { get; set; }
    }

    public class User
    {
        public int ID { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(50)]
        public string Username { get; set; }
        [StringLength(50)]
        public string Password { get; set; }
        [StringLength(50)]
        public string Phone { get; set; }
        [StringLength(50)]
        public string Rank { get; set; }
        public DateTime DateTime { get; set; }
        public DateTime ExpiryDate { get; set; }
        [StringLength(20)]
        public string expiryUpdatePass { get; set; }
    }


    public class Vendor
    {
        public int ID { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(50)]
        public string Email { get; set; }
        [StringLength(50)]
        public string Phone { get; set; }
        [StringLength(50)]
        public string CompanyName { get; set; }
    }

    public class VendorAccount
    {
        public int ID { get; set; }
        public int VendorID { get; set; }
        [StringLength(12)]
        public string InvoiceID { get; set; }
        public App_Code.Constants.TransactionType TransactionType { get; set; }
        public DateTime DateTime { get; set; }
        public double Amount { get; set; }
        public int UserID { get; set; }
    }

    public class Expense
    {
        public long id { get; set; }
        [StringLength(150)]
        public string Description { get; set; }
        public DateTime DateTime { get; set; }
        public int UserID { get; set; }
        public double amount { get; set; }
    }


    public class PlutoSettings
    {
        public int id { get; set; }
        public string CompanyLogo { get; set; }
        [StringLength(50)]
        public string CompanyName { get; set; }
        [StringLength(20)]
        public string CompanyPhone { get; set; }
        [StringLength(20)]
        public string CompanyPhone2 { get; set; }
        [StringLength(200)]
        public string CompanyAddress { get; set; }
        [StringLength(1000)]
        public string ComapnySaleNote { get; set; }
    }


    public class Courier
    {
        public long id { get; set; }
        [StringLength(300)]
        public string TrackingID { get; set; }
        public long SaleID { get; set; }
        [StringLength(200)]
        public string CustomerName { get; set; }
        [StringLength(200)]
        public string CustomerPhone { get; set; }
    }

}
