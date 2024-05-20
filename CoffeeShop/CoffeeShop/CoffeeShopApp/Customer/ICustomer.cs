using CoffeeShopApp.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopApp.Customer
{
    public interface ICustomer
    {
        ICoffeeOrder MakeOrder(params string[] ingredients);
    }
}
