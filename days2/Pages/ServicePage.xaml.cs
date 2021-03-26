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
    /// Логика взаимодействия для ServicePage.xaml
    /// </summary>
    public partial class ServicePage : Page
    {
        public ServicePage()
        {
            InitializeComponent();
            list.ItemsSource = Code.DB.ServicePhoto.ToList();
        }

        private void Bage_Click(object sender, RoutedEventArgs e)
        {
            if (NavigationService.CanGoBack)
            {
                NavigationService.GoBack();
            }
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddPage(null));
        }

        private void del_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var delete = (ServicePhoto)list.SelectedItem;
                var del = (Service)delete.Service;
                if (MessageBox.Show($"Вы точно хотите удалиnm ", "Внимание",
                    MessageBoxButton.YesNo,
                    MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    try
                    {
                        Code.DB.ServicePhoto.Remove(delete);
                        Code.DB.Service.Remove(del);
                        Code.DB.SaveChanges();
                        Code.DB.ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                        list.ItemsSource = Code.DB.ServicePhoto.ToList();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
            }
            catch
            {
                MessageBox.Show("выберите элеменет который вы хотите удалить", "Ошибка!", MessageBoxButton.OK);
            }
        }

        private void EditService_Click(object sender, RoutedEventArgs e)
        {
            Admin.ID = list.SelectedIndex+1;
            NavigationService.Navigate(new AddPage((sender as Button).DataContext as Service));
        }

        private void Page_IsHitTestVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                Code.DB.ChangeTracker.Entries().
                    ToList().ForEach(p => p.Reload());
                list.ItemsSource = Code.DB.ServicePhoto.ToList();
            }
        }
      
    }
}
