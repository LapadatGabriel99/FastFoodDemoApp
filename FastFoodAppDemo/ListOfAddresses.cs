using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodAppDemo
{
    public class ListOfAddresses : LisfOf
    {

        public List<object> AddressList { get; private set; }
        public ListOfAddresses() { AddressList = new List<object>(); }
        public override void AddToList(object address)
        {
            AddressList.Add(address);
        }
    }
}
