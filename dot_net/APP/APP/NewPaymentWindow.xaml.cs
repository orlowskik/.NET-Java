﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace APP
{
    /// <summary>
    /// Interaction logic for CFormWindow.xaml
    /// </summary>
    public partial class NewPaymentWindow : Window
    {
        private bool loanGranted = true; 
        private string dateOfIssue = null;
        private string dateOfExpire = null;
        /// <summary>
        /// Set up when opened. Creates connection to DB
        /// and lists all contacts
        /// </summary>
        public NewPaymentWindow()
        {
            InitializeComponent();
            var context = new PaymentsContext();
            ContactsList3.ItemsSource = context.TakeAllPersons();
        }


        private void HandleCheckPlus(object sender, RoutedEventArgs e)
        {
            loanGranted = true;
        }

        private void HandleCheckMinus(object sender, RoutedEventArgs e)
        {
            loanGranted = false;
        }
        /// <summary>
        /// Takes selected contact and filled form data
        /// to add loan to selected table
        /// </summary>
        /// <param name="sender">Automated parameter from WPF</param>
        /// <param name="e">Automatic parameter. In this situation is NULL</param>
        private void BtnSubmit(object sender, RoutedEventArgs e)
        {
            var context = new PaymentsContext();
            TextBoxLoanSize.MaxLength = 3;
            if (ContactsList3.SelectedItem == null)
            {
                return;
            }
            if (!TextBoxLoanSize.Text.Any())
            {
                return;
            }
            string person = (string) ContactsList3.SelectedItems[0];
            string IDstring = new string(person.TakeWhile(Char.IsDigit).ToArray());
            Console.WriteLine(person);
            int ID = int.Parse(IDstring);
            //int ID = 1;

            Person loanPerson = context.GetPersonWithID(ID);

            int loanSize= int.Parse(TextBoxLoanSize.Text.Trim());


            if (loanGranted == true)
            {
                LoanGranted LG = new LoanGranted() {
                    PersonID = loanPerson.ID,
                    LoanSize = loanSize,
                    DateOfIssue = dateOfIssue,
                    DateOfExpiry = dateOfExpire
                };
                context.AddNewLoanGranted(LG);
            } 
            else
            {
                LoanObtained LO = new LoanObtained()
                {
                    PersonID = loanPerson.ID,
                    LoanSize = loanSize,
                    DateOfIssue = dateOfIssue,
                    DateOfExpiry = dateOfExpire
                };
                context.AddNewLoanObtained(LO);
            }
            context.SaveChanges();
            this.Close();
        }
        /// <summary>
        /// Closes window.
        /// </summary>
        /// <param name="sender">Automated parameter from WPF</param>
        /// <param name="e">Automatic parameter. In this situation is NULL</param>
        private void BtnExit(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Handling first date picker for WPF window
        /// </summary>
        /// <param name="sender">Automated parameter from WPF</param>
        /// <param name="e">Automatic parameter. In this situation is NULL</param>
        private void DatePicker_SelectedDateChangedIssue(object sender, SelectionChangedEventArgs e)
        {
            var picker = sender as DatePicker;
            DateTime? date = picker.SelectedDate;

            if (date == null)
            {
                this.Title = "No date";
            }
            else
            {
                this.Title = date.Value.ToShortDateString();
                dateOfIssue = date.Value.ToShortDateString();
                Console.WriteLine(date.Value.ToShortDateString()); 
            }
        }
        /// <summary>
        /// Handling second date picker for WPF window
        /// </summary>
        /// <param name="sender">Automated parameter from WPF</param>
        /// <param name="e">Automatic parameter. In this situation is NULL</param>
        private void DatePicker_SelectedDateChangedExpire(object sender, SelectionChangedEventArgs e)
        {
            var picker = sender as DatePicker;
            DateTime? date = picker.SelectedDate;

            if (date == null)
            {
                this.Title = "No date";
            }
            else
            {
                this.Title = date.Value.ToShortDateString();
                dateOfExpire = date.Value.ToShortDateString();
                Console.WriteLine(date.Value.ToShortDateString());
            }
        }
    }
}
