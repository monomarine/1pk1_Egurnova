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

namespace Task_38_01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string login;
        private string password1, password2;    


        public MainWindow()
        {
            InitializeComponent();

        }



        private void regiztrationButton_Click(object sender, RoutedEventArgs e)
        {
           login = loginTextBox.Text;
            password1 = passwordBox1.Password;
            password2 = passwordBox2.Password;

            if(String.IsNullOrEmpty(login) )
            {
                MessageBox.Show("логин пустой!");
                return;
            }

            if( password1 == password2 && password1.Length >= 6)
            {
                MessageBox.Show($"регистрация прошла успешно\n" +
                    $"ваш логин - {login}\n" +
                    $"ваш пароль - {password1}");
            }
            else
            {
                MessageBox.Show("пароли не совпадают или длина меньше 6 символов");
                return ;
            }
        }
    }
}