using ClosedXML.Excel;
using LMS.Data;
using LMS.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Win32;
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
    /// Interaction logic for SalesReportWindow.xaml
    /// </summary>
    public partial class SalesReportWindow : Window
    {
        private readonly LmsContext _context;

        public SalesReportWindow()
        {
            InitializeComponent();
            _context = new LmsContext();

           
        }

        //Filling data for export
        private void FillDataBase()
        {
            DgvExport.ItemsSource = _context.Orders.Where(x => x.CreatedAt >= DtpStartDate.SelectedDate && x.ReturnDate <= DtpEndDate.SelectedDate || (x.ReturnedDate >= DtpStartDate.SelectedDate && x.ReturnedDate <= DtpEndDate.SelectedDate)).Include(x => x.Customer).ToList();
        }

        //Data Validation between two dates
        private bool DatePickVal()
        {
            bool hasError = false;

            if (DtpStartDate.SelectedDate == null || DtpEndDate.SelectedDate == null)
            {
                LblStart.Foreground = new SolidColorBrush(Colors.Red);
                LblEnd.Foreground = new SolidColorBrush(Colors.Red);
                hasError = true;
            }
            else
            {
                LblStart.Foreground = new SolidColorBrush(Colors.Black);
                LblEnd.Foreground = new SolidColorBrush(Colors.Black);
            }
            return hasError;
        }
        private void BtnDataShow_Click(object sender, RoutedEventArgs e)
        {
            if (DatePickVal())
            {
                MessageBox.Show("Please pick dates");

                return;
            }
            
            
             FillDataBase();
            
            
        }

        
        //Export button
        private void BtnExport_Click(object sender, RoutedEventArgs e)
        {
            if (DatePickVal())
            {
                MessageBox.Show("Please pick dates");

                return;
            }
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Excel files|*.xlsx",
                Title = "Save an Excel File"
            };
            saveFileDialog.ShowDialog();

            List<Order> export;

            export = _context.Orders.Where(x => x.CreatedAt >= DtpStartDate.SelectedDate && x.ReturnDate <= DtpEndDate.SelectedDate || (x.ReturnedDate >= DtpStartDate.SelectedDate && x.ReturnedDate <= DtpEndDate.SelectedDate)).Include(x => x.Customer).ToList();

            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Orders");

                worksheet.Columns("A", "I").AdjustToContents();

                worksheet.Cell("A1").SetValue("Name");
                worksheet.Cell("B1").SetValue("Surname");
                worksheet.Cell("C1").SetValue("Phone");
                worksheet.Cell("D1").SetValue("Created");
                worksheet.Cell("E1").SetValue("Deadline");
                worksheet.Cell("F1").SetValue("ReturnedDate");
                worksheet.Cell("G1").SetValue("Fine");
                worksheet.Cell("H1").SetValue("Payment");
                worksheet.Cell("I1").SetValue("Total Payment");

                worksheet.Cell("A1").Style.Fill.SetBackgroundColor(XLColor.FromArgb(0, 181, 204));
                worksheet.Cell("B1").Style.Fill.SetBackgroundColor(XLColor.FromArgb(0, 181, 204));
                worksheet.Cell("C1").Style.Fill.SetBackgroundColor(XLColor.FromArgb(0, 181, 204));
                worksheet.Cell("D1").Style.Fill.SetBackgroundColor(XLColor.FromArgb(0, 181, 204));
                worksheet.Cell("E1").Style.Fill.SetBackgroundColor(XLColor.FromArgb(0, 181, 204));
                worksheet.Cell("F1").Style.Fill.SetBackgroundColor(XLColor.FromArgb(0, 181, 204));
                worksheet.Cell("G1").Style.Fill.SetBackgroundColor(XLColor.FromArgb(0, 181, 204));
                worksheet.Cell("H1").Style.Fill.SetBackgroundColor(XLColor.FromArgb(0, 181, 204));
                worksheet.Cell("I1").Style.Fill.SetBackgroundColor(XLColor.FromArgb(0, 181, 204));


                worksheet.Cell("A1").Style.Font.SetFontColor(XLColor.White);
                worksheet.Cell("B1").Style.Font.SetFontColor(XLColor.White);
                worksheet.Cell("C1").Style.Font.SetFontColor(XLColor.White);
                worksheet.Cell("D1").Style.Font.SetFontColor(XLColor.White);
                worksheet.Cell("E1").Style.Font.SetFontColor(XLColor.White);
                worksheet.Cell("F1").Style.Font.SetFontColor(XLColor.White);
                worksheet.Cell("G1").Style.Font.SetFontColor(XLColor.White);
                worksheet.Cell("H1").Style.Font.SetFontColor(XLColor.White);
                worksheet.Cell("I1").Style.Font.SetFontColor(XLColor.White);


                int row = 2;

                foreach (Order order in export)
                {
                   
                    worksheet.Cell("A" + row).Value = order.Customer.Name;
                    worksheet.Cell("B" + row).Value = order.Customer.Surname;
                    worksheet.Cell("C" + row).Value = order.Customer.PhoneNumber;
                    worksheet.Cell("D" + row).Value = order.CreatedAt;
                    worksheet.Cell("E" + row).Value = order.ReturnDate;
                    worksheet.Cell("F" + row).Value = order.ReturnedDate;
                    worksheet.Cell("G" + row).Value = order.Fine;
                    worksheet.Cell("H" + row).Value = order.OrderPrice;
                    worksheet.Cell("I" + row).Value = order.TotalPrice;

                    row++;
                }

                if (!String.IsNullOrWhiteSpace(saveFileDialog.FileName))
                {
                    workbook.SaveAs(saveFileDialog.FileName);
                }


            }
        }
    }
}
