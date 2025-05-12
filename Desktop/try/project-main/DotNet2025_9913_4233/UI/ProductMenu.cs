using BlApi;
using BO;
using DO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{

    public partial class ProductMenu : Form
    {
        [System.Runtime.InteropServices.DllImport("kernel32.dll")]
        private static extern bool AllocConsole();
        private static IBl _bl = Factory.Get();
        private List<SaleInProduct> tempListOfSaleInProducts = new List<SaleInProduct>();
        public ProductMenu()
        {
            InitializeComponent();
        }

        private void ProductMenu_Load(object sender, EventArgs e)
        {
            showProducts.Items.Clear();

            panel1.Visible = false;
            showProductBySearch.Visible = false;
            fullList(_bl.Product.ReadAll());


        }


        private void showProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            showProducts.Items.Clear();

            fullList(_bl.Product.ReadAll());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BO.Product product = new BO.Product();
            product.NameProduct = nameBox.Text.Trim();
            bool isNumber = double.TryParse(priceBox.Text.Trim(), out double result);
            bool isNumberQuantity = int.TryParse(textBox4.Text.Trim(), out int resultQuantity);
            if (!isNumber || !isNumberQuantity)
            {
                MessageBox.Show("נא להזין מספר  בלבד.", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            product.Price = result;
            product.QuantityInStock = resultQuantity;
            product.Category = (CategoryName)catroryBox.SelectedIndex;

            _bl.Product.Create(product);
            MessageBox.Show("המוצר נוסף בהצלחה!!!!!!!!!!!!!!!");

            fullList(_bl.Product.ReadAll());
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            panel1.Visible = true;
            int productId;
            if (!int.TryParse(productForChangeBox.Text, out productId))
            {
                MessageBox.Show("יש להכניס מספר תקין");
                return;
            }
            try
            {
                BO.Product p = _bl.Product.Read(productId);
                textBox1.Text = p.QuantityInStock.ToString();
                textBox3.Text = p.NameProduct.ToString();
                textBox2.Text = p.Price.ToString();
                comboBox1.Text = p.Category.ToString();
                SaleMenu s = new SaleMenu();
                List<BO.Sale> sale = _bl.Sale.ReadAll(s => s._productId == p.Id);
            }
            catch (BlNotFoundId)
            {
                MessageBox.Show("יש להכניס מזהה מוצר תקין");
            }
        }



        private void button2_Click_2(object sender, EventArgs e)
        {
            BO.Product p = new BO.Product();
            p.Id = int.Parse(productForChangeBox.Text);
            p.NameProduct = textBox3.Text;
            p.Price = double.Parse(textBox2.Text);

            p.Category = (CategoryName)comboBox1.SelectedIndex;
            p.QuantityInStock = int.Parse(textBox1.Text);
            _bl.Product.Update(p);
            fullList(_bl.Product.ReadAll());
        }


        private void deleteButten_Click(object sender, EventArgs e)
        {
            bool isNumber = int.TryParse(idDelete.Text, out int result);
            if (!isNumber)
            {
                MessageBox.Show("נא להזין מספר תקין בלבד.", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
                idDelete.Text = string.Empty;
            }
            else
            {
                try
                {
                    _bl.Product.Delete(result);
                    MessageBox.Show("המוצר נמחק בהצלחה");
                    fullList(_bl.Product.ReadAll());

                }
                catch (BO.BlNotFoundId)
                {
                    MessageBox.Show("המוצר לא קיים במערכת , אנא הכנס מזהה מוצר תקין");

                }
            }

        }

        public void fullList(List<BO.Product> p, ListBox l = null)
        {

            if (l == null)
                l = showProducts;
            l.Items.Clear();
            p.ForEach(product =>
              {

                  l.Items.Add("מזהה מוצר: " + product.Id);
                  l.Items.Add("שם מוצר: " + product.NameProduct);
                  l.Items.Add("מחיר: " + product.Price);
                  l.Items.Add("כמות במלאי: " + product.QuantityInStock);
                  l.Items.Add("קטגוריה: " + product.Category);
                  l.Items.Add("רשימת מבצעים: ");

                  l.Items.Add("-------------");
              });
        }

        private void filterButten_Click(object sender, EventArgs e)
        {
            string productName = filter.Text;
            BO.Product product = _bl.Product.Read((p) => p.NameProduct == productName);
            if (product == null)
            {
                MessageBox.Show("מוצר לא קיים");
            }
            else
            {
                showProductBySearch.Items.Clear();
                showProductBySearch.Visible = true;
                showProductBySearch.Items.Add("מזהה מוצר: " + product.Id);
                showProductBySearch.Items.Add("שם מוצר: " + product.NameProduct);
                showProductBySearch.Items.Add("מחיר: " + product.Price);
                showProductBySearch.Items.Add("כמות במלאי: " + product.QuantityInStock);
                showProductBySearch.Items.Add("קטגוריה: " + product.Category);
                showProductBySearch.Items.Add("-------------");
            }
        }


        private void filterBox_TextChanged(object sender, EventArgs e)
        {
            if (filter.Text == "")
                fullList(_bl.Product.ReadAll());
        }
        private void filterBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bool isNumber = int.TryParse(filterBox.Text, out int result);
                if (!isNumber)
                {
                    MessageBox.Show("נא להזין מספר  בלבד.", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (filterByPrice.Checked == false && filterByQuntity.Checked == false)
                {
                    MessageBox.Show("יש לבחור אופציה לסינון", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (filterByPrice.Checked == true && filterByQuntity.Checked == true)

                {
                    MessageBox.Show("יש לבחור אופציה  אחת בלבד לסינון", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    List<BO.Product> tmp = new List<BO.Product>();
                    showProducts.Items.Clear();
                    if (filterByQuntity.Checked == true)
                    {
                        _bl.Product.ReadAll((p) => p.QuantityInStock == result).ForEach(product =>
                        {
                            tmp.Add(product);
                        });
                    }
                    else
                    {
                        _bl.Product.ReadAll((p) => p.Price == result).ForEach(product =>
                        {
                            tmp.Add(product);
                        });
                    }
                    fullList(tmp);
                }
            }
        }

        private void productForChangeBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
