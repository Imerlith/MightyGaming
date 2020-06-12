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
    /// Logika interakcji dla klasy CustomerShowHistory.xaml
    /// </summary>
    public partial class CustomerShowHistoryWindow : Window
    {
        public CustomerShowHistoryWindow()
        {
            InitializeComponent();
        }

        private void Button_Back_OnClick(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
