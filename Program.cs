using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tema
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Manole Robert", "FEAA", 3);
            Console.WriteLine(student1.Afisare);

            Professor profesor1 = new Professor("Ion Vasile", "Automatica Si Calculatoare", "IT");
            Console.WriteLine(profesor1.Afisare);
        }
    }
}
