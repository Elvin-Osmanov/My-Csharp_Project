using LMS.Data;
using LMS.Models;
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
    /// Interaction logic for BookReturnWindow.xaml
    /// </summary>
    public partial class BookReturnWindow : Window
    {
        private readonly LmsContext _context;
        private Order _selectedOrder;

        public BookReturnWindow()
        {
            InitializeComponent();
            _context = new LmsContext();

            OrderDataFill();
            Fine();
        }

        private void Fine()
        {
            var books = _context.Orders.Where(x => x.Returned == false);

            foreach(var book in books)
            {
                var FineDays= (book.ReturnDate - DateTime.Today).Days;
                if (FineDays < 0)
                {
                    book.Fine =book.Fine-FineDays;
                }
            }
        }
        private void OrderDataFill()
        {
            DgvReturnBooks.ItemsSource = _context.Orders.Where(r => r.Returned == false).Include(c => c.Customer).ToList();
            
        }

        private void DgvReturnBooks_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DgvReturnBooks.SelectedItem == null) return;

            _selectedOrder = (Order)DgvReturnBooks.SelectedItem;


        }

        private void BtnSearch_Click(object sender, RoutedEventArgs e)
        {
            DgvReturnBooks.ItemsSource = _context.Orders.Where(c => c.Customer.Name.Contains(TxtSCustomer.Text) && c.Returned == false).ToList();
        }

        private void BtnReturn_Click(object sender, RoutedEventArgs e)
        {
            if (_selectedOrder == null) return;
            var bookQuantity = _context.OrderItems.Where(x => x.OrderId == _selectedOrder.Id).Include(m => m.Book);

            foreach (var q in bookQuantity)
            {
                q.Book.Quantity+= 1;
            }

            _selectedOrder.Returned = true;
            _selectedOrder.ReturnedDate = DateTime.Today;

            _context.SaveChanges();

            OrderDataFill();

            if (_selectedOrder.Fine > 0)
            {
                LblMessage.Content="Book Returned" + $" Fine is :{ _selectedOrder.Fine} dollars";
            }
            else
            {
                LblMessage.Content = "Book Returned";
            }
        }
    }
}
