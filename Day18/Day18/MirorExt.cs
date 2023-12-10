using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day18
{
    internal static class MirorExt
    {
        public static void Miror(this int miror)
        {
            Console.WriteLine(miror);
        }

        public static int squer(this int miror)
        {
            return miror * miror;
        }

      /*  public static string reve(this string r)
        {
          

            char[] arr = r.ToCharArray();
            for (int i = r.Length, j=0; i > r.Length; i--,j++)
            {
                char temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
               
            }
       
            return new string (arr);
        }*/
    }
}
