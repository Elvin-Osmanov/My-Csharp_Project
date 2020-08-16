using LMS.Data;
using LMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Interaction logic for CustomerWindow.xaml
    /// </summary>
    public partial class CustomerWindow : Window
    {
        private readonly LmsContext _context;
        private Customer _selectedCustomer;
        public CustomerWindow()
        {
            InitializeComponent();
            _context = new LmsContext();

            FillBaseGrid();
        }

        #region BaseMethods
        private void FillBaseGrid()
        {
            DgvCustomers.ItemsSource = _context.Customers.ToList();
        }

        private void Reset()
        {
            TxtCName.Clear();
            TxtCSurname.Clear();
            TxtCPhone.Clear();
            DtpCBirthInner.SelectedDate = null;
           


            BtnAddC.IsEnabled = true;
            BtnDeleteC.IsEnabled = false;
            BtnEditC.IsEnabled = false;

            FillBaseGrid();

        }

        private bool FormValidation()
        {
            bool hasError = false;

            if (string.IsNullOrEmpty(TxtCName.Text))
            {
                LblCName.Foreground = new SolidColorBrush(Colors.Red);
                hasError = true;
            }
            else
            {
                LblCName.Foreground = new SolidColorBrush(Colors.Black);
            }


            if (string.IsNullOrEmpty(TxtCSurname.Text))
            {
                LblCSurname.Foreground = new SolidColorBrush(Colors.Red);
                hasError = true;
            }
            else
            {
                LblCSurname.Foreground = new SolidColorBrush(Colors.Black);
            }

            if (DtpCBirthInner.SelectedDate == null)
            {
                LblCBirth.Foreground = new SolidColorBrush(Colors.Red);
                hasError = true;
            }
            else
            {
                LblCBirth.Foreground = new SolidColorBrush(Colors.Black);
            }
            if (string.IsNullOrEmpty(TxtCPhone.Text))
            {
                LblCPhone.Foreground = new SolidColorBrush(Colors.Red);
                hasError = true;
            }
            else
            {
                LblCPhone.Foreground = new SolidColorBrush(Colors.Black);
            }
            return hasError;
        }



        #endregion

        //Customer CRUD Starts

        private void BtnAddC_Click(object sender, RoutedEventArgs e)
        {
            if (FormValidation())
            {
                MessageBox.Show("Fill the obligatory places e.g *");
                return;
            }

            Customer customer= new Customer()
            {
                Name = TxtCName.Text,
                Surname = TxtCSurname.Text,
                PhoneNumber = TxtCPhone.Text,
                BirthDate = (DateTime)DtpCBirthInner.SelectedDate
            };

            _context.Add(customer);
            _context.SaveChanges();

            Reset();

            MessageBox.Show("Customer is Added");
        }

        private void BtnEditC_Click(object sender, RoutedEventArgs e)
        {
            if (FormValidation())
            {
                MessageBox.Show("Fill the obligatory places e.g *");
                return;
            }

            _selectedCustomer.Name = TxtCName.Text;
            _selectedCustomer.Surname = TxtCSurname.Text;
            _selectedCustomer.PhoneNumber = TxtCPhone.Text;
            _selectedCustomer.BirthDate = (DateTime)DtpCBirthInner.SelectedDate;
            _context.SaveChanges();

            Reset();

            MessageBox.Show("Customer is Edited");
        }

        private void BtnDeleteC_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult r = MessageBox.Show("Are you sure?", _selectedCustomer.ToString(), MessageBoxButton.YesNo);

            if (r == MessageBoxResult.Yes)
            {
                _context.Customers.Remove(_selectedCustomer);
                _context.SaveChanges();

                Reset();

                MessageBox.Show("Customer is Deleted");
            }
        }
        private void DgvCustomers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DgvCustomers.SelectedItem == null) return;

            _selectedCustomer = (Customer)DgvCustomers.SelectedItem;

            TxtCName.Text = _selectedCustomer.Name;
            TxtCSurname.Text = _selectedCustomer.Surname;
            TxtCPhone.Text = _selectedCustomer.PhoneNumber;
            DtpCBirthInner.SelectedDate = _selectedCustomer.BirthDate;

            BtnAddC.IsEnabled = false;
            BtnDeleteC.IsEnabled = true;
            BtnEditC.IsEnabled = true;
        }

        //Customer CRUD Ends

        #region TxtBoxControl

        private void TxtCName_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!Regex.IsMatch(TxtCName.Text, "^[a-zA-Z_ ]*$"))
            {
                MessageBox.Show("Name textbox accepts only alphabetical characters");
                TxtCName.Clear();

            }
        }

        private void TxtCSurname_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!Regex.IsMatch(TxtCSurname.Text, "^[a-zA-Z_ ]*$"))
            {
                MessageBox.Show("Surname textbox accepts only alphabetical characters");
                TxtCSurname.Clear();

            }
        }

        private void TxtCPhone_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = new Regex("[^0-9]+").IsMatch(e.Text);
        }




        #endregion

       
    }
}
