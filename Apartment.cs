using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hourse
{
    public class Apartment : IComparable<Apartment>
    {
        public double Area { get; set; }
        // владелец
        public string Owner { get; set; }
        public int Number { get; set; }

        public Apartment(double area, string owner, int number)
        {
            Area = area;
            Owner = owner;
            Number = number;
        }
        public int CompareTo(Apartment other)
        {
            return Number.CompareTo(other.Number);
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Информация о квартире #{Number}: Площадь {Area}, Владелец: {Owner}");
        }
    }
}
