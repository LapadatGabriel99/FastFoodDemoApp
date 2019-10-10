using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFoodAppDemo
{
    public class ListOfControls : LisfOf
    {
        public List<object> ControlList { get; private set; }

        public ListOfControls() { this.ControlList = new List<object>(); }

        public override void AddToList(object Control)
        {
            ControlList.Add(Control);
        }
    }
}
