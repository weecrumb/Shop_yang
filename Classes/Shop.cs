﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_yanguzov.Classes
{
    public class Shop
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public Shop(string Name, int Price) {
            this.Name = Name;
            this.Price = Price;
        }
    }
}
