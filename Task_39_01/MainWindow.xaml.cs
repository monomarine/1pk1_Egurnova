using System.IO;
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
using Microsoft.Win32;

namespace Task_39_01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OpenFileButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Title = "Открыть",
                Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
            };

            if(openFileDialog.ShowDialog() == true)
            {
                try
                {
                    string content = File.ReadAllText(openFileDialog.FileName);
                    MainTextBox.Text = content;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Невозможно открыть файл",
                        "Ошибка",
                        MessageBoxButton.YesNoCancel,
                        MessageBoxImage.Exclamation);
                }
            }
        }

        private void SaveFileButton_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog()
            {
                DefaultExt = ".txt",
                Title = "Сохранить",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
            };

            try 
            {
                if (saveFileDialog.ShowDialog() == true)
                {
                    string fileName = saveFileDialog.FileName;
                    File.WriteAllText(fileName, MainTextBox.Text);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "ошибка",
                    MessageBoxButton.YesNoCancel,
                    MessageBoxImage.Warning);
            }
          

        }

        private void Window_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            this.Background = new SolidColorBrush(Colors.Firebrick);
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Q)
            {
                MessageBox.Show("вы нажали Q");
            }
            else
            {
                MessageBox.Show("вы нажали не Q");
            }
        }
    }
}