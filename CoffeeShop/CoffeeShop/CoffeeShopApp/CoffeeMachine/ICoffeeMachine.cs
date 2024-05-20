using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeShopApp.Coffee;

namespace CoffeeShopApp.CoffeeMachine
{
    public interface ICoffeeMachine
    {
        ICoffee MakeCoffee();
    }
}
