using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodAppDemo
{
    public class VisualizeFoodInfoThroughWebPage : VisualizeFoodInfo
    {
        private ListOfAddresses addressesList;

        public VisualizeFoodInfoThroughWebPage()
        {
            addressesList = new ListOfAddresses();
            AddToListOfAddresses();
        }

        public void AddToListOfAddresses()
        {
            FoodInfoStringAddress FoodSAddress = new FoodInfoStringAddress();
            FoodSAddress.Address = Address.Burger;
            FoodSAddress.Choose(FoodSAddress.Address);
            addressesList.AddToList(FoodSAddress.SAddress);
            FoodSAddress.Address = Address.CheeseCake;
            FoodSAddress.Choose(FoodSAddress.Address);
            addressesList.AddToList(FoodSAddress.SAddress);
            FoodSAddress.Address = Address.Pizza;
            FoodSAddress.Choose(FoodSAddress.Address);
            addressesList.AddToList(FoodSAddress.SAddress);
        }

        public void GoSeeBurgerInfo()
        {
            System.Diagnostics.Process.Start(addressesList.AddressList[0] as string);
        }

        public void GoSeeCheeseCakeInfo()
        {
            System.Diagnostics.Process.Start(addressesList.AddressList[1] as string);
        }

        public void GoSeePizzaInfo()
        {
            System.Diagnostics.Process.Start(addressesList.AddressList[2] as string);
        }
    }
}
