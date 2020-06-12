using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;


namespace Checkpoint2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> TeliaEmployees = new List<Employee>();


            TeliaEmployees.Add(new Employee("01.02.2020", "Mark Knophler", 57));
            new Person();
            Company Telia = new Company("Telia", TeliaEmployees.Count);


            Telia.DescripeCompany(Telia);
            foreach (var Empl in TeliaEmployees)
            {
                Empl.DescripeEmployee(Empl);
            }
            
               
            

        }
    }
   
}
