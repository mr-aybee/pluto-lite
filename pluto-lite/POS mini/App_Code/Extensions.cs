using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_mini.App_Code
{
    public static class Extensions
    {
        public static double ToDouble(this object val)
        {
            if (val == null && string.IsNullOrEmpty(val.ToString()))
                return 0;
            double outVal = 0;
            if (double.TryParse(val.ToString(), out outVal))
            {
                return outVal;
            }
            return 0;
        }
        public static int ToInt32(this object val)
        {
            if (val == null && string.IsNullOrEmpty(val.ToString()))
                return 0;
            int outVal = 0;
            if (int.TryParse(val.ToString(), out outVal))
            {
                return outVal;
            }
            return 0;
        }
    }
}
