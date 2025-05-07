using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Task_38_02
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Product> products = new() //список всех продуктов
        {
            new Product("Молоко", 1200),
            new Product("Хлеб", 500),
            new Product("Яйца", 800),
            new Product("Сыр", 1500),
            new Product("Мясо", 2500),
            new Product("Рыба", 1800),
            new Product("Овощи", 600),
            new Product("Фрукты", 900),
            new Product("Йогурт", 700),
            new Product("Колбаса", 1300),
            new Product("Макароны", 400),
            new Product("Рис", 450),
            new Product("Кофе", 2000),
            new Product("Чай", 300),
            new Product("Сахар", 350)
        };

        private List<Product> basketProducts = new(); //список продуктов в корзине
        private decimal totalPrice;
        private decimal deliveryPrice = 300m;
        public MainWindow()
        {
            InitializeComponent();

            //связывание листбоксов с нужным списком в качестве источника данных
            allProductsListBox.ItemsSource = products; 
            basketListBox.ItemsSource = basketProducts;
        }

        private void addProductButton_Click(object sender, RoutedEventArgs e)
        {
            var product = allProductsListBox.SelectedItem as Product;
            if (product != null)
            {
                basketProducts.Add(product);
                basketListBox.Items.Refresh();
            }
        }

        private decimal GetTotalPrice(ref List<Product> products)
        {
            decimal totalPrice = 0;
            foreach (var product in products)
            {
                totalPrice += product.Price;
            }
            return totalPrice;  
        }

        private void takeOrderButton_Click(object sender, RoutedEventArgs e)
        {
            if (deliveryOnCheckBox.IsChecked == true)
            {
                totalPrice = GetTotalPrice(ref basketProducts) + deliveryPrice;
            }
            else
                totalPrice = GetTotalPrice(ref basketProducts);

            MessageBox.Show($"сумма вашего заказа: \n" +
                $"{totalPrice:F2}");
                
        }
    }
}