using LMS.Data;
using LMS.Models;
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
    /// Interaction logic for BookWindow.xaml
    /// </summary>
    public partial class BookWindow : Window
    {
        private readonly LmsContext _context;
        private Book _selectedBook;
        public BookWindow()
        {
            InitializeComponent();
            _context = new LmsContext();

            FillList();

            FillBaseGrid();
        }

        #region BaseMethods
        private void FillList()
        {
            LbGenre.ItemsSource = _context.Genres.ToList();
            LbGenre.DisplayMemberPath = "Name";
        }

        private void FillBaseGrid()
        {
            DgvBooks.ItemsSource = _context.Books.ToList();
        }
        private void Reset()
        {
            TxtBName.Clear();
            TxtAuthor.Clear();
            TxtPrice.Clear();
            LbGenre.SelectedItem = null;


            BtnAddB.IsEnabled = true;
            BtnDeleteB.IsEnabled = false;
            BtnEditB.IsEnabled = false;

            FillBaseGrid();

        }

        private bool FormValidation()
        {
            bool hasError = false;

            if (string.IsNullOrEmpty(TxtBName.Text))
            {
                LblBName.Foreground = new SolidColorBrush(Colors.Red);
                hasError = true;
            }
            else
            {
                LblBName.Foreground = new SolidColorBrush(Colors.Black);
            }


            if (string.IsNullOrEmpty(TxtAuthor.Text))
            {
                LblAuthor.Foreground = new SolidColorBrush(Colors.Red);
                hasError = true;
            }
            else
            {
                LblAuthor.Foreground = new SolidColorBrush(Colors.Black);
            }

            if (LbGenre.SelectedItem == null)
            {
                LblGenre.Foreground = new SolidColorBrush(Colors.Red);
                hasError = true;
            }
            else
            {
                LblGenre.Foreground = new SolidColorBrush(Colors.Black);

            }
            if (string.IsNullOrEmpty(TxtPrice.Text))
            {
                LblPrice.Foreground = new SolidColorBrush(Colors.Red);
                LblDollar.Foreground = new SolidColorBrush(Colors.Red);
                hasError = true;
            }
            else
            {
                LblPrice.Foreground = new SolidColorBrush(Colors.Black);
                LblDollar.Foreground = new SolidColorBrush(Colors.Black);
            }
            return hasError;
        }

        //private double PriceValidation()
        //{
        //    double p = (double)Convert.ToDouble(TxtPrice.Text);
        //    if (!double.TryParse(TxtPrice.Text, out double Price))
        //    {
        //        LblDollar.Foreground = new SolidColorBrush(Colors.Red);
               
        //    }
        //    else
        //    {
        //        LblDollar.Foreground = new SolidColorBrush(Colors.Black);
        //    }

        //    return p;
        //}

        #endregion

        private void BtnAddB_Click(object sender, RoutedEventArgs e)
        {
            if (FormValidation())
            {
                MessageBox.Show("Fill the obligatory places e.g *");
                return;
            }

            //if (PriceValidation())
            //{
            //    MessageBox.Show("Please number for Price input");
            //    return;
            //}

            Book book = new Book()
            {
                Name = TxtBName.Text,
                Author = TxtAuthor.Text,
                Genre = (Genre)LbGenre.SelectedItem,
                Price = (double)Convert.ToDouble(TxtPrice.Text)
            };

            _context.Add(book);
            _context.SaveChanges();

            Reset();

            MessageBox.Show("Book is Added");

        }

        private void BtnEditB_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnDeleteB_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
