using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13
{
   public  interface IPay
    {
        void pay(double x) { }
    }
    public class Cashier
    {
        public IPay payment;
        public Cashier(IPay payment)
        {
            this.payment = payment;
        }

        public void checkout(double amount)
        {
            payment.pay(amount);
        }
    }

    internal class PaymentCach:IPay
    {
       public void pay(double x) {
            Console.WriteLine("cach pay");
        }
    }
    internal class PaymentVisa : IPay
    {
       public void pay(double x)
        {
            Console.WriteLine("PaymentVisa");
        }
    }
    internal class PaymentMaster : IPay
    {
       public void pay(double x)
        {
            Console.WriteLine("PaymentMaster");
        }
    }
}
