using System;

namespace Checkpoint2
{
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

        public Employee(string _hireDate, string _name, int _age)
        {
            Name = _name;
            Age = _age;
            HireDate = _hireDate;



        }
        public void DescripeEmployee(Employee x)
        {
            Console.WriteLine("Emplyee is named: " + x.Name);
            Console.WriteLine("He/She is {0} years old", x.Age);
            Console.WriteLine("He/She was hired {0}", x.HireDate);


        }
        public void CreateEmployee()
        {
            Console.WriteLine("What is your name?");
        }


        /*public static bool SetHireDate()
        {
            return (Regex.IsMatch(_hireDate, "^[0-9]\d+$")); 
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
        public void DescripeCompany(Company x)
        {
            Console.WriteLine("The company is named " + x.CompanyName);
            Console.WriteLine("It has {0} emplyee(s).", x.NumOfEmpl);
            


        }



    }
}
