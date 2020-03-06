using System;
using System.Collections.Generic;
using System.Text;

namespace SnowballerConsole
{
    public class Bill
    {
        public string Name { get; set; }
        public decimal Total { get; set; }
        public decimal MonthlyPayment { get; set; }
        
        public DateTime MonthsPayOff { get; private set; }
        
        public Bill(string name, decimal total, decimal monthlyPayment)
        {
            Name = name;
            Total = total;
            MonthlyPayment = monthlyPayment;
            MonthsPayOff = DateTime.Now;
        }

        public DateTime GetPayOff(decimal total, decimal monthlyPayment)
        {
            var months = Convert.ToInt32(total / monthlyPayment);
            MonthsPayOff = MonthsPayOff.AddMonths(months);
            return MonthsPayOff;
        }
    }
}
