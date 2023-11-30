using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day12.NewFolder
{
    public class Student : Person
    {
       public string Qulification;
        public bool IsIntern;
        public int Grade;
        public int TotalHours;
        public Student()
        {

        }
        public Student(int SSd, string Name, bool HasJoB,string qulification, bool isIntern, int grade, int totalHours) :base(SSd, Name,HasJoB)
        {
            Qulification = qulification;
            IsIntern = isIntern;
            Grade = grade;
            TotalHours = totalHours;
        }
        public void StudentInf()
        {
            Console.WriteLine("**************Student class*****************");
            Console.WriteLine($"{SSd} , {Name} , {HasJoB}, {Qulification},  {IsIntern},  {Grade} , {TotalHours}");
            Console.WriteLine("*******************************");
        }
    }
}
