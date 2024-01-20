using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseZoo
{
    internal class DataStore
    {
        public void SaveData(string filePath, List<Animal> animals, List<Employee> employees)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (var animal in animals)
                {
                    writer.WriteLine($"Животное,{animal.Spicies},{animal.Peculiarities}");
                }

                foreach (var employee in employees)
                {
                    writer.WriteLine($"Работник,{employee.Name},{employee.Salary},{employee.JobTitle},{employee.Phone}");
                }
            }
        }
    }
}
