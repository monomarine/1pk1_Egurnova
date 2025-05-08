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

/*
 * Создайте окно ввода информации о книге (название, автор, год издания, состояние – перечисление)
При нажатии на кнопку «сохранить» данные о книге сохраняются во внутренний список связанный с ListBox
при двойном клике по элементу списка - появляется всплывающее окно с информацией о книге
При закрытии приложения данные сериализируются в файл
при открытии приложения - данные восстанавливаются из файла сохранения
*/
namespace Lesson_38_03
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Library library = new();
        public MainWindow()
        {
            InitializeComponent();
            stateComboBox.SelectedIndex = 1;
            booksListBox.ItemsSource = library.Books;
        }

        private void addBookButton_Click(object sender, RoutedEventArgs e)
        {
            if(!Validate(out string errorMessage))
            {
                MessageBox.Show(errorMessage);
                return;
            }

            //собираем объект книги
            Book book = new Book(
                titleTextBox.Text, //название из поля titleTextBox
                authorTextBox.Text, //автор из поля 
                Int32.Parse(yearTextBox.Text), // год издания из поля с преобразование в int
                (BookState)stateComboBox.SelectedIndex //состояние - из выпадающего списка берется индекс выбранного элемента м преобразовывается к перечислению
                );

            library.AddBook(book);
            
            booksListBox.Items.Refresh(); //обновление элементов ListBox чтобы отобразить все изменения
            
            Clear();
        }

        private void clearBookButton_Click(object sender, RoutedEventArgs e)
        {
            Clear();
        }

        private bool Validate(out string error)
        {
            error = "";
            try
            {
                int year = Convert.ToInt32(yearTextBox.Text);
                if (year < 1900 || year > DateTime.Now.Year)
                {
                    error += "год издания некорректен\n";
                    return false;
                }
            }
            catch( FormatException ex)
            {
                error = "год издания - не число\n";
                return false ;
            }

            if (string.IsNullOrEmpty(titleTextBox.Text))
            {
                error += "Название пусто\n";
                return false;
            }
            else if(string.IsNullOrEmpty(authorTextBox.Text))
            {
                error += "поле автора пусто\n";
                return false;   
            }
            
            return true;
        }

        private void Clear()
        {
            titleTextBox.Clear();
            authorTextBox.Clear();
            yearTextBox.Clear();
            stateComboBox.SelectedIndex = 1;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            library.Load();
            booksListBox.ItemsSource = library.Books;
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            library.Save();
        }

        private void booksListBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            ShowBookInfo();
        }

        private void deleteBookMenuItem_Click(object sender, RoutedEventArgs e)
        {
            var item = booksListBox.SelectedItem;

            if (item != null && item is Book book)
            {
                library.RemoveBook(book);
                booksListBox.Items.Refresh();
            }
        }

        private void showInfoMenuItem_Click(object sender, RoutedEventArgs e)
        {
            ShowBookInfo();
        }

        private void ShowBookInfo()
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
    }
}