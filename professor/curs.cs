using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace professor
{
    class Curs
    {
        internal string Name { get; set; }
        internal Professor Professor { get; set; }
        internal int Year { get; set; }
        internal List<Student> StudentList { get; set; }
        public string AllDetails
        {
            get
            {
                return $"Course Name: {Name},\nProfessor: {Professor.AllDetails},Year: {Year}";
            }

        }

        internal void Print()
        {
            Console.WriteLine(AllDetails);
            foreach (var item in StudentList)
            {
                Console.WriteLine($"Student Name: {item.Name}, Faculty: {item.Faculty}, Year: {item.Year}");
            }
        }
    }
}
