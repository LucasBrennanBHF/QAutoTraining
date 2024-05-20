using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopApp.Coffee
{
    public interface ICoffee
    {
        void AddIngredients(params string[] ingredients);
    }
}
