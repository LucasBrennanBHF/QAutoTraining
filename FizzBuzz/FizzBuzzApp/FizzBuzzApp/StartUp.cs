using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzApp
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            FizzBuzz app = new FizzBuzz();
            app.GenerateFizzBuzz(0, 15);
            Console.ReadKey();
        }
    }
}
