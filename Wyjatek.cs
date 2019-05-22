using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp1
{
    class Wyjatek:Exception
    {
        public static void Info()
        {
            MessageBox.Show("Dany pociąg nie istnieje w bazie danych!!");
        }
    }
}
