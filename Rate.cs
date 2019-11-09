using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOTEL
{
    class Rate
    {
        internal Rate(decimal amount, string curr)
        {
            Amount = amount;
            Currency = curr;
        }
        internal decimal Amount { get; set; }
        internal string Currency { get; set; }
        internal string AllDetails
        {
            get
            {
                return $"{Amount} {Currency}";
            }

        }

        internal void Print()
        {
            Console.WriteLine(AllDetails);
        }
    }
}
