using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace Day11
{
    internal class Human
    {
        private int id;
        public static int Id;
        private int FirstNum;
         string FirstName;
         string LastName;
         string Email;
        public int Age;

        public string firstName
        {
            set{ this.FirstName = value; }
            get{ return this.FirstName; }
            
        }
        public string lastName
        {
            set { this.LastName = value; }
            get { return this.LastName; }

        }
        public int age
        {
            set { this.Age = value; }
            get { return this.Age; }

        }

        public Human() { }
      /*  public Human(int id ,string _Email) {
            this.id = id;
            this.Email = _Email;
        }*/
        public int getiD()=>this.FirstNum;
        public string getEmai()=>this.Email;
        public void SetEmai(string _Email) => this.Email = _Email;

        public Human(string _FirtsName, string _LirtsName,string _Email , int _aga)
        {
            Id += 1;
            FirstNum = Id;
            FirstName = _FirtsName;
            LastName = _LirtsName;
            Email = _Email;
            Age = _aga;
        }
     
        public void Print()
        {
            Console.WriteLine($" id: {FirstNum}\n First Name :{FirstName} \n Last Name: {LastName} \n Email:{Email} \n age: {Age}");
            Console.WriteLine("______________________________________________________________");
        }
    }
}
