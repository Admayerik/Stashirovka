using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseZoo
{
    internal class User : Person, IBuy
    {
        public int AdultTickets { get; set; }
        public int ChildTickets { get; set; }
        public int DiscountTickets { get; set; }
        public bool Excursion { get; set; }
        public bool AnimalFood { get; set; }
        public bool ContactZoo { get; set; }
        Show show = new Show();
        public bool Show {  get; set; }
        
        public double Price { get; private set; }

        public User(string name) : base(name)
        {

        }

        public override void Info()
        {
            Console.WriteLine($"Взрослых билетов: {AdultTickets}, Детских билетов: {ChildTickets}, Билетов со скидкой: {DiscountTickets}");
            Console.WriteLine($"Экскурсия: {Excursion}, Еда для животных: {AnimalFood}, Контактный зоопарк: {ContactZoo}");
        }

        public double CalculateCost(Zoo z)
        {
            double TotalCost = 0;

            TotalCost += AdultTickets * z.AdultTicketPrice + ChildTickets * z.ChildTicketPrice + DiscountTickets * z.DiscountTicketPrice;

            if (Excursion)
            {
                TotalCost += z.ExcursionPrice;
            }
            if(AnimalFood)
            {
                TotalCost += z.AnimalFoodPrice;
            }
            if (ContactZoo)
            {
                TotalCost += z.ContactZooPrice;
            }

            if(Show)
            {
                TotalCost += show.Price;
            }
            Price = TotalCost;
            return TotalCost;
        }
    }
}
