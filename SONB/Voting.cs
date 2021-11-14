using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SONB
{
    class Voting
    {
        DateTime? t1 = null;
        DateTime? t2 = null;
        DateTime? t3 = null;
        DateTime? t4 = null;
        DateTime? t5 = null;
        DateTime? t6 = null;

        int w1 = 1;
        int w2 = 1;
        int w3 = 1;
        int w4 = 1;
        int w5 = 1;
        int w6 = 1;

        public bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("co chcesz zrobić:");
            Console.WriteLine("1) pobierz czas z serwerów");
            Console.WriteLine("2) Ustaw wagi");
            Console.WriteLine("3) wyswietl czasy z serwerów");
            Console.WriteLine("4) wyswietl wagi serwerów");
            Console.WriteLine("5) wyście");
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
                        Console.Clear();
                        Console.WriteLine("podaj wagę:");
                        w1 = Convert.ToInt32(Console.ReadLine());
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("podaj wagę:");
                        w2 = Convert.ToInt32(Console.ReadLine());
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("podaj wagę:");
                        w3 = Convert.ToInt32(Console.ReadLine());
                        break;
                    case "4":
                        Console.Clear();
                        Console.WriteLine("podaj wagę:");
                        w4 = Convert.ToInt32(Console.ReadLine());
                        break;
                    case "5":
                        Console.Clear();
                        Console.WriteLine("podaj wagę:");
                        w5 = Convert.ToInt32(Console.ReadLine());
                        break;
                    case "6":
                        Console.Clear();
                        Console.WriteLine("podaj wagę:");
                        w6 = Convert.ToInt32(Console.ReadLine());
                        break;
                    case "7":
                        showMenu =  false;
                        break;
                    default:
                        break;
                }
            }  
        }

        private void GetTime()
        {
            Console.Clear();
            Thread thread1 = new Thread(() => { t1 = GetDateTime(); });
            thread1.Start();
            thread1.Join();

            Thread thread2 = new Thread(() => { t2 = GetDateTime(); });
            thread2.Start();
            thread2.Join();

            Thread thread3 = new Thread(() => { t3 = GetDateTime(); });
            thread3.Start();
            thread3.Join();


            Thread thread4 = new Thread(() => { t4 = GetDateTime(); });
            thread4.Start();
            thread4.Join();


            Thread thread5 = new Thread(() => { t5 = GetDateTime(); });
            thread5.Start();
            thread5.Join();


            Thread thread6 = new Thread(() => { t6 = GetDateTime(); });
            thread6.Start();
            thread6.Join();

            DisplayResult("Pobrano");
        }

        private void WriteTimes()
        {
            Console.Clear();
            Console.WriteLine("Serwer 1 czas: " + ((DateTime)t1).TimeOfDay);
            Console.WriteLine("Serwer 2 czas: " + ((DateTime)t2).TimeOfDay);
            Console.WriteLine("Serwer 3 czas: " + ((DateTime)t3).TimeOfDay);
            Console.WriteLine("Serwer 4 czas: " + ((DateTime)t4).TimeOfDay);
            Console.WriteLine("Serwer 5 czas: " + ((DateTime)t5).TimeOfDay);
            Console.WriteLine("Serwer 6 czas: " + ((DateTime)t6).TimeOfDay);
            Console.WriteLine("Naciśnij enter aby powrócić do menu");
            Console.ReadLine();
        }
        private void WriteWeights()
        {
            Console.Clear();
            Console.WriteLine("Serwer 1 waga: " + w1);
            Console.WriteLine("Serwer 2 waga: " + w2);
            Console.WriteLine("Serwer 3 waga: " + w3);
            Console.WriteLine("Serwer 4 waga: " + w4);
            Console.WriteLine("Serwer 5 waga: " + w5);
            Console.WriteLine("Serwer 6 waga: " + w6);
            Console.WriteLine("Naciśnij enter aby powrócić do menu");
            Console.ReadLine();
        }
        private void DisplayResult(string message)
        {
            Console.WriteLine($"{message}");
            Console.WriteLine("Naciśnij enter aby powrócić do menu");
            Console.ReadLine();
        }


        public DateTime GetDateTime()
        {
            return DateTime.Now;
        }
    }
}
