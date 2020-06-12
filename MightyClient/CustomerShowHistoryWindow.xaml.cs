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

            // TreeViewItem bookings = new TreeViewItem { Header = "Rezerwacja"};

            var SampleData = new SampleData();

            var Extras_List = SampleData.GetExtras();      

            customer_show_history_data_grid.ItemsSource = Extras_List;

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

                    Extras Extras = dgr.Item as Extras;
                    new CustomerDetailsWindow().Show();
                }
            }
        }
    }
}
