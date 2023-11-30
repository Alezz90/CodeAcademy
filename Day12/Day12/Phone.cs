using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Day12
{
     class Phone
    {
        static int  Id;
        int []IdNum;
        string[] Name;
        long[] number;
        int size;

     public Phone(int _size)
    {
            size = _size;
            IdNum = new int[size];
            Name = new string[size];
            number = new long[size];
        }
        public int getSize()
        {
            return this.size;
        }
        public void AddPhone(string _name,long _number)
        {
            IdNum[Id] = Id;
            Name[Id] = _name;
            number[Id] = _number;
            Id ++;
        }
        public long this[string index]
        {
            get { return number[Array.IndexOf(Name,index)]; }
            set {
               for(int i = 0; i < size; i++)
                {
                    if (this.Name[i] != index) {

                        number[Array.IndexOf(Name, index)] = value;
                        Console.WriteLine("Up");
                    }
                    else
                        Name[Id] = index;
                        IdNum[Id] = Id;
                        number[Array.IndexOf(Name, index)] = value;
                        Id++;
                    break;
                }
                
            }
        }

        public void displayAll()
        {
            for(int i = 0; i < size; i++)
            {
                if (Name[i] != null)
                    Console.WriteLine($"{IdNum[i]} name ={Name[i]} , number={number[i]}");
            }
        }
        public void displayNumber(long num)
        {
            Console.WriteLine("***********************");
            for (int i = 0; i < size; i++)
            {
                if (number[i] == num)
                    Console.WriteLine($"{IdNum[i]} name ={Name[i]} , number={number[i]}");
            }
        }
    }
}