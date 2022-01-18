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
    /// Interaction logic for SubWindow2.xaml
    /// </summary>
    public partial class SubWindow2 : Window
    {
        Voting voting;
        public SubWindow2()
        {
            InitializeComponent();
        }
        public SubWindow2(Voting voting2)
        {
            InitializeComponent();
            voting = voting2;
            StringBuilder groups = new StringBuilder("Grupy:");
            foreach (KeyValuePair<int, ServerList<Server>> item in voting.groups)
            {
                groups.Append($"\nGrupa {item.Key}: ");
                foreach (Server server in item.Value)
                {
                    groups.Append($"\n {server.Time.Value.TimeOfDay} ");
                }
            }

            Groups.Content = groups.ToString();
        }

    }
}
