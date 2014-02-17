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

namespace LocalBooru
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool defaultTextErased;
        public MainWindow()
        {
            InitializeComponent();
            defaultTextErased = false;
        }

        private void ListBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }

        private void EraseDefaultText(object sender, RoutedEventArgs e)
        {
            if (!defaultTextErased && sender == searchBox)
            {
                defaultTextErased = true;
                searchBox.Text = "";
                searchBox.Foreground = new SolidColorBrush(Color.FromRgb(0, 0, 0));
            }
        }

        private void InitiateSearch(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("Search initiated");
        }
    }
}
