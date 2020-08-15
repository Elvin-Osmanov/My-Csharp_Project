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
            TxtQuantity.Clear();
            TxtShelf.Clear();

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
            if (string.IsNullOrEmpty(TxtShelf.Text))
            {
                LblShelf.Foreground = new SolidColorBrush(Colors.Red);
                hasError = true;
            }
            else
            {
                LblShelf.Foreground = new SolidColorBrush(Colors.Black);
            }
            if (string.IsNullOrEmpty(TxtQuantity.Text))
            {
                LblQuantity.Foreground = new SolidColorBrush(Colors.Red);
                hasError = true;
            }
            else
            {
                LblQuantity.Foreground = new SolidColorBrush(Colors.Black);
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

      

        #endregion

        //Book CRUD starts

        private void BtnAddB_Click(object sender, RoutedEventArgs e)
        {
            if (FormValidation())
            {
                MessageBox.Show("Fill the obligatory places e.g *");
                return;
            }



            Book book = new Book()
            {
                Name = TxtBName.Text,
                Author = TxtAuthor.Text,
                Genre = (Genre)LbGenre.SelectedItem,
                PricePerWeek = (double)Convert.ToDouble(TxtPrice.Text),
                Quantity = Convert.ToInt32(TxtQuantity.Text),
                Shelf = Convert.ToInt32(TxtShelf.Text)
            };
        

            _context.Add(book);
            _context.SaveChanges();

            Reset();

            MessageBox.Show("Book is Added");

        }

        private void BtnEditB_Click(object sender, RoutedEventArgs e)
        {
            if (FormValidation())
            {
                MessageBox.Show("Fill the obligatory places e.g *");
                return;
            }

            _selectedBook.Name = TxtBName.Text;
            _selectedBook.PricePerWeek =Convert.ToDouble(TxtPrice.Text);
            _selectedBook.Author = TxtAuthor.Text;
            _selectedBook.Genre = (Genre)LbGenre.SelectedItem;
            _selectedBook.Quantity =Convert.ToInt32(TxtQuantity.Text);
            _selectedBook.Shelf = Convert.ToInt32(TxtShelf.Text);
            _context.SaveChanges();

            Reset();

            MessageBox.Show("Book is Edited");
        }

        private void BtnDeleteB_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult r = MessageBox.Show("Are you sure?", _selectedBook.ToString(), MessageBoxButton.YesNo);

            if (r == MessageBoxResult.Yes)
            {
                _context.Books.Remove(_selectedBook);
                _context.SaveChanges();

                Reset();

                MessageBox.Show("Book is Deleted");
            }
        }

        private void DgvBooks_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DgvBooks.SelectedItem == null) return;

            _selectedBook = (Book)DgvBooks.SelectedItem;

            TxtBName.Text = _selectedBook.Name;
            TxtAuthor.Text = _selectedBook.Author;
            TxtPrice.Text = _selectedBook.PricePerWeek.ToString();
            LbGenre.SelectedItem = _selectedBook.Genre;
            TxtQuantity.Text = _selectedBook.Quantity.ToString();
            TxtShelf.Text = _selectedBook.Shelf.ToString();

            BtnAddB.IsEnabled = false;
            BtnDeleteB.IsEnabled = true;
            BtnEditB.IsEnabled = true;
        }

        //Book CRUD ends





        #region TxtBoxControl

        private void TxtPrice_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = new Regex("[^0-9,]+").IsMatch(e.Text);
        }

        private void TxtQuantity_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = new Regex("[^0-9]+").IsMatch(e.Text);
        }

        private void TxtBName_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!Regex.IsMatch(TxtBName.Text, "^[a-zA-Z_ ]*$"))
            {
                MessageBox.Show("Name textbox accepts only alphabetical characters");
                TxtBName.Clear();

            }
        }

        private void TxtAuthor_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!Regex.IsMatch(TxtAuthor.Text, "^[a-zA-Z_ ]*$"))
            {
                MessageBox.Show("Author textbox accepts only alphabetical characters");
                TxtAuthor.Clear();

            }
        }

        private void TxtShelf_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = new Regex("[^0-9]+").IsMatch(e.Text);
        }
        #endregion


    }
}
