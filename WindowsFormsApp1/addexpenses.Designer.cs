
namespace WindowsFormsApp1
{
    partial class addexpenses
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
            this.Save_button = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.AM_L = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ET_L = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Date_L_in_ADD_Stock = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Save_button
            // 
            this.Save_button.Location = new System.Drawing.Point(95, 342);
            this.Save_button.Name = "Save_button";
            this.Save_button.Size = new System.Drawing.Size(89, 36);
            this.Save_button.TabIndex = 24;
            this.Save_button.Text = "SAVE";
            this.Save_button.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(256, 237);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(114, 31);
            this.textBox2.TabIndex = 23;
            // 
            // AM_L
            // 
            this.AM_L.AutoSize = true;
            this.AM_L.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AM_L.Location = new System.Drawing.Point(92, 238);
            this.AM_L.Name = "AM_L";
            this.AM_L.Size = new System.Drawing.Size(85, 25);
            this.AM_L.TabIndex = 22;
            this.AM_L.Text = "Amount";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(256, 133);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(187, 31);
            this.textBox1.TabIndex = 21;
            // 
            // ET_L
            // 
            this.ET_L.AutoSize = true;
            this.ET_L.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ET_L.Location = new System.Drawing.Point(70, 133);
            this.ET_L.Name = "ET_L";
            this.ET_L.Size = new System.Drawing.Size(138, 25);
            this.ET_L.TabIndex = 20;
            this.ET_L.Text = "Expens Type";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(177, 27);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(282, 26);
            this.dateTimePicker1.TabIndex = 19;
            // 
            // Date_L_in_ADD_Stock
            // 
            this.Date_L_in_ADD_Stock.AutoSize = true;
            this.Date_L_in_ADD_Stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date_L_in_ADD_Stock.Location = new System.Drawing.Point(114, 27);
            this.Date_L_in_ADD_Stock.Name = "Date_L_in_ADD_Stock";
            this.Date_L_in_ADD_Stock.Size = new System.Drawing.Size(57, 25);
            this.Date_L_in_ADD_Stock.TabIndex = 18;
            this.Date_L_in_ADD_Stock.Text = "Date";
            this.Date_L_in_ADD_Stock.Click += new System.EventHandler(this.Date_L_in_ADD_Stock_Click);
            // 
            // addexpenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 405);
            this.Controls.Add(this.Save_button);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.AM_L);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ET_L);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Date_L_in_ADD_Stock);
            this.Name = "addexpenses";
            this.Text = "addexpenses";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Save_button;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label AM_L;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label ET_L;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label Date_L_in_ADD_Stock;
    }
}