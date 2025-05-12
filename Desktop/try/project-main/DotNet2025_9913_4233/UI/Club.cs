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
    public partial class Club : Form
    {
        private static IBl _bl = Factory.Get();

        public Club()
        {
            InitializeComponent();
        }


        private void Club_Load(object sender, EventArgs e)
        {
            idNum.Visible = false;
            id.Visible = false;
        }


        private void isFavorite_CheckedChanged(object sender, EventArgs e)
        {
            if (isFavorite.Checked)
            {
                idNum.Visible = true;
                id.Visible = true;
            }
            else
            {
                idNum.Visible = false;
                id.Visible = false;
            }
        }

        private void continuation_Click(object sender, EventArgs e)
        {
            if (!isFavorite.Checked) {
                this.Close();
                newOrder o = new newOrder(new BO.Customer(),new Order(false));
                o.Show();
            }
            else
            {
                bool isNum = int.TryParse(idNum.Text, out int num); 
                try
                {
                    BO.Customer c = _bl.Customer.Read(num);
                    MessageBox.Show(" שלום לקוח " + c._customerName);
                    this.Close();
                    newOrder o = new newOrder(c, new Order(true));
                    o.Show();

                }
               catch (BlNotFoundId ){
                    MessageBox.Show("מצטערים אבל מספר ת.ז. זה אינו מופיע במערכת אנא נסה שנית  או התחבר למועדון");
                    this.Close();
                    newOrder o = new newOrder(new BO.Customer(), new Order(false)  );
                    o.Show();
                }
                   
                }
                
            }
        }
    
}
