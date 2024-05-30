using MyLibraryApp.Admin;
using MyLibraryApp.Database;
using MyLibraryApp.ViewModal;
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

namespace MyLibraryApp.Staffer
{
    /// <summary>
    /// Логика взаимодействия для AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {
        public AdminWindow()
        {
            InitializeComponent();
            DataContext = new AppWindowVM();
        }

        private void rbAsc_Checked(object sender, RoutedEventArgs e)
        {
            if ((sender as RadioButton).Name == "rbAsc")
            {
                (DataContext as AppWindowVM).Sort(true);
            }
            else
            {
                (DataContext as AppWindowVM).Sort(false);
            }
        }

        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show(
                "Вы уверены, что хотите выйти?",
                "Подтверждение выхода",
                MessageBoxButton.YesNo,
                MessageBoxImage.Question);

            if (result == MessageBoxResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                base.OnClosing(e);
            }
        }

        private void rbDesc_Checked(object sender, RoutedEventArgs e)
        {
            if ((sender as RadioButton).Name == "rbDesc")
            {
                (DataContext as AppWindowVM).Sort(false);
            }
            else
            {
                (DataContext as AppWindowVM).Sort(true);
            }

        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            var addWindow = new AddWindow(null);
            addWindow.Show();
        }

        private void txtbSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            (DataContext as AppWindowVM).Search((sender as TextBox).Text);
        }

        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            var removeWindow = new RemoveWindow((DataContext as AppWindowVM).SelectedBook);
            removeWindow.Show();
            Close();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var selectedBook = (DataContext as AppWindowVM).SelectedBook;

                MessageBoxResult result = MessageBox.Show(
                    $"Вы уверены, что хотите удалить книгу \"{selectedBook.Title}\"?",
                    "Подтверждение удаления",
                    MessageBoxButton.YesNo,
                    MessageBoxImage.Question);

                if (result == MessageBoxResult.Yes)
                {
                    using (var db = new MyLibraryAppEntities())
                    {
                        var objectForDelete = db.Book.FirstOrDefault(x => x.ID == selectedBook.ID);
                        db.Book.Remove(objectForDelete);
                        db.SaveChanges();
                        (DataContext as AppWindowVM).LoadData();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка!\nВы не можете удалить данную книгу!", "Сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }
    }
}
