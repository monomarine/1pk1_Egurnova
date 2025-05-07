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
        private string login; //внутреннее поле для хранения логина
        private string password1; //поле для хранения первого введенного пароля
        private string password2; //поле для хранения второго введенного пароля

        //конструтор, создающий объект окна во время выполнения. содержит стандартный метод для инициализации всех компонентов
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// обработчик нажатия на кнопку "Зарегестрироваться"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void regiztrationButton_Click(object sender, RoutedEventArgs e)
        {
            //считывание данных из полей окна (логи и паролей в соответствующие переменные)
            login = loginTextBox.Text; //в TextBox полезная информация извлекается из свойства Text
            password1 = passwordBox1.Password; //в PasswordBox полезная информация извлекается из свойства Password
            password2 = passwordBox2.Password;

            if(String.IsNullOrEmpty(login) ) //если логин пустой то выкидываем предупреждение о останавливаем дальнейшую работу
            {
                MessageBox.Show("логин пустой!"); //всплывающее окно с сообщение внутри
                return;
            }

            if( password1 == password2 && password1.Length >= 6) //если оба введенных пароля совпадают и длина не менее 6 символов то выводим сообщение об успехе
            {
                MessageBox.Show($"регистрация прошла успешно\n" +
                    $"ваш логин - {login}\n" +
                    $"ваш пароль - {password1}");
            }
            else // в последнем возможном варианте - пароли не корректные. обрабатываем данную ситуацию
            {
                MessageBox.Show("пароли не совпадают или длина меньше 6 символов");
                return ;
            }
        }
    }
}