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
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        private readonly LmsContext _context;
        public LoginWindow()
        {
            InitializeComponent();
            _context = new LmsContext();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            




            if (string.IsNullOrEmpty(TxtUser.Text) || string.IsNullOrEmpty(TxtPass.Password))
            {
                MessageBox.Show("Please fill all inputs");

            }
            else
            {
                //admin log
                if (TxtUser.Text == "admin" && TxtPass.Password == "admin")
                {
                    DashboardWindow dw = new DashboardWindow();
                    dw.Show();
                    this.Close();
                }
                else
                {
                    LblMessage.Visibility = Visibility.Visible;
                }

                


            }

            var manager = _context.Managers.FirstOrDefault(m => m.Email==TxtPass.Password);
            //manager log
            if (manager != null)
            {


                if (manager.Password == null && manager.Email!=TxtUser.Text)
                {
                    LblMessage.Visibility = Visibility.Visible;

                }
                else
                {
                    DashboardWindow dw = new DashboardWindow();
                    dw.Show();
                    this.Close();
                }
            }






        }
    }
}
