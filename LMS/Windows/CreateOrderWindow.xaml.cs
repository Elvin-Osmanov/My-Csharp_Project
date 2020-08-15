using LMS.Data;
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

using LMS.Models;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using Microsoft.EntityFrameworkCore;
using System.Threading;

namespace LMS.Windows
{
    /// <summary>
    /// Interaction logic for CreateOrderWindow.xaml
    /// </summary>
    public partial class CreateOrderWindow : Window
    {
        private readonly LmsContext _context;
        private List<Book> books;
        private Book _selectedBook;
        private Customer _selectedCustomer;

        public CreateOrderWindow()
        {
            InitializeComponent();
            _context = new LmsContext();
            books = new List<Book>();

            FillOrderBase();
            BooksData();
        }

        private void FillOrderBase()
        {
            DgvOrders.ItemsSource = _context.Orders.ToList();
        }

        private void ResetingData()
        {
            DtpDeadline.SelectedDate = null;
            DtpOrderCreatedDate.SelectedDate = null;
            DgvSBooks.SelectedItem = null;
            DgvSCustomers.SelectedItem = null;
            TxtBSearch.Clear();
            TxtCSearch.Clear();


            DgvOrders.ItemsSource = _context.Orders.ToList();
        }

        private void BooksData()
        {
            DgvSBooks.ItemsSource = _context.Books.ToList();
        }
        private void BtnCSearch_Click(object sender, RoutedEventArgs e)
        {

            DgvSCustomers.ItemsSource = _context.Customers.Where(x => x.Name.Contains(TxtCSearch.Text)).ToList();
        }

        private bool inputValidation()
        {
            bool hasError = false;
            if (DgvSBooks.SelectedItem == null)
            {
                LblSelectedB.Visibility = Visibility.Visible;
                hasError = true;
            }
            else
            {
                LblSelectedB.Visibility = Visibility.Hidden;
            }
            if (DgvSCustomers.SelectedItem == null)
            {
                LblSelectedC.Visibility = Visibility.Visible;
                hasError = true;
            }
            else
            {
                LblSelectedC.Visibility = Visibility.Hidden;
            }
            if (DtpOrderCreatedDate.SelectedDate == null)
            {
                DtpOrderCreatedDate.SelectedDate = DateTime.Now;
            }

            if (DtpDeadline.SelectedDate == null)
            {
                LblReturnDate.Visibility = Visibility.Visible;
                hasError = true;
            }
            else
            {
                LblReturnDate.Visibility = Visibility.Hidden;
            }
            return hasError;
        }

        private void BtnBSearch_Click(object sender, RoutedEventArgs e)
        {
            DgvSBooks.ItemsSource = _context.Books.Where(x => x.Name.Contains(TxtBSearch.Text)).ToList();
        }

        private void BtnCartAdd_Click(object sender, RoutedEventArgs e)
        {
            if (inputValidation())
            {
                return;
            }


            //Calculatind day and price realtion

            double priceForDays = (((DateTime)DtpDeadline.SelectedDate - (DateTime)DtpOrderCreatedDate.SelectedDate).Days) / 7.0;

            double week = Math.Ceiling(priceForDays);

            double priceForNow = 0;

            foreach (var book in books)
            {
                priceForNow = priceForNow + book.PricePerWeek;
            }

            decimal PriceOfOrder = Convert.ToDecimal(week) * Convert.ToDecimal(priceForNow);

            Order order = new Order()
            {
                OrderPrice = PriceOfOrder,
                ReturnDate = (DateTime)DtpDeadline.SelectedDate,
                CreatedAt = (DateTime)DtpOrderCreatedDate.SelectedDate,
                CustomerId=_selectedCustomer.Id
                
            };

            _context.Orders.Add(order);
            _context.SaveChanges();





            foreach(var book in books)
            {
                OrderItem orderItem = new OrderItem()
                {
                    OrderId = order.Id,
                    BookId = book.Id
                };

                _context.OrderItems.Add(orderItem);
                _context.SaveChanges();
            }

            books.Clear();
            ResetingData();

            MessageBox.Show("Order is Created");
        }

        private void DgvSCustomers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DgvSCustomers.SelectedItem == null) return;

            _selectedCustomer = (Customer)DgvSCustomers.SelectedItem;
        }

        private void DgvSBooks_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DgvSBooks.SelectedItem == null) return;

            _selectedBook = (Book)DgvSBooks.SelectedItem;

            if (_selectedBook.Quantity == 0)
            {
                MessageBox.Show("This book is out of stock");
                return;
            }
            else
            {
                _selectedBook.Quantity = _selectedBook.Quantity - 1;
            }

            var choosenBook = (books.FirstOrDefault(b => b.Id == _selectedBook.Id));

            if (choosenBook != null)
            {
                MessageBox.Show("You can choose identical book only once");
            }

            books.Add(_selectedBook);
        }
    }
}
