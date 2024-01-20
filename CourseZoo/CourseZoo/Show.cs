using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseZoo
{
    internal class Show : IBuy
    {
        public double Price { get; private set; } = 1300;

        public void ShowDescription()
        {
            Console.WriteLine("Данное шоу позволяет окунуться в мир...");
        }
    }
}
