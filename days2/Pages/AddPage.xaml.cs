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
    /// Логика взаимодействия для AddPage.xaml
    /// </summary>
    public partial class AddPage : Page
    {
        private Service _service = new Service();
        private ServicePhoto _servicePhoto = new ServicePhoto();
        public AddPage(Service selectID)
        {
            InitializeComponent();
            cbImage.ItemsSource = Code.DB.Image.ToList();
            if (Admin.ID != 0)//если выбрана редактирование
            {//заносим значения в tbиз бд
                _service.ID = Admin.ID;
                //данные для обновления
            }
           
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {//вставка
            StringBuilder errors = new StringBuilder();

            int count = cbImage.SelectedIndex+1;
            _service.MainImagePath = count;
            if (_service.MainImagePath<0)
                errors.Append("Укажите картинку");
            if (string.IsNullOrWhiteSpace(tbname.Text))
                errors.Append("Введиет название");
            _service.Discount =Convert.ToDouble(Tbdiscont.Text);
            if (_service.Discount < 0)
                errors.Append("Введиет скидку");
            if (_service.DurationInSeconds < 0)
                errors.Append("Введите время выполнения >0");
            if (_service.Cost < 0)
                errors.Append("Введите Цену >0");



            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }
            try
            {
                if (Admin.ID > 0)
                {   //обновляем и тд

                    //проверка на правильность ввода
                    //1 время не превышает 4 часа
                    if (_service.DurationInSeconds > 14400)
                        errors.Append("Введео время больше 4 часов");
                    //2 проверка на повтор названия
                    var proverka1 = Code.DB.Service.Where(w => w.Title ==
                    _service.Title).ToList();
                    if (proverka1.Count != 0)
                        errors.Append("Запись услуги такая уже существует");

                    if (errors.Length > 0)
                    {
                        MessageBox.Show(errors.ToString());
                        return;
                    }
                    _service.ID = 116;
                    int num = Admin.ID=116;
                    var uRow = Code.DB.Service.Where(w => w.ID == num).FirstOrDefault();
                    Code.DB.SaveChanges();
                    uRow.Title = tbname.Text;
                    uRow.Cost = Convert.ToDecimal(tbcount.Text);
                    uRow.Discount = Convert.ToDouble(Tbdiscont.Text);
                    uRow.DurationInSeconds = Convert.ToInt32(tbtime.Text);
                    Code.DB.SaveChanges();
                   
                    _servicePhoto.ServiceID = Admin.ID;
                    _servicePhoto.ID = Admin.ID;
                    var images = Code.DB.Image.Where(
                    u => u.ID == count).Select(s => s.PhotoPath).ToList();
                    _servicePhoto.PhotoPath = images.First();
                    Code.DB.SaveChanges();
                    MessageBox.Show("Данные добавлены");

                    

                   
                }
                else
                {
                    _service.Title = tbname.Text;
                    //проверка на правильность ввода
                    //1 время не превышает 4 часа
                    if (_service.DurationInSeconds > 14400)
                        errors.Append("Введео время больше 4 часов");
                    //2 проверка на повтор названия
                    var proverka1 = Code.DB.Service.Where(w => w.Title == 
                    _service.Title).ToList();
                    if (proverka1.Count!=0)
                        errors.Append("Запись услуги такая уже существует");
                    
                    if (errors.Length > 0)
                    {
                        MessageBox.Show(errors.ToString());
                        return;
                    }

                    _service.MainImagePath = count;
                    _service.Title = tbname.Text;
                    _service.Cost =Convert.ToDecimal(tbcount.Text);
                    _service.Discount =Convert.ToDouble(Tbdiscont.Text);
                    _service.DurationInSeconds =Convert.ToInt32(tbtime.Text);
                    Code.DB.Service.Add(_service);
                    Code.DB.SaveChanges();

                    _servicePhoto.ServiceID = Code.DB.Service.Max(m => m.ID);
                    _servicePhoto.ID = Code.DB.ServicePhoto.Max(m => m.ID) + 1;
                    var images = Code.DB.Image.Where(
                    u => u.ID == count).Select(s => s.PhotoPath).ToList();
                    _servicePhoto.PhotoPath = images.First();
                    Code.DB.ServicePhoto.Add(_servicePhoto);
                    Code.DB.SaveChanges();


                    MessageBox.Show("Данные добавлены");
                }
                if (NavigationService.CanGoBack) 
                {
                    Admin.ID = 0;
                    NavigationService.GoBack();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void bage_Click(object sender, RoutedEventArgs e)
        {
            if (NavigationService.CanGoBack)
            {
                Admin.ID = 0;
                NavigationService.GoBack();
            }
        }
    }
}
