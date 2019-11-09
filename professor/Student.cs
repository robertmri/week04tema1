using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace professor
{
    internal class Student
    {
         
        internal string Name { get; set; }
        internal string Faculty { get; set; }
        internal int Year { get; set; }
        internal string AllDetails
        {
            get
            {
                return $"Student Name: {Name}, Faculty: {Faculty}, Year: {Year}";
            }
        }

        internal void Print()
        {
            Console.WriteLine(AllDetails);
        }
    }
}
