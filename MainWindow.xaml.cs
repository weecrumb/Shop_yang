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
using System.Xml.Linq;

namespace Shop_yanguzov
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<object> AllItems = Classes.RepoItems.AllItems();
        public MainWindow()
        {
            InitializeComponent();
            CreateUI();
        }
        public void CreateUI()
        {
            foreach (object Item in AllItems)
            {
                parent.Children.Add(new Elements.Item(Item));
            }
        }

        public void SearchT(string TovarName, object Item)
        {
            Elements.Item first = new Elements.Item(Item);

            string charT = first.secondCh.ToLower();
            string name = first.firstCh.ToLower();
            if (name.Contains(TovarName) || charT.Contains(TovarName))
            {
                parent.Children.Add(new Elements.Item(Item));
            }
        }

        private void Search(object sender, KeyEventArgs e)
        {
            if (SearchText.Text == "" && e.Key == Key.Enter)
            {
                parent.Children.Clear();
                CreateUI();
                return;
                //ff
            }
            if (e.Key == Key.Enter)
            {
                parent.Children.Clear();
                foreach (object Item in AllItems)
                {
                    string search = SearchText.Text.ToLower();
                    SearchT(search, Item);
                }


            }
        }
    }
}
