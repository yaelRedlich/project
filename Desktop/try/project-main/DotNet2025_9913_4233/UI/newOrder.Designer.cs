namespace UI
{
    partial class newOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            productOrder = new Label();
            textBox1 = new TextBox();
            selectFromList = new Button();
            countForOrderUpDown = new NumericUpDown();
            countForOrder = new Label();
            addToOrder = new Button();
            cart = new ListBox();
            splitter1 = new Splitter();
            showProducts = new ListBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)countForOrderUpDown).BeginInit();
            SuspendLayout();
            // 
            // productOrder
            // 
            productOrder.AutoSize = true;
            productOrder.Location = new Point(676, 58);
            productOrder.Name = "productOrder";
            productOrder.Size = new Size(65, 20);
            productOrder.TabIndex = 0;
            productOrder.Text = "קוד מוצר";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(475, 55);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 1;
            // 
            // selectFromList
            // 
            selectFromList.Location = new Point(475, 104);
            selectFromList.Name = "selectFromList";
            selectFromList.Size = new Size(203, 34);
            selectFromList.TabIndex = 2;
            selectFromList.Text = "בחירה מתוך רשימה";
            selectFromList.UseVisualStyleBackColor = true;
            selectFromList.Click += selectFromList_Click;
            // 
            // countForOrderUpDown
            // 
            countForOrderUpDown.Location = new Point(475, 166);
            countForOrderUpDown.Name = "countForOrderUpDown";
            countForOrderUpDown.Size = new Size(157, 27);
            countForOrderUpDown.TabIndex = 3;
            // 
            // countForOrder
            // 
            countForOrder.AutoSize = true;
            countForOrder.Location = new Point(656, 173);
            countForOrder.Name = "countForOrder";
            countForOrder.Size = new Size(95, 20);
            countForOrder.TabIndex = 4;
            countForOrder.Text = "כמות להזמנה";
            // 
            // addToOrder
            // 
            addToOrder.Location = new Point(475, 218);
            addToOrder.Name = "addToOrder";
            addToOrder.Size = new Size(150, 29);
            addToOrder.TabIndex = 5;
            addToOrder.Text = "הוסף להזמנה";
            addToOrder.UseVisualStyleBackColor = true;
            addToOrder.Click += addToOrder_Click;
            // 
            // cart
            // 
            cart.FormattingEnabled = true;
            cart.ItemHeight = 20;
            cart.Location = new Point(52, 58);
            cart.Name = "cart";
            cart.Size = new Size(304, 324);
            cart.TabIndex = 6;
            cart.SelectedIndexChanged += cart_SelectedIndexChanged;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(4, 712);
            splitter1.TabIndex = 7;
            splitter1.TabStop = false;
            // 
            // showProducts
            // 
            showProducts.FormattingEnabled = true;
            showProducts.ItemHeight = 20;
            showProducts.Location = new Point(475, 297);
            showProducts.Name = "showProducts";
            showProducts.Size = new Size(242, 184);
            showProducts.TabIndex = 8;
            showProducts.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(68, 456);
            button1.Name = "button1";
            button1.Size = new Size(172, 79);
            button1.TabIndex = 9;
            button1.Text = "לתשלום";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // newOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1303, 712);
            Controls.Add(button1);
            Controls.Add(showProducts);
            Controls.Add(splitter1);
            Controls.Add(cart);
            Controls.Add(addToOrder);
            Controls.Add(countForOrder);
            Controls.Add(countForOrderUpDown);
            Controls.Add(selectFromList);
            Controls.Add(textBox1);
            Controls.Add(productOrder);
            Name = "newOrder";
            Text = "newOrder";
            Load += newOrder_Load;
            ((System.ComponentModel.ISupportInitialize)countForOrderUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label productOrder;
        private TextBox textBox1;
        private Button selectFromList;
        private NumericUpDown countForOrderUpDown;
        private Label countForOrder;
        private Button addToOrder;
        private ListBox cart;
        private Splitter splitter1;
        private ListBox showProducts;
        private Button button1;
    }
}