using DataBasse.Model;
using DataBasse.MyDBcontext;
using static System.Formats.Asn1.AsnWriter;

namespace DataBasse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            /* using MyAppData db = new MyAppData();
              Employee emp =new Employee();
              emp.Name = "Mohammed";
              emp.Address = "al-hamra";
              emp.salary = 300;
              db.Employees.Add(emp);
             db.SaveChanges();*/

            //"using" key word to open and close connection tuomatically
         //  using MyAppData db = new MyAppData();

            #region select using id
            //   var emp = (from x in db.Employees where x.Id == 1 select x).FirstOrDefault();
            //   Console.WriteLine(emp?.Name??"NA");
            #endregion

            #region update

            /*  var empUpdate = (from x in db.Employees where x.Id == 1 select x).FirstOrDefault();
              empUpdate.Name = "Khalid";
              db.Employees.Update(empUpdate);
              Console.WriteLine(empUpdate?.Name ?? "NA");*/
            #endregion

            #region select list and loop inside...Orderby
            /*  var emp1 = (from x in db.Employees orderby x.Name select x).ToList();
               foreach(var i in emp1)
               {
                   Console.WriteLine(i.Name ?? "NA");
               }*/
            #endregion
            #region select count
              //var empCount = (from x in db.Employees orderby x.Name select x).Count();
            //    Console.WriteLine(empCount);
            #endregion
            #region delete 
            /*  var empdaelte = (from x in db.Employees where x.Id == 2 select x).FirstOrDefault();
              db.Employees.Remove(empdaelte);
              db.SaveChanges();*/
            // Console.WriteLine(empUpdate?.Name ?? "NA");
            #endregion
        }
    }
}