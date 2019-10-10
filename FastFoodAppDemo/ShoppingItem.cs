using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodAppDemo
{
    public class ShoppingItem
    {
        public string _name;
        public int _price;
        public Image _img;
        public ShoppingInfo _sInfo; 

        public ShoppingItem(string name, int price, Image img, ShoppingInfo sInfo)
        {
            _name = name;
            _price = price;
            _img = img;
            _sInfo = SInfo;
        }

        public string Name { get; set; }
        public int Price { get; set; }
        public Image Img { get; set; }
        public ShoppingInfo SInfo { get; set; }
    }
}
