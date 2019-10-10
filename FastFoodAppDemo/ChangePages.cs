using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFoodAppDemo
{
    public class ChangePages
    {
        public static void BringPageToFront(Control page)
        {
            page.BringToFront();
        }
    }
}
