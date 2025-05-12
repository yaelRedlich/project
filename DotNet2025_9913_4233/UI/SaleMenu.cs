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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UI
{
    public partial class SaleMenu : Form
    {
        private static IBl _bl = Factory.Get();

        public SaleMenu()
        {
            InitializeComponent();
        }

     
        private void addSale_Click(object sender, EventArgs e)
        {
            try
            {
                BO.Sale s = new BO.Sale();

                // בדיקה: האם מזהה מוצר הוא מספר שלם
                if (!int.TryParse(nameBox.Text, out int productId))
                {
                    MessageBox.Show("יש להזין מזהה מוצר מספרי תקין.");
                    return;
                }

                // בדיקה: האם כמות למבצע היא מספר שלם
                if (!int.TryParse(textBox4.Text, out int quantity))
                {
                    MessageBox.Show("יש להזין כמות תקינה.");
                    return;
                }
                if (!double.TryParse(priceBox.Text, out double salePrice))
                {
                    MessageBox.Show("יש להזין מחיר תקין.");
                    return;
                }


                DateTime start = DateTime.Now;
                DateTime end = dateTimeEnd.Value; 

                if (end < start)
                {
                    MessageBox.Show("תאריך סיום המבצע לא יכול להיות לפני היום.");
                    return;
                }
                s._productId = productId;
                s._quantityForSale = quantity;
                s._isForClubMembersOnly = favorite.Checked;
                s._dateStartSale = start;
                s._dateEndSale = end;
                s._salePrice = salePrice;

                _bl.Sale.Create(s);
                MessageBox.Show("המבצע נוסף בהצלחה!");
                fullList(_bl.Sale.ReadAll());
            }
            catch (BlProductIdExist ex)
            {
                MessageBox.Show(ex.Message);

            }
            catch (Exception ex)
            {
                MessageBox.Show("אירעה שגיאה: " + ex.Message);
            }
        }


        private void SaleMenu_Load(object sender, EventArgs e)
        {
            BO.Sale sale1 = new BO.Sale(1, 20, 30, true, new DateTime(2024, 2, 5), new DateTime(2025, 12, 2));
            BO.Sale sale2 = new BO.Sale(2, 20, 30, true, new DateTime(2024, 2, 5), new DateTime(2025, 12, 2));
            BO.Sale sale3 = new BO.Sale(1, 20, 30, true, new DateTime(2024, 2, 5), new DateTime(2025, 12, 2));
            BO.Sale sale4 = new BO.Sale(1, 20, 30, true, new DateTime(2024, 2, 5), new DateTime(2025, 12, 2));
            _bl.Sale.Create(sale1);
            _bl.Sale.Create(sale2);
            _bl.Sale.Create(sale3);
            _bl.Sale.Create(sale4);
            panel1.Visible = false;
            fullList(_bl.Sale.ReadAll());

        }
        public void fullList(List<BO.Sale> s, ListBox l = null)
        {
            if (l == null)
                l = showSale;
            s.ForEach(s =>
            {
                l.Items.Add("מזהה מבצע : " + s.id);
                l.Items.Add("מזהה מוצר: " + s._productId);
                l.Items.Add("מחיר להנחה: " + s._salePrice);

                l.Items.Add("כמות מוצרים המשתתפים במבצע: " + s._quantityForSale);
                l.Items.Add(" ללקוחות במועדון: " + s._isForClubMembersOnly);
                l.Items.Add("תאריך התחלה: " + s._dateStartSale);
                l.Items.Add("תאריך סיום: " + s._dateEndSale);
                l.Items.Add("-------------");
            });
        }

        private void deleteButten_Click(object sender, EventArgs e)
        {
            bool isNumber = int.TryParse(idDelete.Text, out int result);
            MessageBox.Show(result.ToString() + " the num");
            if (!isNumber)
            {
                MessageBox.Show("נא להזין מספר תקין בלבד.", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
                idDelete.Text = string.Empty;
            }
            else
            {
                try
                {
                    _bl.Sale.Delete(result);
                    MessageBox.Show("המבצע נמחק בהצלחה");
                    fullList(_bl.Sale.ReadAll());

                }
                catch (BO.BlNotFoundId)
                {
                    MessageBox.Show("המוצר לא קיים במערכת , אנא הכנס מזהה מוצר תקין");

                }
            }
        }

        private void filterButten_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(filter.Text, out int saleId))
            {
                MessageBox.Show("יש להזין מזהה מוצר מספרי תקין.");
                return;
            }
            BO.Sale s = _bl.Sale.Read((s) => s.id == saleId);
            if (s == null)
            {
                MessageBox.Show("מוצר לא קיים");
            }
            else
            {
                showSaleBySearch.Items.Clear();
                showSaleBySearch.Visible = true;
                showSaleBySearch.Items.Add("מזהה מבצע : " + s.id);
                showSaleBySearch.Items.Add("מזהה מוצר: " + s._productId);
                showSaleBySearch.Items.Add("שם מוצר: " + s._salePrice);
                showSaleBySearch.Items.Add("כמות מוצרים המשתתפים במבצע: " + s._quantityForSale);
                showSaleBySearch.Items.Add(" ללקוחות במועדון: " + s._isForClubMembersOnly);
                showSaleBySearch.Items.Add("תאריך התחלה: " + s._dateStartSale);
                showSaleBySearch.Items.Add("תאריך סיום: " + s._dateEndSale);
                showSaleBySearch.Items.Add("-------------");
            }

        }


        private void changeButten_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            if (!int.TryParse(saleForChangeBox.Text, out int saleId))
            {
                MessageBox.Show("יש להכניס מספר תקין!");
                return;
            }
            try
            {
                BO.Sale s = _bl.Sale.Read(saleId);
                textBox3.Text = s._productId.ToString();
                textBox2.Text = s._salePrice.ToString();
                textBox1.Text = s._quantityForSale.ToString();
                checkBox1.Checked = s._isForClubMembersOnly;
                dateTimePicker2.Value = s._dateStartSale;
                dateTimePicker1.Value = s._dateEndSale;
            }
            catch (BlNotFoundId ex)
            {
                MessageBox.Show("יש להכניס מזהה מבצע תקין");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (!int.TryParse(textBox3.Text, out int productId))
            {
                MessageBox.Show("יש להכניס מספר תקין");
                return;
            }
            if (!int.TryParse(textBox2.Text, out int priceId))
            {
                MessageBox.Show("יש להכניס מספר תקין");
                return;
            }
            if (!int.TryParse(textBox1.Text, out int quantityForSale))
            {
                MessageBox.Show("יש להכניס מספר תקין");
                return;
            }
            try
            {
                BO.Sale s = new BO.Sale();
                s.id = int.Parse(saleForChangeBox.Text);
                s._productId = productId;
                s._salePrice = priceId;
                s._quantityForSale = quantityForSale;
                s._isForClubMembersOnly = checkBox1.Checked;
                s._dateStartSale = dateTimePicker2.Value;
                s._dateEndSale = dateTimePicker1.Value;
                _bl.Sale.Update(s);
                MessageBox.Show("המבצע עודכן בהצלחה");
                fullList(_bl.Sale.ReadAll());
            }
            catch (BlNotFoundId)
            {
                MessageBox.Show("יש להכניס מזהה מבצע תקין");
            }
            catch (BlProductIdExist)
            {
                MessageBox.Show("יש להכניס מזהה מוצר תקין");

            }
        }

       
    }
}
