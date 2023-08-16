namespace xCheats.Loader
{
    partial class RDRO
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
            this.label1 = new System.Windows.Forms.Label();
            this.ExitBtn = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.PfadBtn = new Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
            this.RDOContent = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.Pfad = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.RDOLCreate = new Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
            this.GoPublicBtn = new Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
            this.WindowControll = new Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm(this.components);
            this.Email = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.Password = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SaveBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitBtn.Animated = true;
            this.ExitBtn.ControlBoxStyle = Siticone.Desktop.UI.WinForms.Enums.ControlBoxStyle.Custom;
            this.ExitBtn.FillColor = System.Drawing.Color.Red;
            this.ExitBtn.IconColor = System.Drawing.Color.Black;
            this.ExitBtn.Location = new System.Drawing.Point(543, 12);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(20, 20);
            this.ExitBtn.TabIndex = 3;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // PfadBtn
            // 
            this.PfadBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.PfadBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.PfadBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.PfadBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.PfadBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.PfadBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PfadBtn.ForeColor = System.Drawing.Color.White;
            this.PfadBtn.Location = new System.Drawing.Point(125, 151);
            this.PfadBtn.Name = "PfadBtn";
            this.PfadBtn.Size = new System.Drawing.Size(107, 25);
            this.PfadBtn.TabIndex = 4;
            this.PfadBtn.Text = "Get RDR2 Path";
            this.PfadBtn.Click += new System.EventHandler(this.PfadBtn_Click);
            // 
            // RDOContent
            // 
            this.RDOContent.BorderColor = System.Drawing.Color.Fuchsia;
            this.RDOContent.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RDOContent.DefaultText = "";
            this.RDOContent.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.RDOContent.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.RDOContent.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.RDOContent.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.RDOContent.FillColor = System.Drawing.Color.Black;
            this.RDOContent.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RDOContent.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.RDOContent.ForeColor = System.Drawing.Color.Fuchsia;
            this.RDOContent.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RDOContent.Location = new System.Drawing.Point(12, 120);
            this.RDOContent.Name = "RDOContent";
            this.RDOContent.PasswordChar = '\0';
            this.RDOContent.PlaceholderText = "Lobby Code";
            this.RDOContent.SelectedText = "";
            this.RDOContent.Size = new System.Drawing.Size(107, 25);
            this.RDOContent.TabIndex = 5;
            // 
            // Pfad
            // 
            this.Pfad.Animated = true;
            this.Pfad.AutoRoundedCorners = true;
            this.Pfad.BorderColor = System.Drawing.Color.Fuchsia;
            this.Pfad.BorderRadius = 33;
            this.Pfad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Pfad.DefaultText = "C:\\Program Files (x86)\\Steam\\steamapps\\common\\Red Dead Redemption 2\\x64\\data";
            this.Pfad.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Pfad.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Pfad.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Pfad.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Pfad.FillColor = System.Drawing.Color.Black;
            this.Pfad.FocusedState.BorderColor = System.Drawing.Color.Transparent;
            this.Pfad.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Pfad.ForeColor = System.Drawing.Color.Fuchsia;
            this.Pfad.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.Pfad.Location = new System.Drawing.Point(12, 38);
            this.Pfad.Multiline = true;
            this.Pfad.Name = "Pfad";
            this.Pfad.PasswordChar = '\0';
            this.Pfad.PlaceholderForeColor = System.Drawing.Color.Transparent;
            this.Pfad.PlaceholderText = "";
            this.Pfad.SelectedText = "";
            this.Pfad.Size = new System.Drawing.Size(267, 69);
            this.Pfad.Style = Siticone.Desktop.UI.WinForms.Enums.TextBoxStyle.Material;
            this.Pfad.TabIndex = 6;
            // 
            // RDOLCreate
            // 
            this.RDOLCreate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.RDOLCreate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.RDOLCreate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.RDOLCreate.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.RDOLCreate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.RDOLCreate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.RDOLCreate.ForeColor = System.Drawing.Color.White;
            this.RDOLCreate.Location = new System.Drawing.Point(12, 151);
            this.RDOLCreate.Name = "RDOLCreate";
            this.RDOLCreate.Size = new System.Drawing.Size(107, 25);
            this.RDOLCreate.TabIndex = 7;
            this.RDOLCreate.Text = "Create Lobby";
            this.RDOLCreate.Click += new System.EventHandler(this.RDOLCreate_Click);
            // 
            // GoPublicBtn
            // 
            this.GoPublicBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.GoPublicBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.GoPublicBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.GoPublicBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.GoPublicBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.GoPublicBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.GoPublicBtn.ForeColor = System.Drawing.Color.White;
            this.GoPublicBtn.Location = new System.Drawing.Point(125, 120);
            this.GoPublicBtn.Name = "GoPublicBtn";
            this.GoPublicBtn.Size = new System.Drawing.Size(107, 25);
            this.GoPublicBtn.TabIndex = 8;
            this.GoPublicBtn.Text = "Go Public";
            this.GoPublicBtn.Click += new System.EventHandler(this.GoPublicBtn_Click);
            // 
            // WindowControll
            // 
            this.WindowControll.AnimateWindow = true;
            this.WindowControll.ContainerControl = this;
            this.WindowControll.DockIndicatorTransparencyValue = 0.6D;
            this.WindowControll.TransparentWhileDrag = true;
            // 
            // Email
            // 
            this.Email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Email.DefaultText = "";
            this.Email.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Email.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Email.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Email.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Email.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Email.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Email.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Email.Location = new System.Drawing.Point(363, 63);
            this.Email.Name = "Email";
            this.Email.PasswordChar = '\0';
            this.Email.PlaceholderText = "";
            this.Email.SelectedText = "";
            this.Email.Size = new System.Drawing.Size(200, 36);
            this.Email.TabIndex = 9;
            // 
            // Password
            // 
            this.Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Password.DefaultText = "";
            this.Password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Password.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Password.Location = new System.Drawing.Point(363, 120);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '\0';
            this.Password.PlaceholderText = "";
            this.Password.SelectedText = "";
            this.Password.Size = new System.Drawing.Size(200, 36);
            this.Password.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Magenta;
            this.label2.Location = new System.Drawing.Point(360, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Magenta;
            this.label3.Location = new System.Drawing.Point(360, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Password:";
            // 
            // SaveBtn
            // 
            this.SaveBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SaveBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SaveBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SaveBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SaveBtn.FillColor = System.Drawing.Color.Black;
            this.SaveBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SaveBtn.ForeColor = System.Drawing.Color.Turquoise;
            this.SaveBtn.Location = new System.Drawing.Point(363, 162);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(200, 23);
            this.SaveBtn.TabIndex = 13;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // RDRO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(575, 190);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.GoPublicBtn);
            this.Controls.Add(this.RDOLCreate);
            this.Controls.Add(this.Pfad);
            this.Controls.Add(this.RDOContent);
            this.Controls.Add(this.PfadBtn);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RDRO";
            this.ShowIcon = false;
            this.Text = "RDRO";
            this.Load += new System.EventHandler(this.RDRO_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox ExitBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneGradientButton PfadBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox RDOContent;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox Pfad;
        private Siticone.Desktop.UI.WinForms.SiticoneGradientButton RDOLCreate;
        private Siticone.Desktop.UI.WinForms.SiticoneGradientButton GoPublicBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm WindowControll;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox Password;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox Email;
        private Siticone.Desktop.UI.WinForms.SiticoneButton SaveBtn;
    }
}