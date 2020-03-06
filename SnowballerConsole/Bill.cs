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

        private DateTime _monthsPayOff;

        public DateTime MonthsPayOff
        {
            get { return _monthsPayOff; }            
        }
        
        public Bill(string name, decimal total, decimal monthlyPayment)
        {
            Name = name;
            Total = total;
            MonthlyPayment = monthlyPayment;
            _monthsPayOff = DateTime.Now;
        }

        public DateTime GetPayOff(decimal total, decimal monthlyPayment)
        {
            var months = Convert.ToInt32(total / monthlyPayment);
            _monthsPayOff = _monthsPayOff.AddMonths(months);
            return _monthsPayOff;
        }
    }
}
