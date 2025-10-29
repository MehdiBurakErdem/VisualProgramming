namespace Project12AlinacakListesi
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.WritetoListBox = new System.Windows.Forms.Button();
            this.DeletetoListBox = new System.Windows.Forms.Button();
            this.DeletetoComboBox = new System.Windows.Forms.Button();
            this.WritetoComboBox = new System.Windows.Forms.Button();
            this.ComboBoxToListBox = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "TextBox";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(106, 63);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(189, 26);
            this.textBox1.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(486, 63);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(170, 28);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(367, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "ComboBox";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 22;
            this.listBox1.Location = new System.Drawing.Point(397, 195);
            this.listBox1.Name = "listBox1";
            this.listBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listBox1.Size = new System.Drawing.Size(186, 334);
            this.listBox1.TabIndex = 4;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(396, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "ListBox";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WritetoListBox
            // 
            this.WritetoListBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.WritetoListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.WritetoListBox.Location = new System.Drawing.Point(106, 122);
            this.WritetoListBox.Name = "WritetoListBox";
            this.WritetoListBox.Size = new System.Drawing.Size(174, 44);
            this.WritetoListBox.TabIndex = 6;
            this.WritetoListBox.Text = "Write to ListBox";
            this.WritetoListBox.UseVisualStyleBackColor = false;
            this.WritetoListBox.Click += new System.EventHandler(this.WritetoListBox_Click);
            // 
            // DeletetoListBox
            // 
            this.DeletetoListBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.DeletetoListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DeletetoListBox.Location = new System.Drawing.Point(106, 181);
            this.DeletetoListBox.Name = "DeletetoListBox";
            this.DeletetoListBox.Size = new System.Drawing.Size(174, 44);
            this.DeletetoListBox.TabIndex = 8;
            this.DeletetoListBox.Text = "Delete to ListBox";
            this.DeletetoListBox.UseVisualStyleBackColor = false;
            this.DeletetoListBox.Click += new System.EventHandler(this.DeletetoListBox_Click);
            // 
            // DeletetoComboBox
            // 
            this.DeletetoComboBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.DeletetoComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DeletetoComboBox.Location = new System.Drawing.Point(106, 383);
            this.DeletetoComboBox.Name = "DeletetoComboBox";
            this.DeletetoComboBox.Size = new System.Drawing.Size(189, 45);
            this.DeletetoComboBox.TabIndex = 11;
            this.DeletetoComboBox.Text = "Delete to ComboBox";
            this.DeletetoComboBox.UseVisualStyleBackColor = false;
            this.DeletetoComboBox.Click += new System.EventHandler(this.DeletetoComboBox_Click);
            // 
            // WritetoComboBox
            // 
            this.WritetoComboBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.WritetoComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.WritetoComboBox.Location = new System.Drawing.Point(106, 318);
            this.WritetoComboBox.Name = "WritetoComboBox";
            this.WritetoComboBox.Size = new System.Drawing.Size(189, 45);
            this.WritetoComboBox.TabIndex = 10;
            this.WritetoComboBox.Text = "Write to ComboBox";
            this.WritetoComboBox.UseVisualStyleBackColor = false;
            this.WritetoComboBox.Click += new System.EventHandler(this.WritetoComboBox_Click);
            // 
            // ComboBoxToListBox
            // 
            this.ComboBoxToListBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ComboBoxToListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ComboBoxToListBox.Location = new System.Drawing.Point(367, 97);
            this.ComboBoxToListBox.Name = "ComboBoxToListBox";
            this.ComboBoxToListBox.Size = new System.Drawing.Size(289, 38);
            this.ComboBoxToListBox.TabIndex = 12;
            this.ComboBoxToListBox.Text = "ComboBox To ListBox";
            this.ComboBoxToListBox.UseVisualStyleBackColor = false;
            this.ComboBoxToListBox.Click += new System.EventHandler(this.ComboBoxToListBox_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(809, 603);
            this.Controls.Add(this.ComboBoxToListBox);
            this.Controls.Add(this.DeletetoComboBox);
            this.Controls.Add(this.WritetoComboBox);
            this.Controls.Add(this.DeletetoListBox);
            this.Controls.Add(this.WritetoListBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button WritetoListBox;
        private System.Windows.Forms.Button DeletetoListBox;
        private System.Windows.Forms.Button DeletetoComboBox;
        private System.Windows.Forms.Button WritetoComboBox;
        private System.Windows.Forms.Button ComboBoxToListBox;
    }
}

