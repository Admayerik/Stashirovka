using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseZoo
{
    internal class Employee : Person
    {
        public int? Salary {  get; private set; }
        public string JobTitle {  get; private set; }
        public string Phone { get; private set; }
        public Employee(string name, int? salary, string jobTitle, string phone) : base(name)
        {
            Salary = salary;
            JobTitle = jobTitle;
            Phone = phone;
        }

        public override void Info()
        {
            Console.WriteLine($"Имя - {Name} \nРабота - {JobTitle} \nЗарплата - {Salary} \nТелефон - {Phone}");
        }
    }
}
