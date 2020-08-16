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

            FillTomorrow();
            FillToday();
            ExpiredDeadline();
        }

        //Shows Returning books for tomorrow
        private void FillTomorrow()
        {
            DgvTomorrow.ItemsSource = _context.OrderItems.Where(x => x.Order.ReturnDate == DateTime.Today.AddDays(1)).Include(x => x.Order.Customer).Include(b=>b.Book).ToList();
        }

        //Shows Returning books for today
        private void FillToday()
        {
            DgvToday.ItemsSource = _context.OrderItems.Where(x => x.Order.ReturnDate == DateTime.Today).Include(x => x.Order.Customer).Include(b => b.Book).ToList();
        }

        //Shows expired books 
        private void ExpiredDeadline()
        {
            DgvYesterday.ItemsSource = _context.OrderItems.Where(x => x.Order.ReturnDate < DateTime.Today).Include(x => x.Order.Customer).Include(b => b.Book).ToList();
        }
    }
}
