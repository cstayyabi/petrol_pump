
namespace WindowsFormsApp1
{
    partial class addemploy
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
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.mp = new System.Windows.Forms.Label();
            this.position = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.name_e = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.jd = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Save_button
            // 
            this.Save_button.Location = new System.Drawing.Point(55, 365);
            this.Save_button.Name = "Save_button";
            this.Save_button.Size = new System.Drawing.Size(89, 36);
            this.Save_button.TabIndex = 17;
            this.Save_button.Text = "SAVE";
            this.Save_button.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(195, 275);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(114, 31);
            this.textBox3.TabIndex = 16;
            // 
            // mp
            // 
            this.mp.AutoSize = true;
            this.mp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mp.Location = new System.Drawing.Point(15, 278);
            this.mp.Name = "mp";
            this.mp.Size = new System.Drawing.Size(129, 25);
            this.mp.TabIndex = 15;
            this.mp.Text = "Monthly pay";
            // 
            // position
            // 
            this.position.AutoSize = true;
            this.position.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.position.Location = new System.Drawing.Point(15, 194);
            this.position.Name = "position";
            this.position.Size = new System.Drawing.Size(89, 25);
            this.position.TabIndex = 13;
            this.position.Text = "Position";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(216, 125);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(187, 31);
            this.textBox1.TabIndex = 12;
            // 
            // name_e
            // 
            this.name_e.AutoSize = true;
            this.name_e.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_e.Location = new System.Drawing.Point(24, 125);
            this.name_e.Name = "name_e";
            this.name_e.Size = new System.Drawing.Size(80, 25);
            this.name_e.TabIndex = 11;
            this.name_e.Text = "Name  ";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(137, 50);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(253, 26);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // jd
            // 
            this.jd.AutoSize = true;
            this.jd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jd.Location = new System.Drawing.Point(6, 50);
            this.jd.Name = "jd";
            this.jd.Size = new System.Drawing.Size(132, 25);
            this.jd.TabIndex = 9;
            this.jd.Text = "Joining Date";
            // 
            // comboBox1
            // 
            this.comboBox1.DisplayMember = "sale man";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "SaleMan",
            "Accountant",
            "Guard"});
            this.comboBox1.Location = new System.Drawing.Point(216, 191);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(148, 28);
            this.comboBox1.TabIndex = 18;
            // 
            // addemploy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 432);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Save_button);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.mp);
            this.Controls.Add(this.position);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.name_e);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.jd);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "addemploy";
            this.Text = "addemploy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Save_button;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label mp;
        private System.Windows.Forms.Label position;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label name_e;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label jd;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}