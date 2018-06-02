using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;

namespace Restoran
{
    public partial class MainForm : Form
    {
        ArrayList products = new ArrayList();

        public MainForm()
        {
            InitializeComponent();
            products.AddRange(new Product[]{
                  new Product{
                    Name = "Kabab",
                    Price = 4,
                    CountOf = 100,
                    ProductCategory = ProductCategory.MainFoods

                },
                  new Product {
                Name = "Sac",
                Price = 10,
                CountOf = 100,
                ProductCategory = ProductCategory.MainFoods

                },
                  new Product {
                Name = "Dolma",
                Price = 5,
                CountOf = 100,
                ProductCategory = ProductCategory.MainFoods

                },
                      new Product {
                Name = "Ezo Gelin",
                Price = 5,
                CountOf = 100,
                ProductCategory = ProductCategory.Soups

                },
                            new Product {
                Name = "Tomat Supu",
                Price = 2,
                CountOf = 100,
                ProductCategory = ProductCategory.Soups

                },
                                new Product {
                Name = "Paytaxt Salati",
                Price = 1.50,
                CountOf = 100,
                ProductCategory = ProductCategory.Salats

                },
                                 new Product {
                Name = "Mimoza Salati",
                Price = 0.50,
                CountOf = 100,
                ProductCategory = ProductCategory.Salats

                },
                                     new Product {
                Name = "Mimoza Salati",
                Price = 2.50,
                CountOf = 100,
                ProductCategory = ProductCategory.Salats

                },
                                       new Product {
                Name = "Ayran",
                Price = 0.50,
                CountOf = 100,
                ProductCategory = ProductCategory.Drinks

                },
                                       new Product {
                Name = "Cola",
                Price = 1.00,
                CountOf = 100,
                ProductCategory = ProductCategory.Drinks

                },
                                       new Product {
                Name = "Fanta",
                Price = 1.00,
                CountOf = 100,
                ProductCategory = ProductCategory.Drinks

                },
                                       new Product {
                Name = "Sutlac",
                Price = 2.50,
                CountOf = 100,
                ProductCategory = ProductCategory.Deserts

                },
                                       new Product {
                Name = "Paxlava",
                Price = 3.50,
                CountOf = 100,
                ProductCategory = ProductCategory.Deserts

                },
                                       new Product {
                Name = "Tort",
                Price = 5.50,
                CountOf = 100,
                ProductCategory = ProductCategory.Deserts

                },
            });

      
            cmbx_category.DataSource = Enum.GetValues(typeof(ProductCategory));
        }

      

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void cmbx_category_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = (sender as ComboBox).SelectedItem.ToString();
            ProductCategory foodsOfselectingCategory = (ProductCategory)Enum.Parse(typeof(ProductCategory), selectedItem);
            cmbx_name.Items.Clear();
            foreach (Product item in products)
            {
                if(item.ProductCategory == foodsOfselectingCategory)
                {
                    cmbx_name.Items.Add(item.Name);
                }
            }
        }

        private void cmbx_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            string SelectedValue = (sender as ComboBox).SelectedItem.ToString();
            foreach (Product item in products)
            {
                if(item.Name == SelectedValue)
                {
                    price_box.Text = item.Price +  " " + "AZN";
                }
            }
            
        }
    }
}
