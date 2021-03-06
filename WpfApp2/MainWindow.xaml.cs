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

namespace WpfApp2
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public ViewModel model;
        private NavigationService  navigationService;
        public MainWindow()
        {
            InitializeComponent();
            model = new ViewModel();
            this.DataContext = model;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Dispatcher.Invoke(() =>
            {
                MessageBox.Show(model.Data.ToString());
            });
        }


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var page = new Page1();
            this.Content = page;
        }
    }
}
