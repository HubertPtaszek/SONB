using SONB;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for SubWindow.xaml
    /// </summary>
    public partial class SubWindow : Window
    {
        Voting voting;
        MainWindow mainWindow;
        public SubWindow()
        {
            InitializeComponent();
        }
        public SubWindow(Voting voting2, MainWindow window)
        {
            InitializeComponent();
            voting = voting2;
            mainWindow = window;
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            voting.s2.Time = null;
            mainWindow.s2Time.Content = "";
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {

            voting.s3.Weight = 999;
            mainWindow.s3Weight.Value = 999;
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.s1Weight.Value = 0;
            mainWindow.s1Time.Content = "";
            voting.s1 = null;
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
