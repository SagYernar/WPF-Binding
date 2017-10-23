using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Shop
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Products> products;
        public MainWindow()
        {
            InitializeComponent();
            products = new ObservableCollection<Products>(
                new List<Products>
                {
                    new Products
                    {
                        Id = 1,
                        Name = "ShunHao",
                        Price = 140,
                        MadeIn = "China",
                        Time = DateTime.Today.ToShortDateString()
                        

                    },
                    new Products
                    {
                        Id = 2,
                        Name = "Kola",
                        Price = 220,
                        MadeIn = "Usa",
                        Time = DateTime.Today.ToShortDateString()
                    },
            });
            productsGrid.ItemsSource = products;
        }
    }
}
