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

namespace DataBinding
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<string> products;
        public MainWindow()
        {
            InitializeComponent();

            products = new ObservableCollection<string>
            {
                "Яблоко", "Сахар", "Кофе", "Почка", "Молоко"
            };
            productsList.ItemsSource = products;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            if(!String.IsNullOrEmpty(productTextBox.Text))
                products.Add(productTextBox.Text);
        }
    }
}
