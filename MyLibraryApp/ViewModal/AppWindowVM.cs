using MyLibraryApp.Database;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;
using System.Data.Entity;

namespace MyLibraryApp.ViewModal
{
    public class AppWindowVM : BaseVM
    {
        private ObservableCollection<User> _users;
        public ObservableCollection<User> Users
        {
            get { return _users; }
            set
            {
                _users = value;
                OnPropertyChanged(nameof(Users));
            }
        }

        private ObservableCollection<Role> _roles;
        public ObservableCollection<Role> Roles
        {
            get { return _roles; }
            set
            {
                _roles = value;
                OnPropertyChanged(nameof(Roles));
            }
        }

        private ObservableCollection<Author> _authors;
        public ObservableCollection<Author> Authors
        {
            get { return _authors; }
            set
            {
                _authors = value;
                OnPropertyChanged(nameof(Authors));
            }
        }

        private ObservableCollection<Book> _books;
        public ObservableCollection<Book> Books
        {
            get { return _books; }
            set
            {
                _books = value;
                OnPropertyChanged(nameof(Books));
            }
        }

        private Database.Book _selectedBook;
        public Database.Book SelectedBook
        {
            get { return _selectedBook; }
            set
            {
                _selectedBook = value;
                OnPropertyChanged(nameof(SelectedBook));
            }
        }

        private Book _selected;
        public Book Selected
        {
            get { return _selected; }
            set
            {
                _selected = value;
                OnPropertyChanged(nameof(Selected));
            }
        }

        private ObservableCollection<Genre> _genres;
        public ObservableCollection<Genre> Genres
        {
            get { return _genres; }
            set
            {
                _genres = value;
                OnPropertyChanged(nameof(Genres));
            }
        }

        private ObservableCollection<Publisher> _publishers;
        public ObservableCollection<Publisher> Publishers
        {
            get { return _publishers; }
            set
            {
                _publishers = value;
                OnPropertyChanged(nameof(Publisher));
            }
        }



        public AppWindowVM()
        {
            Initialize();
            LoadData();
        }


        private void Initialize()
        {
            Users = new ObservableCollection<User>();
            Roles = new ObservableCollection<Role>();
            Authors = new ObservableCollection<Author>();
            Books = new ObservableCollection<Book>();
            Genres = new ObservableCollection<Genre>();
            Publishers = new ObservableCollection<Publisher>();
        }


        public void LoadData()
        {
            Books.Clear();  

            try
            {
                using (var db = new MyLibraryAppEntities())
                {
                    var result = DB.DB_s.Book.Include("Genre").Include("Publisher").Include("Author").ToList();
                    result.ForEach(p => Books?.Add(p));
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка!");
            }

            Roles.Clear();
            try
            {
                using (var db = new MyLibraryAppEntities())
                {
                    var result = DB.DB_s.Role.ToList();
                    result.ForEach(r => Roles?.Add(r));
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка!");
            }

            Publishers.Clear();
            try
            {
                using (var db = new MyLibraryAppEntities())
                {
                    var result = DB.DB_s.Publisher.ToList();
                    result.ForEach(s => Publishers?.Add(s));
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка!");
            }

            Users.Clear();
            try
            {
                using (var db = new MyLibraryAppEntities())
                {
                    var result = DB.DB_s.User.ToList();
                    result.ForEach(u => Users?.Add(u));
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка!");
            }

            Genres.Clear();
            try
            {
                using (var db = new MyLibraryAppEntities())
                {
                    var result = DB.DB_s.Genre.ToList();
                    result.ForEach(u => Genres?.Add(u));
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка!");
            }

            Authors.Clear();
            try
            {
                using (var db = new MyLibraryAppEntities())
                {
                    var result = DB.DB_s.Author.ToList();
                    result.ForEach(u => Authors?.Add(u));
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка!");
            }

        }

        public void Search(string search)
        {
            if (string.IsNullOrEmpty(search))
            {
                LoadData();
                return;
            }

            Books.Clear();
            using (var db = new MyLibraryAppEntities())
            {
                var result = db.Book.Where(x => x.Title.ToLower().Contains(search.ToLower())).Include("Author").Include("Publisher").Include("Genre").Include("User").ToList();
                result.ForEach(x => Books.Add(x));
            }
        }


        public void Sort(bool isDesc)
        {
            if (!isDesc)
            {
                var result = Books.OrderBy(u => u.PublicationYear).ToList();

                Books.Clear();

                result.ForEach(u => Books.Add(u));
            }
            else
            {
                var result = Books.OrderByDescending(u => u.PublicationYear).ToList();

                Books.Clear();

                result.ForEach(u => Books.Add(u));

            }
        }
    }
}
    