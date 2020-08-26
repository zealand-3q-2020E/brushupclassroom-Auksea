using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class Student
    {
        protected string Name { get; set; }
        protected int BirthMonth { get; set; }
        protected int Birthday { get; set; }

        public Student(string name, int birthMont, int birthday)
        {
            Name = name;
            BirthMonth = birthMont;
            Birthday = birthday;
        }



    }
}
