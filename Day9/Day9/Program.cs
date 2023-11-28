namespace Day9
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome \n Enter employee first name");
            string Fname = Console.ReadLine();
            Console.WriteLine(" Enter employee Last name");
            string Lname = Console.ReadLine();
            Console.WriteLine(" Enter age");

            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Enter hours work");
            double WorkHours = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" Enter How much money per hour");
            double money = Convert.ToDouble(Console.ReadLine());
            double salary = (SalaryCalcu(WorkHours, money));

            Employ emp1 = new Employ(Fname,Lname,age,salary );
            Employ emp2 = new Employ("Azza", "Lname", 33, 35.0);
            Employ emp3 = new Employ("F", "L", 20, 12.0);
          
            Employ[] empl =  { emp1, emp2, emp3 }; 
            
           foreach (Employ emp in empl)
            {
                Console.WriteLine($"{emp.Fname} {emp.Lname} {emp.age}");
            }


           /* Console.WriteLine($"Welcome {emp1} {emp1.Lname}" +
                $"your age {emp1.age} your salary is {emp1.salary}");*/
        }
       static double SalaryCalcu(double WorkHours, double money)
        {
            double totalSalary= WorkHours*money;
            double tax = totalSalary * .3;
            return (totalSalary - tax) ;
        }
    }
}