using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace professor
{
    internal class Professor

    {
        internal string Name { get; set; }
        internal string Faculty { get; set; }
        internal string Specialisation { get; set; }
        public string AllDetails
        {
            get
            {
                return $"Professor Name: {Name}, Faculty: {Faculty}, Specialisation: {Specialisation}";
            }
        }
        internal void Print()
        {
            Console.WriteLine(AllDetails);
        }
    }
}
