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
    /// Interaction logic for BuyerHomeStands.xaml
    /// </summary>
    public partial class BuyerHomeStands : Window
    {
        public BuyerHomeStands()
        {
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            InitializeComponent();
        }


        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            BuyerHome subWindow = new BuyerHome();
            subWindow.Show();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CarNextRating subWindow = new CarNextRating();
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

        private void Stand_Car_Click(object sender, RoutedEventArgs e)
        {
            CarsInStand subWindow = new CarsInStand();
            subWindow.Show();
            this.Close();
        }


        private void Back_Click(object sender, RoutedEventArgs e)
        {
            BuyerHome subWindow = new BuyerHome();
            subWindow.Show();
            this.Close();
        }
    }
}
