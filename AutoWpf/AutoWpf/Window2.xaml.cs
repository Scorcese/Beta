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
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class UsersTable : Window
    {
        private AutoContext _autoContext;
        public UsersTable()
        {
            InitializeComponent();
            _autoContext = new AutoContext();

            var users = _autoContext.Users.ToList();
            usersDataGrid.ItemsSource = users;
        }
    }
}
