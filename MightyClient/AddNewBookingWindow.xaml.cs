using MightyClient.Models;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MightyClient
{
    public partial class AddNewBookingWindow : Window
    { 
        public AddNewBookingWindow()
        {
            InitializeComponent();

            List<Station> Stations = SampleData.Stations;

            add_station.ItemsSource = Stations;
        }

        private void Button_Next_OnClick(object sender, RoutedEventArgs e)
        {

            string Firstname = add_first_name.Text,
                Lastname = add_last_name.Text,
                Phonenumber = add_phone_number.Text,
                Email = add_email.Text;

            long holder;


            if (!String.IsNullOrEmpty(add_first_name.Text) )
            {
                Firstname = add_first_name.Text;
            }
            else
            {
                MessageBox.Show("Pole 'Imie' wymagane");
                return;
            }

            if (!String.IsNullOrEmpty(add_last_name.Text))
            {
                Lastname = add_last_name.Text;
            }
            else
            {
                MessageBox.Show("Pole 'Nazwisko' wymagane");
                return;
            }

            if (!String.IsNullOrEmpty(add_phone_number.Text) && long.TryParse(add_phone_number.Text, out holder) && (add_phone_number.Text.Length > 8 && add_phone_number.Text.Length < 13))
            {
                Phonenumber = add_phone_number.Text;
            }
            else
            {
                MessageBox.Show("Pole 'Numer telefonu' jest wymagane i musi składać się wyłącznie z cyfr");
                return;
            }

            if (!String.IsNullOrEmpty(add_email.Text)&& add_email.Text.Contains('@'))
            {
                Email = add_email.Text;
            }
            else
            {
                MessageBox.Show("Pole 'Email' jest wymagane i musi zawierać poprawny adres email");
                return;
            }

            int People = 0,
                Pc = 0,
                Xbox = 0,
                Ps = 0,
                Boardgames = 0;

            if (!String.IsNullOrEmpty(add_people.Text) && int.TryParse(add_people.Text, out People))
            {
                People = Int32.Parse(add_people.Text);
            }
            else
            {
                MessageBox.Show("Pole 'Liczba osób' jest wymagane i musi składać się wyłącznie z cyfr");
                return;
            }

            if (!String.IsNullOrEmpty(add_pc.Text) && int.TryParse(add_pc.Text, out Pc))
            {
                Pc = Int32.Parse(add_pc.Text);
            }
            else
            {
                MessageBox.Show("Pole 'PC' jest wymagane i musi składać się wyłącznie z cyfr");
                return;
            }

            if (!String.IsNullOrEmpty(add_xbox.Text) && int.TryParse(add_xbox.Text, out Xbox))
            {
                Xbox = Int32.Parse(add_xbox.Text);
            }
            else
            {
                MessageBox.Show("Pole 'Xbox' jest wymagane i musi składać się wyłącznie z cyfr");
                return;
            }

            if (!String.IsNullOrEmpty(add_ps.Text)&& int.TryParse(add_ps.Text, out Ps))
            {
                Ps = Int32.Parse(add_ps.Text);
            }
            else
            {
                MessageBox.Show("Pole 'Playstation' jest wymagane i musi składać się wyłącznie z cyfr");
                return;
            }


            if (!String.IsNullOrEmpty(add_board_games.Text) && int.TryParse(add_board_games.Text, out Boardgames))
            {
                Boardgames = Int32.Parse(add_board_games.Text);
            } 
            else
            {
                MessageBox.Show("Pole 'Planszówki' jest wymagane i musi składać się wyłącznie z cyfr");
                return;
            }

            DateTime Date;
            TimeSpan Hour;
            Station Station;

            if (add_date.SelectedDate != null)
            {
                Date = (DateTime)add_date.SelectedDate;
            } 
            else
            {
                MessageBox.Show("Wybierz datę rezerwacji");
                return;
            }

            if (add_hour.Value != null)
            {
                
                Hour = ((DateTime)add_hour.Value).TimeOfDay;
            } 
            else
            {
                MessageBox.Show("Wybierz godzinę rezerwacji");
                return;
            }

            if(add_station.SelectedItem != null)
            {
                Station = (Station)add_station.SelectedItem;
            }
            else
            {
                MessageBox.Show("Wybierz stanowisko");
                return;
            }

            Order food = (add_checkbox_food.IsChecked == true)? SampleData.Orders[0]: null, 
                music = (add_checkbox_music.IsChecked == true) ? SampleData.Orders[1] : null,
                cosplay = (add_checkbox_cosplay.IsChecked == true) ? SampleData.Orders[2] : null,
                alcohol = (add_checkbox_alcohol.IsChecked == true) ? SampleData.Orders[3] : null;

            List<Order> o = new List<Order> { food, music, cosplay, alcohol };
            Booking b = new Booking { Date = Date, Hour = Hour, Numberofpeople = People, Confirmed = false, Pc = Pc, Xbox = Xbox, Ps = Ps, Boardgames = Boardgames };
            Customer c = new Customer();
            List<Extras> ex = new List<Extras>();
            List<StationsBookings> sb = new List<StationsBookings> { new StationsBookings { StationStationnumberNavigation = Station, BookingIdbookingNavigation = b } };

            bool isCustomer = false;

            foreach (Customer cust in SampleData.Customers)
            {
                if(cust.Email.Equals(Email))
                {
                    isCustomer = true;
                    c = cust;
                    c.addBooking(b);
                }
            }

            if (!isCustomer) {
                Person p = new Person { Firstname = Firstname, Lastname = Lastname };
                c = new Customer { PersonIdpersonNavigation = p, Email = Email, Phonenumber = Phonenumber};
                c.addBooking(b);
                SampleData.AddPerson(p);
                SampleData.AddCustomer(c);
            }

            b.CustomerIdcustomerNavigation = c;

            decimal cost = 0;

            foreach (Order ord in o)
            {
                if (ord != null)
                {
                    Extras ext = new Extras { BookingIdbookingNavigation = b, OrderIdorderNavigation = ord };
                    ex.Add(ext);
                    b.Notes += ord.Description + " ";
                    SampleData.AddExtras(ext);
                    cost += ord.Cost;
                }
            }


            b.StationsBookings = sb;
            b.Extras = ex;
            b.Cost += cost;

            SampleData.AddStationBooking(sb[0]);
            SampleData.AddBooking(b);

            Close();
        }


        private void Button_Back_OnClick(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
