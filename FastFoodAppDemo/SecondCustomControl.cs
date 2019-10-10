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
    public partial class SecondCustomControl : UserControl
    {
        public SecondCustomControl()
        {
            InitializeComponent();
            this.Click += new EventHandler(ReadMoreBurger_Button_Click);
        }

        VisualizeFoodInfoThroughWebPage VFITWP = new VisualizeFoodInfoThroughWebPage();

        private void ReadMoreBurger_Button_Click(object sender, EventArgs e)
        {
            
        }
    }
}
