
namespace WindowsFormsApp1
{
    partial class employaccount
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
            this.addemploybutton = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // addemploybutton
            // 
            this.addemploybutton.Location = new System.Drawing.Point(49, 56);
            this.addemploybutton.Name = "addemploybutton";
            this.addemploybutton.Size = new System.Drawing.Size(105, 47);
            this.addemploybutton.TabIndex = 0;
            this.addemploybutton.Text = "ADD Employ";
            this.addemploybutton.UseVisualStyleBackColor = true;
            this.addemploybutton.Click += new System.EventHandler(this.addemploybutton_Click);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(1, 3);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 1;
            this.back.Text = "<-Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 175);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(776, 263);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // employaccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.back);
            this.Controls.Add(this.addemploybutton);
            this.Name = "employaccount";
            this.Text = "employaccount";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addemploybutton;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}