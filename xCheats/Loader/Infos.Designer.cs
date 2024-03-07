namespace xCheats.Loader
{
    partial class Infos
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Infos));
            ExitBtn = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            DeviceInfo = new Siticone.Desktop.UI.WinForms.SiticoneDeviceInfo(components);
            BorderInfo = new Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm(components);
            TaskPRogress = new Siticone.Desktop.UI.WinForms.SiticoneTaskBarProgress(components);
            FolderDial = new FolderBrowserDialog();
            Automation = new System.ComponentModel.BackgroundWorker();
            Credits = new TabPage();
            GLName2 = new Label();
            GLName = new Label();
            CRA2 = new Label();
            CRA = new Label();
            PhilInfo = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            CeliInfo = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            label4 = new Label();
            DCName2 = new Label();
            DCAV2 = new PictureBox();
            DCName = new Label();
            DCAV1 = new PictureBox();
            Settings = new TabPage();
            DllNameBox = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            ExodusBtn = new Siticone.Desktop.UI.WinForms.SiticoneImageButton();
            label5 = new Label();
            Sterni = new Label();
            label3 = new Label();
            AutoInjectCB = new Siticone.Desktop.UI.WinForms.SiticoneCheckBox();
            AutoInjTB = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            AutoStartBtn = new Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
            WS = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            siticoneButton1 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            SaveSet = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            ConsoleHideBox = new Siticone.Desktop.UI.WinForms.SiticoneCheckBox();
            inittxt = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            siticoneCheckBox1 = new Siticone.Desktop.UI.WinForms.SiticoneCheckBox();
            HotkeyTxT = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            FixTool = new TabPage();
            RemoveGWLD = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            StateUpd = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            RemovePatch = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            RuntimesText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            RunTimeDwn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            PatchText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            PatchDwn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            DwnBar = new Siticone.Desktop.UI.WinForms.SiticoneCircleProgressBar();
            GamesWinLiveText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            GamesWinLiveDwn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            About = new TabPage();
            Repo2 = new LinkLabel();
            CPUStat = new Label();
            MBoard = new Label();
            CPU = new Label();
            GPU = new Label();
            TestLabel = new Label();
            ConInfo = new Label();
            StatusInfo = new Label();
            AppVer = new Label();
            DCCopyTag = new LinkLabel();
            linkLabel1 = new LinkLabel();
            label2 = new Label();
            label1 = new Label();
            siticonePictureBox1 = new Siticone.Desktop.UI.WinForms.SiticonePictureBox();
            siticoneTabControl1 = new Siticone.Desktop.UI.WinForms.SiticoneTabControl();
            Credits.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DCAV2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DCAV1).BeginInit();
            Settings.SuspendLayout();
            FixTool.SuspendLayout();
            About.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)siticonePictureBox1).BeginInit();
            siticoneTabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // ExitBtn
            // 
            ExitBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ExitBtn.Animated = true;
            ExitBtn.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            ExitBtn.ControlBoxStyle = Siticone.Desktop.UI.WinForms.Enums.ControlBoxStyle.Custom;
            ExitBtn.FillColor = Color.Red;
            ExitBtn.IconColor = Color.Black;
            ExitBtn.Location = new Point(976, 8);
            ExitBtn.Margin = new Padding(5, 4, 5, 4);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Size = new Size(59, 31);
            ExitBtn.TabIndex = 2;
            ExitBtn.Click += ExitBtn_Click;
            // 
            // BorderInfo
            // 
            BorderInfo.AnimateWindow = true;
            BorderInfo.AnimationType = Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm.AnimateWindowType.AW_HOR_POSITIVE;
            BorderInfo.ContainerControl = this;
            BorderInfo.DockIndicatorTransparencyValue = 0.6D;
            BorderInfo.DragStartTransparencyValue = 0.5D;
            BorderInfo.TransparentWhileDrag = true;
            // 
            // TaskPRogress
            // 
            TaskPRogress.TargetForm = null;
            // 
            // FolderDial
            // 
            FolderDial.Description = "Select a exclusion for Windows Defender";
            FolderDial.RootFolder = Environment.SpecialFolder.MyComputer;
            FolderDial.ShowNewFolderButton = false;
            // 
            // Automation
            // 
            Automation.DoWork += Automation_DoWork;
            // 
            // Credits
            // 
            Credits.BackColor = Color.Black;
            Credits.Controls.Add(GLName2);
            Credits.Controls.Add(GLName);
            Credits.Controls.Add(CRA2);
            Credits.Controls.Add(CRA);
            Credits.Controls.Add(PhilInfo);
            Credits.Controls.Add(CeliInfo);
            Credits.Controls.Add(label4);
            Credits.Controls.Add(DCName2);
            Credits.Controls.Add(DCAV2);
            Credits.Controls.Add(DCName);
            Credits.Controls.Add(DCAV1);
            Credits.Location = new Point(4, 44);
            Credits.Margin = new Padding(5, 4, 5, 4);
            Credits.Name = "Credits";
            Credits.Size = new Size(1036, 626);
            Credits.TabIndex = 7;
            Credits.Text = "Credits";
            // 
            // GLName2
            // 
            GLName2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GLName2.ForeColor = Color.White;
            GLName2.Location = new Point(225, 269);
            GLName2.Margin = new Padding(5, 0, 5, 0);
            GLName2.Name = "GLName2";
            GLName2.RightToLeft = RightToLeft.No;
            GLName2.Size = new Size(168, 44);
            GLName2.TabIndex = 46;
            GLName2.Text = "DisplayName: ";
            // 
            // GLName
            // 
            GLName.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GLName.ForeColor = Color.White;
            GLName.Location = new Point(17, 269);
            GLName.Margin = new Padding(5, 0, 5, 0);
            GLName.Name = "GLName";
            GLName.RightToLeft = RightToLeft.No;
            GLName.Size = new Size(168, 44);
            GLName.TabIndex = 45;
            GLName.Text = "DisplayName: ";
            // 
            // CRA2
            // 
            CRA2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CRA2.ForeColor = Color.White;
            CRA2.Location = new Point(225, 313);
            CRA2.Margin = new Padding(5, 0, 5, 0);
            CRA2.Name = "CRA2";
            CRA2.RightToLeft = RightToLeft.No;
            CRA2.Size = new Size(168, 63);
            CRA2.TabIndex = 44;
            CRA2.Text = "Created At: ???";
            // 
            // CRA
            // 
            CRA.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CRA.ForeColor = Color.White;
            CRA.Location = new Point(17, 313);
            CRA.Margin = new Padding(5, 0, 5, 0);
            CRA.Name = "CRA";
            CRA.RightToLeft = RightToLeft.No;
            CRA.Size = new Size(168, 63);
            CRA.TabIndex = 43;
            CRA.Text = "Created At: ???";
            // 
            // PhilInfo
            // 
            PhilInfo.BorderColor = Color.Transparent;
            PhilInfo.Cursor = Cursors.IBeam;
            PhilInfo.DefaultText = "API Dev";
            PhilInfo.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            PhilInfo.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            PhilInfo.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            PhilInfo.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            PhilInfo.FillColor = Color.Transparent;
            PhilInfo.FocusedState.BorderColor = Color.Transparent;
            PhilInfo.Font = new Font("Segoe UI", 9F);
            PhilInfo.ForeColor = Color.Magenta;
            PhilInfo.HideSelection = false;
            PhilInfo.HoverState.BorderColor = Color.Transparent;
            PhilInfo.Location = new Point(223, 364);
            PhilInfo.Margin = new Padding(2, 3, 2, 3);
            PhilInfo.Multiline = true;
            PhilInfo.Name = "PhilInfo";
            PhilInfo.PasswordChar = '\0';
            PhilInfo.PlaceholderForeColor = Color.Transparent;
            PhilInfo.PlaceholderText = "";
            PhilInfo.ReadOnly = true;
            PhilInfo.SelectedText = "";
            PhilInfo.Size = new Size(80, 44);
            PhilInfo.TabIndex = 42;
            // 
            // CeliInfo
            // 
            CeliInfo.BorderColor = Color.Transparent;
            CeliInfo.Cursor = Cursors.IBeam;
            CeliInfo.DefaultText = "Core Dev";
            CeliInfo.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            CeliInfo.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            CeliInfo.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            CeliInfo.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            CeliInfo.FillColor = Color.Transparent;
            CeliInfo.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            CeliInfo.Font = new Font("Segoe UI", 9F);
            CeliInfo.ForeColor = Color.Magenta;
            CeliInfo.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            CeliInfo.Location = new Point(17, 364);
            CeliInfo.Margin = new Padding(2, 3, 2, 3);
            CeliInfo.Multiline = true;
            CeliInfo.Name = "CeliInfo";
            CeliInfo.PasswordChar = '\0';
            CeliInfo.PlaceholderForeColor = Color.Transparent;
            CeliInfo.PlaceholderText = "";
            CeliInfo.ReadOnly = true;
            CeliInfo.SelectedText = "";
            CeliInfo.Size = new Size(90, 44);
            CeliInfo.TabIndex = 41;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(10, 21);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(153, 25);
            label4.TabIndex = 39;
            label4.Text = "Developed By:";
            // 
            // DCName2
            // 
            DCName2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DCName2.ForeColor = Color.White;
            DCName2.Location = new Point(225, 224);
            DCName2.Margin = new Padding(5, 0, 5, 0);
            DCName2.Name = "DCName2";
            DCName2.Size = new Size(168, 44);
            DCName2.TabIndex = 38;
            DCName2.Text = "Username: ???";
            // 
            // DCAV2
            // 
            DCAV2.BackgroundImageLayout = ImageLayout.Stretch;
            DCAV2.BorderStyle = BorderStyle.FixedSingle;
            DCAV2.ErrorImage = null;
            DCAV2.InitialImage = null;
            DCAV2.Location = new Point(225, 59);
            DCAV2.Margin = new Padding(5, 4, 5, 4);
            DCAV2.Name = "DCAV2";
            DCAV2.Size = new Size(164, 161);
            DCAV2.SizeMode = PictureBoxSizeMode.StretchImage;
            DCAV2.TabIndex = 37;
            DCAV2.TabStop = false;
            // 
            // DCName
            // 
            DCName.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DCName.ForeColor = Color.White;
            DCName.Location = new Point(16, 224);
            DCName.Margin = new Padding(5, 0, 5, 0);
            DCName.Name = "DCName";
            DCName.RightToLeft = RightToLeft.No;
            DCName.Size = new Size(168, 44);
            DCName.TabIndex = 36;
            DCName.Text = "Username: ???";
            // 
            // DCAV1
            // 
            DCAV1.BackgroundImageLayout = ImageLayout.Stretch;
            DCAV1.BorderStyle = BorderStyle.FixedSingle;
            DCAV1.ErrorImage = null;
            DCAV1.InitialImage = null;
            DCAV1.Location = new Point(16, 59);
            DCAV1.Margin = new Padding(5, 4, 5, 4);
            DCAV1.Name = "DCAV1";
            DCAV1.Size = new Size(164, 161);
            DCAV1.SizeMode = PictureBoxSizeMode.StretchImage;
            DCAV1.TabIndex = 35;
            DCAV1.TabStop = false;
            // 
            // Settings
            // 
            Settings.BackColor = Color.Black;
            Settings.Controls.Add(DllNameBox);
            Settings.Controls.Add(ExodusBtn);
            Settings.Controls.Add(label5);
            Settings.Controls.Add(Sterni);
            Settings.Controls.Add(label3);
            Settings.Controls.Add(AutoInjectCB);
            Settings.Controls.Add(AutoInjTB);
            Settings.Controls.Add(AutoStartBtn);
            Settings.Controls.Add(WS);
            Settings.Controls.Add(siticoneButton1);
            Settings.Controls.Add(SaveSet);
            Settings.Controls.Add(ConsoleHideBox);
            Settings.Controls.Add(inittxt);
            Settings.Controls.Add(siticoneCheckBox1);
            Settings.Controls.Add(HotkeyTxT);
            Settings.Location = new Point(4, 44);
            Settings.Margin = new Padding(5, 4, 5, 4);
            Settings.Name = "Settings";
            Settings.Size = new Size(1036, 626);
            Settings.TabIndex = 6;
            Settings.Text = "Settings";
            // 
            // DllNameBox
            // 
            DllNameBox.BorderColor = Color.FromArgb(192, 0, 192);
            DllNameBox.Cursor = Cursors.IBeam;
            DllNameBox.DefaultText = "";
            DllNameBox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            DllNameBox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            DllNameBox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            DllNameBox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            DllNameBox.Enabled = false;
            DllNameBox.FillColor = Color.Black;
            DllNameBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            DllNameBox.Font = new Font("Segoe UI", 9F);
            DllNameBox.ForeColor = Color.FromArgb(192, 0, 192);
            DllNameBox.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            DllNameBox.Location = new Point(774, 129);
            DllNameBox.Margin = new Padding(5, 4, 5, 4);
            DllNameBox.Name = "DllNameBox";
            DllNameBox.PasswordChar = '\0';
            DllNameBox.PlaceholderText = "Dll Name? dont include .dll";
            DllNameBox.SelectedText = "";
            DllNameBox.Size = new Size(218, 40);
            DllNameBox.TabIndex = 39;
            DllNameBox.Visible = false;
            // 
            // ExodusBtn
            // 
            ExodusBtn.BackColor = Color.Transparent;
            ExodusBtn.CheckedState.ImageSize = new Size(64, 64);
            ExodusBtn.Enabled = false;
            ExodusBtn.HoverState.ImageSize = new Size(50, 43);
            ExodusBtn.Image = (Image)resources.GetObject("ExodusBtn.Image");
            ExodusBtn.ImageOffset = new Point(0, 0);
            ExodusBtn.ImageRotate = 0F;
            ExodusBtn.ImageSize = new Size(45, 43);
            ExodusBtn.ImeMode = ImeMode.Disable;
            ExodusBtn.Location = new Point(25, 516);
            ExodusBtn.Margin = new Padding(5, 4, 5, 4);
            ExodusBtn.Name = "ExodusBtn";
            ExodusBtn.PressedState.ImageSize = new Size(45, 43);
            ExodusBtn.Size = new Size(59, 67);
            ExodusBtn.TabIndex = 38;
            ExodusBtn.TabStop = false;
            ExodusBtn.UseTransparentBackground = true;
            ExodusBtn.Visible = false;
            ExodusBtn.Click += ExodusBtn_Click;
            // 
            // label5
            // 
            label5.BackColor = Color.Transparent;
            label5.Enabled = false;
            label5.Font = new Font("Microsoft Sans Serif", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Magenta;
            label5.Location = new Point(-1, 580);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(34, 37);
            label5.TabIndex = 37;
            label5.Text = "*";
            label5.Visible = false;
            // 
            // Sterni
            // 
            Sterni.BackColor = Color.Transparent;
            Sterni.Font = new Font("Microsoft Sans Serif", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Sterni.ForeColor = Color.Magenta;
            Sterni.Location = new Point(986, 31);
            Sterni.Margin = new Padding(5, 0, 5, 0);
            Sterni.Name = "Sterni";
            Sterni.Size = new Size(34, 37);
            Sterni.TabIndex = 36;
            Sterni.Text = "*";
            Sterni.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Enabled = false;
            label3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Magenta;
            label3.Location = new Point(22, 587);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(499, 20);
            label3.TabIndex = 35;
            label3.Text = "*You will need an Exodus account and a paid subscription.";
            label3.Visible = false;
            // 
            // AutoInjectCB
            // 
            AutoInjectCB.AutoSize = true;
            AutoInjectCB.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            AutoInjectCB.CheckedState.BorderRadius = 0;
            AutoInjectCB.CheckedState.BorderThickness = 0;
            AutoInjectCB.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            AutoInjectCB.ForeColor = Color.Magenta;
            AutoInjectCB.Location = new Point(774, 93);
            AutoInjectCB.Margin = new Padding(5, 4, 5, 4);
            AutoInjectCB.Name = "AutoInjectCB";
            AutoInjectCB.Size = new Size(152, 24);
            AutoInjectCB.TabIndex = 33;
            AutoInjectCB.Text = "Enable Auto Inject";
            AutoInjectCB.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            AutoInjectCB.UncheckedState.BorderRadius = 0;
            AutoInjectCB.UncheckedState.BorderThickness = 0;
            AutoInjectCB.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
            AutoInjectCB.Visible = false;
            // 
            // AutoInjTB
            // 
            AutoInjTB.Animated = true;
            AutoInjTB.Cursor = Cursors.IBeam;
            AutoInjTB.DefaultText = "Here you can allow the AutoInject Dll (RDR2)";
            AutoInjTB.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            AutoInjTB.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            AutoInjTB.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            AutoInjTB.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            AutoInjTB.FillColor = Color.Black;
            AutoInjTB.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            AutoInjTB.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AutoInjTB.ForeColor = Color.Fuchsia;
            AutoInjTB.HideSelection = false;
            AutoInjTB.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            AutoInjTB.Location = new Point(757, 27);
            AutoInjTB.Margin = new Padding(5, 4, 5, 4);
            AutoInjTB.Multiline = true;
            AutoInjTB.Name = "AutoInjTB";
            AutoInjTB.PasswordChar = '\0';
            AutoInjTB.PlaceholderText = "";
            AutoInjTB.ReadOnly = true;
            AutoInjTB.SelectedText = "";
            AutoInjTB.Size = new Size(266, 152);
            AutoInjTB.TabIndex = 34;
            AutoInjTB.Visible = false;
            // 
            // AutoStartBtn
            // 
            AutoStartBtn.DisabledState.BorderColor = Color.DarkGray;
            AutoStartBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            AutoStartBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            AutoStartBtn.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            AutoStartBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            AutoStartBtn.Font = new Font("Segoe UI", 9F);
            AutoStartBtn.ForeColor = Color.White;
            AutoStartBtn.Location = new Point(0, 193);
            AutoStartBtn.Margin = new Padding(5, 4, 5, 4);
            AutoStartBtn.Name = "AutoStartBtn";
            AutoStartBtn.Size = new Size(266, 52);
            AutoStartBtn.TabIndex = 30;
            AutoStartBtn.Text = "Install Autostart";
            AutoStartBtn.Click += ToggleButton_Click;
            // 
            // WS
            // 
            WS.Cursor = Cursors.IBeam;
            WS.DefaultText = "Set Autostart\r\n";
            WS.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            WS.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            WS.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            WS.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            WS.FillColor = Color.Black;
            WS.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            WS.Font = new Font("Segoe UI", 9F);
            WS.ForeColor = Color.Fuchsia;
            WS.HideSelection = false;
            WS.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            WS.Location = new Point(0, 151);
            WS.Margin = new Padding(5, 4, 5, 4);
            WS.Multiline = true;
            WS.Name = "WS";
            WS.PasswordChar = '\0';
            WS.PlaceholderText = "";
            WS.ReadOnly = true;
            WS.SelectedText = "";
            WS.Size = new Size(266, 96);
            WS.TabIndex = 29;
            // 
            // siticoneButton1
            // 
            siticoneButton1.BackColor = Color.Black;
            siticoneButton1.DisabledState.BorderColor = Color.DarkGray;
            siticoneButton1.DisabledState.CustomBorderColor = Color.DarkGray;
            siticoneButton1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            siticoneButton1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            siticoneButton1.FillColor = Color.Black;
            siticoneButton1.Font = new Font("Segoe UI", 9F);
            siticoneButton1.ForeColor = Color.Magenta;
            siticoneButton1.HoverState.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            siticoneButton1.HoverState.ForeColor = Color.Green;
            siticoneButton1.Location = new Point(615, 574);
            siticoneButton1.Margin = new Padding(5, 4, 5, 4);
            siticoneButton1.Name = "siticoneButton1";
            siticoneButton1.Size = new Size(311, 41);
            siticoneButton1.TabIndex = 28;
            siticoneButton1.Text = "Add Exclusion to Windows Defender";
            siticoneButton1.Click += Defender_Click;
            // 
            // SaveSet
            // 
            SaveSet.DisabledState.BorderColor = Color.DarkGray;
            SaveSet.DisabledState.CustomBorderColor = Color.DarkGray;
            SaveSet.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            SaveSet.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            SaveSet.FillColor = Color.Black;
            SaveSet.Font = new Font("Segoe UI", 9F);
            SaveSet.ForeColor = Color.White;
            SaveSet.HoverState.BorderColor = Color.Magenta;
            SaveSet.HoverState.ForeColor = Color.Magenta;
            SaveSet.Location = new Point(926, 574);
            SaveSet.Margin = new Padding(5, 4, 5, 4);
            SaveSet.Name = "SaveSet";
            SaveSet.Size = new Size(97, 40);
            SaveSet.TabIndex = 5;
            SaveSet.Text = "Save";
            SaveSet.Click += SaveSet_Click;
            // 
            // ConsoleHideBox
            // 
            ConsoleHideBox.AutoSize = true;
            ConsoleHideBox.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            ConsoleHideBox.CheckedState.BorderRadius = 0;
            ConsoleHideBox.CheckedState.BorderThickness = 0;
            ConsoleHideBox.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            ConsoleHideBox.ForeColor = Color.Magenta;
            ConsoleHideBox.Location = new Point(280, 111);
            ConsoleHideBox.Margin = new Padding(5, 4, 5, 4);
            ConsoleHideBox.Name = "ConsoleHideBox";
            ConsoleHideBox.Size = new Size(177, 24);
            ConsoleHideBox.TabIndex = 3;
            ConsoleHideBox.Text = "Disable Hide Function";
            ConsoleHideBox.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            ConsoleHideBox.UncheckedState.BorderRadius = 0;
            ConsoleHideBox.UncheckedState.BorderThickness = 0;
            ConsoleHideBox.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
            // 
            // inittxt
            // 
            inittxt.Cursor = Cursors.IBeam;
            inittxt.DefaultText = "Disable the Console Hide Function after Initialize";
            inittxt.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            inittxt.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            inittxt.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            inittxt.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            inittxt.FillColor = Color.Black;
            inittxt.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            inittxt.Font = new Font("Segoe UI", 9F);
            inittxt.ForeColor = Color.Fuchsia;
            inittxt.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            inittxt.Location = new Point(274, 0);
            inittxt.Margin = new Padding(5, 4, 5, 4);
            inittxt.Multiline = true;
            inittxt.Name = "inittxt";
            inittxt.PasswordChar = '\0';
            inittxt.PlaceholderText = "";
            inittxt.SelectedText = "";
            inittxt.Size = new Size(266, 143);
            inittxt.TabIndex = 4;
            // 
            // siticoneCheckBox1
            // 
            siticoneCheckBox1.AutoSize = true;
            siticoneCheckBox1.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            siticoneCheckBox1.CheckedState.BorderRadius = 0;
            siticoneCheckBox1.CheckedState.BorderThickness = 0;
            siticoneCheckBox1.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            siticoneCheckBox1.ForeColor = Color.Magenta;
            siticoneCheckBox1.Location = new Point(7, 109);
            siticoneCheckBox1.Margin = new Padding(5, 4, 5, 4);
            siticoneCheckBox1.Name = "siticoneCheckBox1";
            siticoneCheckBox1.Size = new Size(150, 24);
            siticoneCheckBox1.TabIndex = 1;
            siticoneCheckBox1.Text = "Keyboard Listener";
            siticoneCheckBox1.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            siticoneCheckBox1.UncheckedState.BorderRadius = 0;
            siticoneCheckBox1.UncheckedState.BorderThickness = 0;
            siticoneCheckBox1.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
            // 
            // HotkeyTxT
            // 
            HotkeyTxT.Cursor = Cursors.IBeam;
            HotkeyTxT.DefaultText = "Activate the Hotkey Function";
            HotkeyTxT.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            HotkeyTxT.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            HotkeyTxT.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            HotkeyTxT.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            HotkeyTxT.FillColor = Color.Black;
            HotkeyTxT.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            HotkeyTxT.Font = new Font("Segoe UI", 9F);
            HotkeyTxT.ForeColor = Color.Fuchsia;
            HotkeyTxT.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            HotkeyTxT.Location = new Point(0, 0);
            HotkeyTxT.Margin = new Padding(5, 4, 5, 4);
            HotkeyTxT.Multiline = true;
            HotkeyTxT.Name = "HotkeyTxT";
            HotkeyTxT.PasswordChar = '\0';
            HotkeyTxT.PlaceholderText = "";
            HotkeyTxT.SelectedText = "";
            HotkeyTxT.Size = new Size(266, 141);
            HotkeyTxT.TabIndex = 2;
            // 
            // FixTool
            // 
            FixTool.BackColor = Color.Black;
            FixTool.Controls.Add(RemoveGWLD);
            FixTool.Controls.Add(StateUpd);
            FixTool.Controls.Add(RemovePatch);
            FixTool.Controls.Add(RuntimesText);
            FixTool.Controls.Add(RunTimeDwn);
            FixTool.Controls.Add(PatchText);
            FixTool.Controls.Add(PatchDwn);
            FixTool.Controls.Add(DwnBar);
            FixTool.Controls.Add(GamesWinLiveText);
            FixTool.Controls.Add(GamesWinLiveDwn);
            FixTool.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FixTool.Location = new Point(4, 44);
            FixTool.Margin = new Padding(5, 4, 5, 4);
            FixTool.Name = "FixTool";
            FixTool.Size = new Size(1036, 626);
            FixTool.TabIndex = 5;
            FixTool.Text = "Fix Tools";
            FixTool.Click += FixTool_Click;
            // 
            // RemoveGWLD
            // 
            RemoveGWLD.DisabledState.BorderColor = Color.DarkGray;
            RemoveGWLD.DisabledState.CustomBorderColor = Color.DarkGray;
            RemoveGWLD.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            RemoveGWLD.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            RemoveGWLD.FillColor = Color.Black;
            RemoveGWLD.Font = new Font("Segoe UI", 9F);
            RemoveGWLD.ForeColor = Color.White;
            RemoveGWLD.HoverState.ForeColor = Color.Magenta;
            RemoveGWLD.Location = new Point(10, 280);
            RemoveGWLD.Margin = new Padding(5, 4, 5, 4);
            RemoveGWLD.Name = "RemoveGWLD";
            RemoveGWLD.Size = new Size(266, 36);
            RemoveGWLD.TabIndex = 11;
            RemoveGWLD.Text = "Remove";
            RemoveGWLD.Visible = false;
            RemoveGWLD.Click += RemoveGWLD_Click;
            // 
            // StateUpd
            // 
            StateUpd.DisabledState.BorderColor = Color.DarkGray;
            StateUpd.DisabledState.CustomBorderColor = Color.DarkGray;
            StateUpd.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            StateUpd.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            StateUpd.FillColor = Color.Black;
            StateUpd.Font = new Font("Segoe UI", 9F);
            StateUpd.ForeColor = Color.White;
            StateUpd.HoverState.ForeColor = Color.Magenta;
            StateUpd.Location = new Point(874, 537);
            StateUpd.Margin = new Padding(5, 4, 5, 4);
            StateUpd.Name = "StateUpd";
            StateUpd.Size = new Size(149, 59);
            StateUpd.TabIndex = 10;
            StateUpd.Text = "Update State";
            StateUpd.Click += StateUpd_Click;
            // 
            // RemovePatch
            // 
            RemovePatch.DisabledState.BorderColor = Color.DarkGray;
            RemovePatch.DisabledState.CustomBorderColor = Color.DarkGray;
            RemovePatch.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            RemovePatch.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            RemovePatch.FillColor = Color.Black;
            RemovePatch.Font = new Font("Segoe UI", 9F);
            RemovePatch.ForeColor = Color.White;
            RemovePatch.HoverState.ForeColor = Color.Magenta;
            RemovePatch.Location = new Point(286, 280);
            RemovePatch.Margin = new Padding(5, 4, 5, 4);
            RemovePatch.Name = "RemovePatch";
            RemovePatch.Size = new Size(266, 36);
            RemovePatch.TabIndex = 9;
            RemovePatch.Text = "Remove";
            RemovePatch.Visible = false;
            RemovePatch.Click += RemovePatch_Click;
            // 
            // RuntimesText
            // 
            RuntimesText.Cursor = Cursors.IBeam;
            RuntimesText.DefaultText = "This install all Runtimes from Windows ";
            RuntimesText.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            RuntimesText.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            RuntimesText.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            RuntimesText.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            RuntimesText.Enabled = false;
            RuntimesText.FillColor = Color.Black;
            RuntimesText.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            RuntimesText.Font = new Font("Segoe UI", 9F);
            RuntimesText.ForeColor = Color.Fuchsia;
            RuntimesText.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            RuntimesText.Location = new Point(560, 19);
            RuntimesText.Margin = new Padding(5, 4, 5, 4);
            RuntimesText.Multiline = true;
            RuntimesText.Name = "RuntimesText";
            RuntimesText.PasswordChar = '\0';
            RuntimesText.PlaceholderText = "";
            RuntimesText.SelectedText = "";
            RuntimesText.Size = new Size(266, 208);
            RuntimesText.TabIndex = 7;
            RuntimesText.Visible = false;
            // 
            // RunTimeDwn
            // 
            RunTimeDwn.DisabledState.BorderColor = Color.DarkGray;
            RunTimeDwn.DisabledState.CustomBorderColor = Color.DarkGray;
            RunTimeDwn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            RunTimeDwn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            RunTimeDwn.Enabled = false;
            RunTimeDwn.FillColor = Color.Black;
            RunTimeDwn.Font = new Font("Segoe UI", 9F);
            RunTimeDwn.ForeColor = Color.White;
            RunTimeDwn.HoverState.ForeColor = Color.Magenta;
            RunTimeDwn.Location = new Point(560, 236);
            RunTimeDwn.Margin = new Padding(5, 4, 5, 4);
            RunTimeDwn.Name = "RunTimeDwn";
            RunTimeDwn.Size = new Size(266, 36);
            RunTimeDwn.TabIndex = 6;
            RunTimeDwn.Text = "Download";
            RunTimeDwn.Visible = false;
            RunTimeDwn.Click += RunTimeDwn_Click;
            // 
            // PatchText
            // 
            PatchText.Cursor = Cursors.IBeam;
            PatchText.DefaultText = "This is a Patcher for 32Bit old games to Patch that 4GB for 64Bit";
            PatchText.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            PatchText.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            PatchText.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            PatchText.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            PatchText.FillColor = Color.Black;
            PatchText.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            PatchText.Font = new Font("Segoe UI", 9F);
            PatchText.ForeColor = Color.Fuchsia;
            PatchText.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            PatchText.Location = new Point(286, 19);
            PatchText.Margin = new Padding(5, 4, 5, 4);
            PatchText.Multiline = true;
            PatchText.Name = "PatchText";
            PatchText.PasswordChar = '\0';
            PatchText.PlaceholderText = "";
            PatchText.SelectedText = "";
            PatchText.Size = new Size(266, 208);
            PatchText.TabIndex = 5;
            // 
            // PatchDwn
            // 
            PatchDwn.DisabledState.BorderColor = Color.DarkGray;
            PatchDwn.DisabledState.CustomBorderColor = Color.DarkGray;
            PatchDwn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            PatchDwn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            PatchDwn.FillColor = Color.Black;
            PatchDwn.Font = new Font("Segoe UI", 9F);
            PatchDwn.ForeColor = Color.White;
            PatchDwn.HoverState.ForeColor = Color.Magenta;
            PatchDwn.Location = new Point(286, 236);
            PatchDwn.Margin = new Padding(5, 4, 5, 4);
            PatchDwn.Name = "PatchDwn";
            PatchDwn.Size = new Size(266, 36);
            PatchDwn.TabIndex = 4;
            PatchDwn.Text = "Download";
            PatchDwn.Click += PatchDwn_Click;
            // 
            // DwnBar
            // 
            DwnBar.Animated = true;
            DwnBar.BackColor = Color.Transparent;
            DwnBar.Backwards = true;
            DwnBar.FillColor = Color.FromArgb(200, 213, 218, 223);
            DwnBar.FillThickness = 12;
            DwnBar.Font = new Font("Segoe UI", 12F);
            DwnBar.ForeColor = Color.Magenta;
            DwnBar.Location = new Point(874, 4);
            DwnBar.Margin = new Padding(5, 4, 5, 4);
            DwnBar.Minimum = 0;
            DwnBar.Name = "DwnBar";
            DwnBar.ProgressThickness = 12;
            DwnBar.ShadowDecoration.Mode = Siticone.Desktop.UI.WinForms.Enums.ShadowMode.Circle;
            DwnBar.ShowText = true;
            DwnBar.Size = new Size(144, 144);
            DwnBar.TabIndex = 3;
            DwnBar.Text = "TestProgress";
            DwnBar.Visible = false;
            // 
            // GamesWinLiveText
            // 
            GamesWinLiveText.Cursor = Cursors.IBeam;
            GamesWinLiveText.DefaultText = "Games For Windows Live Service is disabled by Microsoft here u can download the offline setup to start Games that needed This\r\n";
            GamesWinLiveText.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            GamesWinLiveText.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            GamesWinLiveText.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            GamesWinLiveText.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            GamesWinLiveText.FillColor = Color.Black;
            GamesWinLiveText.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            GamesWinLiveText.Font = new Font("Segoe UI", 9F);
            GamesWinLiveText.ForeColor = Color.Fuchsia;
            GamesWinLiveText.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            GamesWinLiveText.Location = new Point(10, 19);
            GamesWinLiveText.Margin = new Padding(5, 4, 5, 4);
            GamesWinLiveText.Multiline = true;
            GamesWinLiveText.Name = "GamesWinLiveText";
            GamesWinLiveText.PasswordChar = '\0';
            GamesWinLiveText.PlaceholderText = "";
            GamesWinLiveText.SelectedText = "";
            GamesWinLiveText.Size = new Size(266, 208);
            GamesWinLiveText.TabIndex = 1;
            // 
            // GamesWinLiveDwn
            // 
            GamesWinLiveDwn.DisabledState.BorderColor = Color.DarkGray;
            GamesWinLiveDwn.DisabledState.CustomBorderColor = Color.DarkGray;
            GamesWinLiveDwn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            GamesWinLiveDwn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            GamesWinLiveDwn.FillColor = Color.Black;
            GamesWinLiveDwn.Font = new Font("Segoe UI", 9F);
            GamesWinLiveDwn.ForeColor = Color.White;
            GamesWinLiveDwn.HoverState.ForeColor = Color.Magenta;
            GamesWinLiveDwn.Location = new Point(10, 236);
            GamesWinLiveDwn.Margin = new Padding(5, 4, 5, 4);
            GamesWinLiveDwn.Name = "GamesWinLiveDwn";
            GamesWinLiveDwn.Size = new Size(266, 36);
            GamesWinLiveDwn.TabIndex = 0;
            GamesWinLiveDwn.Text = "Download";
            GamesWinLiveDwn.Click += GamesWinLiveDwn_Click;
            // 
            // About
            // 
            About.BackColor = Color.Black;
            About.Controls.Add(Repo2);
            About.Controls.Add(CPUStat);
            About.Controls.Add(MBoard);
            About.Controls.Add(CPU);
            About.Controls.Add(GPU);
            About.Controls.Add(TestLabel);
            About.Controls.Add(ConInfo);
            About.Controls.Add(StatusInfo);
            About.Controls.Add(AppVer);
            About.Controls.Add(DCCopyTag);
            About.Controls.Add(linkLabel1);
            About.Controls.Add(label2);
            About.Controls.Add(label1);
            About.Controls.Add(siticonePictureBox1);
            About.Location = new Point(4, 44);
            About.Margin = new Padding(5, 4, 5, 4);
            About.Name = "About";
            About.Padding = new Padding(5, 4, 5, 4);
            About.Size = new Size(1036, 626);
            About.TabIndex = 4;
            About.Text = "About";
            // 
            // Repo2
            // 
            Repo2.AutoSize = true;
            Repo2.Font = new Font("Arial Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Repo2.LinkColor = Color.Magenta;
            Repo2.Location = new Point(711, 583);
            Repo2.Margin = new Padding(5, 0, 5, 0);
            Repo2.Name = "Repo2";
            Repo2.Size = new Size(304, 27);
            Repo2.TabIndex = 42;
            Repo2.TabStop = true;
            Repo2.Text = " Click Here For GitHub Repo";
            Repo2.Click += GithubRepo_Click;
            // 
            // CPUStat
            // 
            CPUStat.AutoSize = true;
            CPUStat.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CPUStat.ForeColor = Color.Fuchsia;
            CPUStat.Location = new Point(4, 552);
            CPUStat.Margin = new Padding(5, 0, 5, 0);
            CPUStat.Name = "CPUStat";
            CPUStat.Size = new Size(150, 20);
            CPUStat.TabIndex = 25;
            CPUStat.Text = "CPU-Status: ???";
            // 
            // MBoard
            // 
            MBoard.AutoSize = true;
            MBoard.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MBoard.ForeColor = Color.Fuchsia;
            MBoard.Location = new Point(4, 580);
            MBoard.Margin = new Padding(5, 0, 5, 0);
            MBoard.Name = "MBoard";
            MBoard.Size = new Size(123, 20);
            MBoard.TabIndex = 24;
            MBoard.Text = "M-Board: ???";
            // 
            // CPU
            // 
            CPU.AutoSize = true;
            CPU.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CPU.ForeColor = Color.Fuchsia;
            CPU.Location = new Point(4, 524);
            CPU.Margin = new Padding(5, 0, 5, 0);
            CPU.Name = "CPU";
            CPU.Size = new Size(89, 20);
            CPU.TabIndex = 23;
            CPU.Text = "CPU: ???";
            // 
            // GPU
            // 
            GPU.AutoSize = true;
            GPU.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GPU.ForeColor = Color.Fuchsia;
            GPU.Location = new Point(4, 497);
            GPU.Margin = new Padding(5, 0, 5, 0);
            GPU.Name = "GPU";
            GPU.Size = new Size(90, 20);
            GPU.TabIndex = 22;
            GPU.Text = "GPU: ???";
            // 
            // TestLabel
            // 
            TestLabel.AutoSize = true;
            TestLabel.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TestLabel.ForeColor = Color.Fuchsia;
            TestLabel.Location = new Point(5, 474);
            TestLabel.Margin = new Padding(5, 0, 5, 0);
            TestLabel.Name = "TestLabel";
            TestLabel.Size = new Size(147, 20);
            TestLabel.TabIndex = 21;
            TestLabel.Text = "OS Version: ???";
            // 
            // ConInfo
            // 
            ConInfo.AutoSize = true;
            ConInfo.Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ConInfo.ForeColor = Color.White;
            ConInfo.Location = new Point(585, 289);
            ConInfo.Margin = new Padding(5, 0, 5, 0);
            ConInfo.Name = "ConInfo";
            ConInfo.Size = new Size(0, 24);
            ConInfo.TabIndex = 20;
            // 
            // StatusInfo
            // 
            StatusInfo.AutoSize = true;
            StatusInfo.Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            StatusInfo.ForeColor = Color.White;
            StatusInfo.Location = new Point(402, 289);
            StatusInfo.Margin = new Padding(5, 0, 5, 0);
            StatusInfo.Name = "StatusInfo";
            StatusInfo.Size = new Size(186, 24);
            StatusInfo.TabIndex = 19;
            StatusInfo.Text = "Connection Status:";
            // 
            // AppVer
            // 
            AppVer.AutoSize = true;
            AppVer.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AppVer.ForeColor = Color.Magenta;
            AppVer.Location = new Point(8, 583);
            AppVer.Margin = new Padding(5, 0, 5, 0);
            AppVer.Name = "AppVer";
            AppVer.Size = new Size(0, 24);
            AppVer.TabIndex = 18;
            // 
            // DCCopyTag
            // 
            DCCopyTag.AutoSize = true;
            DCCopyTag.LinkColor = Color.Magenta;
            DCCopyTag.Location = new Point(2, 37);
            DCCopyTag.Margin = new Padding(5, 0, 5, 0);
            DCCopyTag.Name = "DCCopyTag";
            DCCopyTag.Size = new Size(214, 20);
            DCCopyTag.TabIndex = 7;
            DCCopyTag.TabStop = true;
            DCCopyTag.Text = "Discord Tag:  .reneehopeblasey";
            DCCopyTag.LinkClicked += linkLabel2_LinkClicked;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.Magenta;
            linkLabel1.Location = new Point(2, 84);
            linkLabel1.Margin = new Padding(5, 0, 5, 0);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(231, 20);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Discord Server: Dovahkiin Lounge";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Magenta;
            label2.Location = new Point(43, 64);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(120, 20);
            label2.TabIndex = 5;
            label2.Text = "▼ Click To Join▼";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Magenta;
            label1.Location = new Point(43, 9);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(128, 20);
            label1.TabIndex = 3;
            label1.Text = "▼ Click To Copy▼";
            // 
            // siticonePictureBox1
            // 
            siticonePictureBox1.BackgroundImage = (Image)resources.GetObject("siticonePictureBox1.BackgroundImage");
            siticonePictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            siticonePictureBox1.FillColor = Color.Transparent;
            siticonePictureBox1.ImageRotate = 0F;
            siticonePictureBox1.Location = new Point(402, 9);
            siticonePictureBox1.Margin = new Padding(5, 4, 5, 4);
            siticonePictureBox1.Name = "siticonePictureBox1";
            siticonePictureBox1.Size = new Size(248, 276);
            siticonePictureBox1.TabIndex = 0;
            siticonePictureBox1.TabStop = false;
            // 
            // siticoneTabControl1
            // 
            siticoneTabControl1.Controls.Add(About);
            siticoneTabControl1.Controls.Add(FixTool);
            siticoneTabControl1.Controls.Add(Settings);
            siticoneTabControl1.Controls.Add(Credits);
            siticoneTabControl1.ItemSize = new Size(125, 40);
            siticoneTabControl1.Location = new Point(0, 3);
            siticoneTabControl1.Margin = new Padding(5, 4, 5, 4);
            siticoneTabControl1.Name = "siticoneTabControl1";
            siticoneTabControl1.SelectedIndex = 0;
            siticoneTabControl1.Size = new Size(1044, 674);
            siticoneTabControl1.TabButtonHoverState.BorderColor = Color.Empty;
            siticoneTabControl1.TabButtonHoverState.FillColor = Color.Black;
            siticoneTabControl1.TabButtonHoverState.Font = new Font("Segoe UI Semibold", 10F);
            siticoneTabControl1.TabButtonHoverState.ForeColor = Color.Cyan;
            siticoneTabControl1.TabButtonHoverState.InnerColor = Color.Black;
            siticoneTabControl1.TabButtonIdleState.BorderColor = Color.Empty;
            siticoneTabControl1.TabButtonIdleState.FillColor = Color.Black;
            siticoneTabControl1.TabButtonIdleState.Font = new Font("Segoe UI Semibold", 10F);
            siticoneTabControl1.TabButtonIdleState.ForeColor = Color.White;
            siticoneTabControl1.TabButtonIdleState.InnerColor = Color.Black;
            siticoneTabControl1.TabButtonSelectedState.BorderColor = Color.Empty;
            siticoneTabControl1.TabButtonSelectedState.FillColor = Color.FromArgb(29, 37, 49);
            siticoneTabControl1.TabButtonSelectedState.Font = new Font("Segoe UI Semibold", 10F);
            siticoneTabControl1.TabButtonSelectedState.ForeColor = Color.White;
            siticoneTabControl1.TabButtonSelectedState.InnerColor = Color.FromArgb(76, 132, 255);
            siticoneTabControl1.TabButtonSize = new Size(125, 40);
            siticoneTabControl1.TabIndex = 0;
            siticoneTabControl1.TabMenuBackColor = Color.Black;
            siticoneTabControl1.TabMenuOrientation = Siticone.Desktop.UI.WinForms.TabMenuOrientation.HorizontalTop;
            siticoneTabControl1.SelectedIndexChanged += siticoneTabControl1_SelectedIndexChanged;
            // 
            // Infos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1043, 677);
            Controls.Add(ExitBtn);
            Controls.Add(siticoneTabControl1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5, 4, 5, 4);
            Name = "Infos";
            Text = "Information";
            Load += Infos_Load;
            Credits.ResumeLayout(false);
            Credits.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DCAV2).EndInit();
            ((System.ComponentModel.ISupportInitialize)DCAV1).EndInit();
            Settings.ResumeLayout(false);
            Settings.PerformLayout();
            FixTool.ResumeLayout(false);
            About.ResumeLayout(false);
            About.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)siticonePictureBox1).EndInit();
            siticoneTabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox ExitBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneDeviceInfo DeviceInfo;
        private Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm BorderInfo;
        private Siticone.Desktop.UI.WinForms.SiticoneTaskBarProgress TaskPRogress;
        private System.Windows.Forms.FolderBrowserDialog FolderDial;
        private System.ComponentModel.BackgroundWorker Automation;
        private Siticone.Desktop.UI.WinForms.SiticoneTabControl siticoneTabControl1;
        private System.Windows.Forms.TabPage About;
        private System.Windows.Forms.LinkLabel Repo2;
        private System.Windows.Forms.Label CPUStat;
        private System.Windows.Forms.Label MBoard;
        private System.Windows.Forms.Label CPU;
        private System.Windows.Forms.Label GPU;
        private System.Windows.Forms.Label TestLabel;
        private System.Windows.Forms.Label ConInfo;
        private System.Windows.Forms.Label StatusInfo;
        private System.Windows.Forms.Label AppVer;
        private System.Windows.Forms.LinkLabel DCCopyTag;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Siticone.Desktop.UI.WinForms.SiticonePictureBox siticonePictureBox1;
        private System.Windows.Forms.TabPage FixTool;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox RuntimesText;
        private Siticone.Desktop.UI.WinForms.SiticoneButton RunTimeDwn;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox PatchText;
        private Siticone.Desktop.UI.WinForms.SiticoneButton PatchDwn;
        private Siticone.Desktop.UI.WinForms.SiticoneCircleProgressBar DwnBar;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox GamesWinLiveText;
        private Siticone.Desktop.UI.WinForms.SiticoneButton GamesWinLiveDwn;
        private System.Windows.Forms.TabPage Settings;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox DllNameBox;
        protected internal Siticone.Desktop.UI.WinForms.SiticoneImageButton ExodusBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Sterni;
        private System.Windows.Forms.Label label3;
        private Siticone.Desktop.UI.WinForms.SiticoneCheckBox AutoInjectCB;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox AutoInjTB;
        private Siticone.Desktop.UI.WinForms.SiticoneGradientButton AutoStartBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox WS;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton SaveSet;
        private Siticone.Desktop.UI.WinForms.SiticoneCheckBox ConsoleHideBox;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox inittxt;
        private Siticone.Desktop.UI.WinForms.SiticoneCheckBox siticoneCheckBox1;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox HotkeyTxT;
        private System.Windows.Forms.TabPage Credits;
        private System.Windows.Forms.Label CRA2;
        private System.Windows.Forms.Label CRA;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox PhilInfo;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox CeliInfo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label DCName2;
        private System.Windows.Forms.PictureBox DCAV2;
        private System.Windows.Forms.Label DCName;
        private System.Windows.Forms.PictureBox DCAV1;
        private System.Windows.Forms.Label GLName;
        private System.Windows.Forms.Label GLName2;
        private Siticone.Desktop.UI.WinForms.SiticoneButton RemovePatch;
        private Siticone.Desktop.UI.WinForms.SiticoneButton StateUpd;
        private Siticone.Desktop.UI.WinForms.SiticoneButton RemoveGWLD;
    }
}