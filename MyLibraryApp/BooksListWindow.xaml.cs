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
    /// Логика взаимодействия для BooksListWindow.xaml
    /// </summary>
    public partial class BooksListWindow : Window
    {
        public BooksListWindow()
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

        private void tbSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            (DataContext as AppWindowVM).Search((sender as TextBox).Text);
        }
    }
}
