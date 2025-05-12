namespace UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {

            customerMenu c = new customerMenu();
            c.Show();
        }

        private void products_Click(object sender, EventArgs e)
        {
            ProductMenu p = new ProductMenu();
            p.Show();
        }

        private void sale_Click(object sender, EventArgs e)
        {
            SaleMenu s = new SaleMenu();
            s.Show();
        }

        private void newOrder_Click(object sender, EventArgs e)
        {
            Club c = new Club();
            c.Show();   
        }
    }
}