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
    /// Логика взаимодействия для Client.xaml
    /// </summary>
    public partial class Client : Page
    {
        public Client()
        {
            InitializeComponent();
            list.ItemsSource = Code.DB.ServicePhoto.ToList();
            discount.ItemsSource = Code.DB.Service.ToList();
        }
        int _sorter;
        private void Up_Click(object sender, RoutedEventArgs e)
        {
            var discont2 = (Service)discount.SelectedItem;
            var data = Code.DB.ServicePhoto.OrderBy(w =>
            w.Service.Discount == discont2.Discount).ToList();
            list.ItemsSource = data;
        }

        private void Bage_Click(object sender, RoutedEventArgs e)
        {
            if (NavigationService.CanGoBack)
            {
                NavigationService.GoBack();
            }
        }

        private void down_Click(object sender, RoutedEventArgs e)
        {
            var discond2 = (Service)discount.SelectedItem;
            var data = Code.DB.ServicePhoto.OrderByDescending(w => 
            w.Service.Discount == discond2.Discount).ToList();
            list.ItemsSource = data;
        }
    }
}
