using MyLibraryApp.Database;
using MyLibraryApp.Staffer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace MyLibraryApp.ViewModal
{
    public class AuthorizationVM : BaseVM
    {
        private string _login;
        public string Login
        {
            get => _login;
            set
            {
                _login = value;
                OnPropertyChanged(nameof(Login));
            }
        }
        private User _user;

        public string GetPassword(PasswordBox passwordBox) { return passwordBox.Password; }




        private bool UserAuthorizaton(string login, string password)
        {
            using (var db = new MyLibraryAppEntities())
            {
                var res = db.User.FirstOrDefault(user => user.Login == login && user.Password == password);
                _user = res;
                if (res != null && res.Role.Name == "администратор" || res != null && res.Role.Name == "читатель" || res != null & res.Role.Name == "библиотекарь")
                {
                    return true;
                }

                else
                {
                    return false;
                }

            }
        }

        public void AuthInApp(PasswordBox passwordBox)
        {
            string password = GetPassword(passwordBox); 
            bool result = UserAuthorizaton(Login, password);
            if (result)
            {
                if (_user != null)
                {
                    if (_user.Role.Name == "администратор")
                    {
                        foreach (Window window in Application.Current.Windows)
                        {
                            if (window is AuthorizationWindow)
                            {
                                var newForm = new AdminWindow();
                                newForm.Show();
                                window.Close();
                            }
                        }
                    }

                    else if (_user.Role.Name == "читатель")
                    {
                        foreach (Window window in Application.Current.Windows)
                        {
                            if (window is AuthorizationWindow)
                            {
                                var newForm = new BooksListWindow();
                                newForm.Show();
                                window.Close();
                            }
                        }
                    }

                    else if (_user.Role.Name == "библиотекарь")
                    {
                        foreach (Window window in Application.Current.Windows)
                        {
                            if (window is AuthorizationWindow)
                            {
                                var newForm = new BooksListWindow();
                                newForm.Show();
                                window.Close();
                            }
                        }
                    }

                }
            }
            else
            {
                MessageBox.Show("Ошибка!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                System.Diagnostics.Process.Start(Application.ResourceAssembly.Location);
                Application.Current.Shutdown();
            }
        }
    }
}
