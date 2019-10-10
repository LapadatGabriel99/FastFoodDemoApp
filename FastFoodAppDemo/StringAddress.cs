using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodAppDemo
{

    public class StringAddress : Addresses
    {
        public Address Address { get; set; }
        public string SAddress { get; private set; }

        public override void Choose(Address address)
        { 
            switch(address)
            {
                case Address.Facebook:
                    SAddress = "https://www.facebook.com/JollibeePhilippines";
                    break;
                case Address.Instagram:
                    SAddress = "https://www.instagram.com/jollibee/";
                    break;
                case Address.Twitter:
                    SAddress = "https://twitter.com/jollibee";
                    break;
                default:
                    SAddress = "https://www.facebook.com/JollibeePhilippines";
                    break;
            }
        }
    }
}
