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
using Task_38_03;

namespace Lesson_38_03
{
#pragma warning disable
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Library _library = new();
        public MainWindow()
        {
            InitializeComponent();
            stateComboBox.SelectedIndex = 1;
            booksListBox.ItemsSource = _library.Books;
        }

        #region обработчики_Событий_WPF_элементов
        private void addBookButton_Click(object sender, RoutedEventArgs e) //----------------------КНОПКА ДОБАВИТЬ
        {
            if (!Validate(out string errorMessage)) //если данные не прошли валидацию
            {
                MessageBox.Show(errorMessage); //то показываем сообщение об ошибке(ах)
                return; //завершаем метод
            }

            //если валидация пройдена, то собираем объект книги
            Book book = new Book(
                titleTextBox.Text, //название из поля titleTextBox
                authorTextBox.Text, //автор из поля authorTextBox
                Int32.Parse(yearTextBox.Text), // год издания из поля yearTextBox с преобразование в int
                (BookState)stateComboBox.SelectedIndex //состояние - из выпадающего списка берется индекс выбранного элемента
                );

            _library.AddBook(book); //вызывается метод добавления книги в библиотеку

            booksListBox.Items.Refresh(); //обновление элементов ListBox чтобы отобразить все изменения
            Clear();
        }
        private void clearBookButton_Click(object sender, RoutedEventArgs e) //--------------------КНОПКА ОЧИСТИТЬ
        {
            Clear();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e) //----------------------------ЗАГРУЗКА ОКНА
        {
            _library.Load();
            booksListBox.ItemsSource = _library.Books;
        }
        private void Window_Closed(object sender, EventArgs e)  //---------------------------------ЗАКРЫТИЕ ОКНА
        {
            _library.Save();
        }
        private void deleteBookMenuItem_Click(object sender, RoutedEventArgs e) //-----------------КОНТЕКСТНОЕ МЕНЮ "УДАЛИТЬ"
        {
            //извлекаем выбранный элемент из ListBox
            var item = booksListBox.SelectedItem;

            //проверяем его на пустоту и является ли он по факту книгой
            if (item != null && item is Book book)
            {
                _library.RemoveBook(book); //вызываем удаление книги из библиотеки
                booksListBox.Items.Refresh(); //обновляем ListBox
            }
        }
        private void showInfoMenuItem_Click(object sender, RoutedEventArgs e) //-------------------КОНТЕКСТНОЕ МЕНЮ "ПОДРОБНЕЕ"
        {
            ShowBookInfo();
        }
        private void booksListBox_MouseDoubleClick(object sender, MouseButtonEventArgs e) //-------ДВОЙНОЙ КЛИК ПО ЭЛЕМЕНТУ СПИСКА
        {
            ShowBookInfo();
        }
        #endregion

        #region вспомомагательные_методы
        //метод-валидатор вводимых данных
        private bool Validate(out string error) //-------------------------------------------------ВАЛИДАЦИЯ ВХОДНЫХ ДАННЫХ
        {
            error = "";
            try //есть вероятность что в поле года будет текст, который не преобразовать к числу
            {
                int year = Convert.ToInt32(yearTextBox.Text);
                if (year < 1900 || year > DateTime.Now.Year) //проверка года издания на корректный диапазон
                {
                    error += "год издания должен быть от 1900 до текцщего года\n";
                }
            }
            catch (FormatException ex)
            {
                error = "год издания - не число\n";
            }

            if (string.IsNullOrEmpty(titleTextBox.Text))  //проверка названия на пустые данные
            {
                error += "Название пусто\n";
            }
            if (string.IsNullOrEmpty(authorTextBox.Text)) //проверка автора на пустые данные
            {
                error += "поле автора пусто\n";
            }

            if (error.Length > 0) 
            {
                return false;
            }
            return true;
        }
        private void Clear()    //-----------------------------------------------------------------ОЧИСТКА ПОЛЕЙ ВВОДА
        {
            titleTextBox.Clear();
            authorTextBox.Clear();
            yearTextBox.Clear();
            stateComboBox.SelectedIndex = 1;
        }
        private void ShowBookInfo() //-------------------------------------------------------------ВСПЛЫВАЮЩЕЕ ОКНО С ИНФОРМАЦИЕЙ ПО ВЫБРАННОЙ КНИГЕ
        {
            var item = booksListBox.SelectedItem;
            if (item != null && item is Book book)
            {
                MessageBox.Show($"{book.Author}\n" +
                    $"{book.Title}\n" +
                    $"год издания: {book.YearOfPublication}\n" +
                    $"состояние - {book.StringState()}");
            }
        }
        #endregion






    }
}
