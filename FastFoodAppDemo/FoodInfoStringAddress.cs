using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodAppDemo
{
    public class FoodInfoStringAddress : Addresses
    {
        public Address Address { get; set; }
        public string SAddress { get; private set; }

        public override void Choose(Address address)
        {
            switch(address)
            {
                case Address.Burger :
                    SAddress = "https://www.jollibee.com.ph/menu/burger/";
                    break;
                case Address.CheeseCake :
                    SAddress = "https://mcdonalds.ro/ce-mancam/produse/detalii/11-big-tasty";
                    break;
                case Address.Pizza :
                    SAddress = "https://www.pizzaibiza.ro/pizza-craiova-ibiza.html";
                    break;
                default:
                    break;
            }
        }
    }
}
