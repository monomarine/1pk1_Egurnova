using System.Collections.ObjectModel;
using System.IO;
using System.Text.Json;
using System.Windows;
using System.Windows.Input;
using Microsoft.Win32;

namespace Task_40_01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Note>? notes = new();
        string saveFileName = "notes.json";
        public MainWindow()
        {
            InitializeComponent();
            NotesListBox.ItemsSource = notes;
        }

        private void AddNoteButton_Click(object sender, RoutedEventArgs e)
        {
            AddNoteWindow addNoteWindow = new AddNoteWindow(this); //экземпляр модального окна
            // если в модальном окне пользователь нажал кнопку "добавить"
            if (addNoteWindow.ShowDialog() == true)
            {
                try // есть вероятность исключения, поэтому обрабатываем возможную оошиюку
                {
                    notes.Add(addNoteWindow.Note); //обращаемся к объекту модального окна и его свойству Note
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void MainListBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var note = NotesListBox.SelectedItem as Note;
            if (note != null)
            {
                AddNoteWindow addNoteWindow = new AddNoteWindow(this, note);
                if (addNoteWindow.ShowDialog() == true)
                {
                    notes.Remove(note);
                    notes.Add(addNoteWindow.Note);
                }
            }
        }
        private void MainListBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Delete)
            {
                var note = NotesListBox.SelectedItem as Note;
                if (note != null)
                {
                    notes.Remove(note);
                }
            }
        }
        #region ContextMenu
        private void ExportToTXTMenuItem_Click(object sender, RoutedEventArgs e)
        {
            var note = NotesListBox.SelectedItem as Note;
            if (note != null)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog()
                {
                    Title = "Экспорт",
                    FileName = note.Title,
                    DefaultExt = ".txt",
                    InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
                };

                if (saveFileDialog.ShowDialog() == true)
                {
                    File.WriteAllText(saveFileDialog.FileName, note.Content);
                }
            }
        }
        private void DeleteNoteMenuItem_Click(object sender, RoutedEventArgs e)
        {
            var note = NotesListBox.SelectedItem as Note;
            if (note != null)
            {
                notes.Remove(note);
            }
        }

        private void EditNoteMenuItem_Click(object sender, RoutedEventArgs e)
        {
            var note = NotesListBox.SelectedItem as Note;
            if (note != null)
            {
                AddNoteWindow addNoteWindow = new AddNoteWindow(this, note);
                if (addNoteWindow.ShowDialog() == true)
                {
                    notes.Remove(note);
                    notes.Add(addNoteWindow.Note);
                }
            }
        }

        #endregion

        #region Loaded_Closing
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (File.Exists(saveFileName))
            {
                string jsonContent = File.ReadAllText(saveFileName);
                notes = JsonSerializer.Deserialize<ObservableCollection<Note>>(jsonContent);
                NotesListBox.ItemsSource = notes;
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                WriteIndented = true,
                Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping
            };
            string jsoncontent = JsonSerializer.Serialize(notes, options);
            try
            {
                File.WriteAllText(saveFileName, jsoncontent);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Невозможно выполнить сохранение\n" + ex.Message);
            }
        }
        #endregion
    }
}