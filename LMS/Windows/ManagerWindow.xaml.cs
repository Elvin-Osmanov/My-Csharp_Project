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
    /// Interaction logic for ManagerWindow.xaml
    /// </summary>
    public partial class ManagerWindow : Window
    {
        private readonly LmsContext _context;
        private Manager _selectedManager;

        public ManagerWindow()
        {
            InitializeComponent();
            _context = new LmsContext();

            FillBaseGrid();
        }

        #region BaseMethods
        private void FillBaseGrid()
        {
            DgvManagers.ItemsSource = _context.Managers.ToList();
        }

        private void Reset()
        {
            TxtMname.Clear();
            TxtMsurname.Clear();
            TxtSpeciality.Clear();
            DtpDate.SelectedDate = null;


            BtnAddM.IsEnabled = true;
            BtnDeleteM.IsEnabled = false;
            BtnEditM.IsEnabled = false;

            FillBaseGrid();

        }

        private bool FormValidation()
        {
            bool hasError = false;

            if (string.IsNullOrEmpty(TxtMname.Text))
            {
                LblName.Foreground = new SolidColorBrush(Colors.Red);
                hasError = true;
            }
            else
            {
                LblName.Foreground = new SolidColorBrush(Colors.Black);
            }


            if (string.IsNullOrEmpty(TxtMsurname.Text))
            {
                LblSurname.Foreground = new SolidColorBrush(Colors.Red);
                hasError = true;
            }
            else
            {
                LblSurname.Foreground = new SolidColorBrush(Colors.Black);
            }
            
            if (DtpDate.SelectedDate == null)
            {
                LblDate.Foreground = new SolidColorBrush(Colors.Red);
                hasError = true;
            }
            else
            {
                LblDate.Foreground = new SolidColorBrush(Colors.Black);
            }
            if (string.IsNullOrEmpty(TxtSpeciality.Text))
            {
                LblSpeciality.Foreground = new SolidColorBrush(Colors.Red);
                hasError = true;
            }
            else
            {
                LblSpeciality.Foreground = new SolidColorBrush(Colors.Black);
            }
            return hasError;
        }
        #endregion


        //Manager CRUD starts

        private void BtnAddM_Click(object sender, RoutedEventArgs e)
        {
            if (FormValidation())
            {
                MessageBox.Show("Fill the obligatory places e.g *");
                return;
            }

            Manager manager = new Manager()
            {
                Name = TxtMname.Text,
                Surname = TxtMsurname.Text,
                Speciality = TxtSpeciality.Text,
                BirthDate =(DateTime) DtpDate.SelectedDate
            };

            _context.Add(manager);
            _context.SaveChanges();

            Reset();

            MessageBox.Show("Manager is Added");


        }

        private void BtnEditM_Click(object sender, RoutedEventArgs e)
        {
            if (FormValidation())
            {
                MessageBox.Show("Fill the obligatory places e.g *");
                return;
            }

            _selectedManager.Name = TxtMname.Text;
            _selectedManager.Surname = TxtMsurname.Text;
            _selectedManager.Speciality = TxtSpeciality.Text;
            _selectedManager.BirthDate = (DateTime)DtpDate.SelectedDate;
            _context.SaveChanges();

            Reset();

            MessageBox.Show("Manager is Edited");

        }

        private void DgvManagers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DgvManagers.SelectedItem == null) return;

            _selectedManager = (Manager)DgvManagers.SelectedItem;

            TxtMname.Text = _selectedManager.Name;
            TxtMsurname.Text = _selectedManager.Surname;
            TxtSpeciality.Text= _selectedManager.Speciality;
            DtpDate.SelectedDate = _selectedManager.BirthDate;

            BtnAddM.IsEnabled = false;
            BtnDeleteM.IsEnabled = true;
            BtnEditM.IsEnabled = true;
        }

        private void BtnDeleteM_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult r = MessageBox.Show("Are you sure?", _selectedManager.ToString(), MessageBoxButton.YesNo);

            if (r == MessageBoxResult.Yes)
            {
                _context.Managers.Remove(_selectedManager);
                _context.SaveChanges();

                Reset();

                MessageBox.Show("Manager is Deleted");
            }
        }

        //Manager CRUD ends
    }
}
