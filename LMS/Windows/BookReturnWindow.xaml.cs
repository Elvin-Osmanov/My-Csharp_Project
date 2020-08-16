using DocumentFormat.OpenXml.Spreadsheet;
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

            
            Fine();
            TotalPrice();
            OrderDataFill();
        }

        //Fine Calculation

        private void TotalPrice()
        {
            var books = _context.Orders.Where(x => x.Returned == false);
            
            foreach(var book in books)
            {
                if (book.Fine != null)
                {
                    var Total = book.OrderPrice + book.Fine;

                    book.TotalPrice = (decimal)Total;
                }
                else
                {
                    book.TotalPrice = book.OrderPrice;
                }
            }
        }

        private void Fine()
        {
            var books = _context.Orders.Where(x => x.Returned == false);

            foreach(var book in books)
            {
                var FineDays= (book.ReturnDate - DateTime.Today).Days;
                if (FineDays < 0)
                {
                    book.Fine = Math.Abs((decimal)(+FineDays * 0.05));
                }
            }
        }

        //Selecting Orders from data
        private void OrderDataFill()
        {
            DgvReturnBooks.ItemsSource = _context.Orders.Where(r => r.Returned == false).Include(c => c.Customer).ToList();
            
        }



        private void DgvReturnBooks_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DgvReturnBooks.SelectedItem == null) return;

            _selectedOrder = (Order)DgvReturnBooks.SelectedItem;
            

        }

        
        //Search for Customers
        private void BtnSearch_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(TxtSCustomer.Text))
            {
                MessageBox.Show("Put the name for search");
                return;
            }
            DgvReturnBooks.ItemsSource = _context.Orders.Where(c => c.Customer.Name.Contains(TxtSCustomer.Text) && c.Returned == false).ToList();
        }


        //Book returning function
        private void BtnReturn_Click(object sender, RoutedEventArgs e)
        {
            if (_selectedOrder == null) return;
            var bookQuantity = _context.OrderItems.Where(x => x.OrderId == _selectedOrder.Id).Include(m => m.Book);

            foreach (var q in bookQuantity)
            {
                q.Book.Quantity++;
            }

            _selectedOrder.Returned = true;
            _selectedOrder.ReturnedDate = DateTime.Today;

            _context.SaveChanges();

            OrderDataFill();

            var TotalPayment = _selectedOrder.OrderPrice + _selectedOrder.Fine;
            
            if (_selectedOrder.Fine > 0)
            {
                LblMessage.Content = "Book Returned, " + $"Total Payment: {String.Format("{0:0.##}", TotalPayment)}$";

            }
            else
            {
                LblMessage.Content = "Book Returned, " + $"Total Payment: {String.Format("{0:0.##}", _selectedOrder.OrderPrice)}$";
            }
        }
    }
}
