﻿using System;
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
using Dip_SWD_SubTask9_Async.Logic;

namespace Dip_SWD_SubTask9_Async
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

            private void PrimeButton_Click(object sender, RoutedEventArgs e)
            {
                  string n = nthNumber.Text;
                  label.Content = PrimeNum.CalculateNthPrimeNumber(int.Parse(n));
            }
      }
}
