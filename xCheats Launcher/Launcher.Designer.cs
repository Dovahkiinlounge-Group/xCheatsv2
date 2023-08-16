namespace xCheats_Launcher
{
    partial class Launcher
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Launcher));
            this.Window = new Zeroit.Framework.Form.ZeroitChromeForm();
            this.OffTggl = new Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopCheckBox();
            this.BGTggl = new Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopCheckBox();
            this.zeroitLollipopButton1 = new Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AppText = new Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopLabel();
            this.StartBtn = new Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopButton();
            this.AdminTggl = new Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopCheckBox();
            this.Window.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Window
            // 
            this.Window.BackColor = System.Drawing.Color.Black;
            this.Window.BorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Window.ColorBackground1 = System.Drawing.Color.Violet;
            this.Window.ColorBackground2 = System.Drawing.Color.LightSeaGreen;
            this.Window.Controls.Add(this.AdminTggl);
            this.Window.Controls.Add(this.OffTggl);
            this.Window.Controls.Add(this.BGTggl);
            this.Window.Controls.Add(this.zeroitLollipopButton1);
            this.Window.Controls.Add(this.pictureBox1);
            this.Window.Controls.Add(this.AppText);
            this.Window.Controls.Add(this.StartBtn);
            this.Window.Customization = "AAAA//////8AAP//";
            this.Window.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Window.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Window.Image = null;
            this.Window.Location = new System.Drawing.Point(0, 0);
            this.Window.Movable = false;
            this.Window.Name = "Window";
            this.Window.NoRounding = false;
            this.Window.Sizable = false;
            this.Window.Size = new System.Drawing.Size(800, 450);
            this.Window.SmartBounds = true;
            this.Window.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Window.TabIndex = 0;
            this.Window.Text = "xCheats";
            this.Window.TransparencyKey = System.Drawing.Color.Empty;
            this.Window.Transparent = false;
            this.Window.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.Window.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.Window.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseUp);
            // 
            // OffTggl
            // 
            this.OffTggl.AllowTransparency = true;
            this.OffTggl.Checked = false;
            this.OffTggl.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(142)))), ((int)(((byte)(245)))));
            this.OffTggl.ForeColor = System.Drawing.Color.Magenta;
            this.OffTggl.Location = new System.Drawing.Point(22, 75);
            this.OffTggl.Name = "OffTggl";
            this.OffTggl.RectangleWidth = 1;
            this.OffTggl.Size = new System.Drawing.Size(65, 20);
            this.OffTggl.TabIndex = 7;
            this.OffTggl.Text = "Offline";
            this.OffTggl.UncheckedColor = System.Drawing.Color.White;
            this.OffTggl.Click += new System.EventHandler(this.OffTggl_Click);
            // 
            // BGTggl
            // 
            this.BGTggl.AllowTransparency = true;
            this.BGTggl.Checked = false;
            this.BGTggl.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(142)))), ((int)(((byte)(245)))));
            this.BGTggl.ForeColor = System.Drawing.Color.Green;
            this.BGTggl.Location = new System.Drawing.Point(22, 101);
            this.BGTggl.Name = "BGTggl";
            this.BGTggl.RectangleWidth = 1;
            this.BGTggl.Size = new System.Drawing.Size(98, 20);
            this.BGTggl.TabIndex = 6;
            this.BGTggl.Text = "Background";
            this.BGTggl.UncheckedColor = System.Drawing.Color.White;
            this.BGTggl.Click += new System.EventHandler(this.BGTggl_Click);
            // 
            // zeroitLollipopButton1
            // 
            this.zeroitLollipopButton1.AllowTransparency = true;
            this.zeroitLollipopButton1.AnimationInterval = 1;
            this.zeroitLollipopButton1.BackColor = System.Drawing.Color.Transparent;
            this.zeroitLollipopButton1.BGColor = "#508ef5";
            this.zeroitLollipopButton1.Corners = 1F;
            this.zeroitLollipopButton1.DisabledBGColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(178)))), ((int)(((byte)(181)))));
            this.zeroitLollipopButton1.DoubleRipple = false;
            this.zeroitLollipopButton1.EnabledBGColor = System.Drawing.Color.Black;
            this.zeroitLollipopButton1.FontColor = "#ffffff";
            this.zeroitLollipopButton1.ForeColor = System.Drawing.Color.Red;
            this.zeroitLollipopButton1.Location = new System.Drawing.Point(776, 0);
            this.zeroitLollipopButton1.Name = "zeroitLollipopButton1";
            this.zeroitLollipopButton1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.zeroitLollipopButton1.RippleEffectColor = System.Drawing.Color.Black;
            this.zeroitLollipopButton1.RippleOpacity = 25;
            this.zeroitLollipopButton1.Size = new System.Drawing.Size(24, 22);
            this.zeroitLollipopButton1.Smoothing = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.zeroitLollipopButton1.TabIndex = 3;
            this.zeroitLollipopButton1.Text = "X";
            this.zeroitLollipopButton1.TextRendering = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.zeroitLollipopButton1.Click += new System.EventHandler(this.zeroitLollipopButton1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(316, 129);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(168, 158);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // AppText
            // 
            this.AppText.AllowTransparency = false;
            this.AppText.AutoSize = true;
            this.AppText.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AppText.Font = new System.Drawing.Font("Aharoni", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppText.ForeColor = System.Drawing.Color.Fuchsia;
            this.AppText.Location = new System.Drawing.Point(243, 75);
            this.AppText.Name = "AppText";
            this.AppText.Size = new System.Drawing.Size(310, 35);
            this.AppText.TabIndex = 1;
            this.AppText.Text = "xCheats Launcher";
            // 
            // StartBtn
            // 
            this.StartBtn.AllowTransparency = true;
            this.StartBtn.AnimationInterval = 1;
            this.StartBtn.BackColor = System.Drawing.Color.Transparent;
            this.StartBtn.BGColor = "#fffff";
            this.StartBtn.Corners = 1F;
            this.StartBtn.DisabledBGColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(178)))), ((int)(((byte)(181)))));
            this.StartBtn.DoubleRipple = false;
            this.StartBtn.EnabledBGColor = System.Drawing.Color.Transparent;
            this.StartBtn.FontColor = "#ffffff";
            this.StartBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.StartBtn.Location = new System.Drawing.Point(294, 415);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.RippleEffectColor = System.Drawing.Color.Black;
            this.StartBtn.RippleOpacity = 25;
            this.StartBtn.Size = new System.Drawing.Size(201, 23);
            this.StartBtn.Smoothing = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.StartBtn.TabIndex = 0;
            this.StartBtn.Text = "Start xCheats";
            this.StartBtn.TextRendering = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // AdminTggl
            // 
            this.AdminTggl.AllowTransparency = true;
            this.AdminTggl.Checked = false;
            this.AdminTggl.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(142)))), ((int)(((byte)(245)))));
            this.AdminTggl.ForeColor = System.Drawing.Color.Green;
            this.AdminTggl.Location = new System.Drawing.Point(22, 127);
            this.AdminTggl.Name = "AdminTggl";
            this.AdminTggl.RectangleWidth = 1;
            this.AdminTggl.Size = new System.Drawing.Size(102, 20);
            this.AdminTggl.TabIndex = 8;
            this.AdminTggl.Text = "Admin Mode";
            this.AdminTggl.UncheckedColor = System.Drawing.Color.White;
            this.AdminTggl.Click += new System.EventHandler(this.AdminTggl_Click);
            // 
            // Launcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Window);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Launcher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "zeroitGradientForm1";
            this.Window.ResumeLayout(false);
            this.Window.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopButton StartBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopLabel AppText;
        public Zeroit.Framework.Form.ZeroitChromeForm Window;
        private Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopButton zeroitLollipopButton1;
        private Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopCheckBox OffTggl;
        private Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopCheckBox BGTggl;
        private Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopCheckBox AdminTggl;
    }
}

