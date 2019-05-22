using System;
using System.Collections.Generic;
using System.IO;
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
using Finisar.SQLite;

namespace WpfApp1
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static DateTime Actuall_Time = DateTime.UtcNow.ToLocalTime();
        public static List<Train> TrainList = null;
        public static List<Stop> StopList = null;
        public static List<Ride> RideList = null;
        public static Window3 wnd3;
        public static Window2 wnd2;
        public static Window1 wnd;
        public static string miejsce { get; set; }
        public static string date { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            InitTime();
            SQLCommand.SQLOpen();
        }
        public void InitTime()
        {
            textBox_Copy1.Text = Actuall_Time.ToString("HH:mm");
            calendar1.SelectedDate = DateTime.Today;
            //calendar1.SelectedDate = Convert.ToDateTime("08.04.2019");
        }
        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (textBox.Text == "" || textBox_Copy.Text == "" || textBox_Copy1.Text == "")
            {
                MessageBox.Show("Proszę uzupełnić dane!");
            }
            else
            {
                date = Convert.ToDateTime(calendar1.SelectedDate).ToString("dd.MM.yyyy");
                TrainList = new List<Train>();
                StopList = new List<Stop>();
                RideList = new List<Ride>();
                DateTime data;
                data = Convert.ToDateTime(calendar1.SelectedDate);
                string starting_place = textBox.Text.Trim();
                string destination = textBox_Copy.Text.Trim();
                try
                {
                    DateTime time_departure = Convert.ToDateTime(textBox_Copy1.Text.Trim());
                    if (SQLCommand.Search(StopList, RideList, TrainList, data.ToString("dd.MM.yyyy"), starting_place, destination, time_departure))
                    {
                        MessageBox.Show("Brak Linii!");
                    }
                    else
                    {
                        wnd = new Window1();
                        wnd.Show();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Podano zły format godziny!!");
                    SQLCommand.sqlite_conn.Close();
                }
            }
        }
        private void button2_Click(object sender, RoutedEventArgs e)
        {
            wnd2 = new Window2();
            wnd2.Show();
        }
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (textBox1.Text != "")
            {
                date = Convert.ToDateTime(calendar1.SelectedDate).ToString("dd.MM.yyyy");
                StopList = new List<Stop>();
                miejsce = textBox1.Text.Trim();
                wnd3 = new Window3();
                wnd3.Show();
            }
            else
            {
                MessageBox.Show("Nie podano stacji!");
            }
        }
    }
}
