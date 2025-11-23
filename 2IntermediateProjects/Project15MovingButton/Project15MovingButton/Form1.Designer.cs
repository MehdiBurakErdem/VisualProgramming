namespace Project15MovingButton
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
            this.components = new System.ComponentModel.Container();
            this.YakalamaButonu = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.CounterLabel = new System.Windows.Forms.Label();
            this.DirectionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // YakalamaButonu
            // 
            this.YakalamaButonu.Location = new System.Drawing.Point(302, 198);
            this.YakalamaButonu.Name = "YakalamaButonu";
            this.YakalamaButonu.Size = new System.Drawing.Size(181, 71);
            this.YakalamaButonu.TabIndex = 0;
            this.YakalamaButonu.Text = "Yakalama Butonu";
            this.YakalamaButonu.UseVisualStyleBackColor = true;
            this.YakalamaButonu.Click += new System.EventHandler(this.YakalamaButonu_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // CounterLabel
            // 
            this.CounterLabel.AutoSize = true;
            this.CounterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CounterLabel.Location = new System.Drawing.Point(26, 9);
            this.CounterLabel.Name = "CounterLabel";
            this.CounterLabel.Size = new System.Drawing.Size(90, 22);
            this.CounterLabel.TabIndex = 1;
            this.CounterLabel.Text = "Timer: 0 ";
            // 
            // DirectionLabel
            // 
            this.DirectionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DirectionLabel.Location = new System.Drawing.Point(302, 53);
            this.DirectionLabel.Name = "DirectionLabel";
            this.DirectionLabel.Size = new System.Drawing.Size(181, 142);
            this.DirectionLabel.TabIndex = 2;
            this.DirectionLabel.Text = "↓↓↓";
            this.DirectionLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DirectionLabel);
            this.Controls.Add(this.CounterLabel);
            this.Controls.Add(this.YakalamaButonu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button YakalamaButonu;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label CounterLabel;
        private System.Windows.Forms.Label DirectionLabel;
    }
}

