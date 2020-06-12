using System;
using System.Collections.Generic;
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
        }
    
        private void button_next_onClick(object sender, RoutedEventArgs e)
        {
            Console.Out.WriteLine(add_first_name.Text + " " + add_last_name.Text + ", " + add_phone_number.Text + ", " + add_email.Text);
            Console.Out.WriteLine(add_date.SelectedDate + ", " + add_hour.SelectedDate + ", " + add_people.Text + ", " + add_station.Text);
            Console.Out.WriteLine(add_checkbox_food.IsChecked + ", " + add_checkbox_music.IsChecked + ", " + add_checkbox_cosplay.IsChecked + ", " + add_checkbox_alcohol.IsChecked);
            Console.Out.WriteLine(add_pc.Text + ", " + add_xbox.Text + ", " + add_ps.Text + ", " + add_board_games.Text);
        }

        private void Button_Back_OnClick(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
