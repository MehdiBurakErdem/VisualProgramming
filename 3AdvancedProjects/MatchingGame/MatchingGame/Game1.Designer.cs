namespace MatchingGame
{
    partial class Game1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game1));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges6 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.LevelLabel = new System.Windows.Forms.Label();
            this.MatchesLabel = new System.Windows.Forms.Label();
            this.HideTimer = new System.Windows.Forms.Timer(this.components);
            this.ExitButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.TimerLabel = new System.Windows.Forms.Label();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.FailPanel = new System.Windows.Forms.Panel();
            this.RetryButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.FailMainPageButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.FailLabel = new System.Windows.Forms.Label();
            this.FailPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LevelLabel
            // 
            this.LevelLabel.BackColor = System.Drawing.Color.DarkGray;
            this.LevelLabel.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LevelLabel.Location = new System.Drawing.Point(12, 9);
            this.LevelLabel.Name = "LevelLabel";
            this.LevelLabel.Size = new System.Drawing.Size(161, 47);
            this.LevelLabel.TabIndex = 9;
            this.LevelLabel.Text = "Level 1";
            this.LevelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MatchesLabel
            // 
            this.MatchesLabel.BackColor = System.Drawing.Color.DarkGray;
            this.MatchesLabel.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MatchesLabel.Location = new System.Drawing.Point(539, 9);
            this.MatchesLabel.Name = "MatchesLabel";
            this.MatchesLabel.Size = new System.Drawing.Size(251, 47);
            this.MatchesLabel.TabIndex = 10;
            this.MatchesLabel.Text = "Matches Found: 0";
            this.MatchesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MatchesLabel.Click += new System.EventHandler(this.MatchesLabel_Click);
            // 
            // HideTimer
            // 
            this.HideTimer.Interval = 1000;
            // 
            // ExitButton
            // 
            this.ExitButton.AllowAnimations = true;
            this.ExitButton.AllowMouseEffects = true;
            this.ExitButton.AllowToggling = false;
            this.ExitButton.AnimationSpeed = 200;
            this.ExitButton.AutoGenerateColors = false;
            this.ExitButton.AutoRoundBorders = false;
            this.ExitButton.AutoSizeLeftIcon = true;
            this.ExitButton.AutoSizeRightIcon = true;
            this.ExitButton.BackColor = System.Drawing.Color.Transparent;
            this.ExitButton.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.ExitButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ExitButton.BackgroundImage")));
            this.ExitButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.ExitButton.ButtonText = "Exit";
            this.ExitButton.ButtonTextMarginLeft = 0;
            this.ExitButton.ColorContrastOnClick = 45;
            this.ExitButton.ColorContrastOnHover = 45;
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.ExitButton.CustomizableEdges = borderEdges4;
            this.ExitButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ExitButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.ExitButton.DisabledFillColor = System.Drawing.Color.Empty;
            this.ExitButton.DisabledForecolor = System.Drawing.Color.Empty;
            this.ExitButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.ExitButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ExitButton.ForeColor = System.Drawing.Color.White;
            this.ExitButton.IconLeft = null;
            this.ExitButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ExitButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.ExitButton.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.ExitButton.IconMarginLeft = 11;
            this.ExitButton.IconPadding = 10;
            this.ExitButton.IconRight = null;
            this.ExitButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ExitButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.ExitButton.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.ExitButton.IconSize = 25;
            this.ExitButton.IdleBorderColor = System.Drawing.Color.Empty;
            this.ExitButton.IdleBorderRadius = 0;
            this.ExitButton.IdleBorderThickness = 0;
            this.ExitButton.IdleFillColor = System.Drawing.Color.Empty;
            this.ExitButton.IdleIconLeftImage = null;
            this.ExitButton.IdleIconRightImage = null;
            this.ExitButton.IndicateFocus = false;
            this.ExitButton.Location = new System.Drawing.Point(946, 9);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.ExitButton.OnDisabledState.BorderRadius = 1;
            this.ExitButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.ExitButton.OnDisabledState.BorderThickness = 1;
            this.ExitButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ExitButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.ExitButton.OnDisabledState.IconLeftImage = null;
            this.ExitButton.OnDisabledState.IconRightImage = null;
            this.ExitButton.onHoverState.BorderColor = System.Drawing.Color.DarkKhaki;
            this.ExitButton.onHoverState.BorderRadius = 1;
            this.ExitButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.ExitButton.onHoverState.BorderThickness = 1;
            this.ExitButton.onHoverState.FillColor = System.Drawing.Color.Red;
            this.ExitButton.onHoverState.ForeColor = System.Drawing.Color.White;
            this.ExitButton.onHoverState.IconLeftImage = null;
            this.ExitButton.onHoverState.IconRightImage = null;
            this.ExitButton.OnIdleState.BorderColor = System.Drawing.Color.Black;
            this.ExitButton.OnIdleState.BorderRadius = 1;
            this.ExitButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.ExitButton.OnIdleState.BorderThickness = 1;
            this.ExitButton.OnIdleState.FillColor = System.Drawing.Color.Firebrick;
            this.ExitButton.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.ExitButton.OnIdleState.IconLeftImage = null;
            this.ExitButton.OnIdleState.IconRightImage = null;
            this.ExitButton.OnPressedState.BorderColor = System.Drawing.Color.Red;
            this.ExitButton.OnPressedState.BorderRadius = 1;
            this.ExitButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.ExitButton.OnPressedState.BorderThickness = 1;
            this.ExitButton.OnPressedState.FillColor = System.Drawing.Color.Red;
            this.ExitButton.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.ExitButton.OnPressedState.IconLeftImage = null;
            this.ExitButton.OnPressedState.IconRightImage = null;
            this.ExitButton.Size = new System.Drawing.Size(120, 47);
            this.ExitButton.TabIndex = 14;
            this.ExitButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ExitButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.ExitButton.TextMarginLeft = 0;
            this.ExitButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.ExitButton.UseDefaultRadiusAndThickness = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click_1);
            // 
            // TimerLabel
            // 
            this.TimerLabel.AutoSize = true;
            this.TimerLabel.BackColor = System.Drawing.Color.DarkGray;
            this.TimerLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TimerLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.TimerLabel.Location = new System.Drawing.Point(291, 14);
            this.TimerLabel.Name = "TimerLabel";
            this.TimerLabel.Size = new System.Drawing.Size(112, 32);
            this.TimerLabel.TabIndex = 15;
            this.TimerLabel.Text = "Time: 00";
            this.TimerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GameTimer
            // 
            this.GameTimer.Interval = 1000;
            // 
            // FailPanel
            // 
            this.FailPanel.BackColor = System.Drawing.Color.White;
            this.FailPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FailPanel.Controls.Add(this.RetryButton);
            this.FailPanel.Controls.Add(this.FailMainPageButton);
            this.FailPanel.Controls.Add(this.FailLabel);
            this.FailPanel.Location = new System.Drawing.Point(392, 252);
            this.FailPanel.Name = "FailPanel";
            this.FailPanel.Size = new System.Drawing.Size(304, 183);
            this.FailPanel.TabIndex = 16;
            this.FailPanel.Visible = false;
            // 
            // RetryButton
            // 
            this.RetryButton.AllowAnimations = true;
            this.RetryButton.AllowMouseEffects = true;
            this.RetryButton.AllowToggling = false;
            this.RetryButton.AnimationSpeed = 200;
            this.RetryButton.AutoGenerateColors = false;
            this.RetryButton.AutoRoundBorders = false;
            this.RetryButton.AutoSizeLeftIcon = true;
            this.RetryButton.AutoSizeRightIcon = true;
            this.RetryButton.BackColor = System.Drawing.Color.Transparent;
            this.RetryButton.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.RetryButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RetryButton.BackgroundImage")));
            this.RetryButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.RetryButton.ButtonText = "Again!";
            this.RetryButton.ButtonTextMarginLeft = 0;
            this.RetryButton.ColorContrastOnClick = 45;
            this.RetryButton.ColorContrastOnHover = 45;
            this.RetryButton.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges5.BottomLeft = true;
            borderEdges5.BottomRight = true;
            borderEdges5.TopLeft = true;
            borderEdges5.TopRight = true;
            this.RetryButton.CustomizableEdges = borderEdges5;
            this.RetryButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.RetryButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.RetryButton.DisabledFillColor = System.Drawing.Color.Empty;
            this.RetryButton.DisabledForecolor = System.Drawing.Color.Empty;
            this.RetryButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.RetryButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.RetryButton.ForeColor = System.Drawing.Color.White;
            this.RetryButton.IconLeft = null;
            this.RetryButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RetryButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.RetryButton.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.RetryButton.IconMarginLeft = 11;
            this.RetryButton.IconPadding = 10;
            this.RetryButton.IconRight = null;
            this.RetryButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RetryButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.RetryButton.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.RetryButton.IconSize = 25;
            this.RetryButton.IdleBorderColor = System.Drawing.Color.Empty;
            this.RetryButton.IdleBorderRadius = 0;
            this.RetryButton.IdleBorderThickness = 0;
            this.RetryButton.IdleFillColor = System.Drawing.Color.Empty;
            this.RetryButton.IdleIconLeftImage = null;
            this.RetryButton.IdleIconRightImage = null;
            this.RetryButton.IndicateFocus = false;
            this.RetryButton.Location = new System.Drawing.Point(151, 127);
            this.RetryButton.Name = "RetryButton";
            this.RetryButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.RetryButton.OnDisabledState.BorderRadius = 1;
            this.RetryButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.RetryButton.OnDisabledState.BorderThickness = 1;
            this.RetryButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.RetryButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.RetryButton.OnDisabledState.IconLeftImage = null;
            this.RetryButton.OnDisabledState.IconRightImage = null;
            this.RetryButton.onHoverState.BorderColor = System.Drawing.Color.DarkKhaki;
            this.RetryButton.onHoverState.BorderRadius = 1;
            this.RetryButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.RetryButton.onHoverState.BorderThickness = 1;
            this.RetryButton.onHoverState.FillColor = System.Drawing.Color.Red;
            this.RetryButton.onHoverState.ForeColor = System.Drawing.Color.White;
            this.RetryButton.onHoverState.IconLeftImage = null;
            this.RetryButton.onHoverState.IconRightImage = null;
            this.RetryButton.OnIdleState.BorderColor = System.Drawing.Color.Black;
            this.RetryButton.OnIdleState.BorderRadius = 1;
            this.RetryButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.RetryButton.OnIdleState.BorderThickness = 1;
            this.RetryButton.OnIdleState.FillColor = System.Drawing.Color.OliveDrab;
            this.RetryButton.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.RetryButton.OnIdleState.IconLeftImage = null;
            this.RetryButton.OnIdleState.IconRightImage = null;
            this.RetryButton.OnPressedState.BorderColor = System.Drawing.Color.Red;
            this.RetryButton.OnPressedState.BorderRadius = 1;
            this.RetryButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.RetryButton.OnPressedState.BorderThickness = 1;
            this.RetryButton.OnPressedState.FillColor = System.Drawing.Color.Red;
            this.RetryButton.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.RetryButton.OnPressedState.IconLeftImage = null;
            this.RetryButton.OnPressedState.IconRightImage = null;
            this.RetryButton.Size = new System.Drawing.Size(137, 47);
            this.RetryButton.TabIndex = 16;
            this.RetryButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RetryButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.RetryButton.TextMarginLeft = 0;
            this.RetryButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.RetryButton.UseDefaultRadiusAndThickness = true;
            this.RetryButton.Click += new System.EventHandler(this.RetryButton_Click_1);
            // 
            // FailMainPageButton
            // 
            this.FailMainPageButton.AllowAnimations = true;
            this.FailMainPageButton.AllowMouseEffects = true;
            this.FailMainPageButton.AllowToggling = false;
            this.FailMainPageButton.AnimationSpeed = 200;
            this.FailMainPageButton.AutoGenerateColors = false;
            this.FailMainPageButton.AutoRoundBorders = false;
            this.FailMainPageButton.AutoSizeLeftIcon = true;
            this.FailMainPageButton.AutoSizeRightIcon = true;
            this.FailMainPageButton.BackColor = System.Drawing.Color.Transparent;
            this.FailMainPageButton.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.FailMainPageButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FailMainPageButton.BackgroundImage")));
            this.FailMainPageButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.FailMainPageButton.ButtonText = "Main Page";
            this.FailMainPageButton.ButtonTextMarginLeft = 0;
            this.FailMainPageButton.ColorContrastOnClick = 45;
            this.FailMainPageButton.ColorContrastOnHover = 45;
            this.FailMainPageButton.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges6.BottomLeft = true;
            borderEdges6.BottomRight = true;
            borderEdges6.TopLeft = true;
            borderEdges6.TopRight = true;
            this.FailMainPageButton.CustomizableEdges = borderEdges6;
            this.FailMainPageButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.FailMainPageButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.FailMainPageButton.DisabledFillColor = System.Drawing.Color.Empty;
            this.FailMainPageButton.DisabledForecolor = System.Drawing.Color.Empty;
            this.FailMainPageButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.FailMainPageButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FailMainPageButton.ForeColor = System.Drawing.Color.White;
            this.FailMainPageButton.IconLeft = null;
            this.FailMainPageButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FailMainPageButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.FailMainPageButton.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.FailMainPageButton.IconMarginLeft = 11;
            this.FailMainPageButton.IconPadding = 10;
            this.FailMainPageButton.IconRight = null;
            this.FailMainPageButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.FailMainPageButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.FailMainPageButton.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.FailMainPageButton.IconSize = 25;
            this.FailMainPageButton.IdleBorderColor = System.Drawing.Color.Empty;
            this.FailMainPageButton.IdleBorderRadius = 0;
            this.FailMainPageButton.IdleBorderThickness = 0;
            this.FailMainPageButton.IdleFillColor = System.Drawing.Color.Empty;
            this.FailMainPageButton.IdleIconLeftImage = null;
            this.FailMainPageButton.IdleIconRightImage = null;
            this.FailMainPageButton.IndicateFocus = false;
            this.FailMainPageButton.Location = new System.Drawing.Point(8, 127);
            this.FailMainPageButton.Name = "FailMainPageButton";
            this.FailMainPageButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.FailMainPageButton.OnDisabledState.BorderRadius = 1;
            this.FailMainPageButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.FailMainPageButton.OnDisabledState.BorderThickness = 1;
            this.FailMainPageButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.FailMainPageButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.FailMainPageButton.OnDisabledState.IconLeftImage = null;
            this.FailMainPageButton.OnDisabledState.IconRightImage = null;
            this.FailMainPageButton.onHoverState.BorderColor = System.Drawing.Color.DarkKhaki;
            this.FailMainPageButton.onHoverState.BorderRadius = 1;
            this.FailMainPageButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.FailMainPageButton.onHoverState.BorderThickness = 1;
            this.FailMainPageButton.onHoverState.FillColor = System.Drawing.Color.Red;
            this.FailMainPageButton.onHoverState.ForeColor = System.Drawing.Color.White;
            this.FailMainPageButton.onHoverState.IconLeftImage = null;
            this.FailMainPageButton.onHoverState.IconRightImage = null;
            this.FailMainPageButton.OnIdleState.BorderColor = System.Drawing.Color.Black;
            this.FailMainPageButton.OnIdleState.BorderRadius = 1;
            this.FailMainPageButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.FailMainPageButton.OnIdleState.BorderThickness = 1;
            this.FailMainPageButton.OnIdleState.FillColor = System.Drawing.Color.Brown;
            this.FailMainPageButton.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.FailMainPageButton.OnIdleState.IconLeftImage = null;
            this.FailMainPageButton.OnIdleState.IconRightImage = null;
            this.FailMainPageButton.OnPressedState.BorderColor = System.Drawing.Color.Red;
            this.FailMainPageButton.OnPressedState.BorderRadius = 1;
            this.FailMainPageButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.FailMainPageButton.OnPressedState.BorderThickness = 1;
            this.FailMainPageButton.OnPressedState.FillColor = System.Drawing.Color.Red;
            this.FailMainPageButton.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.FailMainPageButton.OnPressedState.IconLeftImage = null;
            this.FailMainPageButton.OnPressedState.IconRightImage = null;
            this.FailMainPageButton.Size = new System.Drawing.Size(137, 47);
            this.FailMainPageButton.TabIndex = 15;
            this.FailMainPageButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.FailMainPageButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.FailMainPageButton.TextMarginLeft = 0;
            this.FailMainPageButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.FailMainPageButton.UseDefaultRadiusAndThickness = true;
            this.FailMainPageButton.Click += new System.EventHandler(this.FailMainPageButton_Click_1);
            // 
            // FailLabel
            // 
            this.FailLabel.BackColor = System.Drawing.Color.DarkGray;
            this.FailLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FailLabel.Location = new System.Drawing.Point(8, 9);
            this.FailLabel.Name = "FailLabel";
            this.FailLabel.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.FailLabel.Size = new System.Drawing.Size(280, 115);
            this.FailLabel.TabIndex = 10;
            this.FailLabel.Text = "Time\'s over!\r\nYou should be faster ! 😄";
            this.FailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Game1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1078, 644);
            this.Controls.Add(this.FailPanel);
            this.Controls.Add(this.TimerLabel);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.MatchesLabel);
            this.Controls.Add(this.LevelLabel);
            this.Name = "Game1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game1";
            this.Load += new System.EventHandler(this.Game1_Load);
            this.FailPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LevelLabel;
        private System.Windows.Forms.Label MatchesLabel;
        private System.Windows.Forms.Timer HideTimer;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton ExitButton;
        private System.Windows.Forms.Label TimerLabel;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Panel FailPanel;
        private System.Windows.Forms.Label FailLabel;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton RetryButton;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton FailMainPageButton;
    }
}