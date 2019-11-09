using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pizza
{
    class PizzaBase
    {
        private Dictionary<string, int> pizzaBase = new Dictionary<string, int>();

        private string name;
        internal string Name
        {
            get
            {
                if (name == null)
                {
                    return pizzaBase.Keys.First();
                }
                else
                {
                    return name;
                }
            }

            set
            {
                if (pizzaBase.ContainsKey(value))
                {
                    name = value;
                }
                else
                {
                    Console.Write("Not a valid base. Select one between:");
                    foreach (var item in pizzaBase)
                    {
                        Console.Write($"{item.Key} ");
                    }
                }
            }
        }
        internal PizzaBase()
        {
            AddBase();
        }
        private void AddBase()
        {
            pizzaBase.Add("Regular", 10);
            pizzaBase.Add("Thick", 10);
            pizzaBase.Add("Italian", 15);
        }

        internal int CalculateBase()
        {
            return pizzaBase[Name];
        }
        internal void Print()
        {
            Console.WriteLine($"Base: [{Name}] (${(pizzaBase[this.Name])})");
        }
    }
}
