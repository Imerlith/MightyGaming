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
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Customer_OnClick(object sender, RoutedEventArgs e)
        {
            new AddNewBookingWindow().Show();
        }

        private void Button_Employee_OnClick(object sender, RoutedEventArgs e)
        {
            new ShowBookingWindow().Show();
        }
    }


}
