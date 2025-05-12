namespace UI
{
    partial class ProductMenu
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
            display = new TabControl();
            tabPage1 = new TabPage();
            addProduct = new Button();
            catroryBox = new ComboBox();
            textBox4 = new TextBox();
            priceBox = new TextBox();
            quentity = new Label();
            category = new Label();
            price = new Label();
            nameBox = new TextBox();
            name = new Label();
            update = new TabPage();
            changeButten = new Button();
            panel1 = new Panel();
            savaChangeButten = new Button();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            productForChange = new Label();
            productForChangeBox = new TextBox();
            tabPage3 = new TabPage();
            label5 = new Label();
            deleteButten = new Button();
            idDelete = new TextBox();
            tabPage4 = new TabPage();
            showProductBySearch = new ListBox();
            filterButten = new Button();
            filter = new TextBox();
            productName = new TextBox();
            showProducts = new ListBox();
            filterBy = new Label();
            filterByPrice = new CheckBox();
            filterByQuntity = new CheckBox();
            filterBox = new TextBox();
            filterButten2 = new Button();
            display.SuspendLayout();
            tabPage1.SuspendLayout();
            update.SuspendLayout();
            panel1.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            SuspendLayout();
            // 
            // display
            // 
            display.Controls.Add(tabPage1);
            display.Controls.Add(update);
            display.Controls.Add(tabPage3);
            display.Controls.Add(tabPage4);
            display.Location = new Point(53, 29);
            display.Name = "display";
            display.SelectedIndex = 0;
            display.Size = new Size(799, 623);
            display.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(addProduct);
            tabPage1.Controls.Add(catroryBox);
            tabPage1.Controls.Add(textBox4);
            tabPage1.Controls.Add(priceBox);
            tabPage1.Controls.Add(quentity);
            tabPage1.Controls.Add(category);
            tabPage1.Controls.Add(price);
            tabPage1.Controls.Add(nameBox);
            tabPage1.Controls.Add(name);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(791, 590);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "הוספה";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // addProduct
            // 
            addProduct.Location = new Point(219, 262);
            addProduct.Name = "addProduct";
            addProduct.Size = new Size(94, 29);
            addProduct.TabIndex = 11;
            addProduct.Text = "הוסף מוצר";
            addProduct.UseVisualStyleBackColor = true;
            addProduct.Click += button2_Click;
            // 
            // catroryBox
            // 
            catroryBox.FormattingEnabled = true;
            catroryBox.Items.AddRange(new object[] { "Fruits", "Vegetables", "Fish", "Meat", "Dairy ", "", "" });
            catroryBox.Location = new Point(219, 122);
            catroryBox.Name = "catroryBox";
            catroryBox.Size = new Size(132, 28);
            catroryBox.TabIndex = 8;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(226, 167);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 7;
            // 
            // priceBox
            // 
            priceBox.Location = new Point(226, 75);
            priceBox.Name = "priceBox";
            priceBox.Size = new Size(125, 27);
            priceBox.TabIndex = 5;
            // 
            // quentity
            // 
            quentity.AutoSize = true;
            quentity.Location = new Point(396, 167);
            quentity.Name = "quentity";
            quentity.Size = new Size(87, 20);
            quentity.TabIndex = 4;
            quentity.Text = "כמות במלאי";
            // 
            // category
            // 
            category.AutoSize = true;
            category.Location = new Point(396, 125);
            category.Name = "category";
            category.Size = new Size(62, 20);
            category.TabIndex = 3;
            category.Text = "קטגוריה";
            // 
            // price
            // 
            price.AutoSize = true;
            price.Location = new Point(396, 82);
            price.Name = "price";
            price.Size = new Size(41, 20);
            price.TabIndex = 2;
            price.Text = "מחיר";
            // 
            // nameBox
            // 
            nameBox.Location = new Point(219, 27);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(125, 27);
            nameBox.TabIndex = 1;
            // 
            // name
            // 
            name.AutoSize = true;
            name.Location = new Point(396, 34);
            name.Name = "name";
            name.Size = new Size(66, 20);
            name.TabIndex = 0;
            name.Text = "שם מוצר";
            // 
            // update
            // 
            update.Controls.Add(changeButten);
            update.Controls.Add(panel1);
            update.Controls.Add(productForChange);
            update.Controls.Add(productForChangeBox);
            update.Location = new Point(4, 29);
            update.Name = "update";
            update.Padding = new Padding(3);
            update.Size = new Size(791, 590);
            update.TabIndex = 1;
            update.Text = "עדכון";
            update.UseVisualStyleBackColor = true;
            // 
            // changeButten
            // 
            changeButten.Location = new Point(215, 65);
            changeButten.Name = "changeButten";
            changeButten.Size = new Size(94, 29);
            changeButten.TabIndex = 3;
            changeButten.Text = "שינוי";
            changeButten.UseVisualStyleBackColor = true;
            changeButten.Click += button2_Click_1;
            // 
            // panel1
            // 
            panel1.Controls.Add(savaChangeButten);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(79, 115);
            panel1.Name = "panel1";
            panel1.Size = new Size(598, 445);
            panel1.TabIndex = 2;
            // 
            // savaChangeButten
            // 
            savaChangeButten.Location = new Point(52, 231);
            savaChangeButten.Name = "savaChangeButten";
            savaChangeButten.Size = new Size(94, 29);
            savaChangeButten.TabIndex = 31;
            savaChangeButten.Text = "שמור שינויים";
            savaChangeButten.UseVisualStyleBackColor = true;
            savaChangeButten.Click += button2_Click_2;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Fruits", "Vegetables", "Fish", "Meat", "Dairy" });
            comboBox1.Location = new Point(142, 122);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(132, 28);
            comboBox1.TabIndex = 28;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(149, 167);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 27;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(149, 75);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 26;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(319, 167);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 25;
            label1.Text = "כמות במלאי";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(319, 125);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 24;
            label2.Text = "קטגוריה";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(319, 82);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 23;
            label3.Text = "מחיר";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(142, 27);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(319, 34);
            label4.Name = "label4";
            label4.Size = new Size(66, 20);
            label4.TabIndex = 21;
            label4.Text = "שם מוצר";
            // 
            // productForChange
            // 
            productForChange.AutoSize = true;
            productForChange.Location = new Point(340, 26);
            productForChange.Name = "productForChange";
            productForChange.Size = new Size(120, 20);
            productForChange.TabIndex = 1;
            productForChange.Text = "הכנס מוצר לשינוי";
            // 
            // productForChangeBox
            // 
            productForChangeBox.Location = new Point(335, 65);
            productForChangeBox.Name = "productForChangeBox";
            productForChangeBox.Size = new Size(125, 27);
            productForChangeBox.TabIndex = 0;
            productForChangeBox.TextChanged += productForChangeBox_TextChanged;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(label5);
            tabPage3.Controls.Add(deleteButten);
            tabPage3.Controls.Add(idDelete);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(791, 590);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "מחיקה";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(420, 47);
            label5.Name = "label5";
            label5.Size = new Size(135, 20);
            label5.TabIndex = 2;
            label5.Text = "מזהה מוצר למחיקה";
            // 
            // deleteButten
            // 
            deleteButten.Location = new Point(259, 86);
            deleteButten.Name = "deleteButten";
            deleteButten.Size = new Size(94, 29);
            deleteButten.TabIndex = 1;
            deleteButten.Text = "מחק";
            deleteButten.UseVisualStyleBackColor = true;
            deleteButten.Click += deleteButten_Click;
            // 
            // idDelete
            // 
            idDelete.Location = new Point(391, 86);
            idDelete.Name = "idDelete";
            idDelete.Size = new Size(189, 27);
            idDelete.TabIndex = 0;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(showProductBySearch);
            tabPage4.Controls.Add(filterButten);
            tabPage4.Controls.Add(filter);
            tabPage4.Controls.Add(productName);
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(791, 590);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "חיפוש";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // showProductBySearch
            // 
            showProductBySearch.FormattingEnabled = true;
            showProductBySearch.ItemHeight = 20;
            showProductBySearch.Location = new Point(197, 228);
            showProductBySearch.Name = "showProductBySearch";
            showProductBySearch.Size = new Size(347, 164);
            showProductBySearch.TabIndex = 3;
            // 
            // filterButten
            // 
            filterButten.Location = new Point(342, 160);
            filterButten.Name = "filterButten";
            filterButten.Size = new Size(94, 29);
            filterButten.TabIndex = 2;
            filterButten.Text = "סנן";
            filterButten.UseVisualStyleBackColor = true;
            filterButten.Click += filterButten_Click;
            // 
            // filter
            // 
            filter.Location = new Point(329, 102);
            filter.Name = "filter";
            filter.Size = new Size(125, 27);
            filter.TabIndex = 1;
            // 
            // productName
            // 
            productName.Location = new Point(314, 55);
            productName.Name = "productName";
            productName.Size = new Size(173, 27);
            productName.TabIndex = 0;
            productName.Text = "הכנס שם מצור לסינון";
            // 
            // showProducts
            // 
            showProducts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            showProducts.FormattingEnabled = true;
            showProducts.ItemHeight = 20;
            showProducts.Location = new Point(858, 134);
            showProducts.Name = "showProducts";
            showProducts.Size = new Size(470, 484);
            showProducts.TabIndex = 1;
            showProducts.SelectedIndexChanged += showProducts_SelectedIndexChanged;
            // 
            // filterBy
            // 
            filterBy.AutoSize = true;
            filterBy.Location = new Point(991, 29);
            filterBy.Name = "filterBy";
            filterBy.Size = new Size(54, 20);
            filterBy.TabIndex = 2;
            filterBy.Text = "סנן לפי";
            // 
            // filterByPrice
            // 
            filterByPrice.AutoSize = true;
            filterByPrice.Location = new Point(1035, 54);
            filterByPrice.Name = "filterByPrice";
            filterByPrice.Size = new Size(63, 24);
            filterByPrice.TabIndex = 4;
            filterByPrice.Text = "מחיר";
            filterByPrice.UseVisualStyleBackColor = true;
            // 
            // filterByQuntity
            // 
            filterByQuntity.AutoSize = true;
            filterByQuntity.Location = new Point(926, 54);
            filterByQuntity.Name = "filterByQuntity";
            filterByQuntity.Size = new Size(64, 24);
            filterByQuntity.TabIndex = 5;
            filterByQuntity.Text = "כמות";
            filterByQuntity.UseVisualStyleBackColor = true;
            // 
            // filterBox
            // 
            filterBox.Location = new Point(1048, 84);
            filterBox.Name = "filterBox";
            filterBox.Size = new Size(125, 27);
            filterBox.TabIndex = 6;
            filterBox.TextChanged += filterBox_TextChanged;
            filterBox.KeyDown += filterBox_KeyDown;
            // 
            // filterButten2
            // 
            filterButten2.Location = new Point(880, 84);
            filterButten2.Name = "filterButten2";
            filterButten2.Size = new Size(94, 29);
            filterButten2.TabIndex = 7;
            filterButten2.Text = "סנן";
            filterButten2.UseVisualStyleBackColor = true;
            // 
            // ProductMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1398, 776);
            Controls.Add(filterButten2);
            Controls.Add(filterBox);
            Controls.Add(filterByQuntity);
            Controls.Add(filterByPrice);
            Controls.Add(filterBy);
            Controls.Add(showProducts);
            Controls.Add(display);
            Name = "ProductMenu";
            Text = "ProductMenu";
            Load += ProductMenu_Load;
            display.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            update.ResumeLayout(false);
            update.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl display;
        private TabPage tabPage1;
        private TabPage update;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TextBox nameBox;
        private Label name;
        private TextBox textBox4;
        private TextBox priceBox;
        private Label category;
        private Label price;
        private ComboBox catroryBox;
        private Label quentity;
        private ListBox showProducts;
        private Button addProduct;
        private TextBox productForChangeBox;
        private Label productForChange;
        private Panel panel1;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private Button changeButten;
        private Button savaChangeButten;
        private Button deleteButten;
        private TextBox idDelete;
        private Button filterButten;
        private TextBox filter;
        private TextBox productName;
        private ListBox showProductBySearch;
        private Label filterBy;
        private CheckBox filterByPrice;
        private CheckBox filterByQuntity;
        private TextBox filterBox;
        private Button filterButten2;
        private Label label5;
    }
}