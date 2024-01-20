using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseZoo
{
    internal class Animal : IView
    {
        public string Spicies {  get; private set; }
        public string Peculiarities {  get; private set; }
        public Animal(string spicies, string peculiarities)
        {
            Spicies = spicies;
            Peculiarities = peculiarities;
        }
        public void Info()
        {
            Console.WriteLine($"Вид - {Spicies} \nОсобенности - {Peculiarities}");
        }
    }
}
