using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace selection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("whivh topping?");
            string pizza = Console.ReadLine().ToLower();

            switch (pizza)
            {
                case "cheese and tomato":
                    Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
