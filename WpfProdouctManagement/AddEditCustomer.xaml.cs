using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
using DataAccses;
using DataAccses.Models;
using static DataAccses.Models.Customer;





namespace WpfProdouctManagement
{
    /// <summary>
    /// Interaction logic for AddEditCustomer.xaml
    /// </summary>
    public partial class AddEditCustomer : Window
    {
        private CustomerDataAccses customerDataAccses;

        private Customer editingCustomer;
        private bool isedit = false;
        public AddEditCustomer(CustomerDataAccses cstDataAccses)
        {
            InitializeComponent();
            customerDataAccses = cstDataAccses;
        }





        public AddEditCustomer(CustomerDataAccses cstDataAccses, Customer cst)
        {
            InitializeComponent();
            customerDataAccses = cstDataAccses;
            editingCustomer = cst;
            isedit = true;
            tbFirstName.Text = editingCustomer.FisrtName;
            tbLastName.Text = editingCustomer.LastName;
            tbPhoneNumber.Text = editingCustomer.PhoneNumber.ToString();
            tbAddress.Text = editingCustomer.Address;


        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, RoutedEventArgs e)
        {


            bool isvalid = true;
            isvalid = CheckCustomerValidity();

            if (isvalid)
            {
                if (isedit)
                {
                    Customer cst = new Customer()

                    {
                        Id = editingCustomer.Id,
                        FisrtName = tbFirstName.Text,
                        LastName = tbLastName.Text,
                        PhoneNumber = Convert.ToUInt64(tbPhoneNumber.Text),
                        Address = tbAddress.Text,

                    };

                    customerDataAccses.EditCustomer(cst);
                }


                else
                {
                    Customer cst = new Customer()

                    {
                        Id = customerDataAccses.GetNextId(),
                        FisrtName = tbFirstName.Text,
                        LastName = tbLastName.Text,
                        PhoneNumber = Convert.ToUInt64(tbPhoneNumber.Text),
                        Address = tbAddress.Text,

                    };
                    customerDataAccses.AddCustomer(cst);


                }

                this.Close();
            }









        }

        private bool CheckCustomerValidity()


        {
            bool isvalid = true;
            string fisrtName = tbFirstName.Text.Trim().ToLower();
            string lastName = tbLastName.Text.Trim().ToLower();
            string phoneNumber = tbPhoneNumber.Text.Trim().ToLower();
            string address = tbAddress.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(fisrtName))
            {
                isvalid = false;
              lblerror.Content = ("**First Name is invalid");
            }
            else if (string.IsNullOrEmpty(lastName))
            {
                isvalid = false;
                lblerror.Content = ("**Last Name is invalid");
            }
          

            else if (!UInt64.TryParse(phoneNumber, out ulong p))
            {
                isvalid = false;
                lblerror.Content = ("**Phone Number is invalid");
            }
            else if (address.Contains("paris"))
            {
                isvalid = false;
                lblerror.Content = ("**Paris is no acceprted!");
                   
            }
            else
            {
                lblerror.Content = "";
            }



            return isvalid;


        }

        private void tbPhoneNumber_TextChanged(object sender, TextChangedEventArgs e)
        {
            string phoneNumber = tbPhoneNumber.Text.Trim().ToLower();
            if (!UInt64.TryParse(phoneNumber, out ulong p))
            {
                
                lblerror.Content = ("**Phone Number is invalid");
            }
            else { lblerror.Content = ""; }
            
        }
    }
}
