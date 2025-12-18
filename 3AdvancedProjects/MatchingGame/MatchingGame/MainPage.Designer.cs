namespace MatchingGame
{
    partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.StartButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.InformationText = new System.Windows.Forms.Label();
            this.UsersChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.LogOutButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuButton1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.UsersChart)).BeginInit();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.AllowAnimations = true;
            this.StartButton.AllowMouseEffects = true;
            this.StartButton.AllowToggling = false;
            this.StartButton.AnimationSpeed = 200;
            this.StartButton.AutoGenerateColors = false;
            this.StartButton.AutoRoundBorders = false;
            this.StartButton.AutoSizeLeftIcon = true;
            this.StartButton.AutoSizeRightIcon = true;
            this.StartButton.BackColor = System.Drawing.Color.Transparent;
            this.StartButton.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.StartButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("StartButton.BackgroundImage")));
            this.StartButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.StartButton.ButtonText = "Start";
            this.StartButton.ButtonTextMarginLeft = 0;
            this.StartButton.ColorContrastOnClick = 45;
            this.StartButton.ColorContrastOnHover = 45;
            this.StartButton.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.StartButton.CustomizableEdges = borderEdges1;
            this.StartButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.StartButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.StartButton.DisabledFillColor = System.Drawing.Color.Empty;
            this.StartButton.DisabledForecolor = System.Drawing.Color.Empty;
            this.StartButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.StartButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.StartButton.ForeColor = System.Drawing.Color.White;
            this.StartButton.IconLeft = null;
            this.StartButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StartButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.StartButton.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.StartButton.IconMarginLeft = 11;
            this.StartButton.IconPadding = 10;
            this.StartButton.IconRight = null;
            this.StartButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.StartButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.StartButton.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.StartButton.IconSize = 25;
            this.StartButton.IdleBorderColor = System.Drawing.Color.Empty;
            this.StartButton.IdleBorderRadius = 0;
            this.StartButton.IdleBorderThickness = 0;
            this.StartButton.IdleFillColor = System.Drawing.Color.Empty;
            this.StartButton.IdleIconLeftImage = null;
            this.StartButton.IdleIconRightImage = null;
            this.StartButton.IndicateFocus = false;
            this.StartButton.Location = new System.Drawing.Point(377, 329);
            this.StartButton.Name = "StartButton";
            this.StartButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.StartButton.OnDisabledState.BorderRadius = 1;
            this.StartButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.StartButton.OnDisabledState.BorderThickness = 1;
            this.StartButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.StartButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.StartButton.OnDisabledState.IconLeftImage = null;
            this.StartButton.OnDisabledState.IconRightImage = null;
            this.StartButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.StartButton.onHoverState.BorderRadius = 1;
            this.StartButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.StartButton.onHoverState.BorderThickness = 1;
            this.StartButton.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.StartButton.onHoverState.ForeColor = System.Drawing.Color.White;
            this.StartButton.onHoverState.IconLeftImage = null;
            this.StartButton.onHoverState.IconRightImage = null;
            this.StartButton.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.StartButton.OnIdleState.BorderRadius = 1;
            this.StartButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.StartButton.OnIdleState.BorderThickness = 1;
            this.StartButton.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.StartButton.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.StartButton.OnIdleState.IconLeftImage = null;
            this.StartButton.OnIdleState.IconRightImage = null;
            this.StartButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.StartButton.OnPressedState.BorderRadius = 1;
            this.StartButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.StartButton.OnPressedState.BorderThickness = 1;
            this.StartButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.StartButton.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.StartButton.OnPressedState.IconLeftImage = null;
            this.StartButton.OnPressedState.IconRightImage = null;
            this.StartButton.Size = new System.Drawing.Size(182, 74);
            this.StartButton.TabIndex = 1;
            this.StartButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.StartButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.StartButton.TextMarginLeft = 0;
            this.StartButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.StartButton.UseDefaultRadiusAndThickness = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click_1);
            // 
            // InformationText
            // 
            this.InformationText.BackColor = System.Drawing.Color.Black;
            this.InformationText.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.InformationText.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.InformationText.Location = new System.Drawing.Point(15, 261);
            this.InformationText.Name = "InformationText";
            this.InformationText.Size = new System.Drawing.Size(904, 65);
            this.InformationText.TabIndex = 9;
            this.InformationText.Text = "Welcome Username";
            this.InformationText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UsersChart
            // 
            chartArea1.Name = "ChartArea1";
            this.UsersChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.UsersChart.Legends.Add(legend1);
            this.UsersChart.Location = new System.Drawing.Point(206, 536);
            this.UsersChart.Name = "UsersChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.UsersChart.Series.Add(series1);
            this.UsersChart.Size = new System.Drawing.Size(555, 257);
            this.UsersChart.TabIndex = 10;
            this.UsersChart.Text = "UsersChart";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(13, 476);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(904, 57);
            this.label1.TabIndex = 11;
            this.label1.Text = "Information of Gamers";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LogOutButton
            // 
            this.LogOutButton.AllowAnimations = true;
            this.LogOutButton.AllowMouseEffects = true;
            this.LogOutButton.AllowToggling = false;
            this.LogOutButton.AnimationSpeed = 200;
            this.LogOutButton.AutoGenerateColors = false;
            this.LogOutButton.AutoRoundBorders = false;
            this.LogOutButton.AutoSizeLeftIcon = true;
            this.LogOutButton.AutoSizeRightIcon = true;
            this.LogOutButton.BackColor = System.Drawing.Color.Transparent;
            this.LogOutButton.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.LogOutButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LogOutButton.BackgroundImage")));
            this.LogOutButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.LogOutButton.ButtonText = "Log Out";
            this.LogOutButton.ButtonTextMarginLeft = 0;
            this.LogOutButton.ColorContrastOnClick = 45;
            this.LogOutButton.ColorContrastOnHover = 45;
            this.LogOutButton.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.LogOutButton.CustomizableEdges = borderEdges2;
            this.LogOutButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.LogOutButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.LogOutButton.DisabledFillColor = System.Drawing.Color.Empty;
            this.LogOutButton.DisabledForecolor = System.Drawing.Color.Empty;
            this.LogOutButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.LogOutButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LogOutButton.ForeColor = System.Drawing.Color.White;
            this.LogOutButton.IconLeft = null;
            this.LogOutButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LogOutButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.LogOutButton.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.LogOutButton.IconMarginLeft = 11;
            this.LogOutButton.IconPadding = 10;
            this.LogOutButton.IconRight = null;
            this.LogOutButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LogOutButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.LogOutButton.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.LogOutButton.IconSize = 25;
            this.LogOutButton.IdleBorderColor = System.Drawing.Color.Empty;
            this.LogOutButton.IdleBorderRadius = 0;
            this.LogOutButton.IdleBorderThickness = 0;
            this.LogOutButton.IdleFillColor = System.Drawing.Color.Empty;
            this.LogOutButton.IdleIconLeftImage = null;
            this.LogOutButton.IdleIconRightImage = null;
            this.LogOutButton.IndicateFocus = false;
            this.LogOutButton.Location = new System.Drawing.Point(12, 12);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.LogOutButton.OnDisabledState.BorderRadius = 1;
            this.LogOutButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.LogOutButton.OnDisabledState.BorderThickness = 1;
            this.LogOutButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.LogOutButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.LogOutButton.OnDisabledState.IconLeftImage = null;
            this.LogOutButton.OnDisabledState.IconRightImage = null;
            this.LogOutButton.onHoverState.BorderColor = System.Drawing.Color.DarkKhaki;
            this.LogOutButton.onHoverState.BorderRadius = 1;
            this.LogOutButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.LogOutButton.onHoverState.BorderThickness = 1;
            this.LogOutButton.onHoverState.FillColor = System.Drawing.Color.Red;
            this.LogOutButton.onHoverState.ForeColor = System.Drawing.Color.White;
            this.LogOutButton.onHoverState.IconLeftImage = null;
            this.LogOutButton.onHoverState.IconRightImage = null;
            this.LogOutButton.OnIdleState.BorderColor = System.Drawing.Color.Black;
            this.LogOutButton.OnIdleState.BorderRadius = 1;
            this.LogOutButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.LogOutButton.OnIdleState.BorderThickness = 1;
            this.LogOutButton.OnIdleState.FillColor = System.Drawing.Color.Firebrick;
            this.LogOutButton.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.LogOutButton.OnIdleState.IconLeftImage = null;
            this.LogOutButton.OnIdleState.IconRightImage = null;
            this.LogOutButton.OnPressedState.BorderColor = System.Drawing.Color.Red;
            this.LogOutButton.OnPressedState.BorderRadius = 1;
            this.LogOutButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.LogOutButton.OnPressedState.BorderThickness = 1;
            this.LogOutButton.OnPressedState.FillColor = System.Drawing.Color.Red;
            this.LogOutButton.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.LogOutButton.OnPressedState.IconLeftImage = null;
            this.LogOutButton.OnPressedState.IconRightImage = null;
            this.LogOutButton.Size = new System.Drawing.Size(191, 33);
            this.LogOutButton.TabIndex = 13;
            this.LogOutButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LogOutButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.LogOutButton.TextMarginLeft = 0;
            this.LogOutButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.LogOutButton.UseDefaultRadiusAndThickness = true;
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // bunifuButton1
            // 
            this.bunifuButton1.AllowAnimations = true;
            this.bunifuButton1.AllowMouseEffects = true;
            this.bunifuButton1.AllowToggling = false;
            this.bunifuButton1.AnimationSpeed = 200;
            this.bunifuButton1.AutoGenerateColors = false;
            this.bunifuButton1.AutoRoundBorders = false;
            this.bunifuButton1.AutoSizeLeftIcon = true;
            this.bunifuButton1.AutoSizeRightIcon = true;
            this.bunifuButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButton1.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.bunifuButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton1.BackgroundImage")));
            this.bunifuButton1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.ButtonText = "0";
            this.bunifuButton1.ButtonTextMarginLeft = 0;
            this.bunifuButton1.ColorContrastOnClick = 45;
            this.bunifuButton1.ColorContrastOnHover = 45;
            this.bunifuButton1.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.bunifuButton1.CustomizableEdges = borderEdges3;
            this.bunifuButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuButton1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton1.DisabledFillColor = System.Drawing.Color.Empty;
            this.bunifuButton1.DisabledForecolor = System.Drawing.Color.Empty;
            this.bunifuButton1.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.bunifuButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuButton1.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.IconLeft = null;
            this.bunifuButton1.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuButton1.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton1.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.bunifuButton1.IconMarginLeft = 11;
            this.bunifuButton1.IconPadding = 10;
            this.bunifuButton1.IconRight = null;
            this.bunifuButton1.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuButton1.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton1.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.bunifuButton1.IconSize = 25;
            this.bunifuButton1.IdleBorderColor = System.Drawing.Color.Empty;
            this.bunifuButton1.IdleBorderRadius = 0;
            this.bunifuButton1.IdleBorderThickness = 0;
            this.bunifuButton1.IdleFillColor = System.Drawing.Color.Empty;
            this.bunifuButton1.IdleIconLeftImage = null;
            this.bunifuButton1.IdleIconRightImage = null;
            this.bunifuButton1.IndicateFocus = false;
            this.bunifuButton1.Location = new System.Drawing.Point(836, 12);
            this.bunifuButton1.Name = "bunifuButton1";
            this.bunifuButton1.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton1.OnDisabledState.BorderRadius = 1;
            this.bunifuButton1.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.OnDisabledState.BorderThickness = 1;
            this.bunifuButton1.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton1.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton1.OnDisabledState.IconLeftImage = null;
            this.bunifuButton1.OnDisabledState.IconRightImage = null;
            this.bunifuButton1.onHoverState.BorderColor = System.Drawing.Color.DarkKhaki;
            this.bunifuButton1.onHoverState.BorderRadius = 1;
            this.bunifuButton1.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.onHoverState.BorderThickness = 1;
            this.bunifuButton1.onHoverState.FillColor = System.Drawing.Color.Red;
            this.bunifuButton1.onHoverState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.onHoverState.IconLeftImage = null;
            this.bunifuButton1.onHoverState.IconRightImage = null;
            this.bunifuButton1.OnIdleState.BorderColor = System.Drawing.Color.Black;
            this.bunifuButton1.OnIdleState.BorderRadius = 1;
            this.bunifuButton1.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.OnIdleState.BorderThickness = 1;
            this.bunifuButton1.OnIdleState.FillColor = System.Drawing.Color.Firebrick;
            this.bunifuButton1.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.OnIdleState.IconLeftImage = null;
            this.bunifuButton1.OnIdleState.IconRightImage = null;
            this.bunifuButton1.OnPressedState.BorderColor = System.Drawing.Color.Red;
            this.bunifuButton1.OnPressedState.BorderRadius = 1;
            this.bunifuButton1.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.OnPressedState.BorderThickness = 1;
            this.bunifuButton1.OnPressedState.FillColor = System.Drawing.Color.Red;
            this.bunifuButton1.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.OnPressedState.IconLeftImage = null;
            this.bunifuButton1.OnPressedState.IconRightImage = null;
            this.bunifuButton1.Size = new System.Drawing.Size(80, 33);
            this.bunifuButton1.TabIndex = 14;
            this.bunifuButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButton1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.bunifuButton1.TextMarginLeft = 0;
            this.bunifuButton1.TextPadding = new System.Windows.Forms.Padding(0);
            this.bunifuButton1.UseDefaultRadiusAndThickness = true;
            this.bunifuButton1.Click += new System.EventHandler(this.bunifuButton1_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(904, 85);
            this.label2.TabIndex = 15;
            this.label2.Text = "Memory Challenge Game";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("MV Boli", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label3.Location = new System.Drawing.Point(15, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(277, 65);
            this.label3.TabIndex = 16;
            this.label3.Text = "Warm-Up Levels (1–9)";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("MV Boli", 10F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label4.Location = new System.Drawing.Point(639, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(277, 65);
            this.label4.TabIndex = 17;
            this.label4.Text = "Memory Recall (10+)";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label5.Location = new System.Drawing.Point(640, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(277, 192);
            this.label5.TabIndex = 18;
            this.label5.Text = "Watch the numbers.\r\nRemember the order.\r\n\r\nNo limits. Just your memory.";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label6.Location = new System.Drawing.Point(16, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(277, 192);
            this.label6.TabIndex = 19;
            this.label6.Text = "Find matching cards.\r\nRemember their positions.\r\n\r\nMore cards, against the clock." +
    "";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(928, 821);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bunifuButton1);
            this.Controls.Add(this.LogOutButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UsersChart);
            this.Controls.Add(this.InformationText);
            this.Controls.Add(this.StartButton);
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainPage";
            this.Load += new System.EventHandler(this.MainPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UsersChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuButton.BunifuButton StartButton;
        private System.Windows.Forms.Label InformationText;
        private System.Windows.Forms.DataVisualization.Charting.Chart UsersChart;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton LogOutButton;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}