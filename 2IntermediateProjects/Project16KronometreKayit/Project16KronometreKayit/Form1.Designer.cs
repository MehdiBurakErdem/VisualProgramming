namespace Project16KronometreKayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.KronometreTabPage = new System.Windows.Forms.TabPage();
            this.KronometreLabelText = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ikinoktaLabel1 = new System.Windows.Forms.Label();
            this.SaliseLabelText = new System.Windows.Forms.Label();
            this.SaniyeLabelText = new System.Windows.Forms.Label();
            this.DakikaLabelText = new System.Windows.Forms.Label();
            this.SaatLabelText = new System.Windows.Forms.Label();
            this.SaliseLabel = new System.Windows.Forms.Label();
            this.SaniLabel = new System.Windows.Forms.Label();
            this.DakikaLabel = new System.Windows.Forms.Label();
            this.SaatLabel = new System.Windows.Forms.Label();
            this.PauseButton = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SaveToListButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.RestartButton = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.GeriSayımTabPage = new System.Windows.Forms.TabPage();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.CloseTheAppButton = new System.Windows.Forms.Button();
            this.TimerKronometre = new System.Windows.Forms.Timer(this.components);
            this.SystemSaatLabel = new System.Windows.Forms.Label();
            this.SystemTarihLabel = new System.Windows.Forms.Label();
            this.SystemTimer = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.KronometreTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.KronometreTabPage);
            this.tabControl1.Controls.Add(this.GeriSayımTabPage);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(883, 651);
            this.tabControl1.TabIndex = 0;
            // 
            // KronometreTabPage
            // 
            this.KronometreTabPage.Controls.Add(this.KronometreLabelText);
            this.KronometreTabPage.Controls.Add(this.label2);
            this.KronometreTabPage.Controls.Add(this.label1);
            this.KronometreTabPage.Controls.Add(this.ikinoktaLabel1);
            this.KronometreTabPage.Controls.Add(this.SaliseLabelText);
            this.KronometreTabPage.Controls.Add(this.SaniyeLabelText);
            this.KronometreTabPage.Controls.Add(this.DakikaLabelText);
            this.KronometreTabPage.Controls.Add(this.SaatLabelText);
            this.KronometreTabPage.Controls.Add(this.SaliseLabel);
            this.KronometreTabPage.Controls.Add(this.SaniLabel);
            this.KronometreTabPage.Controls.Add(this.DakikaLabel);
            this.KronometreTabPage.Controls.Add(this.SaatLabel);
            this.KronometreTabPage.Controls.Add(this.PauseButton);
            this.KronometreTabPage.Controls.Add(this.SaveToListButton);
            this.KronometreTabPage.Controls.Add(this.SaveButton);
            this.KronometreTabPage.Controls.Add(this.RestartButton);
            this.KronometreTabPage.Controls.Add(this.StartButton);
            this.KronometreTabPage.Controls.Add(this.listBox1);
            this.KronometreTabPage.Location = new System.Drawing.Point(4, 29);
            this.KronometreTabPage.Name = "KronometreTabPage";
            this.KronometreTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.KronometreTabPage.Size = new System.Drawing.Size(875, 618);
            this.KronometreTabPage.TabIndex = 0;
            this.KronometreTabPage.Text = "Kronometre";
            this.KronometreTabPage.UseVisualStyleBackColor = true;
            this.KronometreTabPage.Click += new System.EventHandler(this.KronometreTabPage_Click);
            // 
            // KronometreLabelText
            // 
            this.KronometreLabelText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KronometreLabelText.Location = new System.Drawing.Point(32, 431);
            this.KronometreLabelText.Name = "KronometreLabelText";
            this.KronometreLabelText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.KronometreLabelText.Size = new System.Drawing.Size(390, 75);
            this.KronometreLabelText.TabIndex = 19;
            this.KronometreLabelText.Text = "Kronometre Uygulaması";
            this.KronometreLabelText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(226, 146);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(25, 33);
            this.label2.TabIndex = 18;
            this.label2.Text = ":";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(333, 146);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(25, 33);
            this.label1.TabIndex = 17;
            this.label1.Text = ":";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ikinoktaLabel1
            // 
            this.ikinoktaLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ikinoktaLabel1.Location = new System.Drawing.Point(112, 146);
            this.ikinoktaLabel1.Name = "ikinoktaLabel1";
            this.ikinoktaLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ikinoktaLabel1.Size = new System.Drawing.Size(25, 33);
            this.ikinoktaLabel1.TabIndex = 16;
            this.ikinoktaLabel1.Text = ":";
            this.ikinoktaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SaliseLabelText
            // 
            this.SaliseLabelText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SaliseLabelText.Location = new System.Drawing.Point(348, 146);
            this.SaliseLabelText.Name = "SaliseLabelText";
            this.SaliseLabelText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SaliseLabelText.Size = new System.Drawing.Size(96, 33);
            this.SaliseLabelText.TabIndex = 15;
            this.SaliseLabelText.Text = "00";
            this.SaliseLabelText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SaliseLabelText.Click += new System.EventHandler(this.SaliseLabelText_Click);
            // 
            // SaniyeLabelText
            // 
            this.SaniyeLabelText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SaniyeLabelText.Location = new System.Drawing.Point(241, 146);
            this.SaniyeLabelText.Name = "SaniyeLabelText";
            this.SaniyeLabelText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SaniyeLabelText.Size = new System.Drawing.Size(96, 33);
            this.SaniyeLabelText.TabIndex = 14;
            this.SaniyeLabelText.Text = "00";
            this.SaniyeLabelText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DakikaLabelText
            // 
            this.DakikaLabelText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DakikaLabelText.Location = new System.Drawing.Point(134, 146);
            this.DakikaLabelText.Name = "DakikaLabelText";
            this.DakikaLabelText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DakikaLabelText.Size = new System.Drawing.Size(96, 33);
            this.DakikaLabelText.TabIndex = 13;
            this.DakikaLabelText.Text = "00";
            this.DakikaLabelText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SaatLabelText
            // 
            this.SaatLabelText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SaatLabelText.Location = new System.Drawing.Point(27, 146);
            this.SaatLabelText.Name = "SaatLabelText";
            this.SaatLabelText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SaatLabelText.Size = new System.Drawing.Size(96, 33);
            this.SaatLabelText.TabIndex = 12;
            this.SaatLabelText.Text = "00";
            this.SaatLabelText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SaliseLabel
            // 
            this.SaliseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SaliseLabel.Location = new System.Drawing.Point(343, 85);
            this.SaliseLabel.Name = "SaliseLabel";
            this.SaliseLabel.Size = new System.Drawing.Size(101, 33);
            this.SaliseLabel.TabIndex = 11;
            this.SaliseLabel.Text = "Salise";
            this.SaliseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SaniLabel
            // 
            this.SaniLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SaniLabel.Location = new System.Drawing.Point(236, 85);
            this.SaniLabel.Name = "SaniLabel";
            this.SaniLabel.Size = new System.Drawing.Size(101, 33);
            this.SaniLabel.TabIndex = 10;
            this.SaniLabel.Text = "Saniye";
            this.SaniLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DakikaLabel
            // 
            this.DakikaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DakikaLabel.Location = new System.Drawing.Point(129, 85);
            this.DakikaLabel.Name = "DakikaLabel";
            this.DakikaLabel.Size = new System.Drawing.Size(101, 33);
            this.DakikaLabel.TabIndex = 9;
            this.DakikaLabel.Text = "Dakika";
            this.DakikaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SaatLabel
            // 
            this.SaatLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SaatLabel.Location = new System.Drawing.Point(22, 85);
            this.SaatLabel.Name = "SaatLabel";
            this.SaatLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SaatLabel.Size = new System.Drawing.Size(101, 33);
            this.SaatLabel.TabIndex = 8;
            this.SaatLabel.Text = "Saat";
            this.SaatLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PauseButton
            // 
            this.PauseButton.ImageKey = "Hopstarter-Button-Button-Pause.256.png";
            this.PauseButton.ImageList = this.ımageList1;
            this.PauseButton.Location = new System.Drawing.Point(140, 212);
            this.PauseButton.Name = "PauseButton";
            this.PauseButton.Size = new System.Drawing.Size(90, 80);
            this.PauseButton.TabIndex = 7;
            this.PauseButton.UseVisualStyleBackColor = true;
            this.PauseButton.Click += new System.EventHandler(this.PauseButton_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "Button-Play-icon.png");
            this.ımageList1.Images.SetKeyName(1, "Custom-Icon-Design-Pretty-Office-8-Stop.256.png");
            this.ımageList1.Images.SetKeyName(2, "Hopstarter-Button-Button-Pause.256.png");
            this.ımageList1.Images.SetKeyName(3, "Hopstarter-Sleek-Xp-Software-Windows-Close-Program.256.png");
            this.ımageList1.Images.SetKeyName(4, "Icojam-Blue-Bits-Arrow-right.256.png");
            this.ımageList1.Images.SetKeyName(5, "replay-icon.png");
            this.ımageList1.Images.SetKeyName(6, "Save-as-icon.png");
            // 
            // SaveToListButton
            // 
            this.SaveToListButton.ImageKey = "Icojam-Blue-Bits-Arrow-right.256.png";
            this.SaveToListButton.ImageList = this.ımageList1;
            this.SaveToListButton.Location = new System.Drawing.Point(506, 75);
            this.SaveToListButton.Name = "SaveToListButton";
            this.SaveToListButton.Size = new System.Drawing.Size(90, 80);
            this.SaveToListButton.TabIndex = 6;
            this.SaveToListButton.UseVisualStyleBackColor = true;
            this.SaveToListButton.Click += new System.EventHandler(this.SaveToListButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.ImageKey = "Save-as-icon.png";
            this.SaveButton.ImageList = this.ımageList1;
            this.SaveButton.Location = new System.Drawing.Point(332, 212);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(90, 80);
            this.SaveButton.TabIndex = 5;
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // RestartButton
            // 
            this.RestartButton.ImageKey = "replay-icon.png";
            this.RestartButton.ImageList = this.ımageList1;
            this.RestartButton.Location = new System.Drawing.Point(236, 212);
            this.RestartButton.Name = "RestartButton";
            this.RestartButton.Size = new System.Drawing.Size(90, 80);
            this.RestartButton.TabIndex = 4;
            this.RestartButton.UseVisualStyleBackColor = true;
            this.RestartButton.Click += new System.EventHandler(this.RestartButton_Click);
            // 
            // StartButton
            // 
            this.StartButton.Cursor = System.Windows.Forms.Cursors.No;
            this.StartButton.ImageKey = "Button-Play-icon.png";
            this.StartButton.ImageList = this.ımageList1;
            this.StartButton.Location = new System.Drawing.Point(44, 212);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(90, 80);
            this.StartButton.TabIndex = 2;
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(602, 75);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(235, 424);
            this.listBox1.TabIndex = 1;
            // 
            // GeriSayımTabPage
            // 
            this.GeriSayımTabPage.Location = new System.Drawing.Point(4, 29);
            this.GeriSayımTabPage.Name = "GeriSayımTabPage";
            this.GeriSayımTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.GeriSayımTabPage.Size = new System.Drawing.Size(875, 618);
            this.GeriSayımTabPage.TabIndex = 1;
            this.GeriSayımTabPage.Text = "GeriSayım";
            this.GeriSayımTabPage.UseVisualStyleBackColor = true;
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // CloseTheAppButton
            // 
            this.CloseTheAppButton.ImageKey = "Hopstarter-Sleek-Xp-Software-Windows-Close-Program.256.png";
            this.CloseTheAppButton.ImageList = this.ımageList1;
            this.CloseTheAppButton.Location = new System.Drawing.Point(770, 668);
            this.CloseTheAppButton.Name = "CloseTheAppButton";
            this.CloseTheAppButton.Size = new System.Drawing.Size(90, 80);
            this.CloseTheAppButton.TabIndex = 7;
            this.CloseTheAppButton.UseVisualStyleBackColor = true;
            this.CloseTheAppButton.Click += new System.EventHandler(this.CloseTheAppButton_Click);
            // 
            // TimerKronometre
            // 
            this.TimerKronometre.Tick += new System.EventHandler(this.TimerKronometre_Tick);
            // 
            // SystemSaatLabel
            // 
            this.SystemSaatLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SystemSaatLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SystemSaatLabel.Location = new System.Drawing.Point(470, 690);
            this.SystemSaatLabel.Name = "SystemSaatLabel";
            this.SystemSaatLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SystemSaatLabel.Size = new System.Drawing.Size(178, 33);
            this.SystemSaatLabel.TabIndex = 20;
            this.SystemSaatLabel.Text = "00:00:00";
            this.SystemSaatLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SystemSaatLabel.Click += new System.EventHandler(this.SystemSaatLabel_Click);
            // 
            // SystemTarihLabel
            // 
            this.SystemTarihLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SystemTarihLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SystemTarihLabel.Location = new System.Drawing.Point(147, 690);
            this.SystemTarihLabel.Name = "SystemTarihLabel";
            this.SystemTarihLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SystemTarihLabel.Size = new System.Drawing.Size(194, 33);
            this.SystemTarihLabel.TabIndex = 21;
            this.SystemTarihLabel.Text = "00.00.00";
            this.SystemTarihLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SystemTarihLabel.Click += new System.EventHandler(this.SystemTarihLabel_Click);
            // 
            // SystemTimer
            // 
            this.SystemTimer.Tick += new System.EventHandler(this.SystemTimer_Tick);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(57, 690);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(84, 33);
            this.label3.TabIndex = 22;
            this.label3.Text = "Tarih:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(398, 690);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(66, 33);
            this.label4.TabIndex = 23;
            this.label4.Text = "Saat:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 760);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SystemTarihLabel);
            this.Controls.Add(this.SystemSaatLabel);
            this.Controls.Add(this.CloseTheAppButton);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.KronometreTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage KronometreTabPage;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TabPage GeriSayımTabPage;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button PauseButton;
        private System.Windows.Forms.Button SaveToListButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button RestartButton;
        private System.Windows.Forms.Button CloseTheAppButton;
        private System.Windows.Forms.Label SaatLabel;
        private System.Windows.Forms.Label SaliseLabel;
        private System.Windows.Forms.Label SaniLabel;
        private System.Windows.Forms.Label DakikaLabel;
        private System.Windows.Forms.Label ikinoktaLabel1;
        private System.Windows.Forms.Label SaliseLabelText;
        private System.Windows.Forms.Label SaniyeLabelText;
        private System.Windows.Forms.Label DakikaLabelText;
        private System.Windows.Forms.Label SaatLabelText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label KronometreLabelText;
        private System.Windows.Forms.Timer TimerKronometre;
        private System.Windows.Forms.Label SystemSaatLabel;
        private System.Windows.Forms.Label SystemTarihLabel;
        private System.Windows.Forms.Timer SystemTimer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

