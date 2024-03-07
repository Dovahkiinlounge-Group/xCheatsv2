namespace xCheats.Overlay
{
    partial class RE5___Overlay
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
            this.siticonePanel1 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.money = new System.Windows.Forms.Label();
            this.siticonePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // siticonePanel1
            // 
            this.siticonePanel1.BackColor = System.Drawing.Color.Wheat;
            this.siticonePanel1.BorderRadius = 2;
            this.siticonePanel1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.siticonePanel1.BorderThickness = 5;
            this.siticonePanel1.Controls.Add(this.money);
            this.siticonePanel1.CustomBorderColor = System.Drawing.Color.Fuchsia;
            this.siticonePanel1.Location = new System.Drawing.Point(12, 12);
            this.siticonePanel1.Name = "siticonePanel1";
            this.siticonePanel1.Size = new System.Drawing.Size(200, 244);
            this.siticonePanel1.TabIndex = 0;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // money
            // 
            this.money.AutoSize = true;
            this.money.BackColor = System.Drawing.Color.Transparent;
            this.money.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.money.ForeColor = System.Drawing.Color.Magenta;
            this.money.Location = new System.Drawing.Point(12, 20);
            this.money.Name = "money";
            this.money.Size = new System.Drawing.Size(76, 25);
            this.money.TabIndex = 0;
            this.money.Text = "label1";
            // 
            // RE5___Overlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.siticonePanel1);
            this.Name = "RE5___Overlay";
            this.Text = "RE5___Overlay";
            this.Load += new System.EventHandler(this.RE5___Overlay_Load);
            this.siticonePanel1.ResumeLayout(false);
            this.siticonePanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label money;
    }
}