using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_yanguzov.Classes
{
    public class RepoItems
    {
        public static List<object> AllItems()
        {
            List<object> allItems = new List<object>();
            allItems.Add(new Children("Игрушка интерактивная", 2200, 3));
            allItems.Add(new Children("Кактус танцующий", 894, 6));
            allItems.Add(new Sport("Спортивный мужской костюм", 4999, "L"));
            allItems.Add(new Children("Мягкая игрушка", 2170, 7));
            allItems.Add(new Sport("Баскетбольный мяч", 3500, "7-ка"));
            allItems.Add(new Sport("Набор для гольфа", 5000, "600*800 мм"));
            allItems.Add(new Electro("Робот-пылесос", 7841, "10000 mAH", "5 км/ч"));
            allItems.Add(new Electro("Телефон", 50000, "7000 mAH"));
            allItems.Add(new Electro("Монитор", 20000, "10000mAH"));

            return allItems;
        }
    }
}
