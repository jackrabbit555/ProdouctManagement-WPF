using DataAccses;
using System;
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
using DataAccses.Models;
using static DataAccses.Models.Employee;
using System.Net;

namespace WpfProdouctManagement
{
    /// <summary>
    /// Interaction logic for AddEditEmployee.xaml
    /// </summary>
    public partial class AddEditEmployee : Window
    {
        private EmployeeDataAccses employeeDataAccsess;

        private Employee editingEmployee;
        private bool isedit = false;

        public AddEditEmployee(EmployeeDataAccses empDataAccsess)
        {
            InitializeComponent();
            employeeDataAccsess = empDataAccsess;
        }


        public AddEditEmployee(EmployeeDataAccses empDataAccsess, Employee emp)
        {
            InitializeComponent();
            employeeDataAccsess = empDataAccsess;
            editingEmployee = emp;
            isedit = true;
            tbFirstName.Text = editingEmployee.FisrtName;
            tbLastName.Text = editingEmployee.LastName;
            tbPhoneNumber.Text = editingEmployee.PhoneNumber.ToString();
            tbAddress.Text = editingEmployee.Address.ToString();
            tbSlary.Text = editingEmployee.BaseSalary.ToString();
            ComboDepartment.SelectedIndex = ((int)editingEmployee.Departmentprop);


        }




        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }





        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            bool isvalid = true;
            isvalid = CheckEmployeeValidity();
            if (isvalid)
            {
                if (isedit)
                {
                    Employee emp = new Employee()
                    {
                        Id = editingEmployee.Id,
                        FisrtName = tbFirstName.Text,
                        LastName = tbLastName.Text,
                        PhoneNumber = Convert.ToUInt64(tbPhoneNumber.Text),
                        Address = tbAddress.Text,
                        BaseSalary = Convert.ToDecimal(tbSlary.Text),
                        Departmentprop = (Department)ComboDepartment.SelectedIndex
                    };

                    employeeDataAccsess.EditEmployee(emp);


                }
                else
                {
                    Employee emp = new Employee()
                    {
                        Id = employeeDataAccsess.GetNextId(),
                        FisrtName = tbFirstName.Text,
                        LastName = tbLastName.Text,
                        PhoneNumber = Convert.ToUInt64(tbPhoneNumber.Text),
                        Address = tbAddress.Text,
                        BaseSalary = Convert.ToDecimal(tbSlary.Text),
                        Departmentprop = (Department)ComboDepartment.SelectedIndex
                    };
                    employeeDataAccsess.AddEmployee(emp);

                }
                this.Close();

            }

        }

        private bool CheckEmployeeValidity()
        {
            bool isvalid = true;



            string fisrtName = tbFirstName.Text.Trim().ToLower();
            string lastName = tbLastName.Text.Trim().ToLower();
            string phoneNumber = (tbPhoneNumber.Text).Trim().ToLower();
            string address = tbAddress.Text.Trim().ToLower();
            int departmentprop = ComboDepartment.SelectedIndex;
            string baseSalary = tbSlary.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(fisrtName))
            {
                isvalid = false;
                //tbFirstName.BorderBrush = Brushes.Red;
                lblError.Content = "**First Name is invalid";
            }



            else if (string.IsNullOrEmpty(lastName))
            {
                isvalid = false;
                //tblastName.BorderBrush = Brushes.Red;
                lblError.Content = "**Last Name is invalid";
            }

            else if (!UInt64.TryParse(phoneNumber, out ulong p))
            {
                isvalid = false;
                lblError.Content = "**Phone Number is invalid";
            }
            else if (address.Contains("paris"))
            {
                isvalid = false;
                lblError.Content = "**Paris is not accepted!";
            }

            else if (departmentprop < 0)
            {
                isvalid = false;
                lblError.Content = "**Please Select a Department";
            }
            else if (!decimal.TryParse(baseSalary, out decimal b) || b > 4000)
            {
                isvalid = false;
                lblError.Content = "**Slary is incoorect";
            }


            else
            {
                lblError.Content = "";
            }


            return isvalid;
        }





        private void ComboDepartment_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void tbPhoneNumber_TextChanged(object sender, TextChangedEventArgs e)
        {
            string phoneNumber = (tbPhoneNumber.Text).Trim().ToLower();
            if (!UInt64.TryParse(phoneNumber, out ulong p))
            {
                
                lblError.Content = "**Phone Number is invalid";
               

            }
            else
            {
                lblError.Content = "";
            }
        }
    }
}
