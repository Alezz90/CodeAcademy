using System.Windows.Markup;

namespace Day18
{
    class FullStackPath
    {
        public string StudentName { get; set; }
        public int Grade { get; set; }
        public int age { get; set; }
        public List<string> Subject { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  int x = 5;
              x.Miror();
              Console.WriteLine(x.squer());*/
            #region Enumerable
            /*List<int> list = new List<int> { 1,2, 3, 4 };
            var even = from x in list where x % 2 == 0 select x;
          //  var odd = list.Where(x=> x%2 !=0).ToList();
           /* Console.WriteLine("odd");
            foreach (var item in odd)
            {
                Console.Write($"{item}");
            }
            Console.WriteLine(" even");
            foreach (var item in even)
            {
                Console.Write($" {item}");
            }
            list.Remove(2);
            foreach (var item in even.ToArray())
            {
                Console.Write($"{item}");
            }
            Console.WriteLine();
            list.AddRange(new int[]{5,6,7});
            foreach (var item in list)
            {
                Console.Write($"{item}");
            }
            Console.WriteLine();
            list.AddRange(new int[] { 8, 9, 10 });
            foreach (var item in list)
            {
                Console.Write($"{item}");
            }*/
            #endregion
             IList<FullStackPath> StudentList = new List<FullStackPath>();
            StudentList.Add(new FullStackPath { StudentName = "Yousif", Grade = 96 ,age=26});
            StudentList.Add(new FullStackPath { StudentName = "Mohammed", Grade = 92 ,age =23 });
            StudentList.Add(new FullStackPath { StudentName = "abdu almajed", Grade = 92,age=23 });
            StudentList.Add(new FullStackPath { StudentName = "Nader", Grade = 95,age = 24 });
            StudentList.Add(new FullStackPath { StudentName = "Salim", Grade = 93 ,age =23});

            #region whereEnumerable

            IEnumerable<int> squareNumber = Enumerable.Range(9,10).Select(x => x * x);
            foreach (var num in squareNumber)
            {
                Console.WriteLine($"{num}");
            }
            IEnumerable<int> repeatNumber = Enumerable.Repeat(35,4);
            foreach (var num in repeatNumber)
            {
                Console.WriteLine(num);
            }
           // var result = from p in StudentList select p;// (p => p.Grade > 95);
           
            var emptyNumber = Enumerable.Empty<string>();
            foreach (var num in emptyNumber)
            {
                Console.WriteLine(num);
            }
          
            #region Any-all>>> return boleean
           /* var result = StudentList.Any(p => p.Grade > 95);
            Console.Write("any method: ");
            Console.WriteLine(result);*/
            #endregion

            #region Average, Count, Max, Min, Sum, First, Last, Contains, ElementAt and Distinct
            /* var result = from s in StudentList select s.Grade;
             Console.WriteLine("Average: " + result.Average());
             Console.WriteLine("Average: " + StudentList.Average(p => p.Grade));// do it as Lambda method
             Console.WriteLine("Count: " + result.Count());
             Console.WriteLine("Max: " + result.Max());
             Console.WriteLine("Min: " + result.Min());
             Console.WriteLine("Sum: " + result.Sum());
             Console.WriteLine("First Value: " + result.First());
             Console.WriteLine("Last Value: " + result.Last());
             Console.WriteLine("Is 3500 Available? " + result.Contains(3500));
             Console.WriteLine("Element at 4th Position: " + result.ElementAt(3));
             var distinctPrice = result.Distinct();
             Console.WriteLine(" Distinct Result");
             foreach (var g in distinctPrice)
             {
                 Console.WriteLine("Distinct Value: " + g.ToString());
             }*/
            #endregion
            #region groupby
            //  var result = StudentList.ToLookup(p => p.Grade);

            /* var result = from FullStackPath in StudentList group FullStackPath by new { FullStackPath.Grade, FullStackPath.age } into groups orderby groups.Key.age select groups;

             foreach (var group in result)
             {
                 Console.WriteLine(string.Format($"Grade: {group.Key}"));
                 foreach (var item in group)
                 {
                     Console.WriteLine(string.Format($"\tStudent Name: {item.StudentName} age {item.age} grade {item.Grade}"));
                 }
             }*/
            #endregion
            #region nested where
            /*
             *  var result = from p in GetStudent()
                         select new { p.StudentName, p.Grade,p.Subject};
            foreach (var str in result.SelectMany(FullStackPath =>FullStackPath.Subject))
            {
                Console.WriteLine(" str");
            }
            static List<FullStackPath> GetStudent()
            {
                List<FullStackPath> student = new List<FullStackPath>
                {
                    new FullStackPath
                    {
                        StudentName = "Yousif",
                        Grade = 94,
                        Subject=new List<string>{"oracl","java","css5"}
                    },
                    new FullStackPath
                    {
                        StudentName = "Mohammed",
                        Grade = 96,
                    
                        Subject=new List<string>{"mango","vs","react"}
                    },
                     new FullStackPath
                    {
                        StudentName ="abdu almajed",
                        Grade = 93,
                        Subject=new List<string>{"Sql","C#","Angular"}
                    }
                };
                return student;
            }*/
            #endregion

            /* 
             *
              IList<string> Student = new List<string>()
            {
                "Yousif",
                "Mohammed",
                "abdu almajed",
                "Nader",
                "Salim",
            };
            var result = from s in Student where s.Contains("m") select s;
             var result = from s in StudentList where s.Grade>=95 select s;
        */
#endregion
        }
    }
}