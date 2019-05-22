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
using Finisar.SQLite;

namespace WpfApp1
{
    /// <summary>
    /// Logika interakcji dla klasy Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
            InitTime();
        }
        public void InitTime()
        {
            calendar.SelectedDate = DateTime.Today;
        }
        private void button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DateTime time = Convert.ToDateTime(textBox2.Text.Trim());
                DateTime time2 = Convert.ToDateTime(textBox3.Text.Trim());
                Stop stop = new Stop(textBox.Text.Trim(), textBox3.Text.Trim(), textBox2.Text.Trim(), Convert.ToDateTime(calendar.SelectedDate), int.Parse(textBox4.Text.Trim()), int.Parse(textBox5.Text.Trim()), int.Parse(textBox1.Text.Trim()));
                try
                {
                    SQLCommand.Add(stop);
                    MessageBox.Show("Dodano przystanek!!");
                }
                catch(Wyjatek)
                {
                    Wyjatek.Info();
                    SQLCommand.sqlite_conn.Close();
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Podano zle dane!!!");
                SQLCommand.sqlite_conn.Close();
            }
        }
        private void calendar_Loaded(object sender, RoutedEventArgs e)
        {
            calendar.DisplayDateStart = DateTime.Today;

            CalendarDateRange calendarDateRange = new CalendarDateRange(DateTime.MinValue);
            calendar.BlackoutDates.Add(calendarDateRange);
        }
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Train train = new Train(textBox7.Text.Trim(), textBox8.Text.Trim(), int.Parse(textBox6.Text.Trim()));
                try
                {
                    SQLCommand.Add(train);
                    MessageBox.Show("Pociąg dodany!!");
                }
                catch (Exception)
                {
                    MessageBox.Show("Dany pociąg już istnieje w bazie danych!!!");
                    SQLCommand.sqlite_conn.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Wprowadzone dane są błędne!!!");
                SQLCommand.sqlite_conn.Close();
            }
        }
    }
}
