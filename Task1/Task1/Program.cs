using System;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1
            ///*1- Write a program that allows the user to enter a number then print it.
            //Example
            //Input: 5
            //Output: 5 
            //*/
            //Console.WriteLine("please enter a number?");

            //int number =Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine($"your number is {number} \n thank you ");
            #endregion

            #region 2
            ///*2- Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no.
            //Example (1)
            //Input: 12 
            //Output: Yes
            //Example (2)
            //Input: 9 
            //Output: No
            //*/
            //Console.WriteLine("Please enter number to check if it divided by 3?");
            //int SecondNumber = Convert.ToInt32(Console.ReadLine());
            //int dividResult = SecondNumber % 3;
            //string Output1 = (dividResult == 0) ? "it divisible by 3" : "not disible by 3";
            //Console.WriteLine($"your number {SecondNumber} is {Output1}");
            #endregion

            #region 3
            ///*3- Write a program that allows the user to insert 2 integers then print the max.
            //Example (1)
            //Input: 3 5
            //Output: 5
            //Example (2)
            //Input: 10 7
            //Output: 10
            //*/
            //Console.WriteLine(" we do comparison here please enter first number?");
            //int FirstNumber = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter Second number");
            //int SeNumber = Convert.ToInt32(Console.ReadLine());
            //if (FirstNumber >= SeNumber)
            //{
            //    Console.WriteLine($"{FirstNumber} is the Max");

            //}
            //else
            //    Console.WriteLine($"{SeNumber} is the Max");
            #endregion

            #region 4
            /*4- Write a program that allows the user to insert an integer then print negative if it is negative number otherwise print positive.
            Example (1)
            Input: -5
            Output: negative
            Example (2)
            Input: 10
            Output: positive
            */

            //Console.WriteLine("we need to check the integer you enter Is it negative or positive? \n \t please enter number");

            //int App4 = Convert.ToInt32(Console.ReadLine());
            //string Negative = ((App4 >= 0))?"positive":"nagitive";
            //Console.WriteLine($"your number {App4} is {Negative}");
            #endregion

            #region 5
            /*5- Write a program that takes 3 integers from the user then prints the max element and the min element.
            Example (1)
            Input:7,8,5
            Output:
            max element = 8
            min element = 5
            Example (2)
            Input: 3 6 9
            Outputs:
            Max element = 9
            Min element = 3
            */
            //Console.WriteLine(" we need three number to comper please enter first number");

            //int FNumber = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Second Number?");
            //int SNumber = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Theird number?");
            //int ThNumber = Convert.ToInt32(Console.ReadLine());

            //if ((FNumber >= SNumber) && (FNumber >= ThNumber))
            //{
            //    if (SNumber <= ThNumber)
            //    {

            //        Console.WriteLine($"{FNumber} is the Max \n {ThNumber} is the Min");

            //    }
            //    else
            //        Console.WriteLine($"{FNumber} is the Max \n {SNumber} is the Min");
            //}
            //else if (SNumber >= ThNumber)
            //{
            //    if (FNumber > ThNumber)
            //    {

            //        Console.WriteLine($"{SNumber} is the Max \n {ThNumber} is the Min");

            //    }
            //    else
            //        Console.WriteLine($"{SNumber} is the Max \n {FNumber} is the Min");

            //}
            //else
            //    if (SNumber < FNumber)
            //{

            //    Console.WriteLine($"{ThNumber} is the Max \n {SNumber} is the Min");

            //}
            //else
            //    Console.WriteLine($"{ThNumber} is the Max \n {FNumber} is the Min");


            #endregion
            #region 6
            /*6- Write a program that allows the user to insert an integer number then check If a number is even or odd.*/
            //int x = Convert.ToInt32(Console.ReadLine());
            //int y = x % 2;
            //string result = (y == 0) ? "Even" : "Odd";
            //Console.WriteLine($"{x} is {result} number");
            #endregion

            #region 7
            /*7- Write a program that takes character from the user then if it is a vowel chars (a,e,I,o,u) then print (vowel) otherwise print (consonant).
            Example (1)
            Input: O
            Output: vowel
            Example (2)
            Input: b
            Output: Consonant

             * */
            //Console.WriteLine(" you can cheack the letter for vowel or not \n \t please enter character ");
            //String ch = Console.ReadLine();
            //switch(ch)
            //{
            //    case "a": Console.WriteLine($" {ch} is vowel");
            //        break;
            //        case "e": Console.WriteLine($" {ch} is vowel");
            //        break;
            //    case "i":
            //        Console.WriteLine($" {ch} is vowel");
            //        break;
            //    case "o":
            //        Console.WriteLine($" {ch} is vowel");
            //        break;
            //    case "u":
            //        Console.WriteLine($" {ch} is vowel");
            //        break;
            //    default: Console.WriteLine($" {ch} Consonant letter");
            //        break;

            //}
            #endregion

            #region 8
            /*8- Write a program that allows the user to insert an integer then print all numbers between 1 to that number.
            Example 
            Input: 5
            Output: 1, 2, 3, 4, 5
            */
            //Console.WriteLine("Enter number ");
            //int number = Convert.ToInt32(Console.ReadLine());
            //for(int i = 1; i < number+1; i++)
            //{
            //    Console.Write(i);
            //}
            #endregion

            #region 9
            /*9- Write a program that allows the user to insert an integer then print a multiplication table up to 12.
            Example
            Input: 5
            Outputs: 5 10 15 20 25 30 35 40 45 50 55 60
            */

            //Console.WriteLine("Enter number to give you the multiplication table");
            //int numb = Convert.ToInt32(Console.ReadLine());
            //for (int i = 1; i <= 12; i++) {
            //    int result = i * numb;
            //    Console.Write( $" {result} ");
            //}
            #endregion

            #region 10
            /*
             * 10- Write a program that allows to user to insert number then print all even numbers between 1 to this number
            Example:
            Input: 15
            Output: 2 4 6 8 10 12 14

             * */
            //Console.WriteLine("Enter number");
            //int num = Convert.ToInt32(Console.ReadLine());
            //for (int i = 0; i <= num; i++) {
            //    int Eve = i % 2;
            //    string result = (Eve == 0) ? "even" : "od";
            //    if (result == "even")
            //    {
            //        Console.Write($" {i} " );
            //    }
            //    }
            #endregion

            #region 11
            /*
             * 11- Write a program that takes two integers then prints the power.
            Example:
            Input: 4 3
            Output: 64
            Hint: how to calculate 4^3 = 4 * 4 * 4 =64

             * */
            //Console.WriteLine("Enter two number get the power of it");
            //int numb1= Convert.ToInt32(Console.ReadLine());
            //int numb2 = Convert.ToInt32(Console.ReadLine());
            //int re = numb1;
            //for (int i = 1; i < numb2; i++)
            //{
            //    re = numb1 * re;
            //}
            //Console.WriteLine(re);
            #endregion

            #region 12
            /*
             * 12- Write a program to enter marks of five subjects and calculate total, average and percentage.
            Example
            Input: - Enter Marks of five subjects: 95 76 58 90 89
            Output: Total marks = 408
                 Average Marks = 81
                 Percentage = 81

             * */
            //Console.WriteLine("Enter five marks??");
            //decimal FMark = Convert.ToInt32(Console.ReadLine());
            //decimal SMark = Convert.ToInt32(Console.ReadLine());
            //decimal TMark = Convert.ToInt32(Console.ReadLine());
            //decimal FoMark = Convert.ToInt32(Console.ReadLine());
            //decimal VMark = Convert.ToInt32(Console.ReadLine());

            //decimal Total = FMark + SMark + TMark + FoMark + VMark;
            //decimal average = Total / 5;
            //decimal percentage = Total/500*100;
            //Console.WriteLine($"your Tatal marks = {Total} \n \t Average Marks = {average}\n \t Percentage = {percentage}");

            #endregion

            #region 13

            /*
             * 13- Write a program to input the month number and print the number of days in that month.
            Example
            Input: Month Number: 1
            Output: Days in Month: 31

             * */

            //Console.WriteLine("Enter the month number");
            //int month = Convert.ToInt32(Console.ReadLine());
            //if (month == 2)
            //{
            //    Console.WriteLine("you have 28 or 29 days ");
            //}
            //else if ((month == 4)|| (month == 6)|| (month == 9)|| (month == 11)) {
            //    Console.WriteLine("you have 30 day ");
            //}else
            //    Console.WriteLine("you have 31 day ");



            #endregion
            #region 14

            /*
             *14- Write a program to input marks of five subjects Physics, Chemistry, Biology, Mathematics and Computer, And Calculate percentage and grade.
            Hint:
            Percentage >= 90%: Grad A
            Percentage >= 80%: Grad B
            Percentage >= 70%: Grad C
            Percentage >= 60%: Grad D
            Percentage >= 40%: Grad E
            Percentage < 40%: Grad F
            */
            //Console.WriteLine("Enter subject markes");
            //double ph = Convert.ToDouble(Console.ReadLine());
            //double Ch = Convert.ToDouble(Console.ReadLine());
            //double Bio = Convert.ToDouble(Console.ReadLine());
            //double Ma = Convert.ToDouble(Console.ReadLine());
            //double Cum = Convert.ToDouble(Console.ReadLine());

            //double total = ph + Ch + Bio + Ma + Cum;
            //double per = total / 500 * 100;
            // if (per >= 90 )
            //{
            //    Console.WriteLine($" your Percentage is {per} Grad: A");
            //}else if (per >= 80)
            //{
            //    Console.WriteLine($" your Percentage is {per} Grad: B");
            //}
            //else if (per >= 70)
            //{
            //    Console.WriteLine($" your Percentage is {per} Grad: C");
            //}
            //else if (per >= 60)
            //{
            //    Console.WriteLine($" your Percentage is {per} Grad: D");
            //}
            //else if (per >= 50)
            //{
            //    Console.WriteLine($" your Percentage is {per} Grad: E ");
            //}else
            //    Console.WriteLine($" your Percentage is {per} Grad: F");

            #endregion
            #region 15

            /*
             *15 - Write a program to check whether a number is positive or negative or zero. */

            //Console.WriteLine("Enter number");
            //int num = Convert.ToInt32(Console.ReadLine());
            //if (num == 0)
            //{
            //    Console.WriteLine($" {num} is 0");
            //}
            //else if (num > 0)
            //{
            //    Console.WriteLine($" {num} is positive");
            //} else
            //    Console.WriteLine($"{num} is negaitive");
            #endregion

            #region 16
            /*
             * 16- Write a program to create a Simple Calculator.*/
            //while (true)
            //{

            //    Console.WriteLine("Welcome to the Simple Calculator!\r\nOptions:\r\n1. Addition\r\n2. Subtraction\r\n3. Multiplication\r\n4. Division\r\n5. Exit\r\nSelect an operation (1-5):");
            //    int oper = Convert.ToInt32(Console.ReadLine());

            //    if (oper >= 5)
            //    {
            //        break;
            //    }
            //    Console.WriteLine("enter first operand ");
            //    int operand1 = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("enter Second operand ");
            //    int operand2 = Convert.ToInt32(Console.ReadLine());

            //    int[] operation = new int[4];
            //    operation[0] = operand1 + operand2;
            //    operation[1] = operand1 - operand2;
            //    operation[2] = operand1 * operand2;
            //    operation[3] = operand1 / operand2;
            //    string result = "";

            //    for (int i = 0; i <= operation.Length; i++)
            //    {
            //        if (i == oper)
            //        {
            //            Console.WriteLine($" Result of your Operation is {operation[i - 1]} \n Do you have another operation? yes / no");
            //            result = Console.ReadLine();
            //        }
            //    }

            //    if (result != "yes")
            //    {
            //        break;
            //    }
            //}
            #endregion
            #region 17

            /*
             *17- Write a program to allow the user to enter a string and print the REVERSE of it. */
            //Console.WriteLine("Enter String to REVERE");
            //string word = Console.ReadLine();
            //for (int i = word.Length-1; i >= 0; i--)
            //{
            //    Console.Write(word[i]);
            //}
            #endregion
            #region 18

            /*
             * 18- Write a program to allow the user to enter int and print the REVERSED of it.*/

            //Console.WriteLine("Enter Int to REVERE");
            //string word = Console.ReadLine();
            //for (int i = word.Length - 1; i >= 0; i--)
            //{
            //    Console.Write(word[i]);
            //}

            #endregion

            #region 19

            /*
             * 19. Write a program in C# Sharp to find the sum of all elements of the array.  */
            // Console.WriteLine("Enter size of your array");
            // int n = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("Enter element of array");
            // int res = 0;
            // int[] array = new int[n];
            //for(int i = 0; i < n; i++)
            // {

            //     array[i]= Convert.ToInt32(Console.ReadLine());
            //     res = array[i] + res;
            // }
            // Console.WriteLine($"  sum of all elements of the array is {res}");
            #endregion

            #region 20

            /*
             * 20. Write a program in C# Sharp to count a total number of duplicate elements in an array. */
            //Console.WriteLine("Enter size of your array");
            //int n = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter element of array");

            //int aar = 0;
            //int[] array20 = new int[n];
            //int[] array20Copy = array20;
            //int[] array21 = new int[aar];
            //for (int i = 0; i < n; i++)
            //{
            //    array20[i] = Convert.ToInt32(Console.ReadLine());

            //}
            //for (int i = 0; i < array20.Length; i++)
            //{
            //    for (int j = i + 1; j < array20.Length; j++)
            //    {
            //        if (array20[i] == array20[j])
            //        {
            //            aar += 1;
            //            array21[i] = i + 1;
            //        }
            //    }
            //}
            //Console.WriteLine($"{array21.Length}");
            #endregion

            #region 21
            /*Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.*/
            // Console.WriteLine("Enter size of your arrays");
            // int n = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("Enter element of First array");
            // int[] array = new int[n];
            // int[] Secondarray = new int[n];
            // for (int i = 0; i < n; i++)
            // {
            //     array[i] = Convert.ToInt32(Console.ReadLine());
            // }
            // Console.WriteLine("Enter element of Second array");
            // for (int i = 0; i < n; i++)
            // {
            //     Secondarray[i] = Convert.ToInt32(Console.ReadLine());
            // }
            // int totalsize = n + n;
            // int[] Totla = new int[totalsize];
            // for (int i = 0; i < n; i++)
            // {
            //     Totla[i] = array[i];
            // }
            // for (int i = 0; i <n; i++)
            // { 
            //     Totla[(array.Length)+i] = Secondarray[i];
            // }
            //Array.Sort(Totla);
            // for(int i = 0; i < totalsize;i++) {
            //     Console.Write ($"{ Totla[i]}");
            // }
            #endregion

            #region 22
            /*
             *22. Write a program in C# Sharp to count the frequency of each element of an array. */
            //Console.WriteLine("Enter size of your arrays");
            //int n = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("enter element of first array");
            //int[] array = new int[n];
            //int f = 0;
            //int[] frequentElem = new int[f];
            //for (int i = 0; i < n; i++)
            //{
            //    array[i] = Convert.ToInt32(Console.ReadLine());

            //}
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 1; j < n; j++)
            //    {

            //        if (array[i] == array[j])
            //        {
            //            frequentElem[i] = array[j];
            //        }

            //    }

            //}
            //Console.WriteLine(frequentElem.Length);
            #endregion

            #region 23
            /*23. Write a program in C# Sharp to find maximum and minimum element in an array*/
            //int[] array23 = new int[] { 2, 3, 2, 6, 10, 4, 1 };
            //int max = 0;
            //int min = 1;
            //for (int i = 0;  i < array23.Length; i++)
            //{  
            //  if (array23[i] > max)
            //    {
            //            min = max;
            //            max = array23[i];
            //    }
            //}
            //for (int i = 0; i < array23.Length; i++)
            //{
            //    if (array23[i] < min)
            //    {

            //        min = array23[i];
            //    }
            //}
            //Console.WriteLine($"Max element is {max} minimum is {min}");
            #endregion 23

            #region 24
            /*24. Write a program in C# Sharp to find the second largest element in an array.*/
            //int[] array24 = new int[] {10,2,3,4,5};
            //int secondLarg = 0;
            //  Array.Sort(array24);
            //           Console.WriteLine( $"Secnod largest element is {array24[array24.Length-2]}");
            #endregion

            #region 25
            /*write a program find the longest distance between Two equal cells. In this example. The distance is measured by the number Of cells- for example, the distance between the first and the fourth cell is 2 (cell 2 and cell 3).
            */
            int[] array25 = new int[] { 7, 0, 0, 0, 5, 6, 7, 5, 0, 7, 5, 3 };
            int dist = 0;
            int disV = 0;
            for (int i = 0; i < array25.Length; i++)
            {
                if (array25[i] == disV)
                {
                    dist = array25[i];
                }
            }
            for (int i = array25.Length; i == 0; i--)
            {
                if (array25[i] == disV)
                {
                    disV = array25[i];
                }
            }
            Console.WriteLine(disV - dist);


            #endregion

        }
    }
}