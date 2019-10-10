using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodAppDemo
{ 
    public class VisualizeWebPageThroughLink : VisualizeWebPage
    {

        private ListOfAddresses addressesList;

        public VisualizeWebPageThroughLink()
        {
            addressesList = new ListOfAddresses();
            AddToListOfAddresses();
        }

        private void AddToListOfAddresses()
        {
            StringAddress sAddress = new StringAddress();
            sAddress.Address = Address.Facebook;
            sAddress.Choose(sAddress.Address);
            addressesList.AddToList(sAddress.SAddress);
            sAddress.Address = Address.Instagram;
            sAddress.Choose(sAddress.Address);
            addressesList.AddToList(sAddress.SAddress);
            sAddress.Address = Address.Twitter;
            sAddress.Choose(sAddress.Address);
            addressesList.AddToList(sAddress.SAddress);
        }

        public void GoToFacebook()
        {
            System.Diagnostics.Process.Start(addressesList.AddressList[0] as string);
        }

        public void GoToInstagram()
        {
            System.Diagnostics.Process.Start(addressesList.AddressList[1] as string);
        }

        public void GoToTwitter()
        {
            System.Diagnostics.Process.Start(addressesList.AddressList[2] as string);
        }

    }
}
