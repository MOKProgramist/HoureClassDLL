using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hourse
{
    // дом
    public class House
    {
        public string Address { get; set; }
        public int Floors { get; set; }

        public int Age { get; set; }

        public List<Apartment> Apartments { get; set; } = new List<Apartment>();
        public House(string address, int floors, int age) 
        {
            Address = address;
            Floors = floors;
            Age = age;
        }

        public void AddApartments(List<Apartment> appartaments)
        {
            try
            {
                foreach (Apartment a in appartaments)
                {
                    try
                    {
                        this.AddApartment(a);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        private void AddApartment(Apartment appartament) 
        {
            Apartment FindAppartament = (Apartment)Apartments.FirstOrDefault((app) => app.Number == appartament.Number);
            if (FindAppartament != null)
            {
                throw new Exception($"Квартира {appartament.Number} уже есть в доме.");
            }
            Apartments.Add(appartament); 
        }

        public void ShowInfo()
        {
            int CountAppartaments = Apartments.Count;

            Console.WriteLine(
                $"Дом по адресу {Address} имеет {Floors} этажей и возраст {Age}. В нем {CountAppartaments} квартир."
                );
            if(CountAppartaments > 0)
            {
                Console.WriteLine("Информация о каждой квартире ниже:\n");
                Apartments.Sort();
                foreach (Apartment a in Apartments) a.ShowInfo();
            }
        }


    }
}
