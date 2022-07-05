namespace POS_mini.App_Code
{
    /// <summary>
    /// SaleSlip
    /// </summary>
    public class SaleDetailRpt
    {
        public string SaleID { get; set; }
        public string CustomerName { get; set; }
        public string CustomerPhone { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public string TotalPrice { get; set; }
        public string TotalDiscount { get; set; }
        public string NetAmount { get; set; }
        public string AmountReceived { get; set; }
        public string CashReturn { get; set; }
    }
    public class ItemsListRpt
    {
        public string ID { get; set; }
        public string ProductName { get; set; }
        public string Quantity { get; set; }
        public string UnitPrice { get; set; }
        public string UnitTotal { get; set; }
    }


    /// <summary>
    /// Invoices Reports
    /// </summary>
    public class InvoicesDetailsRpt
    {
        public string VendorName { get; set; }
        public string FromDate { get; set; }
        public string TotalInvoice { get; set; }
        public string TotalProductsInvoice { get; set; }
    }
    public class AllInvoicesRpt
    {
        public string ID { get; set; }
        public string ProductName { get; set; }
        public string VendorName { get; set; }
        public string Quantity { get; set; }
        public string UnitPrice { get; set; }
        public string UnitTotal { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public string InvoiceID { get; set; }
    }

    /// <summary>
    /// Products Reports
    /// </summary>
    public class ProductsInventoryRpt
    {
        public string ID { get; set; }
        public string ProductName { get; set; }
        public string TotalPurchase { get; set; }
        public string Invoiced { get; set; }
        public string Stock { get; set; }
        public string Sold { get; set; }
        public string SalePrice { get; set; }
    }


    public class PayRpt
    {
        public string Name { get; set; }
        public string Date { get; set; }
        public string AmountPaid { get; set; }
        public string RemainingAmount { get; set; }
    }

    /////////////////
    ///
    public class SInvoiceRpt
    {
        public string InvoiceID { get; set; }
        public string VendorName { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public string CashPaid { get; set; }
        public string CashRemaining { get; set; }
        public string TotalPayment { get; set; }
    }

    /////////////////////
    public class PayRecord
    {
        public string ID { get; set; }
        public string CustomerOrVendorName { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public string Amount { get; set; }
        public string PaymentType { get; set; }
        public string SaleStatus { get; set; }
        public string SaleAmount { get; set; }
    }


    public class MultiSaleRecord
    {
        public string ID { get; set; }
        public string ProductName { get; set; }
        public string CustomerName { get; set; }
        public string Quantity { get; set; }
        public string SalePrice { get; set; }
        public string UnitTotal { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
    }
}
