namespace UI
{
    partial class customerMenu
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
            showCustomer = new ListBox();
            display = new TabControl();
            tabPage1 = new TabPage();
            nameBox = new TextBox();
            nameCustomer = new Label();
            addCustomer = new Button();
            textBox4 = new TextBox();
            priceBox = new TextBox();
            address = new Label();
            phone = new Label();
            idBox = new TextBox();
            idProduct = new Label();
            update = new TabPage();
            idCustomerInput = new Label();
            changeButten = new Button();
            panel1 = new Panel();
            textBox1 = new TextBox();
            label1 = new Label();
            savaChangeButten = new Button();
            textBox2 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            textBox5 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            productForChange = new Label();
            customerForChangeBox = new TextBox();
            delete = new TabPage();
            deleteButten = new Button();
            idDelete = new TextBox();
            tabPage4 = new TabPage();
            showCustomerBySearch = new ListBox();
            filterButten = new Button();
            filter = new TextBox();
            customerName = new TextBox();
            filterBox = new TextBox();
            filterByAddress = new Label();
            display.SuspendLayout();
            tabPage1.SuspendLayout();
            update.SuspendLayout();
            panel1.SuspendLayout();
            delete.SuspendLayout();
            tabPage4.SuspendLayout();
            SuspendLayout();
            // 
            // showCustomer
            // 
            showCustomer.FormattingEnabled = true;
            showCustomer.ItemHeight = 20;
            showCustomer.Location = new Point(816, 159);
            showCustomer.Name = "showCustomer";
            showCustomer.Size = new Size(261, 364);
            showCustomer.TabIndex = 3;
          
            // 
            // display
            // 
            display.Controls.Add(tabPage1);
            display.Controls.Add(update);
            display.Controls.Add(delete);
            display.Controls.Add(tabPage4);
            display.Location = new Point(66, 40);
            display.Name = "display";
            display.SelectedIndex = 0;
            display.Size = new Size(664, 511);
            display.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(nameBox);
            tabPage1.Controls.Add(nameCustomer);
            tabPage1.Controls.Add(addCustomer);
            tabPage1.Controls.Add(textBox4);
            tabPage1.Controls.Add(priceBox);
            tabPage1.Controls.Add(address);
            tabPage1.Controls.Add(phone);
            tabPage1.Controls.Add(idBox);
            tabPage1.Controls.Add(idProduct);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(656, 478);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "הוספה";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // nameBox
            // 
            nameBox.Location = new Point(169, 52);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(125, 27);
            nameBox.TabIndex = 26;
            
            // 
            // nameCustomer
            // 
            nameCustomer.AutoSize = true;
            nameCustomer.Location = new Point(342, 55);
            nameCustomer.Name = "nameCustomer";
            nameCustomer.Size = new Size(67, 20);
            nameCustomer.TabIndex = 25;
            nameCustomer.Text = "שם לקוח";
            // 
            // addCustomer
            // 
            addCustomer.Location = new Point(169, 229);
            addCustomer.Name = "addCustomer";
            addCustomer.Size = new Size(94, 29);
            addCustomer.TabIndex = 22;
            addCustomer.Text = "הוסף לקוח";
            addCustomer.UseVisualStyleBackColor = true;
            addCustomer.Click += addSale_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(169, 171);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 18;
            // 
            // priceBox
            // 
            priceBox.Location = new Point(169, 126);
            priceBox.Name = "priceBox";
            priceBox.Size = new Size(125, 27);
            priceBox.TabIndex = 17;
            // 
            // address
            // 
            address.AutoSize = true;
            address.Location = new Point(342, 174);
            address.Name = "address";
            address.Size = new Size(56, 20);
            address.TabIndex = 16;
            address.Text = "כתובת ";
            // 
            // phone
            // 
            phone.AutoSize = true;
            phone.Location = new Point(342, 129);
            phone.Name = "phone";
            phone.Size = new Size(44, 20);
            phone.TabIndex = 14;
            phone.Text = "טלפון";
            // 
            // idBox
            // 
            idBox.Location = new Point(169, 85);
            idBox.Name = "idBox";
            idBox.Size = new Size(125, 27);
            idBox.TabIndex = 13;
      
