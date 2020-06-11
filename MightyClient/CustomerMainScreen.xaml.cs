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

namespace MightyClient
{
    /// <summary>
    /// Logika interakcji dla klasy CustomerMainScreen.xaml
    /// </summary>
    public partial class CustomerMainScreen : Window
    {
        public CustomerMainScreen()
        {
            InitializeComponent();
        }

        private void Button_Add_New_Booking_OnClick(object sender, RoutedEventArgs e)
        {
            new AddNewBookingWindow().Show();
        }

        private void Button_Exit_OnClick(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
