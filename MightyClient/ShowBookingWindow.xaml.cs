using MightyClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
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
    /// Logika interakcji dla klasy ShowBookingWindow.xaml
    /// </summary>
    public partial class ShowBookingWindow : Window
    {

        private SampleData SampleData;
        private List<Extras> Extra;
        private Booking Booking;
        private List<Order> Order;
        private Customer Customer;
        private List<Station> Stations;

        public ShowBookingWindow()
        {
            InitializeComponent();

            var SampleData = new SampleData();
            SampleData.Initialize();

            var Bookings = SampleData.Bookings;
            var Orders = new List<string>();

            foreach (Extras x in SampleData.ExtrasList)
            {
                foreach (Extras xx in SampleData.ExtrasList)
                {
                    if(xx.BookingIdbooking == x.BookingIdbooking)
                    Orders.Add(xx.OrderIdorderNavigation.Name);
                } 

                x.BookingIdbookingNavigation.Notes = String.Join(",", Orders);
                Orders.Clear();
            }

            show_employee_data_grid.ItemsSource = Bookings;

        }

        private void Button_Back_OnClick(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Employee_Data_Grid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (sender != null)
            {
                DataGrid grid = sender as DataGrid;
                if (grid != null && grid.SelectedItems != null && grid.SelectedItems.Count == 1)
                {
                    DataGridRow dgr = grid.ItemContainerGenerator.ContainerFromItem(grid.SelectedItem) as DataGridRow;

                    Booking BookingToShow = dgr.Item as Booking;

                    loadData(BookingToShow);
                }
            }
        }

        public void loadData(Booking Booking)
        {
            show_employee_checkbox_music.IsChecked = false;
            show_employee_checkbox_food.IsChecked = false;
            show_employee_checkbox_cosplay.IsChecked = false;
            show_employee_checkbox_alcohol.IsChecked = false;

            this.SampleData = new SampleData();
            SampleData.Initialize();
            this.Extra = (List<Extras>)Booking.Extras;
            this.Booking = Booking;

            if (this.Extra != null && this.Extra.Count != 0)
            {
                this.Order = new List<Order>();
                foreach (Extras ex in Extra)
                    this.Order.Add(ex.OrderIdorderNavigation);
            }
            else
            {
                this.Order = new List<Order>();
            }
            this.Customer = Booking.CustomerIdcustomerNavigation;


            var StationText = "";
            Stations = new List<Station>();
            foreach (StationsBookings s in Booking.StationsBookings)
            {
                this.Stations.Add(s.StationStationnumberNavigation);
                StationText += s.StationStationnumberNavigation.Stationnumber + ", ";
            }

            show_employee_first_name.Text = Customer.PersonIdpersonNavigation.Firstname;
            show_employee_last_name.Text = Customer.PersonIdpersonNavigation.Lastname;
            show_employee_email.Text = Customer.Email;
            show_employee_phone_number.Text = Customer.Phonenumber;

            show_employee_date.Text = Booking.Date.ToString("MM.dd.yyyy");
            show_employee_hour.Text = Booking.Hour.ToString(@"hh\:mm");
            show_employee_people.Text = Booking.Numberofpeople.ToString();
            show_employee_station.Text = StationText;
            // show_employee_status.Content = "Oczekuje na akceptację";

            foreach (Order o in Order)
            {
                if (o.Name == "Music")
                {
                    show_employee_checkbox_music.IsChecked = true;
                }
                else if (o.Name == "Food")
                {
                    show_employee_checkbox_food.IsChecked = true;
                }
                else if (o.Name == "Cosplay")
                {
                    show_employee_checkbox_cosplay.IsChecked = true;
                }
                else if (o.Name == "Alcohol")
                {
                    show_employee_checkbox_alcohol.IsChecked = true;
                }

            }
            UpdateLayout();
        }

        private void search_bookings_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            var SampleData = new SampleData();
            SampleData.Initialize();

            var Bookings = SampleData.Bookings;

            var SpecificBookings = new List<Booking>();

            foreach(Booking b in Bookings)
            {
                if(search_bookings.SelectedDate == b.Date)
                {
                    SpecificBookings.Add(b);
                }
            }
                

            var Orders = new List<string>();

            foreach (Extras x in SampleData.ExtrasList)
            {
                foreach (Extras xx in SampleData.ExtrasList)
                {
                    if (xx.BookingIdbooking == x.BookingIdbooking)
                        Orders.Add(xx.OrderIdorderNavigation.Name);
                }

                x.BookingIdbookingNavigation.Notes = String.Join(",", Orders);
                Orders.Clear();
            }

            show_employee_data_grid.ItemsSource = SpecificBookings;
            UpdateLayout();
        }
    }
}
