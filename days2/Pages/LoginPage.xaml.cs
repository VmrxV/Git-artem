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
using days2.Classes;
namespace days2.Pages
{
    /// <summary>
    /// Логика взаимодействия для LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void butLogin_Click(object sender, RoutedEventArgs e)
        {
            Admin.admin = 0;
            NavigationService.Navigate(new Client());
        }

        private void ButLoginUser_Click(object sender, RoutedEventArgs e)
        {
            if (tbCode.Text == "0000")//если код введен
            {
                try
                {
                    Admin.admin = 1;
                    NavigationService.Navigate(new ServicePage());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButton.OK,
                        MessageBoxImage.Error);
                }
            }
            else 
            {
                MessageBox.Show("Непральный код", "Ошибка!", MessageBoxButton.OK,
                       MessageBoxImage.Error);
            }

        }
    }
}
