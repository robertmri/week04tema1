using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOTEL
{
    internal class Room
    {
        internal Room(string name, Rate rate, int adult, int children)
        {
            Name = name;
            Rate = rate;
            Adult = adult;
            Children = children;
        }
        internal string Name { get; set; }
        internal Rate Rate { get; set; }
        internal int Adult { get; set; }
        internal int Children { get; set; }
        internal string AllDetails
        {
            get
            {
                return $"Room Name: {Name}, Rate: {Rate.AllDetails}, Adult: {Adult}, Children: {Children}";
            }
        }
        internal string GetPriceForDays(int NrOfDays)
        {
            return $"Total amount for the {NrOfDays} days is: {Rate.Amount * NrOfDays} {Rate.Currency}";
        }
        internal void Print()
        {
            Console.WriteLine(AllDetails);
        }
    }
}
