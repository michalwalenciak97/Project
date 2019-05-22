using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Finisar.SQLite;

namespace WpfApp1
{
    public static class SQLCommand
    {
        public static SQLiteConnection sqlite_conn;
        public static SQLiteCommand sqlite_cmd;
        public static SQLiteCommand sqlite_cmd2;
        public static SQLiteDataReader sqlite_datareader;
        public static SQLiteDataReader sqlite_datareader2;
        static DateTime date;
        static string godjazd;
        static string gprzyjazd;
        static string name;
        static string type;
        static int peron;
        static int tor;
        static int train;
        static string place_start;
        static string place_end;
        static string place;
        public static void SQLOpen()
        {
            sqlite_conn = new SQLiteConnection();
            sqlite_conn.ConnectionString = "Data Source=database2.db;Version=3";
        }
        public static void Add(Stop stop)
        {
            sqlite_conn.Open();
            int count;
            int train = stop.Train;
            sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = "select nr from pociag where nr=" + stop.Train + "";
            count = Convert.ToInt32(sqlite_cmd.ExecuteScalar());
            if (count == 0)
            {
                throw new Wyjatek();
            }
            sqlite_cmd.CommandText = "SELECT count(*) as ile FROM Przystanek";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_datareader = sqlite_cmd.ExecuteReader();
            sqlite_datareader.Read();
            count = int.Parse(sqlite_datareader["ile"].ToString()) + 1;
            sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = "INSERT INTO Przystanek (id, data, godz_przyjazd, godz_odjazd , miejsce, peron, tor, pociag) VALUES (" + count + ",'" + stop.Date.ToString("dd.MM.yyyy") + "','" + stop.Time_arrival + "','" + stop.Time_departure + "','" + stop.Place_Start + "'," + stop.Platform + "," + stop.Track + "," + stop.Train + ");";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_conn.Close();
        }
        public static void Add(Train train)
        {
            sqlite_conn.Open();
            sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = "INSERT INTO pociag (nr, rodzaj, nazwa) VALUES (" + train.Numer + ",'" + train.Type + "','" + train.Name + "');";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_conn.Close();
        }
        public static void Search(string data, string starting_place, List<Stop> ArriveList, List<Stop> DepartureList)
        {
            sqlite_conn.Open();
            DateTime gprzyjazd;
            DateTime godjazd;
            DateTime time = MainWindow.Actuall_Time;
            //DateTime time = Convert.ToDateTime("00:00");
            sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT * FROM Przystanek where miejsce like '" + starting_place + "'";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read())
            {
                date = DateTime.Parse(sqlite_datareader["data"].ToString());
                if (data == date.ToString("dd.MM.yyyy"))
                {
                    try
                    {
                        gprzyjazd = DateTime.Parse(sqlite_datareader["godz_przyjazd"].ToString());
                        godjazd = DateTime.Parse(sqlite_datareader["godz_odjazd"].ToString());
                        peron = int.Parse(sqlite_datareader["peron"].ToString());
                        tor = int.Parse(sqlite_datareader["tor"].ToString());
                        train = int.Parse(sqlite_datareader["pociag"].ToString());
                        if (DateTime.Compare(gprzyjazd, time) >= 0 || DateTime.Compare(godjazd, time) >= 0)
                        {
                            sqlite_cmd2 = sqlite_conn.CreateCommand();
                            sqlite_cmd2.CommandText = "SELECT * FROM Przystanek where pociag like '" + train + "'";
                            sqlite_cmd2.ExecuteNonQuery();
                            sqlite_datareader2 = sqlite_cmd2.ExecuteReader();
                            while (sqlite_datareader2.Read())
                            {
                                date = DateTime.Parse(sqlite_datareader2["data"].ToString());
                                if (data == date.ToString("dd.MM.yyyy"))
                                {
                                    string ggprzyjazd = sqlite_datareader2["godz_przyjazd"].ToString();
                                    string ggodjazd = sqlite_datareader2["godz_odjazd"].ToString();
                                    if (ggprzyjazd == "Start")
                                    {
                                        place_start = sqlite_datareader2["miejsce"].ToString();
                                        ArriveList.Add(new Stop(place_start, place_end, gprzyjazd.ToString("HH:mm"), godjazd.ToString("HH:mm"), date, peron, tor, train));
                                    }
                                    if (ggodjazd == "Koniec")
                                    {
                                        place_end = sqlite_datareader2["miejsce"].ToString();
                                        DepartureList.Add(new Stop(place_start, place_end, gprzyjazd.ToString("HH:mm"), godjazd.ToString("HH:mm"), date, peron, tor, train));
                                    }
                                }
                            }
                        }
                    }
                    catch (Exception)
                    {
                        string ggprzyjazd = sqlite_datareader["godz_przyjazd"].ToString();
                        string ggodjazd = sqlite_datareader["godz_odjazd"].ToString();
                        peron = int.Parse(sqlite_datareader["peron"].ToString());
                        tor = int.Parse(sqlite_datareader["tor"].ToString());
                        train = int.Parse(sqlite_datareader["pociag"].ToString());
                        if (ggprzyjazd == "Start" && DateTime.Compare(DateTime.Parse(ggodjazd), time) >= 0)
                        {
                            sqlite_cmd2 = sqlite_conn.CreateCommand();
                            sqlite_cmd2.CommandText = "SELECT * FROM Przystanek where pociag like '" + train + "'";
                            sqlite_cmd2.ExecuteNonQuery();
                            sqlite_datareader2 = sqlite_cmd2.ExecuteReader();
                            while (sqlite_datareader2.Read())
                            {
                                date = DateTime.Parse(sqlite_datareader2["data"].ToString());
                                if (data == date.ToString("dd.MM.yyyy"))
                                {
                                    string gggprzyjazd = sqlite_datareader2["godz_przyjazd"].ToString();
                                    string gggodjazd = sqlite_datareader2["godz_odjazd"].ToString();
                                    if (gggodjazd == "Koniec")
                                    {
                                        place_end = sqlite_datareader2["miejsce"].ToString();
                                        DepartureList.Add(new Stop(place_start, place_end, ggprzyjazd, ggodjazd, date, peron, tor, train));
                                    }
                                }
                            }
                        }
                        if (ggodjazd == "Koniec" && DateTime.Compare(DateTime.Parse(ggprzyjazd), time) >= 0)
                        {
                            sqlite_cmd2 = sqlite_conn.CreateCommand();
                            sqlite_cmd2.CommandText = "SELECT * FROM Przystanek where pociag like '" + train + "'";
                            sqlite_cmd2.ExecuteNonQuery();
                            sqlite_datareader2 = sqlite_cmd2.ExecuteReader();
                            while (sqlite_datareader2.Read())
                            {
                                date = DateTime.Parse(sqlite_datareader2["data"].ToString());
                                if (data == date.ToString("dd.MM.yyyy"))
                                {
                                    string gggprzyjazd = sqlite_datareader2["godz_przyjazd"].ToString();
                                    string gggodjazd = sqlite_datareader2["godz_odjazd"].ToString();
                                    if (gggprzyjazd == "Start")
                                    {
                                        place_start = sqlite_datareader2["miejsce"].ToString();
                                        ArriveList.Add(new Stop(place_start, place_end, ggprzyjazd, ggodjazd, date, peron, tor, train));
                                    }
                                }
                            }
                        }
                    }
                }
            }
            sqlite_cmd.ExecuteNonQuery();
            sqlite_conn.Close();
        }
        public static bool Search(List<Stop> StopList, List<Ride> RideList, List<Train> TrainList, string data, string starting_place, string destination, DateTime time_departure)
        {
            sqlite_conn.Open();
            int count, count_train;
            bool boolean = true;
            sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT * FROM Przystanek where miejsce like '" + starting_place + "'";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read())
            {
                date = DateTime.Parse(sqlite_datareader["data"].ToString());
                if (data == date.ToString("dd.MM.yyyy"))
                {
                    gprzyjazd = sqlite_datareader["godz_przyjazd"].ToString();
                    godjazd = sqlite_datareader["godz_odjazd"].ToString();
                    peron = int.Parse(sqlite_datareader["peron"].ToString());
                    tor = int.Parse(sqlite_datareader["tor"].ToString());
                    train = int.Parse(sqlite_datareader["pociag"].ToString());
                    place = sqlite_datareader["miejsce"].ToString();
                    try
                    {
                        if (DateTime.Compare(Convert.ToDateTime(godjazd), time_departure) >= 0)
                        {
                            StopList.Add(new Stop(place, gprzyjazd, godjazd, date, peron, tor, train));
                        }
                    }
                    catch (Exception) { }
                }
            }
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT * FROM Pociag";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read())
            {
                name = sqlite_datareader["nazwa"].ToString();
                type = sqlite_datareader["rodzaj"].ToString();
                train = int.Parse(sqlite_datareader["nr"].ToString());
                TrainList.Add(new Train(name, type, train));
            }
            sqlite_cmd.ExecuteNonQuery();
            count_train = TrainList.Count - 1;
            count = StopList.Count - 1;
            sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT * FROM Przystanek where miejsce like '" + destination + "'";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read())
            {
                train = int.Parse(sqlite_datareader["pociag"].ToString());
                gprzyjazd = sqlite_datareader["godz_przyjazd"].ToString();
                for (int i = 0; i <= count; i++)
                {
                    if (StopList[i].Train == train && gprzyjazd != "Start")
                    {
                        godjazd = sqlite_datareader["godz_odjazd"].ToString();
                        peron = StopList[i].Platform;
                        tor = StopList[i].Track;
                        train = int.Parse(sqlite_datareader["pociag"].ToString());
                        for (int j = 0; j <= count_train; j++)
                        {
                            if (train == TrainList[j].Numer && DateTime.Compare(time_departure, DateTime.Parse(StopList[i].Time_departure)) <= 0 && DateTime.Compare(DateTime.Parse(StopList[i].Time_departure), DateTime.Parse(gprzyjazd)) <= 0)
                            {
                                RideList.Add(new Ride(place, sqlite_datareader["miejsce"].ToString(), StopList[i].Time_departure, gprzyjazd, TrainList[j].Name, TrainList[j].Type, peron, tor, train));
                                boolean = false;
                            }
                        }
                    }
                }
            }
            sqlite_conn.Close();
            return boolean;
        }
        public static void createNewDB()
        {
            sqlite_conn.ConnectionString = "Data Source=database2.db;Version=3;New=True;Compress=True;";
            sqlite_conn.Open();
            sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = "CREATE TABLE Pociag (nr integer primary key, rodzaj varchar(8), nazwa varchar(20));";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = "CREATE TABLE Przystanek (id integer primary key, data varchar(11), godz_przyjazd varchar(6), godz_odjazd varchar(6), miejsce varchar(20), peron integer, tor integer, pociag integer, foreign key (pociag) references Pociag(nr));";
            sqlite_cmd.ExecuteNonQuery();
        }
    }
}