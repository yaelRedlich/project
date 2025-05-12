namespace UI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            products = new Button();
            customer = new Button();
            sale = new Button();
            newOrder = new Button();
            SuspendLayout();
            // 
            // products
            // 
            products.Location = new Point(716, 174);
            products.Name = "products";
            products.Size = new Size(127, 88);
            products.TabIndex = 0;
            products.Text = "מוצרים";
            products.UseVisualStyleBackColor = true;
            products.Click += products_Click;
            // 
            // customer
            // 
            customer.Location = new Point(571, 174);
            customer.Name = "customer";
            customer.Size = new Size(120, 88);
            customer.TabIndex = 1;
            customer.Text = "לקוחות";
            customer.UseVisualStyleBackColor = true;
            customer.Click += button2_Click;
            // 
            // sale
            // 
            sale.Location = new Point(405, 174);
            sale.Name = "sale";
            sale.Size = new Size(134, 88);
            sale.TabIndex = 2;
            sale.Text = "מבצעים";
            sale.UseVisualStyleBackColor = true;
            sale.Click += sale_Click;
            // 
            // newOrder
            // 
            newOrder.Location = new Point(106, 401);
            newOrder.Name = "newOrder";
            newOrder.Size = new Size(181, 72);
            newOrder.TabIndex = 3;
            newOrder.Text = "הזמנה חדשה";
            newOrder.UseVisualStyleBackColor = true;
            newOrder.Click += newOrder_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1104, 553);
            Controls.Add(newOrder);
            Controls.Add(sale);
            Controls.Add(customer);
            Controls.Add(products);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button products;
        private Button customer;
        private Button sale;
        private Button newOrder;
    }
}