using Day20.Models;

namespace Day20
{
    internal class Program
    {
        static void Main(string[] args)
        {
           using AirportContext _db = new AirportContext();
            Department _department = new Department();
        
            //add
           /* _department.DepartmentName = "Finance" ;
            _db.Departments.Add(_department);
            _db.SaveChanges();*/

            //select
            var dep = (from x in _db.Departments where x.DepartmentName == "Finance" select x).FirstOrDefault();
               Console.WriteLine(dep?.DepartmentName??"NA");
        }
    }
}