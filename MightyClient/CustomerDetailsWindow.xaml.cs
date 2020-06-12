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
    /// Logika interakcji dla klasy CustomerDetailsWindow.xaml
    /// </summary>
    public partial class CustomerDetailsWindow : Window
    {
        public CustomerDetailsWindow()
        {
            InitializeComponent();
        }

        private void Button_Cancel_OnClick(object sender, RoutedEventArgs e)
        {

            // Acnulowanie rezerwacji
            Close();
        }

        private void Button_Back_OnClick(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
