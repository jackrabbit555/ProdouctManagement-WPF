using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using DataAccses;
using DataAccses.Models;

namespace WpfProdouctManagement
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        EmployeeDataAccses employeeDataAccses = new EmployeeDataAccses();
        CustomerDataAccses customerDataAccses = new CustomerDataAccses();
        ProductDataAccses productDataAccses = new ProductDataAccses();





        ObservableCollection<Employee> employees = new ObservableCollection<Employee>();
        ObservableCollection<Customer> customers = new ObservableCollection<Customer>();
        ObservableCollection<Product> products = new ObservableCollection<Product>();





        public Employee currentEmployee { get; set; } = new Employee();
        public Customer currentCustomer { get; set; } = new Customer();
        public Product currentProduct { get; set; } = new Product();






        public MainWindow()
        {
            InitializeComponent();
            fillData();
            EmplyessGrid.ItemsSource = employees;
            CustomersGrid.ItemsSource = customers;
            ProductGrid.ItemsSource = products;

        }




        private void fillData()
        {
            employees = employeeDataAccses.employees;
            customers = customerDataAccses.customers;
            products = productDataAccses.Products;
        }






        private void btnHome_Click(object sender, RoutedEventArgs e)
        {
            HomePanel.Visibility = Visibility.Visible;
            EmployeesPanel.Visibility = Visibility.Collapsed;
            CostomersPanel.Visibility = Visibility.Collapsed;
            ProductsPanel.Visibility = Visibility.Collapsed;
        }

        private void btnEmolyees_Click(object sender, RoutedEventArgs e)
        {
            HomePanel.Visibility = Visibility.Collapsed;
            EmployeesPanel.Visibility = Visibility.Visible;
            CostomersPanel.Visibility = Visibility.Collapsed;
            ProductsPanel.Visibility = Visibility.Collapsed;
        }

        private void btnCustomers_Click(object sender, RoutedEventArgs e)
        {
            HomePanel.Visibility = Visibility.Collapsed;
            EmployeesPanel.Visibility = Visibility.Collapsed;
            CostomersPanel.Visibility = Visibility.Visible;
            ProductsPanel.Visibility = Visibility.Collapsed;
        }

        private void btnProducs_Click(object sender, RoutedEventArgs e)
        {
            HomePanel.Visibility = Visibility.Visible;
            EmployeesPanel.Visibility = Visibility.Collapsed;
            CostomersPanel.Visibility = Visibility.Collapsed;
            ProductsPanel.Visibility = Visibility.Visible;
        }














        private void EmplyessGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (EmplyessGrid.SelectedIndex  >= 0)
            {
                currentEmployee = EmplyessGrid.SelectedItem as Employee;
                EmployeeLabel.Content = currentEmployee.GetBasicInfo();
            }
        }

        private void btnAddEmployee_Click(object sender, RoutedEventArgs e)
        {
            
            AddEditEmployee addWindow = new AddEditEmployee(employeeDataAccses);
            addWindow.ShowDialog();


        }

        private void btnDeleteEmployee_Click(object sender, RoutedEventArgs e)
        {
            if (EmplyessGrid.SelectedIndex >= 0)
            {
                currentEmployee = EmplyessGrid.SelectedItem as Employee;
                employeeDataAccses.RemoveEmployee(currentEmployee.Id);
                EmployeeLabel.Content = "---";
            }
        }

        private void btnEditEmployee_Click(object sender, RoutedEventArgs e)
        {
            if (EmplyessGrid.SelectedIndex >= 0)
            {
                currentEmployee = EmplyessGrid.SelectedItem as Employee;
                AddEditEmployee addWindow = new AddEditEmployee(employeeDataAccses, currentEmployee);
                addWindow.ShowDialog();
            }
        }







    private void CustomersGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (CustomersGrid.SelectedIndex >= 0)
            {
                currentCustomer = CustomersGrid.SelectedItem as Customer;
                CustomerLabel.Content = currentCustomer.GetBasicInfo();
            }
        }






        private void btnAddCustomer_Click(object sender, RoutedEventArgs e)
        {
            AddEditCustomer addWindow = new AddEditCustomer(customerDataAccses);
            addWindow.ShowDialog();
        }







        private void btnDeleteCustomer_Click(object sender, RoutedEventArgs e)
        {
            if (CustomersGrid.SelectedIndex >= 0)
            {
                currentCustomer = CustomersGrid.SelectedItem as Customer;
                customerDataAccses.RemoveCustomer(currentCustomer.Id);
                CustomerLabel.Content = "---";
            }
        }

      

        private void btnEditCustomer_Click(object sender, RoutedEventArgs e)
        {
            if (CustomersGrid.SelectedIndex >= 0)
           {
                currentCustomer = CustomersGrid.SelectedItem as Customer;
                AddEditCustomer addWindow = new AddEditCustomer(customerDataAccses, currentCustomer);
                addWindow.ShowDialog();
           }
        }















        private void ProductGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ProductGrid.SelectedIndex >= 0)
            {
                currentProduct = ProductGrid.SelectedItem as Product;
                ProductLabel.Content = currentProduct.GetBasicInfo();
            }
        }
        private void btnAddProduct_Click(object sender, RoutedEventArgs e)
        {
            AddEditProduct addwindow = new AddEditProduct(productDataAccses);
            addwindow.ShowDialog();
        }

        private void btnDeleteProduct_Click(object sender, RoutedEventArgs e)
        {
            if (ProductGrid.SelectedIndex >= 0)
            {
                currentProduct = ProductGrid.SelectedItem as Product;
                productDataAccses.RemoveProduct(currentProduct.Id);
                ProductLabel.Content = "---";
            }
        }

        private void btnEditProduct_Click(object sender, RoutedEventArgs e)
        {
            if (ProductGrid.SelectedIndex >= 0)
            {
                currentProduct = ProductGrid.SelectedItem as Product;
                AddEditProduct addwindow = new AddEditProduct(productDataAccses, currentProduct);
                addwindow.ShowDialog();

            }
        }



       
    }
}
