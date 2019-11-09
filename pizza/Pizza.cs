using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pizza
{
    class Pizza
    {
        public Pizza(PizzaBase pBase, string name)
        {
            this.PizzaBase = pBase;
            this.PizzaTopping = new List<PizzaTopping>();
            this.Name = name;
        }
        public string Name { get; set; }
        internal PizzaBase PizzaBase { get; set; }
        internal List<PizzaTopping> PizzaTopping { get; set; }

        internal void AddTopping(PizzaTopping top)
        {
            this.PizzaTopping.Add(top);
        }

        internal int CalculateTotalCost()
        {
            int topingsTotal = 0;

            for (int i = 0; i < PizzaTopping.Count; i++)
            {
                topingsTotal = topingsTotal + PizzaTopping[i].CalculateTopping();
            }

            return this.PizzaBase.CalculateBase() + topingsTotal;
        }

        internal void Print()
        {
            Console.Write($"\nPizza [{this.Name}]\n");
            PizzaBase.Print();
            Console.WriteLine("Topings: ");
            foreach (var item in PizzaTopping)
            {
                item.Print();
            }
            Console.WriteLine($"Total Cost: ($ {CalculateTotalCost()})\n");
        }
    }
}
