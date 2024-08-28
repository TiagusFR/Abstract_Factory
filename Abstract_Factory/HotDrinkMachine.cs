using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    public class HotDrinkMachine
    {
        private Dictionary<string, IHotDrinkFactory> factories = new Dictionary<string, IHotDrinkFactory>();

        public HotDrinkMachine()
        {
            factories.Add("tea", new TeaFactory());
            factories.Add("coffee", new CoffeeFactory());
        }

        public IHotDrink MakeDrink(string type, int amount)
        {
            if (factories.ContainsKey(type))
            {
                return factories[type].Prepare(amount);
            }
            else
            {
                throw new ArgumentException("Drink type not supported");
            }
        }
    }
}