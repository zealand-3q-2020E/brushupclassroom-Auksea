using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassRoom ClassName = new ClassRoom();
            ClassName.ClassName = "3Q";
            ClassName.SemesterStart = new DateTime(2019,8,26);
            ClassName.ClassList = new List<Student>
            {
                new Student ("Aukse",8,17),
                new Student ("Vlad",3,21)
            };

        }
    }
}


    

