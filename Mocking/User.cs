using System;
using System.Collections.Generic;

namespace Mocking
{
    public enum Rights
    {
        Full,
        None,
    };
    public class User 
    {
        List<Employee> emplist;
        
        public User()
        {
            emplist = new List<Employee>();
            //foreach (Employee anemployee in emplist)
            //{
            //    anemployee.Name = "Simon";
            //}
        }

        public int NumMessagesCreated { get; internal set; }
        public string Password { get; set; }
        public Rights Rights { get; internal set; }
        public string UserName { get; set; }

        
   
        public string ViewAllEmployees()
        {
            return "Here is the list";
        }
       
        public void EditEmployeeName(Employee anemployee, string v)
        {
            anemployee.Name = v;

        }
        public void EditEmployeeWage(Employee anemployee, int v)
        {
            anemployee.Wage = v;
        }
    }
}