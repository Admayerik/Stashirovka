using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CourseZoo
{
    internal class Zoo
    {
        List<Animal> animals = new List<Animal>();
        List<Employee> employees = new List<Employee>();

        public double AdultTicketPrice { get; private set; } = 1000;
        public double DiscountTicketPrice { get; private set; } = 700;
        public double ChildTicketPrice { get; private set; } = 300;
        public double ExcursionPrice { get; private set; } = 1200;
        public double AnimalFoodPrice { get; private set; } = 750;
        public double ContactZooPrice { get; private set; } = 450;

        public void CreateAnimal(string species, string characteristics)
        {
            if (ValidateInput(species, characteristics))
                animals.Add(new Animal(species, characteristics));
        }

        public void RemoveAnimal(string species)
        {
            animals.RemoveAll(a => a.Spicies == species);
        }

        public void ViewAllAnimals()
        {
            foreach (var animal in animals)
            {
                animal.Info();
            }
        }

        public void CreateEmployee(string name, int? salary, string job,string phone)
        {
            if (ValidateInput(job, name, phone, Convert.ToString(salary)))
                employees.Add(new Employee(name, salary, job, phone));
        }

        public void RemoveEmployee(string name)
        {
            employees.RemoveAll(e => e.Name == name);
        }

        public void ViewAllEmployees()
        {
            foreach (var employee in employees)
            {
                employee.Info();
            }
        }

        private bool ValidateInput(params string[] inputs)
        {
            foreach (var input in inputs)
            {
                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Пожалуйста заполните все поля.");
                    return false;
                }
            }
            return true;
        }

        public void FindAnimal(string name)
        {
            int i = 0;
            foreach(var animal in animals)
            {
                if(animal.Spicies == name)
                {
                    animal.Info();
                    i += 1;
                }
            }
            if(i == 0)
            {
                Console.WriteLine("Животное не найдено");
            }
        }
        public List<Animal> GetAnimals()
        {
            return animals;
        }

        public List<Employee> GetEmployees()
        {
            return employees;
        }
    }
}
