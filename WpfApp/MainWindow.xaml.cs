using SONB;
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
using System.Text.RegularExpressions;
using Xceed.Wpf.Toolkit;

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Voting voting;
        public MainWindow()
        {
            InitializeComponent();
            voting = new Voting();
            s1Weight.Value = voting.s1.Weight;
            s2Weight.Value = voting.s2.Weight;
            s3Weight.Value = voting.s3.Weight;
            s4Weight.Value = voting.s4.Weight;
            s5Weight.Value = voting.s5.Weight;
            s6Weight.Value = voting.s6.Weight;
            epsilon.Text = voting.epsilon;
        }


        private void Button3Clicked(object sender, RoutedEventArgs e)
        {
            SubWindow2 subWindow2 = new SubWindow2(voting);
            subWindow2.Show();
            result.Content = "";

        }
        private void Button5Clicked(object sender, RoutedEventArgs e)
        {
            SubWindow subWindow = new SubWindow(voting, this);
            subWindow.Show();
            result.Content = "";

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            voting.GetTime();
            s1Time.Content = ((DateTime)voting.s1.Time).TimeOfDay;
            s2Time.Content = ((DateTime)voting.s2.Time).TimeOfDay;
            s3Time.Content = ((DateTime)voting.s3.Time).TimeOfDay;
            s4Time.Content = ((DateTime)voting.s4.Time).TimeOfDay;
            s5Time.Content = ((DateTime)voting.s5.Time).TimeOfDay;
            s6Time.Content = ((DateTime)voting.s6.Time).TimeOfDay;
            result.Content = "";

        }

        private void PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void epsilon_TextChanged(object sender, TextChangedEventArgs e)
        {
            voting.epsilon = ((TextBox)sender).Text;
            result.Content = "";

        }


        private void s1Weight_ValueChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            voting.s1.Weight = (int)((IntegerUpDown)sender).Value;
            result.Content = "";

        }

        private void s2Weight_ValueChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            voting.s2.Weight = (int)((IntegerUpDown)sender).Value;
            result.Content = "";

        }

        private void s3Weight_ValueChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            voting.s3.Weight = (int)((IntegerUpDown)sender).Value;
            result.Content = "";

        }

        private void s4Weight_ValueChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            voting.s4.Weight = (int)((IntegerUpDown)sender).Value;
            result.Content = "";

        }

        private void s5Weight_ValueChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            voting.s5.Weight = (int)((IntegerUpDown)sender).Value;
            result.Content = "";

        }

        private void s6Weight_ValueChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            voting.s6.Weight = (int)((IntegerUpDown)sender).Value;
            result.Content = "";
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            voting.GroupTimes();
            result.Content = "Pogrupowano";
            result.Foreground = Brushes.Green;
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            DateTime? time = voting.VotingMethod();
            result.Content = $"Wynik: {time.Value.TimeOfDay}";
            result.Foreground = Brushes.Green;
        }
    }

}
