using AutoWpf.Models;
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

namespace AutoWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private AutoContext _autoContext;

        public MainWindow()
        {
            InitializeComponent();
            _autoContext = new AutoContext();
        }

        private void AuthorizationButton_Click(object sender, RoutedEventArgs e)
        {
            var login = LoginTextBox.Text;
            var password = PasswordTextBox.Text;

            var users =_autoContext.Users.Where(x=>x.Login == login && x.Password == password).FirstOrDefault();

            if (users == null)
            {
                MessageBox.Show("Такого пользователя нет");
            }

            UsersTable window2 = new UsersTable();
            window2.Show();
            Close();
        }

        private void RegistrationButton_Click(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();
            window1.Show();
            Close();
        }
    }
}
