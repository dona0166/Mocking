using System;

namespace Mocking
{
    public class Employee : Object
    {
        public string Name { get; internal set; }
        public string Type { get; internal set; }
        public int Id { get; internal set; }
        public int Wage { get; internal set; }
        public MailBox MailBox { get; internal set; }

        public Employee()
        {

        }

        public Employee(string name, string job)
        {
            this.Name = name;
            this.Type = job;
            
        }

        public override bool Equals(object ob)
        {
            Employee anemployee = ob as Employee;
            if (anemployee != null && this.Name == anemployee.Name
                && this.Type == anemployee.Type)
            {
                return true;
            }
            else
            {
                return false;
            }


        }

        public double CalculateWeeklySalary(int hours, int wage)
        {
            return hours * wage;
        }


        //public override string ToString()
        //{
        //    return base.ToString();
        //}
    }
}