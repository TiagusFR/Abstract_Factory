using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var machine = new HotDrinkMachine();

            var tea = machine.MakeDrink("tea", 200);
            tea.Consume();

            var coffee = machine.MakeDrink("coffee", 50);
            coffee.Consume();
        }
    }
}
