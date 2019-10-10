using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFoodAppDemo
{
    public class MovingScrollBar
    {
        public Panel Panel { get; set; }
       

        public MovingScrollBar()
        {
            Panel = new Panel();
        }

        public int Default_Location()
        {
            Panel.Top = 76;
            return Panel.Top;
        }

        public int Move_Location(Button button)
        {
            Panel.Top = button.Top;
            return Panel.Top;
        }
    }
}
