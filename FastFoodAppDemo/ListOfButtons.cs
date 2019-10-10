using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodAppDemo
{
    class ListOfButtons : LisfOf
    {
        public List<object> ButtonList { get; private set; }

        public ListOfButtons() { ButtonList = new List<object>(); }

        public override void AddToList(object button)
        {
            ButtonList.Add(button);
        }
    }
}
