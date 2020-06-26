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
    /// Logika interakcji dla klasy CustomerDetailsWindow.xaml
    /// </summary>
    public partial class CustomerDetailsWindow : Window
    {
        private SampleData SampleData;
        private List<Extras> Extra;
        private Booking Booking;
        private List<Order> Order;
        private Customer Customer;
        private List<Station> Stations;

        public CustomerDetailsWindow()
        {
            InitializeComponent();
        }

        private void Button_Cancel_OnClick(object sender, RoutedEventArgs e)
        {
            // Anulowanie rezerwacji
            Close();
        }

        public void loadData(Booking Booking)
        {
            this.Extra = (List<Extras>)Booking.Extras;
            this.Booking = Booking;

            if (this.Extra != null && this.Extra.Count != 0)
            {
                this.Order = new List<Order>();
                foreach (Extras ex in Extra)
                    this.Order.Add(ex.OrderIdorderNavigation);
            } else
            {
                this.Order = new List<Order>();
            }
            this.Customer = Booking.CustomerIdcustomerNavigation;


            var StationText = "";
            Stations = new List<Station>();
            foreach (StationsBookings s in Booking.StationsBookings)
            {
                this.Stations.Add(s.StationStationnumberNavigation);
                StationText += s.StationStationnumberNavigation;
            }

            details_first_name.Text = Customer.PersonIdpersonNavigation.Firstname;
            details_last_name.Text = Customer.PersonIdpersonNavigation.Lastname;
            details_email.Text = Customer.Email;
            details_phone_number.Text = Customer.Phonenumber;

            details_date.Text = Booking.Date.ToString("MM.dd.yyyy");
            details_hour.Text = Booking.Hour.ToString(@"hh\:mm");
            details_people.Text = Booking.Numberofpeople.ToString();
            details_station.Text = StationText;

            if (Booking.Confirmed == false)
            { 
                details_status.Content = "Oczekuje na akceptację";
                details_status.Foreground = Brushes.Red;
            }
            else
            {
                details_status.Content = "Przyjęto rezerwację";
                details_status.Foreground = Brushes.Green;
            }

            foreach(Order o in Order)
            {   
                if (o.Name == "Music") {
                    details_checkbox_music.IsChecked = true;
                } else if (o.Name == "Food") {
                    details_checkbox_food.IsChecked = true;
                }
                else if (o.Name == "Cosplay") {
                    details_checkbox_cosplay.IsChecked = true;
                }
                else if (o.Name == "Alcohol") {
                    details_checkbox_alcohol.IsChecked = true;
                }
            }

            details_pc.Text = Booking.Pc + "";
            details_xbox.Text = Booking.Xbox + "";
            details_ps.Text = Booking.Ps + "";
            details_board_games.Text = Booking.Boardgames + "";

        }

        private void Button_Back_OnClick(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
