using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Shop_yanguzov.Elements
{
    /// <summary>
    /// Логика взаимодействия для Item.xaml
    /// </summary>
    public partial class Item : UserControl
    {
        public string firstCh = "";
        public string secondCh = "";
        public Item(object ItemData)
        {
            InitializeComponent();
            Classes.Shop ShopData = ItemData as Classes.Shop;
            tb_Name.Content = ShopData.Name;
            tb_Price.Content = "Цена: " + ShopData.Price;

            if (ItemData is Classes.Children)
            {
                Classes.Children ChildernData = ItemData as Classes.Children;
                tb_Characteristic.Content = "Возраст: " + ChildernData.Age;
                firstCh = tb_Characteristic.Content.ToString();
            }
            if (ItemData is Classes.Sport)
            {
                Classes.Sport SportData = ItemData as Classes.Sport;
                tb_Characteristic.Content = "Размер: " + SportData.Size;
                firstCh = tb_Characteristic.Content.ToString();
            }
            if (ItemData is Classes.Electro)
            {
                Classes.Electro electroData = ItemData as Classes.Electro;
                tb_Characteristic.Content = "Емкость аккумулятора: " + electroData.BatteryCap;
                firstCh = tb_Characteristic.Content.ToString();
            }

            if (ItemData is Classes.Electro)
            {
                Classes.Electro electroData = ItemData as Classes.Electro;
                if (electroData.DrivingSpeed != "") { 
                    tb_Speed.Content = "Скорость езды:  " + electroData.DrivingSpeed; }
                    
                firstCh = tb_Characteristic.Content.ToString();
                secondCh = tb_Speed.Content.ToString();

            }
        }
    }
}
