using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_yanguzov.Classes
{
    public class Electro : Shop
    {
        public string BatteryCap { get; set; }
        public string DrivingSpeed = "";
        public Electro(string Name, int Price, string BatteryCap, string DrivingSpeed) : base(Name, Price) { 
            this.BatteryCap = BatteryCap;
            this.DrivingSpeed = DrivingSpeed;
        }
        public Electro(string Name, int Price, string BatteryCap) : base(Name, Price)
        {
            this.BatteryCap = BatteryCap;
        }
    }
}
