using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodAppDemo
{
    public enum Address
    {
        Facebook, Instagram, Twitter,
        Burger, CheeseCake, Pizza
    }

    public abstract class Addresses
    {
        public abstract void Choose(Address address);
    }
}
