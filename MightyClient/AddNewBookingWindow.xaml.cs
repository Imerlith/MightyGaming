using MightyClient.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
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

            SampleData SampleData = new SampleData();
            SampleData.Initialize();

            List<Station> Stations = SampleData.Stations;

            add_station.ItemsSource = Stations;
        }
    
        private void Button_Next_OnClick(object sender, RoutedEventArgs e)
        {


            //DateTime.TimeOfDay
            //MessageBox.Show(add_first_name.Text + " " + add_last_name.Text + ", " + add_phone_number.Text + ", " + add_email.Text + "\n" +
            //                add_date.SelectedDate + ", " + add_hour.Value + ", " + add_people.Text + ", " + add_station.Text + "\n" +
            //                add_checkbox_food.IsChecked + ", " + add_checkbox_music.IsChecked + ", " + add_checkbox_cosplay.IsChecked + ", " + add_checkbox_alcohol.IsChecked + "\n" +
            //                add_pc.Text + ", " + add_xbox.Text + ", " + add_ps.Text + ", " + add_board_games.Text);
                   

        }

        private void Button_Back_OnClick(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