            // 
            // idProduct
            // 
            idProduct.AutoSize = true;
            idProduct.Location = new Point(342, 88);
            idProduct.Name = "idProduct";
            idProduct.Size = new Size(31, 20);
            idProduct.TabIndex = 12;
            idProduct.Text = "ת.ז.";
            // 
            // update
            // 
            update.Controls.Add(idCustomerInput);
            update.Controls.Add(changeButten);
            update.Controls.Add(panel1);
            update.Controls.Add(productForChange);
            update.Controls.Add(customerForChangeBox);
            update.Location = new Point(4, 29);
            update.Name = "update";
            update.Padding = new Padding(3);
            update.Size = new Size(656, 478);
            update.TabIndex = 1;
            update.Text = "עדכון";
            update.UseVisualStyleBackColor = true;
            // 
            // idCustomerInput
            // 
            idCustomerInput.AutoSize = true;
            idCustomerInput.Location = new Point(407, 44);
            idCustomerInput.Name = "idCustomerInput";
            idCustomerInput.Size = new Size(66, 20);
            idCustomerInput.TabIndex = 8;
            idCustomerInput.Text = "הכנס ת.ז";
            // 
            // changeButten
            // 
            changeButten.Location = new Point(192, 90);
            changeButten.Name = "changeButten";
            changeButten.Size = new Size(94, 39);
            changeButten.TabIndex = 7;
            changeButten.Text = "שינוי";
            changeButten.UseVisualStyleBackColor = true;
            changeButten.Click += changeButten_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(savaChangeButten);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox5);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(29, 156);
            panel1.Name = "panel1";
            panel1.Size = new Size(598, 350);
            panel1.TabIndex = 6;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(214, 28);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 34;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(387, 31);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 33;
            label1.Text = "שם לקוח";
            // 
            // savaChangeButten
            // 
            savaChangeButten.Location = new Point(52, 231);
            savaChangeButten.Name = "savaChangeButten";
            savaChangeButten.Size = new Size(94, 29);
            savaChangeButten.TabIndex = 31;
            savaChangeButten.Text = "שמור שינויים";
            savaChangeButten.UseVisualStyleBackColor = true;
            savaChangeButten.Click += savaChangeButten_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(214, 147);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 32;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(387, 64);
            label4.Name = "label4";
            label4.Size = new Size(31, 20);
            label4.TabIndex = 27;
            label4.Text = "ת.ז.";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(214, 102);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 31;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(214, 61);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(125, 27);
            textBox5.TabIndex = 28;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(387, 150);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 30;
            label2.Text = "כתובת ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(387, 105);
            label3.Name = "label3";
            label3.Size = new Size(44, 20);
            label3.TabIndex = 29;
            label3.Text = "טלפון";
            // 
            // productForChange
            // 
            productForChange.AutoSize = true;
            productForChange.Location = new Point(290, -28);
            productForChange.Name = "productForChange";
            productForChange.Size = new Size(120, 20);
            productForChange.TabIndex = 5;
            productForChange.Text = "הכנס מוצר לשינוי";
            // 
            // customerForChangeBox
            // 
            customerForChangeBox.Location = new Point(348, 90);
            customerForChangeBox.Name = "customerForChangeBox";
            customerForChangeBox.Size = new Size(125, 27);
            customerForChangeBox.TabIndex = 4;
            // 
            // delete
            // 
            delete.Controls.Add(deleteButten);
            delete.Controls.Add(idDelete);
            delete.Location = new Point(4, 29);
            delete.Name = "delete";
            delete.Padding = new Padding(3);
            delete.Size = new Size(656, 478);
            delete.TabIndex = 2;
            delete.Text = "מחיקה";
            delete.UseVisualStyleBackColor = true;
            // 
            // deleteButten
            // 
            deleteButten.Location = new Point(142, 83);
            deleteButten.Name = "deleteButten";
            deleteButten.Size = new Size(94, 29);
            deleteButten.TabIndex = 3;
            deleteButten.Text = "מחק";
            deleteButten.UseVisualStyleBackColor = true;
            deleteButten.Click += deleteButten_Click;
            // 
            // idDelete
            // 
            idDelete.Location = new Point(259, 83);
            idDelete.Name = "idDelete";
            idDelete.Size = new Size(189, 27);
            idDelete.TabIndex = 2;
            idDelete.Text = "ת.ז. לקוח למחיקה";
       
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(showCustomerBySearch);
            tabPage4.Controls.Add(filterButten);
            tabPage4.Controls.Add(filter);
            tabPage4.Controls.Add(customerName);
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(656, 478);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "חיפוש";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // showCustomerBySearch
            // 
            showCustomerBySearch.FormattingEnabled = true;
            showCustomerBySearch.ItemHeight = 20;
            showCustomerBySearch.Location = new Point(153, 172);
            showCustomerBySearch.Name = "showCustomerBySearch";
            showCustomerBySearch.Size = new Size(347, 164);
            showCustomerBySearch.TabIndex = 7;
            // 
            // filterButten
            // 
            filterButten.Location = new Point(266, 115);
            filterButten.Name = "filterButten";
            filterButten.Size = new Size(94, 29);
            filterButten.TabIndex = 6;
            filterButten.Text = "סנן";
            filterButten.UseVisualStyleBackColor = true;
            filterButten.Click += filterButten_Click;
            // 
            // filter
            // 
            filter.Location = new Point(253, 57);
            filter.Name = "filter";
            filter.Size = new Size(125, 27);
            filter.TabIndex = 5;
            // 
            // customerName
            // 
            customerName.Location = new Point(238, 10);
            customerName.Name = "customerName";
            customerName.Size = new Size(173, 27);
            customerName.TabIndex = 4;
            customerName.Text = "הכנס שם לקוח";
            // 
            // filterBox
            // 
            filterBox.Location = new Point(894, 113);
            filterBox.Name = "filterBox";
            filterBox.Size = new Size(125, 27);
            filterBox.TabIndex = 8;
            filterBox.TextChanged += filterBox_TextChanged;
            filterBox.KeyDown += filterBox_KeyDown;
            // 
            // filterByAddress
            // 
            filterByAddress.AutoSize = true;
            filterByAddress.Location = new Point(894, 76);
            filterByAddress.Name = "filterByAddress";
            filterByAddress.Size = new Size(101, 20);
            filterByAddress.TabIndex = 9;
            filterByAddress.Text = "סנן לפי כתובת";
            // 
            // customerMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1211, 650);
            Controls.Add(filterByAddress);
            Controls.Add(filterBox);
            Controls.Add(showCustomer);
            Controls.Add(display);
            Name = "customerMenu";
            Text = "customerMenu";
            Load += customerMenu_Load;
            display.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            update.ResumeLayout(false);
            update.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            delete.ResumeLayout(false);
            delete.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox showCustomer;
        private TabControl display;
        private TabPage tabPage1;
        private Button addCustomer;
        private TabPage update;
        private TabPage delete;
        private Button deleteButten;
        private TextBox idDelete;
        private TabPage tabPage4;
        private ListBox showCustomerBySearch;
        private Button filterButten;
        private TextBox filter;
        private TextBox customerName;
        private TextBox nameBox;
        private Label nameCustomer;
        private TextBox textBox4;
        private TextBox priceBox;
        private Label address;
        private Label phone;
        private TextBox idBox;
        private Label idProduct;
        private TextBox filterBox;
        private Label filterByAddress;
        private Label idCustomerInput;
        private Button changeButten;
        private Panel panel1;
        private Button savaChangeButten;
        private Label productForChange;
        private TextBox customerForChangeBox;
        private TextBox textBox1;
        private Label label1;
        private TextBox textBox2;
        private Label label4;
        private TextBox textBox3;
        private TextBox textBox5;
        private Label label2;
        private Label label3;
    }
}