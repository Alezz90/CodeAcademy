namespace HelloWorld
{
    class Program
    {
        public static void Main()
        {
            #region Comments 
            // this is a single line Comment that will comment anything in this line 
            /* 
                this 
                is 
                multi-line 
                comment that will comment anything between the comment Block 
             
             */
            #endregion

            #region CONSOLING Data


            //Console.WriteLine("hello my name is joe  , " +
            //    " my age is 26 ,job is software engineer  " +
            //    ",i am happy to participate in building 2040 dream for sultant oman "); 
            #endregion

            #region Variable Decleration
            //// Variable Declaration :
            //// <Datatypes> <Identifier(varname)>  ;
            //int age;
            ////assignment a value to a variable 
            //age = 25;
            //Console.WriteLine(age);

            ////String Declaration and assignment  
            //String name = "my name is joonguini ";
            //Console.WriteLine(name);

            //string str = new String("hello my name is joe  , " +
            //    " my age is 26 ,job is software engineer  ," +
            //    "i am happy to participate in building 2040 dream for sultant oman ");
            //Console.WriteLine(str); 
            #endregion


            #region String Concatination
            ////String Concatination 

            //string firstName = "yousif";
            //string lastName = "ebrahim";
            ////regular concatination 
            //Console.WriteLine("your full name is " + firstName + " " + lastName);

            ////string interpolation 
            //Console.WriteLine($"your full name is {firstName} {lastName}"); 
            #endregion

            #region var and dynamic 
            ////var keyword   // suffix literal 
            ////------------------------------------
            //var s = "joe";  // compilier detect that its a string 

            //var f = 0f;     //compiler detect that it is a float 

            //var d = 0d;     // compiler detect that it is a Double  

            //var m = 0m;     // compiler detect that it is a decimal 

            //var u = 0u;     // compiler detect that it is unsigned interger 

            //var l = 0l;     //compiler detect that it is long integer 

            //var ul = 0ul;   // compiler detect that it is unsigend long integer


            ////Dynamic Keyword 
            //dynamic test = "hello there"; //declared as String 
            //test = 3; 
            //test = 0f;  //compiler detect that it is a float 
            //test = 0d;  // compiler detect that it is a Double 
            //test = 0m;  // compiler detect that it is a decimal
            //test = 0u;  // compiler detect that it is unsigned interger 
            //test = 0l;  //compiler detect that it is long integer
            //test = 0ul;  // compiler detect that it is unsigend long integer 
            #endregion


            #region Expressions 
            // Expressions : expression is combination bestween one or more value to Produce a result 
            //int x = 5 + 3; // the expression "5 + 3" evaluates to 8

            //string s = "hello " + "world " + "from " + "Code Academy "; // the expression ""hello" + "world"" evaluates to "hello world from Code Academy "

            //bool b = (x > 3) && (x < 10); // the expression "(x > 3) && (x < 10)" evaluates to true 
            #endregion

            #region Equality operator
            //EQUALITY Operators 

            //int x  = 3; // ' = ' assignment Operator   
            //int y = 4;

            //Console.WriteLine(x == y); // ' == ' equality operator result will be boolean true or false 
            #endregion


            #region Comparison operators 
            ////Comparison Operators 
            ////-----------------------
            //int x = 5;
            //int y = 10;

            //bool equal = x == y; // false
            //bool notEqual = x != y; // true
            //bool lessThan = x < y; // true
            //bool greaterThan = x > y; // false
            //bool lessThanOrEqual = x <= y; // true
            //bool greaterThanOrEqual = x >= y; // false 
            #endregion


            #region Logical operators 
            //Logaical Operators

            #region Basic Example
            //// logical Basic Example

            //bool a = true;
            //bool b = false;

            //bool resultAND = a && b; // result is false 

            //bool resultOr = a || b; // result is true

            //bool resultNOT = !a; // result is false 
            #endregion
            #region advance example 

            ////Logical operators advance example 
            //int x = 5;
            //int y = 10;
            //bool a = (x < y) && (y < 20); // a is true
            //bool b = (x > y) || (y > 20); // b is false
            //bool c = !(x == y); // c is true 
            #endregion

            #region XOR
            // Xor
            //bool x = true;
            //bool y = false;

            //Console.WriteLine(x ^ y); // true cause of difference  
            #endregion



            #endregion


            #region ShortCircuit
            //SHORT CIRCIUT | ,&
            //bool value = true | Check() ;

            //static bool Check() //method creation 
            //{
            //    Console.WriteLine("checked");
            //    return true;
            //} 
            #endregion

            #region Refrence-Comparison
            ////Refrence type Comparison
            //string s1 = "hello "; //stored in heap 
            //string s2 = "hello"; //stored in heap 
            //Console.WriteLine( s1 == s2 );//true value (operator overloading) 
            #endregion

            #region TernaryOperator
            ////Ternary Operator 
            //// Syntax : variable =  (condition) ? expression1 : expression2
            //int x = 5;
            //int y = 10;

            //string result = (x < y) ? "x is less than y" : "x is greater than or equal to y";
            //Console.WriteLine(result); // outputs "x is less than y" 
            #endregion


        }
    }
}