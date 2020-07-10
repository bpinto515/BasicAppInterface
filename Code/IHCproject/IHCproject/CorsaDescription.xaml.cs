using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace IHCproject
{
    /// <summary>
    /// Interaction logic for CorsaDescription.xaml
    /// </summary>
    public partial class CorsaDescription : Window
    {
        public CorsaDescription()
        {
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CorsaAreYouSure myWindow = new CorsaAreYouSure();
            myWindow.Show();
            this.Close();
        }

        private void Logout_Click(object sender, RoutedEventArgs e)
        {
            MainWindow subWindow = new MainWindow();
            subWindow.Show();
            this.Close();
        }

        private void AccountSettings_Click(object sender, RoutedEventArgs e)
        {
            AccountSettings subWindow = new AccountSettings();
            subWindow.Show();
            this.Close();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            SellerHome subWindow = new SellerHome();
            subWindow.Show();
            this.Close();
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            CorsaEdit subWindow = new CorsaEdit();
            subWindow.Show();
            this.Close();
        }
    }
}
