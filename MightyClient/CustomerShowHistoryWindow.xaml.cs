using MightyClient.Models;
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

            var Bookings = SampleData.Bookings;

            var notes = "";

            foreach (Booking b in Bookings)
            {
                foreach (Extras x in b.Extras)
                {
                    notes += x.OrderIdorderNavigation.Name + " " ;
                }
                b.Notes = notes;
                notes = "";
            }

            customer_show_history_data_grid.ItemsSource = Bookings;
        }

        private void Button_Back_OnClick(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void History_Data_Grid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (sender != null)
            {
                DataGrid grid = sender as DataGrid;
                if (grid != null && grid.SelectedItems != null && grid.SelectedItems.Count == 1)
                {
                    DataGridRow dgr = grid.ItemContainerGenerator.ContainerFromItem(grid.SelectedItem) as DataGridRow;

                    Booking Booking = dgr.Item as Booking;

                    CustomerDetailsWindow CDW = new CustomerDetailsWindow();

                    CDW.loadData(Booking);

                    CDW.Show();
                }
            }
        }
    }
}
