using LMS.Data;
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
            string username = _context.Administrators.Find(1).Username;
            string password = _context.Administrators.Find(1).Password;

            if (string.IsNullOrEmpty(TxtUser.Text)&& string.IsNullOrEmpty(TxtPass.Password))
            {
                MessageBox.Show("Please fill all inputs");

            }
            else
            {

                if (TxtUser.Text == username && TxtPass.Password == password)
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

            
        }
    }
}
