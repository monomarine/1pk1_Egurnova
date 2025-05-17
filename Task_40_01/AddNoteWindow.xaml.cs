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
using System.Windows.Shapes;

namespace Task_40_01
{
    /// <summary>
    /// Логика взаимодействия для AddNoteWindow.xaml
    /// </summary>
    public partial class AddNoteWindow : Window
    {
        public Note Note
        {
            get
            {
                if (!string.IsNullOrEmpty(TitleTextBox.Text))
                    return new Note(TitleTextBox.Text, ContentTextBox.Text);
                else
                    throw new Exception("заголовок не может быть пустым");
            }
        }
        public AddNoteWindow(Window owner)
        {
            this.Owner = owner;
            InitializeComponent();
        }
        public AddNoteWindow(Window owner, Note note)
        {
            this.Owner = owner;
            InitializeComponent();
            TitleTextBox.Text = note.Title;
            ContentTextBox.Text = note.Content;
        }

        private void AddNoteButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
