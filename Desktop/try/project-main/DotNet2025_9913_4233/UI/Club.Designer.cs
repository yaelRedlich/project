namespace UI
{
    partial class Club
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
            isFavorite = new CheckBox();
            continuation = new Button();
            id = new Label();
            idNum = new TextBox();
            SuspendLayout();
            // 
            // isFavorite
            // 
            isFavorite.AutoSize = true;
            isFavorite.Location = new Point(390, 73);
            isFavorite.Name = "isFavorite";
            isFavorite.Size = new Size(176, 24);
            isFavorite.TabIndex = 0;
            isFavorite.Text = "האם אתה חבר מועדון?";
            isFavorite.UseVisualStyleBackColor = true;
            isFavorite.CheckedChanged += isFavorite_CheckedChanged;
            // 
            // continuation
            // 
            continuation.Location = new Point(401, 180);
            continuation.Name = "continuation";
            continuation.Size = new Size(94, 34);
            continuation.TabIndex = 1;
            continuation.Text = "המשך";
            continuation.UseVisualStyleBackColor = true;
            continuation.Click += continuation_Click;
            // 
            // id
            // 
            id.AutoSize = true;
            id.Location = new Point(467, 118);
            id.Name = "id";
            id.Size = new Size(99, 20);
            id.TabIndex = 2;
            id.Text = "אנא הכנס ת.ז.";
   
            // 
            // idNum
            // 
            idNum.Location = new Point(309, 118);
            idNum.Name = "idNum";
            idNum.Size = new Size(125, 27);
            idNum.TabIndex = 3;
         
            // 
            // Club
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(idNum);
            Controls.Add(id);
            Controls.Add(continuation);
            Controls.Add(isFavorite);
            Name = "Club";
            Text = "Club";
            Load += Club_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox isFavorite;
        private Button continuation;
        private Label id;
        private TextBox idNum;
    }
}