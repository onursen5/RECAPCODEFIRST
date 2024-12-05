namespace WinFormsApp1
{
    partial class ArabaEkleme
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
            lblBrandId = new Label();
            txtBrandId = new TextBox();
            txtColorId = new TextBox();
            lblColorId = new Label();
            txtModelYear = new TextBox();
            lblModelYear = new Label();
            txtDailyPrice = new TextBox();
            lblDailyPrice = new Label();
            txtDescription = new TextBox();
            lblDescription = new Label();
            btnEkle = new Button();
            SuspendLayout();
            // 
            // lblBrandId
            // 
            lblBrandId.AutoSize = true;
            lblBrandId.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblBrandId.Location = new Point(132, 32);
            lblBrandId.Name = "lblBrandId";
            lblBrandId.Size = new Size(82, 21);
            lblBrandId.TabIndex = 0;
            lblBrandId.Text = "Brand Id :";
            // 
            // txtBrandId
            // 
            txtBrandId.Location = new Point(253, 32);
            txtBrandId.Name = "txtBrandId";
            txtBrandId.Size = new Size(187, 23);
            txtBrandId.TabIndex = 1;
            // 
            // txtColorId
            // 
            txtColorId.Location = new Point(253, 98);
            txtColorId.Name = "txtColorId";
            txtColorId.Size = new Size(187, 23);
            txtColorId.TabIndex = 3;
            // 
            // lblColorId
            // 
            lblColorId.AutoSize = true;
            lblColorId.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblColorId.Location = new Point(132, 96);
            lblColorId.Name = "lblColorId";
            lblColorId.Size = new Size(78, 21);
            lblColorId.TabIndex = 2;
            lblColorId.Text = "Color Id :";
            // 
            // txtModelYear
            // 
            txtModelYear.Location = new Point(253, 163);
            txtModelYear.Name = "txtModelYear";
            txtModelYear.Size = new Size(187, 23);
            txtModelYear.TabIndex = 5;
            // 
            // lblModelYear
            // 
            lblModelYear.AutoSize = true;
            lblModelYear.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblModelYear.Location = new Point(120, 161);
            lblModelYear.Name = "lblModelYear";
            lblModelYear.Size = new Size(104, 21);
            lblModelYear.TabIndex = 4;
            lblModelYear.Text = "Model Year :";
            // 
            // txtDailyPrice
            // 
            txtDailyPrice.Location = new Point(253, 218);
            txtDailyPrice.Name = "txtDailyPrice";
            txtDailyPrice.Size = new Size(187, 23);
            txtDailyPrice.TabIndex = 7;
            // 
            // lblDailyPrice
            // 
            lblDailyPrice.AutoSize = true;
            lblDailyPrice.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblDailyPrice.Location = new Point(124, 216);
            lblDailyPrice.Name = "lblDailyPrice";
            lblDailyPrice.Size = new Size(100, 21);
            lblDailyPrice.TabIndex = 6;
            lblDailyPrice.Text = "Daily Price :";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(253, 279);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(187, 23);
            txtDescription.TabIndex = 9;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblDescription.Location = new Point(120, 281);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(106, 21);
            lblDescription.TabIndex = 8;
            lblDescription.Text = "Description :";
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(445, 370);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(75, 23);
            btnEkle.TabIndex = 10;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // ArabaEkleme
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEkle);
            Controls.Add(txtDescription);
            Controls.Add(lblDescription);
            Controls.Add(txtDailyPrice);
            Controls.Add(lblDailyPrice);
            Controls.Add(txtModelYear);
            Controls.Add(lblModelYear);
            Controls.Add(txtColorId);
            Controls.Add(lblColorId);
            Controls.Add(txtBrandId);
            Controls.Add(lblBrandId);
            Name = "ArabaEkleme";
            Text = "ArabaEkleme";
            Load += ArabaEkleme_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBrandId;
        private TextBox txtBrandId;
        private TextBox txtColorId;
        private Label lblColorId;
        private TextBox txtModelYear;
        private Label lblModelYear;
        private TextBox txtDailyPrice;
        private Label lblDailyPrice;
        private TextBox txtDescription;
        private Label lblDescription;
        private Button btnEkle;
    }
}