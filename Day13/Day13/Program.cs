using System.Security.Cryptography.X509Certificates;

namespace Day13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee("name1",11,"Manger","IT",2.0,15);
            Console.WriteLine(emp);
            emp.eate();

           
            Cashier payMaster = new Cashier(new PaymentMaster());
            Cashier payVisa = new Cashier(new PaymentVisa());
            Cashier paycash=new Cashier(new PaymentCach());
            payMaster.checkout(3.5);
            payVisa.checkout(4);
            paycash.checkout(5);





        }
    }
}