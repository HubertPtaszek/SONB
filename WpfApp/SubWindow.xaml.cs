﻿using SONB;
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
        public SubWindow()
        {
            InitializeComponent();
        }
        public SubWindow(Voting voting2)
        {
            InitializeComponent();
            voting = voting2;
        }
    }
}
