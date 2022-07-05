using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;


namespace POS_mini.App_Code
{
    public static class Constants
    {
        public enum ReportTypes { CustomerPaySlip , CustomerReportFile, InvoiceReportFile, InvoiceSlip, SaleSheet, VendorPaySlip, VendorReportFile, SaleSlip ,ProductReport, BarcodeSlip}

        static Random random = new Random();
        public static string GetRandomString(int Digits)
        {
            return new string(Enumerable.Repeat("ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789", Digits)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        public static readonly string DBPath = Environment.CurrentDirectory + "\\PlutoDB.sdf";
        public static readonly string UserSession = Environment.CurrentDirectory + "/UserCookie.txt";
        public static void WriteCookie(int userID)
        {
            System.IO.File.WriteAllText(UserSession, userID.ToString());
        }

        internal static int UserID
        {
            get
            {
                return Convert.ToInt32(System.IO.File.ReadAllText(UserSession));
            }
        }
        public static DataTable ToDataTable<T>(List<T> items)
        {
            DataTable dataTable = new DataTable(typeof(T).Name);
            PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo prop in Props)
            {
                var type = (prop.PropertyType.IsGenericType && prop.PropertyType.GetGenericTypeDefinition() == typeof(Nullable<>) ? Nullable.GetUnderlyingType(prop.PropertyType) : prop.PropertyType);
                dataTable.Columns.Add(prop.Name, type);
            }
            foreach (T item in items)
            {
                var values = new object[Props.Length];
                for (int i = 0; i < Props.Length; i++)
                {
                    values[i] = Props[i].GetValue(item, null);
                }
                dataTable.Rows.Add(values);
            }
            return dataTable;
        }
        public static readonly string barcodeImage = Environment.CurrentDirectory + "\\sbCode.jpeg";
        public static readonly string cLogoImage = Environment.CurrentDirectory + "\\cLogo.png";

        public enum TransactionType { debit, credit }
        public enum SaleType { sale, return_ }


        //////////////////////////
        ///queries//
        ////////

        public static string SaleReportQuery(DateTime StartDate, DateTime EndDate)
        {

            return "select BB.ID,AA.isWalkInCustomer,CC.Name as Customer,BB.Name as Product,BB.Quantity,BB.SalePriceUnit,BB.Quantity*BB.SalePriceUnit as UnitTotal,AA.DateTime from( ( select A.ID , A.isWalkInCustomer,A.CustomerID,A.DateTime from Sales A where A.DateTime >= '" + StartDate.ToString() + "' and A.DateTime <= '" + EndDate.ToString() + "')AA left join ( select SII.ID, SII.SaleID,SII.Quantity,SII.SalePriceUnit,SII.Discount,PP.Name from ( ( select SI.ID, SI.ProductID,SI.SaleID,SI.Quantity,SI.SalePriceUnit,SI.Discount from SaleItems SI )SII LEFT JOIN ( select P.ID, P.Name from Products P )PP On (SII.ProductID = PP.ID) ) ) BB on ( BB.SaleID = AA.ID) left join ( select C.ID, C.Name from Customers C )CC on (CC.ID=AA.CustomerID) )";
        }



        //////////////
        ////Dashboard Queries
        ///
        public const string productAlertNotif = "select Top(1000) PP.Name as ProductName,PP.AlertLevel, CASE WHEN(SS.IQuantity-SS.SQuantity) IS NULL THEN 0 ELSE (SS.IQuantity-SS.SQuantity) END as Stock from ( select P.ID, P.Name,P.AlertLevel from products P) PP left join ( select II.IQuantity,SII.SQuantity,II.PID from ( select I.ProductID as PID , Sum(I.Quantity) as IQuantity from Invoices I group by I.ProductID )II INNER JOIN ( select SI.ProductID as PID , Sum(SI.Quantity) as SQuantity from SaleItems SI group by SI.ProductID )SII on (II.PID = SII.PID) )SS on (PP.ID = SS.PID) where PP.AlertLevel > CASE WHEN (SS.IQuantity-SS.SQuantity) IS NULL THEN 0 ELSE (SS.IQuantity-SS.SQuantity) END order by PP.Name";
        public const string todaysSaleGraphQuery = "select SIP.Name as ProductName,sum(SIP.Quantity) as Count from( select S.ID from Sales S where S.DateTime> DateAdd(day,-1,GetDAte()) and S.DateTime <= Getdate()) SS left join ( select SSI.SaleID,PP.Name,SSI.Quantity from ( select SI.SaleID,SI.ProductID,SI.Quantity from SaleItems SI )SSI left join ( select P.Name,P.ID from Products P )PP on (SSI.ProductID=PP.ID) ) SIP on (SIP.SaleID = SS.ID) group by Name";
        public const string todaysInvoiceGraphQuery = "select PP.Name as ProductName,Sum(II.Quantity) as Count from( select I.ProductID,I.Quantity from Invoices I where DAteTime > DateAdd(Day,-1,GETDATE())) II left join ( select P.Name ,P.ID from Products p )PP on (PP.ID= II.ProductID) group by PP.Name";
        public const string DayValuesQuery = "select 'Net Amount Sale' as Type, Case When Cast((Sum(SII.NetAmount)) as bigint) IS NULL THEN 0 ELSE Cast((Sum(SII.NetAmount)) as bigint) END as Amount from( select S.ID,S.DateTime from Sales S where DateTime >= DateAdd(Day,-1,GetDate())) SS left join ( select SI.SaleID,SI.SalePriceUnit,SI.Quantity,SI.Discount, ( (SI.SalePriceUnit*SI.Quantity)-SI.Discount)as NetAmount from SaleItems SI )SII on (SS.ID=SII.SaleID) Union All select 'Expence' as Type, cast(Sum(amount) as bigint) as Amount from Expenses where DateTime >= DateAdd(Day,-1,GetDate()) Union All select 'Discount Given' as Type, Case When Cast((Sum(SII.Discount)) as bigint) IS NULL THEN 0 ELSE Cast((Sum(SII.Discount)) as bigint) END as Amount from ( select S.ID,S.DateTime from Sales S where DateTime >= DateAdd(Day,-1,GetDate()) ) SS left join ( select SI.SaleID,SI.SalePriceUnit,SI.Quantity,SI.Discount, ( (SI.SalePriceUnit*SI.Quantity)-SI.Discount)as NetAmount from SaleItems SI )SII on (SS.ID=SII.SaleID) Union All select 'Profit Without Expenses' as Type, Cast(SUM(SOLD.TotalSoldAmount - ((INVOICED.TotalPurcahse/INVOICED.IQuantity)*SOLD.SQuantity)) as bigint) as Value from ( select SSI.ProductID,Sum(SSI.Quantity) as SQuantity, Sum(SoldAmount) as TotalSoldAmount from ( select S.ID,S.DateTime from Sales S where DateTime >= DateAdd(Day,-1,GetDate()) )SS left join ( select SI.SaleID,SI.ProductID,SI.Quantity,((SI.Quantity*SI.SalePriceUnit)-SI.Discount) as SoldAmount from SaleItems SI )SSI on (SS.ID = SSI.SaleID) group By SSI.ProductID ) SOLD left join ( select I.ProductID, SUM(I.Quantity*I.PurchasePriceUnit) as TotalPurcahse,SUM(I.Quantity) as IQuantity from invoices I group by I.ProductID ) INVOICED on(SOLD.ProductID= INVOICED.ProductID) ";
        public const string MonthValuesQuery = "select 'Net Amount Sale' as Type, Case When Cast((Sum(SII.NetAmount)) as bigint) IS NULL THEN 0 ELSE Cast((Sum(SII.NetAmount)) as bigint) END as Amount from( select S.ID,S.DateTime from Sales S where DateTime >= DateAdd(Month,-1,GetDate())) SS left join ( select SI.SaleID,SI.SalePriceUnit,SI.Quantity,SI.Discount, ( (SI.SalePriceUnit*SI.Quantity)-SI.Discount)as NetAmount from SaleItems SI )SII on (SS.ID=SII.SaleID) Union All select 'Expence' as Type, cast(Sum(amount) as bigint) as Amount from Expenses where DateTime >= DateAdd(Month,-1,GetDate()) Union All select 'Discount Given' as Type, Case When Cast((Sum(SII.Discount)) as bigint) IS NULL THEN 0 ELSE Cast((Sum(SII.Discount)) as bigint) END as Amount from ( select S.ID,S.DateTime from Sales S where DateTime >= DateAdd(Month,-1,GetDate()) ) SS left join ( select SI.SaleID,SI.SalePriceUnit,SI.Quantity,SI.Discount, ( (SI.SalePriceUnit*SI.Quantity)-SI.Discount)as NetAmount from SaleItems SI )SII on (SS.ID=SII.SaleID) Union All select 'Profit Without Expenses' as Type, Cast(SUM(SOLD.TotalSoldAmount - ((INVOICED.TotalPurcahse/INVOICED.IQuantity)*SOLD.SQuantity)) as bigint) as Value from ( select SSI.ProductID,Sum(SSI.Quantity) as SQuantity, Sum(SoldAmount) as TotalSoldAmount from ( select S.ID,S.DateTime from Sales S where DateTime >= DateAdd(Month,-1,GetDate()) )SS left join ( select SI.SaleID,SI.ProductID,SI.Quantity,((SI.Quantity*SI.SalePriceUnit)-SI.Discount) as SoldAmount from SaleItems SI )SSI on (SS.ID = SSI.SaleID) group By SSI.ProductID ) SOLD left join ( select I.ProductID, SUM(I.Quantity*I.PurchasePriceUnit) as TotalPurcahse,SUM(I.Quantity) as IQuantity from invoices I group by I.ProductID ) INVOICED on(SOLD.ProductID= INVOICED.ProductID) ";
        public const string WeekValuesQuery = "select 'Net Amount Sale' as Type, Case When Cast((Sum(SII.NetAmount)) as bigint) IS NULL THEN 0 ELSE Cast((Sum(SII.NetAmount)) as bigint) END as Amount from( select S.ID,S.DateTime from Sales S where DateTime >= DateAdd(Week,-1,GetDate())) SS left join ( select SI.SaleID,SI.SalePriceUnit,SI.Quantity,SI.Discount, ( (SI.SalePriceUnit*SI.Quantity)-SI.Discount)as NetAmount from SaleItems SI )SII on (SS.ID=SII.SaleID) Union All select 'Expence' as Type, cast(Sum(amount) as bigint) as Amount from Expenses where DateTime >= DateAdd(Week,-1,GetDate()) Union All select 'Discount Given' as Type, Case When Cast((Sum(SII.Discount)) as bigint) IS NULL THEN 0 ELSE Cast((Sum(SII.Discount)) as bigint) END as Amount from ( select S.ID,S.DateTime from Sales S where DateTime >= DateAdd(Week,-1,GetDate()) ) SS left join ( select SI.SaleID,SI.SalePriceUnit,SI.Quantity,SI.Discount, ( (SI.SalePriceUnit*SI.Quantity)-SI.Discount)as NetAmount from SaleItems SI )SII on (SS.ID=SII.SaleID) Union All select 'Profit Without Expenses' as Type, Cast(SUM(SOLD.TotalSoldAmount - ((INVOICED.TotalPurcahse/INVOICED.IQuantity)*SOLD.SQuantity)) as bigint) as Value from ( select SSI.ProductID,Sum(SSI.Quantity) as SQuantity, Sum(SoldAmount) as TotalSoldAmount from ( select S.ID,S.DateTime from Sales S where DateTime >= DateAdd(Week,-1,GetDate()) )SS left join ( select SI.SaleID,SI.ProductID,SI.Quantity,((SI.Quantity*SI.SalePriceUnit)-SI.Discount) as SoldAmount from SaleItems SI )SSI on (SS.ID = SSI.SaleID) group By SSI.ProductID ) SOLD left join ( select I.ProductID, SUM(I.Quantity*I.PurchasePriceUnit) as TotalPurcahse,SUM(I.Quantity) as IQuantity from invoices I group by I.ProductID ) INVOICED on(SOLD.ProductID= INVOICED.ProductID) ";



    }

    class WinAPI
    {
        public const int HOR_Positive = 0X1;
        public const int HOR_NEGATIVE = 0X2;
        public const int VER_POSITIVE = 0X4;
        public const int VER_NEGATIVE = 0X8;
        public const int CENTER = 0X10;
        public const int BLEND = 0X80000;

        /// <summary>
        /// Ued For Animations
        /// </summary>
        /// <param name="hwand"></param>
        /// <param name="dwTime"></param>
        /// <param name="dwFlag"></param>
        /// <returns></returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int AnimateWindow(IntPtr hwand, int dwTime, int dwFlag);
        /// <summary>
        /// Used For Beep Sound
        /// </summary>
        /// <param name="freq">Frequency</param>
        /// <param name="duration">Duration</param>
        /// <returns></returns>
        [DllImport("kernel32.dll")]
        public static extern bool Beep(int freq, int duration);








    }
}
