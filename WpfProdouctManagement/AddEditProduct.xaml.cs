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
using System.Diagnostics;
using System.ComponentModel.DataAnnotations;

namespace WpfProdouctManagement
{
    /// <summary>
    /// Interaction logic for AddEditProduct.xaml
    /// </summary>
    public partial class AddEditProduct : Window
    {


        private ProductDataAccses productDataAccses;
        private Product editingProduct;
        private bool isEdit = false;




        public AddEditProduct(ProductDataAccses proDataAccses)
        {
            InitializeComponent();
            productDataAccses = proDataAccses;
        }




        public AddEditProduct(ProductDataAccses proDataAccses, Product pro)
        {
            InitializeComponent();
            productDataAccses = proDataAccses;
            editingProduct = pro;
            isEdit = true;
            tbName.Text = editingProduct.Name;
            tbAuthor.Text = editingProduct.Author;
            tbPrice.Text = editingProduct.Price.ToString();
            tbAvialableCount.Text = editingProduct.AvailableCount.ToString();
        }




        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }





        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            bool isvalid = true;
            isvalid = CheckProductValidity();
            if (isvalid)
            {
                if (isEdit)
                {
                    Product pro = new Product()
                    {
                        Id = editingProduct.Id,
                        Name = tbName.Text,
                        Author = tbAuthor.Text,
                        Price = Convert.ToInt32(tbPrice.Text),
                        AvailableCount = Convert.ToInt32(tbAvialableCount.Text),
                    };
                    productDataAccses.EditProduct(pro);

                }



                else
                {
                    Product pro = new Product()
                    {
                        Id = productDataAccses.GetNextId(),
                        Name = tbName.Text,
                        Author = tbAuthor.Text,
                        Price = Convert.ToInt32(tbPrice.Text),
                        AvailableCount = Convert.ToInt32(tbAvialableCount.Text),
                    };
                    productDataAccses.AddProducts(pro);
                }


                this.Close();
            }


            
            
                

            
        }
        private bool CheckProductValidity()
        
        {
            bool isvalid = true;

            string name = tbName.Text.Trim().ToLower();
            string author = tbAuthor.Text.Trim().ToLower();
            string price = tbPrice.Text.Trim().ToLower();
            string availableCount = tbAvialableCount.Text.Trim().ToLower();


            if (string.IsNullOrEmpty(name))
            {
                isvalid = false;
                lblError.Content = "**Product Name is invalid";
            }

            else if (string.IsNullOrEmpty(author))
            {
                isvalid = false;
                lblError.Content = "**Author Name is invalid";

            }
            

            else if (!decimal.TryParse(price ,out decimal p) )
            {
                isvalid=false;
                lblError.Content = "**Price is invalid";
            }
            else if (!UInt64.TryParse(availableCount , out ulong a))
            {
                isvalid = false;
                lblError.Content = "**Avialable Count is invalid";
            }

            return isvalid;

        }
    }
}
