namespace Day4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String[] codeAcademy = new String[2];
            codeAcademy[0] = "Web";
            codeAcademy[1] = "Security";
            for (int i = 0; i < codeAcademy.Length; i++) { 
                Console.WriteLine(codeAcademy[i]);
        }
            //MultiDim

            String[,] Class = new string[2,3];

            Class[0, 0] = "A";
            Class[0, 1] = "B";
            Class[0, 2] = "C";
            Class[1, 0] = "D";
            Class[1, 1] = "E";
            Class[1, 2] = "F";

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine(Class[i, j]);
                   
                }
            }

            /* for (int i = 0; i < 3; i++)
             {

                 for (int j = i; j <3; j++)
                 {
                     Console.WriteLine(Class[i,j]);

                 }
             }*/
            String[][] Session = new string[2][];

            Session[0] = new string[2] { "kultom","Yousif" };
            Session[1] = new string[3] { "Huda", "Muzna", "Shahed" };

            for(int i =0; i<Session.Length; i++)
            {
               
                for (int j = 0; j< Session[i].Length; j++)
                {
                    Console.WriteLine(Session[i][j]);
                }
            }
          //  Console.WriteLine(Session[0][0]);

        }
    }
}