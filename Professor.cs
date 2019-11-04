using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tema
{
    class Professor
    {
        public Professor(string name, string faculty, string specialization)
        {
            this.name = name;
            this.faculty = faculty;
            this.specialization = specialization;
        }
        public string name { get; set; }
        public string faculty { get; set; }
        public string specialization { get; set; }

        public string Afisare
        {
            get { return $"Profesorul {name} preda la facultatea {faculty} specializarea {specialization}."; }
        }



    }
}
