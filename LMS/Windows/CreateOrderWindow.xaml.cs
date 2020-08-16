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
            CustomersData();
        }

        private void FillOrderBase()
        {
            DgvOrders.ItemsSource = _context.OrderItems.Include("Order").Include("Order.Customer").ToList();
            
           
        }

        //Resetting Data
        private void ResetingData()
        {
            DtpDeadline.SelectedDate = null;
            DtpOrderCreatedDate.SelectedDate = null;
            DgvSBooks.SelectedItem = null;
            DgvSCustomers.SelectedItem = null;
            TxtBSearch.Clear();
            TxtCSearch.Clear();

            
            FillOrderBase();
            
        }

        //Filling Data
        private void BooksData()
        {
            DgvSBooks.ItemsSource = _context.Books.Where(b=>b.Quantity>0).ToList();
        }

        //Filling Customer
        private void CustomersData()
        {
            DgvSCustomers.ItemsSource = _context.Customers.ToList();
        }


        //Search button for Customers
        private void BtnCSearch_Click(object sender, RoutedEventArgs e)
        {

            DgvSCustomers.ItemsSource = _context.Customers.Where(x => x.Name.Contains(TxtCSearch.Text)).ToList();
        }

        //Controlling inputs
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


        //Search button for Books
        private void BtnBSearch_Click(object sender, RoutedEventArgs e)
        {
            DgvSBooks.ItemsSource = _context.Books.Where(x => x.Name.Contains(TxtBSearch.Text) && x.Quantity>0).ToList();
        }

        //Creation of order
        private void BtnCartAdd_Click(object sender, RoutedEventArgs e)
        {
            if (inputValidation())
            {
                return;
            }


            //Calculatind day and price relation

            double priceForDays = (((DateTime)DtpDeadline.SelectedDate - (DateTime)DtpOrderCreatedDate.SelectedDate).Days) / 7.0;

            var week = Math.Ceiling(priceForDays);

            MessageBox.Show(week.ToString());

            decimal priceForNow = 0;

            foreach (var book in books)
            {
                priceForNow = Convert.ToDecimal(+book.PricePerWeek);
            }

            if (week == 0)
            {
                week++;
            }
            
            decimal PriceOfOrder = Math.Abs(Convert.ToDecimal(week) * priceForNow);



            Order order = new Order()
            {
                
                OrderPrice = PriceOfOrder,
                ReturnDate = (DateTime)DtpDeadline.SelectedDate,
                CreatedAt = (DateTime)DtpOrderCreatedDate.SelectedDate,
                CustomerId=_selectedCustomer.Id,
                Returned = false
                
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
           
              _selectedBook.Quantity--;
            

            var choosenBook = books.FirstOrDefault(b => b.Id == _selectedBook.Id);

            if (choosenBook != null)
            {
                MessageBox.Show("You can choose identical book only once");
                return;
            }

            books.Add(_selectedBook);
        }
    }
}
