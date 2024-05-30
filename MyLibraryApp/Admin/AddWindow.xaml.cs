using MyLibraryApp.Database;
using MyLibraryApp.Staffer;
using MyLibraryApp.ViewModal;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
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

namespace MyLibraryApp.Admin
{
    /// <summary>
    /// Логика взаимодействия для AddWindow.xaml
    /// </summary>
    public partial class AddWindow : Window
    {
        Book _book;
        public AddWindow(Book book)
        {
            InitializeComponent();

            cmbGenre.ItemsSource = DB.DB_s.Genre.ToList();
            cmbPublisher.ItemsSource = DB.DB_s.Publisher.ToList();
            cmbAuthor.ItemsSource = DB.DB_s.Author.ToList();

            foreach (var item in App.Current.Windows)
            {
                if (item is AdminWindow)
                    this.Owner = item as Window;
            }
            if (book is null)
            {
                _book = book = new Book();
            }
            else
            {
                _book = book;
            }
            this.DataContext = _book;

        }

        private void btnAddNewBook_Click(object sender, RoutedEventArgs e)
        {
            if (cmbGenre.SelectedIndex == -1 ||
               cmbPublisher.SelectedIndex == -1 ||
               tbPublicationYear.Text == "" ||
               tbTitle.Text == "" ||
               cmbAuthor.SelectedIndex == -1) MessageBox.Show("Введите все данные!", "Сообщение", MessageBoxButton.OK, MessageBoxImage.Information);
            else
            {
                try
                {
                    using (var db = new MyLibraryAppEntities())
                    {
                        var currentGenre = cmbGenre.SelectedItem as Genre;
                        _book.GenreID = currentGenre.ID;

                        var currentPublisher = cmbPublisher.SelectedItem as Publisher;
                        _book.PublisherID = currentPublisher.ID;

                        var currentAuthor = cmbAuthor.SelectedItem as Author;
                        _book.AuthorID = currentAuthor.ID;

                        _book.UserID = 1;

                        db.Book.AddOrUpdate(_book);
                        db.SaveChanges();
                        ((Owner as AdminWindow).DataContext as AppWindowVM).LoadData(); MessageBox.Show("Данные успешно сохранены!", "Сообщение", MessageBoxButton.OK, MessageBoxImage.Information);
                        var adminWindow = new AdminWindow();
                        adminWindow.Show();
                        this.Close();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Ошибка!", "Сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
                }   
            }
        }
    }
}
