using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseZoo
{
    internal interface IBuy  // Интерфейс для объектов, поддерживающих продажу
    {
        double Price { get; }
    }
}
