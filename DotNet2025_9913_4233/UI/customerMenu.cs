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
    public partial class customerMenu : Form
    {
        private static IBl _bl = Factory.Get();

        public customerMenu()
        {
            InitializeComponent();
        }

        private void addSale_Click(object sender, EventArgs e)
        {
            try
            {
                BO.Customer c = new BO.Customer();
                if (!int.TryParse(idBox.Text, out int idCard))
                {
                    MessageBox.Show("יש להזין  ת.ז. מספרות בלבד.");
                    return;
                }

                c._idCard = idCard;
                c._address = textBox4.Text;
                c._customerName = nameBox.Text;
                c._phone = priceBox.Text;

                _bl.Customer.Create(c);
                MessageBox.Show("הלקוח נוסף בהצלחה!");
                fullList(_bl.Customer.ReadAll());
            }
            catch (BlIdExist )
            {
                MessageBox.Show("מצטערים אבל קיים כבר לקוח במערכת עם ת.ז. הזאת");

            }
            catch (Exception ex)
            {
                MessageBox.Show("אירעה שגיאה: " + ex.Message);
            }
            fullList(_bl.Customer.ReadAll());
        }

        private void customerMenu_Load(object sender, EventArgs e)
        {
            panel1.Visible = false ;
            BO.Customer c1 = new BO.Customer(327804233, "0556747158", "maaril", "yael");
            BO.Customer c2 = new BO.Customer(327804235, "0534161926", "chazon david", "tami");
            BO.Customer c3 = new BO.Customer(327804236, "0556781278", "noda ", "suri");
            _bl.Customer.Create(c1);
            _bl.Customer.Create(c2);
            _bl.Customer.Create(c3);
            fullList(_bl.Customer.ReadAll());


        }
        private void fullList(List<BO.Customer> c)
        {
            showCustomer.Items.Clear();

            c.ForEach(c =>
            {
                showCustomer.Items.Add("ת.ז. : " + c._idCard);
                showCustomer.Items.Add("שם לקוח: " + c._customerName);
                showCustomer.Items.Add("טלפון: " + c._phone);
                showCustomer.Items.Add("כתובת: " + c._address);
                showCustomer.Items.Add("-------------");
            });
        }


        private void deleteButten_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(idDelete.Text, out int IdDelete))
            {
                MessageBox.Show("יש להזין  ת.ז. מספרות בלבד.");
                return;
            }
            try
            {
                _bl.Customer.Delete(IdDelete);
                MessageBox.Show("הלקוח נמחק בהצלחה");
            }
            catch (BlNotFoundId )
            {
                MessageBox.Show("לא קיים לקוח כזה במערכת");
            }
            fullList(_bl.Customer.ReadAll());
        }

 

        private void filterButten_Click(object sender, EventArgs e)
        {
            string CustomerName = filter.Text;
            BO.Customer customer = _bl.Customer.Read((c) => c._customerName == CustomerName);
            if (customer == null)
            {
                MessageBox.Show("הלקוח לא קיים");
            }
            else
            {
                showCustomerBySearch.Items.Clear();
                showCustomerBySearch.Visible = true;
                showCustomerBySearch.Items.Add(" שם לקוח: " + customer._customerName);
                showCustomerBySearch.Items.Add("ת.ז. לקוח : " + customer._customerName);
                showCustomerBySearch.Items.Add("כתובת: " + customer._address);
                showCustomerBySearch.Items.Add("טלפון : " + customer._phone);
                showCustomerBySearch.Items.Add("-------------");
            }
        }


        private void filterBox_TextChanged(object sender, EventArgs e)
        {
            if (filterBox.Text == "")
            {
                fullList(_bl.Customer.ReadAll());

            }
        }
        private void filterBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                List<BO.Customer> tmp = new List<BO.Customer>();
                showCustomer.Items.Clear();

                _bl.Customer.ReadAll((p) => p._address.Contains(filterBox.Text)).ForEach(c =>
                    {
                        tmp.Add(c);
                    });

                fullList(tmp);

            }
        }

        private void savaChangeButten_Click(object sender, EventArgs e)
        {
            Customer c = new Customer();
            bool isNum = int.TryParse(textBox5.Text, out int id);
            if (!isNum)
            {
                MessageBox.Show("יש להכניס ערך מספרי");
                return;
            }
            c._idCard = id;
            c._phone = textBox3.Text;
            c._customerName = textBox1.Text;
            c._address = textBox2.Text;
            try
            {
                _bl.Customer.Update(c);
                MessageBox.Show("הלקוח עודכן בהצלחה");
                fullList(_bl.Customer.ReadAll());
            }
            catch (BlIdExist)
            {
                MessageBox.Show("מצטערים אך קיים כבר לקוח עם מזהה זה");
            }
        }

        private void changeButten_Click(object sender, EventArgs e)
        {
            bool isNum = int.TryParse(customerForChangeBox.Text, out int value);
            if (!isNum)
            {
                MessageBox.Show("יש להכניס ערך מספרי");
                return;
            }
            try
            {
                panel1.Visible = true;
                BO.Customer c = _bl.Customer.Read(value);
                textBox1.Text = c._customerName;
                textBox5.Text = c._idCard + "";
                textBox3.Text = c._phone;
                textBox2.Text = c._address;
            }
            catch (BlNotFoundId)
            {
                MessageBox.Show("מצטערים אך לא מצאנו לקוח עם ת.ז זאת אנא נסה שוב");
                return;
            }
        }

    }
}
