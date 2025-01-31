﻿using System;
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

namespace LMS.Windows
{
    /// <summary>
    /// Interaction logic for DashboardWindow.xaml
    /// </summary>
    public partial class DashboardWindow : Window
    {
        public DashboardWindow()
        {
            InitializeComponent();
        }

        private void BtnManagers_Click(object sender, RoutedEventArgs e)
        {
            ManagerWindow mw = new ManagerWindow();
            mw.ShowDialog();
            
        }

        private void BtnCustomers_Click(object sender, RoutedEventArgs e)
        {
            CustomerWindow customerWindow = new CustomerWindow();
            customerWindow.ShowDialog();
        }

        private void BtnBooks_Click(object sender, RoutedEventArgs e)
        {
            BookWindow bw = new BookWindow();
            bw.ShowDialog();
        }

        private void BtnCreate_Click(object sender, RoutedEventArgs e)
        {
            CreateOrderWindow cow = new CreateOrderWindow();
            cow.ShowDialog();
        }

        private void BtnReturn_Click(object sender, RoutedEventArgs e)
        {
            BookReturnWindow brw = new BookReturnWindow();
            brw.ShowDialog();
        }

        private void BtnStream_Click(object sender, RoutedEventArgs e)
        {
            OrderStreamingWindow osw = new OrderStreamingWindow();
            osw.ShowDialog();
        }

        private void BtnButtonReport_Click(object sender, RoutedEventArgs e)
        {
            SalesReportWindow srw = new SalesReportWindow();
            srw.ShowDialog();
        }
    }
}
