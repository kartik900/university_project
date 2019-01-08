namespace sms
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.header = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCheckbox1 = new Bunifu.Framework.UI.BunifuCheckbox();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCheckbox2 = new Bunifu.Framework.UI.BunifuCheckbox();
            this.userbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.passbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.close = new Bunifu.Framework.UI.BunifuImageButton();
            this.loginbutton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.SystemColors.HotTrack;
            this.header.Controls.Add(this.close);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(561, 220);
            this.header.TabIndex = 6;
            this.header.Paint += new System.Windows.Forms.PaintEventHandler(this.header_Paint);
            this.header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseDown);
            this.header.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseMove);
            this.header.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseUp);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(88, 466);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(113, 32);
            this.bunifuCustomLabel2.TabIndex = 10;
            this.bunifuCustomLabel2.Text = "Password";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(88, 362);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(133, 32);
            this.bunifuCustomLabel1.TabIndex = 11;
            this.bunifuCustomLabel1.Text = "User Name";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(88, 248);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(214, 32);
            this.bunifuCustomLabel4.TabIndex = 11;
            this.bunifuCustomLabel4.Text = "Select Designation";
            // 
            // bunifuCheckbox1
            // 
            this.bunifuCheckbox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.bunifuCheckbox1.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.bunifuCheckbox1.Checked = true;
            this.bunifuCheckbox1.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.bunifuCheckbox1.ForeColor = System.Drawing.Color.White;
            this.bunifuCheckbox1.Location = new System.Drawing.Point(94, 311);
            this.bunifuCheckbox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuCheckbox1.Name = "bunifuCheckbox1";
            this.bunifuCheckbox1.Size = new System.Drawing.Size(20, 20);
            this.bunifuCheckbox1.TabIndex = 12;
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(130, 299);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(89, 32);
            this.bunifuCustomLabel5.TabIndex = 11;
            this.bunifuCustomLabel5.Text = "Faculty";
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(338, 299);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(99, 32);
            this.bunifuCustomLabel6.TabIndex = 11;
            this.bunifuCustomLabel6.Text = "Student";
            // 
            // bunifuCheckbox2
            // 
            this.bunifuCheckbox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.bunifuCheckbox2.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.bunifuCheckbox2.Checked = true;
            this.bunifuCheckbox2.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.bunifuCheckbox2.ForeColor = System.Drawing.Color.White;
            this.bunifuCheckbox2.Location = new System.Drawing.Point(302, 311);
            this.bunifuCheckbox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuCheckbox2.Name = "bunifuCheckbox2";
            this.bunifuCheckbox2.Size = new System.Drawing.Size(20, 20);
            this.bunifuCheckbox2.TabIndex = 12;
            // 
            // userbox
            // 
            this.userbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.userbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.userbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.userbox.HintForeColor = System.Drawing.Color.Empty;
            this.userbox.HintText = "";
            this.userbox.isPassword = false;
            this.userbox.LineFocusedColor = System.Drawing.Color.Blue;
            this.userbox.LineIdleColor = System.Drawing.Color.Gray;
            this.userbox.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.userbox.LineThickness = 3;
            this.userbox.Location = new System.Drawing.Point(94, 389);
            this.userbox.Margin = new System.Windows.Forms.Padding(4);
            this.userbox.Name = "userbox";
            this.userbox.Size = new System.Drawing.Size(370, 44);
            this.userbox.TabIndex = 13;
            this.userbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // passbox
            // 
            this.passbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.passbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.passbox.HintForeColor = System.Drawing.Color.Empty;
            this.passbox.HintText = "";
            this.passbox.isPassword = true;
            this.passbox.LineFocusedColor = System.Drawing.Color.Blue;
            this.passbox.LineIdleColor = System.Drawing.Color.Gray;
            this.passbox.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.passbox.LineThickness = 3;
            this.passbox.Location = new System.Drawing.Point(94, 502);
            this.passbox.Margin = new System.Windows.Forms.Padding(4);
            this.passbox.Name = "passbox";
            this.passbox.Size = new System.Drawing.Size(370, 44);
            this.passbox.TabIndex = 13;
            this.passbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // close
            // 
            this.close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.close.BackColor = System.Drawing.Color.Transparent;
            this.close.Image = ((System.Drawing.Image)(resources.GetObject("close.Image")));
            this.close.ImageActive = null;
            this.close.Location = new System.Drawing.Point(528, 3);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(30, 30);
            this.close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.close.TabIndex = 2;
            this.close.TabStop = false;
            this.close.Zoom = 10;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // loginbutton
            // 
            this.loginbutton.ActiveBorderThickness = 1;
            this.loginbutton.ActiveCornerRadius = 20;
            this.loginbutton.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.loginbutton.ActiveForecolor = System.Drawing.Color.White;
            this.loginbutton.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.loginbutton.BackColor = System.Drawing.Color.White;
            this.loginbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("loginbutton.BackgroundImage")));
            this.loginbutton.ButtonText = "Login";
            this.loginbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbutton.ForeColor = System.Drawing.Color.SeaGreen;
            this.loginbutton.IdleBorderThickness = 1;
            this.loginbutton.IdleCornerRadius = 20;
            this.loginbutton.IdleFillColor = System.Drawing.Color.White;
            this.loginbutton.IdleForecolor = System.Drawing.SystemColors.HotTrack;
            this.loginbutton.IdleLineColor = System.Drawing.SystemColors.HotTrack;
            this.loginbutton.Location = new System.Drawing.Point(162, 578);
            this.loginbutton.Margin = new System.Windows.Forms.Padding(5);
            this.loginbutton.Name = "loginbutton";
            this.loginbutton.Size = new System.Drawing.Size(201, 56);
            this.loginbutton.TabIndex = 14;
            this.loginbutton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.loginbutton.Click += new System.EventHandler(this.loginbutton_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(561, 740);
            this.Controls.Add(this.loginbutton);
            this.Controls.Add(this.passbox);
            this.Controls.Add(this.userbox);
            this.Controls.Add(this.bunifuCheckbox2);
            this.Controls.Add(this.bunifuCheckbox1);
            this.Controls.Add(this.header);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.bunifuCustomLabel6);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "login";
            this.Text = "login";
            this.header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel header;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCheckbox bunifuCheckbox1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuCheckbox bunifuCheckbox2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox userbox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox passbox;
        private Bunifu.Framework.UI.BunifuImageButton close;
        private Bunifu.Framework.UI.BunifuThinButton2 loginbutton;
    }
}