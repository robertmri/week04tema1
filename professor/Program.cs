using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace professor
{
    class Program
    {
        static void Main(string[] args)
        {

            Professor prof1 = new Professor();
            prof1.Faculty = "FEAA";
            prof1.Name = "MRI ROBERT";
            prof1.Specialisation = "Finante Banci";

            Student s = new Student();
            s.Faculty = "IT";
            s.Name = "Costel Barzu";
            s.Year = 1;

            Curs c = new Curs();
            c.StudentList = new List<Student>();
            c.StudentList.Add(s);
            c.Professor = prof1;
            c.Year = 3;
            c.Name = "Constructii";
            c.Print();
        }  
    }
}
