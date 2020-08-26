using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class ClassRoom
    {
        public string ClassName;
        public List<Student> ClassList = new List<Student>();
        public DateTime SemesterStart;

        public ClassRoom() { }

    }
}
