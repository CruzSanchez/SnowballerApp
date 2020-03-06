using System;
using System.Collections.Generic;

namespace SnowballerConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var cont = false;
            List<Bill> bills = new List<Bill>();

            do
            {
                Console.WriteLine("What bill would you like to add? It should be in this format seperated by a comma: {name},{total},{monthly payment}");
                var billInfo = Console.ReadLine();
                try
                {
                    var split = billInfo.Split(",");
                    Bill bill = new Bill(split[0], decimal.Parse(split[1]), decimal.Parse(split[2]));
                    bills.Add(bill);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine();
                    Console.WriteLine(e.StackTrace);
                }

                Console.WriteLine("Add another bill? y/n");
                var userResponse = Console.ReadLine().ToLower();

                if (userResponse == "y")
                    cont = true;
                else
                    cont = false;

            } while (cont);

            foreach (var bill in bills)
            {
                bill.GetPayOff(bill.Total,bill.MonthlyPayment);
                var payoff = bill.MonthsPayOff.ToShortDateString();
                Console.WriteLine($"Your pay off date for {bill.Name} is {payoff}");
            }

        }
    }
}
