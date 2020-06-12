﻿using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;


namespace Checkpoint2
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee Mark = new Employee("01.02.2020", "Mark Knophler", 57);
            new Person();
            new Company("Telia", 0);

            Mark.DescripeEmployee(Mark);
            
               
            

        }
    }
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        //private int IdNum { get; set; }
        

        public  Person()
        {
            
        }
        public virtual void SetHireDate()
        {
           
        }
    }
    public class Employee : Person
    {
        public string HireDate { get; set; }

        public Employee(string _hireDate, string _name, int _age )
        {
            Name = _name;
            Age = _age;
            HireDate = _hireDate;



        }
        public void DescripeEmployee(Employee x)
        {
            Console.WriteLine("Emplyee is named: " +x.Name );
            Console.WriteLine("He/She is {0} years old", x.Age);
            Console.WriteLine("He/She was hired {0}", x.HireDate);
            

        }
        

        /*public static override bool  SetHireDate()
        {
            return (Regex.IsMatch(_hireDate, "^[A-ZÆØÅ]$")); 
        }*/
    }
    public class Company
    {
        public int NumOfEmpl { get; set; }
        public string CompanyName { get; set; }
        


        public Company(string _companyName, int _numOfEmpl)
        {
            CompanyName = _companyName;
            NumOfEmpl = _numOfEmpl;

        }


    }
}
