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
using System.Windows.Shapes;
using System.Windows.Threading;

namespace WpfApp1
{
    public partial class Window3 : Window
    {
        public static List<Stop> ArriveList = null;
        public static List<Stop> DepartureList = null;
        public string date { get; set; }
        public string miejsce { get; set; }
        public Window3()
        {
            InitializeComponent();
            Title = "Tablica przyjazdów/odjazdów";
            date = DateTime.Today.ToString("dd.MM.yyyy");
            //date = MainWindow.date;
            miejsce = MainWindow.miejsce;
            label.Content = miejsce;
            InitTable();
            timer();
        }
        void timer()
        {
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer_Tick;
            timer.Start();
        }
        public void InitTable()
        {
            DepartureList = new List<Stop>();
            ArriveList = new List<Stop>();
            SQLCommand.Search(date, miejsce, ArriveList, DepartureList);
            lstTrain.ItemsSource = ArriveList;
            lstTrain_Copy.ItemsSource = DepartureList;
        }
        void timer_Tick(object sender, EventArgs e)
        {
            InitTable();
            lblTime.Content = DateTime.Now.ToLongTimeString();
        }
        private void button_Click(object sender, RoutedEventArgs e)
        {
            label.Content = textBox.Text.Trim();
            miejsce = textBox.Text.Trim();
            InitTable();
        }
    }
}
