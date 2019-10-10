using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFoodAppDemo
{
    public partial class FirstCustomControl : UserControl
    {
        ShoppingItem _shoppingItem;
        ShoppingItem ShoppingItem { get; set; }
        public bool WhenChanged { get; set; }


        public FirstCustomControl()
        {
            InitializeComponent();
            IntializeFirstControlItem();
            WhenChanged = false;
        }

        private void IntializeFirstControlItem()
        {
            _shoppingItem = new ShoppingItem("Chesseburger", 19, Cheeseburger_PictureBox.Image, new ShoppingInfo(CheeseburgerWithOTB_label.Text));
        }

        private void FirstCustomControl_Load(object sender, EventArgs e)
        {

        }

        private void OrderCheeseburger_Button_Click(object sender, EventArgs e)
        {
            
        }

        private void ChessburgerPrice_label_Click(object sender, EventArgs e)
        {
            WhenChanged = true;

        }
    }
}
