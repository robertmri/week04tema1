using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tema
{
    class Student
    {
        public Student(string name, string faculty, int year)
        {
            this.name = name;
            this.faculty = faculty;
            this.year = year;

        }


        public string name { get; set; }

        public string faculty { get; set; }
        public int year { get; set; }

        public string Afisare
        {
            get { return $"Studentul {name} este la facultatea {faculty} in anul {year}."; }
        }

    }
}
