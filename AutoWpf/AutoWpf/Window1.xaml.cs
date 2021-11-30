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
using System.Windows.Shapes;

namespace AutoWpf
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        private AutoContext _autoContext;
        public Window1()
        {
            InitializeComponent();
            _autoContext = new AutoContext();
        }

        private void RegistrationButton_Click(object sender, RoutedEventArgs e)
        {
            var login = LoginTextBox.Text;
            var password = PasswordTextBox.Text;

            User user = new User
            {
                Login = login,
                Password = password,
                Id = Guid.NewGuid(),
            };

            _autoContext.Users.Add(user);
            _autoContext.SaveChanges();
        }
    }
}
