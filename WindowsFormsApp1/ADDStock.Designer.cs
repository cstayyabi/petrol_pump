
namespace WindowsFormsApp1
{
    partial class ADDStock
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
            this.Date_L_in_ADD_Stock = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.VN_L = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.PL = new System.Windows.Forms.Label();
            this.Quantity_L = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Save_button = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.litter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Date_L_in_ADD_Stock
            // 
            this.Date_L_in_ADD_Stock.AutoSize = true;
            this.Date_L_in_ADD_Stock.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date_L_in_ADD_Stock.Location = new System.Drawing.Point(56, 45);
            this.Date_L_in_ADD_Stock.Name = "Date_L_in_ADD_Stock";
            this.Date_L_in_ADD_Stock.Size = new System.Drawing.Size(49, 23);
            this.Date_L_in_ADD_Stock.TabIndex = 0;
            this.Date_L_in_ADD_Stock.Text = "Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(119, 45);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(282, 26);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // VN_L
            // 
            this.VN_L.AutoSize = true;
            this.VN_L.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VN_L.Location = new System.Drawing.Point(12, 120);
            this.VN_L.Name = "VN_L";
            this.VN_L.Size = new System.Drawing.Size(145, 23);
            this.VN_L.TabIndex = 2;
            this.VN_L.Text = "Vehical Number";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(198, 120);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(187, 31);
            this.textBox1.TabIndex = 3;
            // 
            // PL
            // 
            this.PL.AutoSize = true;
            this.PL.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PL.Location = new System.Drawing.Point(34, 190);
            this.PL.Name = "PL";
            this.PL.Size = new System.Drawing.Size(76, 23);
            this.PL.TabIndex = 4;
            this.PL.Text = "Product";
            // 
            // Quantity_L
            // 
            this.Quantity_L.AutoSize = true;
            this.Quantity_L.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quantity_L.Location = new System.Drawing.Point(34, 273);
            this.Quantity_L.Name = "Quantity_L";
            this.Quantity_L.Size = new System.Drawing.Size(82, 23);
            this.Quantity_L.TabIndex = 6;
            this.Quantity_L.Text = "Quantity";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(177, 270);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(114, 31);
            this.textBox3.TabIndex = 7;
            // 
            // Save_button
            // 
            this.Save_button.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save_button.Location = new System.Drawing.Point(37, 360);
            this.Save_button.Name = "Save_button";
            this.Save_button.Size = new System.Drawing.Size(89, 36);
            this.Save_button.TabIndex = 8;
            this.Save_button.Text = "SAVE";
            this.Save_button.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "HSD",
            "SP",
            "Mobile Oil",
            "Karosin Oil "});
            this.comboBox1.Location = new System.Drawing.Point(177, 190);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 9;
            // 
            // litter
            // 
            this.litter.AutoSize = true;
            this.litter.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.litter.Location = new System.Drawing.Point(300, 279);
            this.litter.Name = "litter";
            this.litter.Size = new System.Drawing.Size(37, 13);
            this.litter.TabIndex = 10;
            this.litter.Text = "Litter";
            this.litter.Click += new System.EventHandler(this.label1_Click);
            // 
            // ADDStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 408);
            this.Controls.Add(this.litter);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Save_button);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.Quantity_L);
            this.Controls.Add(this.PL);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.VN_L);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Date_L_in_ADD_Stock);
            this.Name = "ADDStock";
            this.Text = "ADDStock";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Date_L_in_ADD_Stock;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label VN_L;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label PL;
        private System.Windows.Forms.Label Quantity_L;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button Save_button;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label litter;
    }
}