using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace SONB
{
    public class Voting
    {
        public Server s1 = new Server()
        {
            Name = "S1",
            Time = null,
            Weight = 1
        };

        public Server s2 = new Server()
        {
            Name = "S2",
            Time = null,
            Weight = 1
        };

        public Server s3 = new Server()
        {
            Name = "S3",
            Time = null,
            Weight = 1
        };

        public Server s4 = new Server()
        {
            Name = "S4",
            Time = null,
            Weight = 1
        };

        public Server s5 = new Server()
        {
            Name = "S5",
            Time = null,
            Weight = 1
        };

        public Server s6 = new Server()
        {
            Name = "S6",
            Time = null,
            Weight = 1
        };

        public Dictionary<int, ServerList<Server>> groups = new Dictionary<int, ServerList<Server>>();

        public string epsilon = "2";

        public bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("co chcesz zrobić:");
            Console.WriteLine("1) pobierz czas z serwerów");
            Console.WriteLine("2) Ustaw wagi");
            Console.WriteLine("3) wyswietl czasy z serwerów");
            Console.WriteLine("4) wyswietl wagi serwerów");
            Console.WriteLine("5) ustaw epsilon");
            Console.WriteLine("6) podziel na grupy");
            Console.WriteLine("7) wyświetl grupy");
            Console.WriteLine("8) głosowanie");
            Console.WriteLine("9) błedy");
            Console.WriteLine("10) wyście");

            Console.Write("\r\nwybierz opcję: ");

            switch (Console.ReadLine())
            {
                case "1":
                    GetTime();
                    return true;

                case "2":
                    SetWeights();
                    return true;

                case "3":
                    WriteTimes();
                    return true;

                case "4":
                    WriteWeights();
                    return true;

                case "5":
                    epsilon = SetEpsilon();
                    return true;

                case "6":
                    GroupTimes();
                    Console.Clear();
                    Console.WriteLine("pogrupowano");
                    Console.ReadLine();
                    return true;

                case "7":
                    WriteGroupsTimes();
                    return true;

                case "8":
                    DateTime? time = VotingMethod();
                    Console.Clear();
                    Console.WriteLine($"aktualny czas: {time.Value.TimeOfDay}");
                    Console.ReadLine();
                    return true;

                case "9":
                    InsertErrors();
                    return true;

                case "10":
                    return false;

                default:
                    return true;
            }
        }

        private void SetWeights()
        {
            bool showMenu = true;
            while (showMenu)
            {
                Console.Clear();
                Console.WriteLine("wybierz serwer któremu chcesz nadać wagę:");
                Console.WriteLine("1) Serwer 1");
                Console.WriteLine("2) Serwer 2");
                Console.WriteLine("3) Serwer 3");
                Console.WriteLine("4) Serwer 4");
                Console.WriteLine("5) Serwer 5");
                Console.WriteLine("6) Serwer 6");
                Console.WriteLine("7) wróć");
                Console.Write("\r\nwybierz opcję: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        s1.Weight = SetWeight();
                        break;

                    case "2":
                        s2.Weight = SetWeight();
                        break;

                    case "3":
                        s3.Weight = SetWeight();
                        break;

                    case "4":
                        s4.Weight = SetWeight();
                        break;

                    case "5":
                        s5.Weight = SetWeight();
                        break;

                    case "6":
                        s6.Weight = SetWeight();
                        break;

                    case "7":
                        showMenu = false;
                        break;

                    default:
                        break;
                }
            }
        }

        private void InsertErrors()
        {
            bool showMenu = true;
            while (showMenu)
            {
                Console.Clear();
                Console.WriteLine("wybierz błąd:");
                Console.WriteLine("1) serwer nie odpowiada");
                Console.WriteLine("2) Serwer zwraca pustą godzinę");
                Console.WriteLine("3) Serwer ma niepoprawną wagę");
                Console.WriteLine("4) wróć");
                Console.Write("\r\nwybierz opcję: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        s1 = null;
                        break;

                    case "2":
                        s2.Time = null;
                        break;

                    case "3":
                        s3.Weight = SetBadWeight();
                        break;

                    case "4":
                        showMenu = false;
                        break;

                    default:
                        break;
                }
            }
        }

        private void GetTime()
        {
            Console.Clear();
            Thread thread1 = new Thread(() => { s1.Time = GetDateTime(); });
            thread1.Start();
            thread1.Join();

            Thread thread2 = new Thread(() => { s2.Time = GetDateTime(); });
            thread2.Start();
            thread2.Join();

            Thread thread3 = new Thread(() => { s3.Time = GetDateTime(); });
            thread3.Start();
            thread3.Join();

            Thread thread4 = new Thread(() => { s4.Time = GetDateTime(); });
            thread4.Start();
            thread4.Join();

            Thread thread5 = new Thread(() => { s5.Time = GetDateTime(); });
            thread5.Start();
            thread5.Join();

            Thread thread6 = new Thread(() => { s6.Time = GetDateTime(); });
            thread6.Start();
            thread6.Join();

            DisplayResult("Pobrano");
        }

        private void WriteTimes()
        {
            Console.Clear();
            Console.WriteLine("Serwer 1 czas: " + ((DateTime)s1.Time).TimeOfDay);
            Console.WriteLine("Serwer 2 czas: " + ((DateTime)s2.Time).TimeOfDay);
            Console.WriteLine("Serwer 3 czas: " + ((DateTime)s3.Time).TimeOfDay);
            Console.WriteLine("Serwer 4 czas: " + ((DateTime)s4.Time).TimeOfDay);
            Console.WriteLine("Serwer 5 czas: " + ((DateTime)s5.Time).TimeOfDay);
            Console.WriteLine("Serwer 6 czas: " + ((DateTime)s6.Time).TimeOfDay);
            Console.WriteLine("Naciśnij enter aby powrócić do menu");
            Console.ReadLine();
        }

        private void WriteWeights()
        {
            Console.Clear();
            Console.WriteLine("Serwer 1 waga: " + s1.Weight);
            Console.WriteLine("Serwer 2 waga: " + s2.Weight);
            Console.WriteLine("Serwer 3 waga: " + s3.Weight);
            Console.WriteLine("Serwer 4 waga: " + s4.Weight);
            Console.WriteLine("Serwer 5 waga: " + s5.Weight);
            Console.WriteLine("Serwer 6 waga: " + s6.Weight);
            Console.WriteLine("Naciśnij enter aby powrócić do menu");
            Console.ReadLine();
        }

        private void DisplayResult(string message)
        {
            Console.WriteLine($"{message}");
            Console.WriteLine("Naciśnij enter aby powrócić do menu");
            Console.ReadLine();
        }

        public int SetWeight()
        {
            Console.Clear();
            Console.WriteLine("podaj wagę (od 1 do 10):");
            int number;

            while (!int.TryParse(Console.ReadLine(), out number) || !BetweenRanges(1, 10, number))
            {
                Console.Clear();
                Console.WriteLine("Bład, wpisz ponownie liczbe");
            }
            return number;
        }

        public int SetBadWeight()
        {
            Console.Clear();
            Console.WriteLine("podaj błędną wagę");
            int number;

            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.Clear();
                Console.WriteLine("Bład, wpisz ponownie liczbe");
            }
            return number;
        }

        public bool BetweenRanges(int a, int b, int number)
        {
            return (a <= number && number <= b);
        }

        public DateTime GetDateTime()
        {
            TimeSpan interval;
            TimeSpan.TryParseExact("0.01", "s\\.ff", null, out interval);
            Thread.Sleep(interval);
            Console.WriteLine("pobieram czas");
            return DateTime.Now;
        }

        public string SetEpsilon()
        {
            Console.Clear();
            Console.WriteLine("podaj epsilon");
            int number;
            string numberString = Console.ReadLine();
            while (!int.TryParse(numberString, out number))
            {
                Console.Clear();
                Console.WriteLine("Bład, wpisz ponownie liczbe");
                numberString = Console.ReadLine();
            }
            return numberString;
        }

        public void GroupTimes()
        {
            ServerList<Server> servers = new ServerList<Server>();
            if (s1 != null)
                servers.Add(s1);
            if (s2 != null)
                servers.Add(s2);
            if (s3 != null)
                servers.Add(s3);
            if (s4 != null)
                servers.Add(s4);
            if (s5 != null)
                servers.Add(s5);
            if (s6 != null)
                servers.Add(s6);
            string[] formats = { "s\\.f", "s\\.ff", "s\\.fff", "s\\.ffff",
                    "s\\.fffff", "s\\.ffffff", "s\\.fffffff", "s\\.ffffffff"};
            TimeSpan interval;
            TimeSpan.TryParseExact("0." + epsilon, formats, null, out interval);
            groups = new Dictionary<int, ServerList<Server>>();
            HashSet<ServerList<Server>> groupsLocal = new HashSet<ServerList<Server>>(new ServerListComparer());

            foreach (Server server in servers)
            {
                if (server.Time != null)
                {
                    TimeSpan time = server.Time.Value.TimeOfDay + interval;
                    TimeSpan time2 = server.Time.Value.TimeOfDay - interval;
                    List<Server> group = servers.Where(x => x.Time != null && x.Time.Value.TimeOfDay >= time2 && x.Time.Value.TimeOfDay <= time).ToList();
                    ServerList<Server> group2 = new ServerList<Server>(group);
                    groupsLocal.Add(group2);
                }
            }
            int iterator = 1;
            foreach (ServerList<Server> item in groupsLocal)
            {
                groups.Add(iterator, item);
                iterator++;
            }
        }

        public void WriteGroupsTimes()
        {
            Console.Clear();
            foreach (KeyValuePair<int, ServerList<Server>> item in groups)
            {
                Console.WriteLine($"Grupa {item.Key}: ");
                foreach (Server server in item.Value)
                {
                    Console.WriteLine(server.Time.Value.TimeOfDay);
                }
            }

            Console.WriteLine("Naciśnij enter aby powrócić do menu");
            Console.ReadLine();
        }

        public DateTime? VotingMethod()
        {
            DateTime? time = null;
            Dictionary<int, int> bestGroup = new Dictionary<int, int>();
            int maxSupport = 0;
            List<TimeSpan> times = new List<TimeSpan>();
            foreach (KeyValuePair<int, ServerList<Server>> item in groups)
            {
                int localMaxSupport = item.Value.Where(c => BetweenRanges(1, 10, c.Weight)).Sum(x => x.Weight);
                if (localMaxSupport > maxSupport)
                {
                    maxSupport = localMaxSupport;
                    bestGroup = new Dictionary<int, int>();
                    bestGroup.Add(item.Key, maxSupport);
                }
                else if (localMaxSupport == maxSupport)
                {
                    bestGroup.Add(item.Key, maxSupport);
                }
            }
            if (bestGroup.Count == 1)
            {
                ServerList<Server> serverTimes = groups.GetValueOrDefault(bestGroup.FirstOrDefault().Key);
                foreach (Server server in serverTimes)
                {
                    for (int i = 0; i < server.Weight; i++)
                    {
                        times.Add(server.Time.Value.TimeOfDay);
                    }
                }

                double doubleAverageTicks = times.Average(timeSpan => timeSpan.Ticks);
                long longAverageTicks = Convert.ToInt64(doubleAverageTicks);

                time = new DateTime(longAverageTicks);

            }
            else if (bestGroup.Count > 1)
            {
                double maxAvgSupport = 0;
                Dictionary<int, ServerList<Server>> groupsLocal = new Dictionary<int, ServerList<Server>>();
                List<int> maxAvgSupportList = new List<int>();
                foreach (KeyValuePair<int, int> item in bestGroup)
                {
                    groupsLocal.Add(item.Key, groups.GetValueOrDefault(item.Key));
                }

                foreach (KeyValuePair<int, ServerList<Server>> item in groupsLocal)
                {
                    double localAvgMaxSupport = item.Value.Average(x => x.Weight);
                    if (localAvgMaxSupport > maxAvgSupport)
                    {
                        maxAvgSupport = localAvgMaxSupport;
                        maxAvgSupportList.Add(item.Key);
                    }
                    else if (localAvgMaxSupport == maxAvgSupport)
                    {
                        maxAvgSupportList.Add(item.Key);
                    }
                }
                ServerList<Server> serverTimes = groups.GetValueOrDefault(maxAvgSupportList.FirstOrDefault());
                foreach (Server server in serverTimes)
                {
                    for (int i = 0; i < server.Weight; i++)
                    {
                        times.Add(server.Time.Value.TimeOfDay);
                    }
                }

                double doubleAverageTicks = times.Average(timeSpan => timeSpan.Ticks);
                long longAverageTicks = Convert.ToInt64(doubleAverageTicks);

                time = new DateTime(longAverageTicks);

            }
            return time;
        }
    }
}