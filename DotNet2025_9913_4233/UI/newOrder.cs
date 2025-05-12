using BlApi;
using BO;
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
    public partial class newOrder : Form
    {
        private static IBl _bl = Factory.Get();
        private Customer customer;
        Order order;

        public newOrder(Customer _customer, Order _order)
        {
            customer = _customer;
            InitializeComponent();
            order = _order;

        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (showProducts.SelectedItem != null)
            {
                string selectedLine = showProducts.SelectedItem.ToString();

                if (selectedLine.StartsWith("מזהה מוצר:"))
                {
                    string productId = selectedLine.Replace("מזהה מוצר:", "").Trim();
                    textBox1.Text = productId;
                }
            }
        }

        private void newOrder_Load(object sender, EventArgs e)
        {
            showProducts.Visible = false;
        }

        private void selectFromList_Click(object sender, EventArgs e)
        {
            showProducts.Visible = true;
            MessageBox.Show("לבחירת מוזר יש ללחוץ על מזהה מוצר");
            ProductMenu productMenu = new ProductMenu();
            productMenu.fullList(_bl.Product.ReadAll(), showProducts);
        }


        private void addToOrder_Click(object sender, EventArgs e)
        {
            bool isNumber = int.TryParse(textBox1.Text, out int productId);
            if (!isNumber)
            {
                MessageBox.Show("אנא הכנב ערך מספרי", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                BO.Product product = _bl.Product.Read(productId);
                List<BO.SaleInProduct> saleInProducts = _bl.Order.AddProductToOrder(order, productId, (int)countForOrderUpDown.Value);
                fullCart(order.listProduct);

            }
            catch (BlNotFoundId)
            {
                MessageBox.Show("לא קיים מוצר עם קוד זה אנא נסה שנית", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (BlInvalidQuantityException)
            {
                MessageBox.Show("הכמות שהתקבלה אינה חוקית", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (BlOutOfStockException)
            {
                MessageBox.Show("אין מספיק מוצרים במלאי😒", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }

        }


        private void fullCart(List<ProductInOrder> productInOrder)
        {
            cart.Items.Clear();
            productInOrder.ForEach(po =>
            {
                cart.Items.Add(" שם מוצר " + po._productName);
                cart.Items.Add(" מחיר ליחדה " + po._basePrice);
                cart.Items.Add(" כמות להזמנה " + po._quantity);
                cart.Items.Add(" מחיר סופי " + po._finalPrice);
                cart.Items.Add("---------------");

            });
            cart.Items.Add(order.finalPrice + " : סה''כ תשלום להזמנה זה");


        }

        private void button1_Click(object sender, EventArgs e)
        {
            _bl.Order.DoOrder(order);
            MessageBox.Show("ההזמנה הושלמה בהצלחה!!!");
        }

        private void cart_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
