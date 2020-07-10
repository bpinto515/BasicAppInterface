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
    /// Interaction logic for CorsaAreYouSure.xaml
    /// </summary>
    public partial class CorsaAreYouSure : Window
    {
        public CorsaAreYouSure()
        {
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            InitializeComponent();
        }

        private void Yes_Click(object sender, RoutedEventArgs e)
        {
            SellerHome myWindow = new SellerHome();
            myWindow.Show();
            this.Close();
        }


        private void No_Click(object sender, RoutedEventArgs e)
        {
            CorsaDescription myWindow = new CorsaDescription();
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
            CorsaDescription subWindow = new CorsaDescription();
            subWindow.Show();
            this.Close();
        }
    }
}
