using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseZoo
{
    internal class DataGet
    {
        public void LoadData(string filePath, List<Animal> animals, List<Employee> employees)
        {
            animals.Clear();
            employees.Clear();

            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');

                    if (parts.Length > 0)
                    {
                        switch (parts[0])
                        {
                            case "Животное":
                                if (parts.Length >= 3)
                                {
                                    animals.Add(new Animal(parts[1], parts[2]));
                                }
                                break;

                            case "Работник":
                                if (parts.Length >= 4)
                                {
                                    employees.Add(new Employee(parts[1], Convert.ToInt32(parts[4]), parts[5], parts[6]));
                                }
                                break;
                        }
                    }
                }
            }
        }
    }
}
