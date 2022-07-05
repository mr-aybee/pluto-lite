using System.Collections.Generic;

namespace POS_mini.Models
{
    public class InvoicesItemsRepo
    {
        public string VendorID { get; set; }
        public string DateTime { get; set; }
        public List<InvoicesList> InvoicesLists { get; set; }
        public string SameID { get; set; }
        public int UserID { get; set; }
    }

    public class InvoicesList
    {
        public long ProductID { get; set; }
        public float Quantity { get; set; }
        public double PurchasePricePerQuantity { get; set; }
        public double UnitTotal
        {
            get
            {
                return Quantity * PurchasePricePerQuantity;
            }
        }
    }

    public class SaleItemsRepo
    {
        public int ProductID { get; set; }
        public double Quantity { get; set; }
        public double SalePricePerQuantity { get; set; }
        public double DiscountPKR { get; set; }
        public double UntTotalWithDiscount
        {
            get
            {
                return (Quantity * SalePricePerQuantity) - DiscountPKR;
            }
        }
        public double UnitTotal
        {
            get
            {
                return Quantity * SalePricePerQuantity;
            }
        }
    }

    public class KeyValues
    {
        public string Name { get; set; }
        public int Value { get; set; }
    }

    public class ProfitAndSale
    {
        public double SalePriceQty { get; set; }
        public double PurchasePriceQty { get; set; }
        public double SoldQty { get; set; }
        public double saleTotal
        {
            get
            {
                return SoldQty * SalePriceQty;
            }
        }
        public double PurchaseTotal
        {
            get
            {
                return SoldQty * PurchasePriceQty;
            }
        }
    }



}
