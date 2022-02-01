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

namespace Lab20.Pages
{
    /// <summary>
    /// Логика взаимодействия для UsersPage.xaml
    /// </summary>
    public partial class UsersPage : Page
    {
        public UsersPage()
        {
            InitializeComponent();
        }

        private void BTReport(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new ReportPage());
        }

        private void BTOrder(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new OrderPage());
        }

        private void BTCode(object sender, RoutedEventArgs e)
        {

        }
    }
}
