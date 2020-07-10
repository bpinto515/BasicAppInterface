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
    /// Interaction logic for CarsInStand.xaml
    /// </summary>
    public partial class CarsInStand : Window
    {
        public CarsInStand()
        {
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CorsaPage subWindow = new CorsaPage();
            subWindow.Show();
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




        private void Button_Search(object sender, RoutedEventArgs e)
        {
            CorsaSearchResult subWindow = new CorsaSearchResult();
            subWindow.Show();
            this.Close();
        }

        private void OnKeyDownHandler(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                CorsaSearchResult subWindow = new CorsaSearchResult();
                subWindow.Show();
                this.Close();
            }
        }


        private void Back_Click(object sender, RoutedEventArgs e)
        {
            BuyerHomeStands subWindow = new BuyerHomeStands();
            subWindow.Show();
            this.Close();
        }
    }
}
