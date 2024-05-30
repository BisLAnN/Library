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

namespace MyLibraryApp
{
    /// <summary>
    /// Логика взаимодействия для AuthorizationWindow.xaml
    /// </summary>
    public partial class AuthorizationWindow : Window
    {
        public AuthorizationWindow()
        {
            InitializeComponent();
            DataContext = new AuthorizationVM();
        }

        private void SignIn_Click(object sender, RoutedEventArgs e) 
        { 
            if (tbLogin.Text == "" || pswbPassword.Password == "") 
            { 
                MessageBox.Show("Заполните все поля!", "Сообщение", MessageBoxButton.OK, MessageBoxImage.Information); 
            } 

            else 
            { 
                (DataContext as AuthorizationVM).AuthInApp(pswbPassword); 
            } 
        }

        private void txtBuyer_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var newForm = new BooksListWindow();
            newForm.Show();

            Close();
        }
    }
}
