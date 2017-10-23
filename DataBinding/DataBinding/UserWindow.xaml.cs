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
using System.Windows.Shapes;

namespace DataBinding
{
    /// <summary>
    /// Логика взаимодействия для UserWindow.xaml
    /// </summary>
    public partial class UserWindow : Window
    {
        ObservableCollection<User> users;
        public UserWindow()
        {
            InitializeComponent();

            users = new ObservableCollection<User>(
                    new List<User>
                    {
                        new User
                        {
                            Id = 1,
                            Login = "Ернар",
                            Password = "123"
                        },
                        new User
                        {
                            Id = 2,
                            Login = "Ера",
                            Password = "123"
                        },
                        new User
                        {
                            Id = 3,
                            Login = "Ернарский",
                            Password = "123"
                        },
                        new User
                        {
                            Id = 4,
                            Login = "Ернаридзе",
                            Password = "123"
                        },
                    });

            usersGrid.ItemsSource = users;

            //User user = new User()
            //{
            //    Id = 1,
            //    Login = "admin",
            //    Password = "admin"
            //};

            //loginLabel.Content = user.Login;
            //passwordLabel.Content = user.Password;

            //loginTextBox.Text = user.Login;
            //passwordTextBox.Text = user.Password;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //passwordLabel.Content = "asdasd";
            //loginLabel.Content = "dsdsdsd";
        }

        private void ChangeButton_Click(object sender, RoutedEventArgs e)
        {
            string name = users[0].Login.ToString();
        }
    }
}
