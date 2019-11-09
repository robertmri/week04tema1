using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pizza
{
    internal class PizzaTopping
    {

        private Dictionary<string, int> topping = new Dictionary<string, int>();

        private string name;
        internal string Name
        {
            get
            {
                if (name == null)
                {
                    return topping.Keys.First();
                }
                else
                {
                    return name;
                }
            }

            set
            {
                if (topping.ContainsKey(value))
                {
                    name = value;
                }
                else
                {
                    Console.Write("Not a valid topping. Select one between:");
                    foreach (var item in topping)
                    {
                        Console.Write($"{item.Key} ");
                    }
                }
            }
        }
        internal PizzaTopping()
        {
            AddToppings();
        }
        private void AddToppings()
        {
            topping.Add("Cheese", 5);
            topping.Add("Meat", 5);
            topping.Add("Vegetable", 5);
        }

        internal int CalculateTopping()
        {
            return topping[Name];
        }
        internal void Print()
        {
            if (Name == "Meat")
            {
                Console.WriteLine($"\t{Name.ToUpper()} - ($ {topping[this.Name]})");
            }
            else
            {
                Console.WriteLine($"\t{Name} - ($ {topping[this.Name]})");
            }
        }
    }
}
