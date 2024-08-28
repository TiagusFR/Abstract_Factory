using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    public class Coffee :IHotDrink
    {
        public void Consume()
        {
            Console.WriteLine("This coffe is delicious!");
        }
    }
}
