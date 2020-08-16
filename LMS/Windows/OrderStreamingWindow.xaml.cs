using LMS.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
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
    /// Interaction logic for OrderStreamingWindow.xaml
    /// </summary>
    public partial class OrderStreamingWindow : Window
    {
        private readonly LmsContext _context;
        public OrderStreamingWindow()
        {
            InitializeComponent();
            _context = new LmsContext();
        }

        private void FillTomorrow()
        {
            DgvTomorrow.ItemsSource = _context.Orders.Where(x => x.Returned == true && x.ReturnDate == DateTime.Today.AddDays(1)).Include(x => x.Customer).ToList();
        }

        private void FillToday()
        {
            DgvToday.ItemsSource = _context.Orders.Where(x => x.Returned == true && x.ReturnDate == DateTime.Today).Include(x => x.Customer).ToList();
        }

        private void ExpiredDeadline()
        {
            DgvYesterday.ItemsSource = _context.Orders.Where(x => x.Returned == true && x.ReturnDate < DateTime.Today).Include(x => x.Customer).ToList();
        }
    }
}
