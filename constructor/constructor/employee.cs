using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace constructor
{
    internal class employee
    {
        private int employ_id;
        private string employ_name;
        private string employ_email;
        private string employ_department;

        public employee(int id,string name,string email,string department)
        {
            employ_id = id;
            employ_name = name;
            employ_email = email;
            employ_department = department;


        }  

        public void emp_details()
        {
            Console.WrintLine(employ_id);
            Console.WriteLine(employ_name);
            Console.WriteLine(employ_email);
            Console.WriteLine(employ_department);




        }



    }
}
