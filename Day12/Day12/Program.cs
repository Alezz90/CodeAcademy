using Day12.NewFolder;
using System.Runtime.InteropServices;

namespace Day12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Phone ph = new Phone(9);
              ph.AddPhone( "Nam1", 2222);
              ph.AddPhone("Nam2", 9999);
              ph.AddPhone("Nam3", 111);
              ph.displayAll();
              ph.displayNumber(2222);
              Console.WriteLine("Indexer property");
              Console.WriteLine(ph["Nam2"]);
              ph["Nam4"] = 5665;

              ph.displayAll();*/
          
            Person p1 = new Person();
            p1.Name = "Name1";
            p1.SSd = 5555;
            p1.HasJoB = true;
            p1.Des();
            Person p2 = new Person(2222,"Name2",false);
            p2.Des();


            Employee Ep = new Employee();
            Ep.Name = "LukyPerson";
            Ep.SSd = 2222;
            Ep.HasJoB = true;
            Ep.JobTitle = "Jobtitle";
            Ep.Swage = 5;
            Ep.WorkingHour = 15;
            Ep.EmpPrint();

            Employee Ep2 = new Employee(4444,"Emp2",true,"IT","Manger",15,3.5);
            Ep2.EmpPrint();

            Student student = new Student();
            student.Name = "Student1";
            student.SSd = 5555;
            student.HasJoB = false;
           
            student.Qulification = "B";
            student.Grade = 4;
            student.TotalHours = 20;
            student.StudentInf();

            Student student2 = new Student(33, "student2", false,"Dep",true,3,20);
            student2.StudentInf();


        }
    }
}