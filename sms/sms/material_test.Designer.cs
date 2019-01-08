namespace sms
{
    partial class material_test
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
            BunifuAnimatorNS.Animation animation6 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation5 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(material_test));
            this.drawer = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.content = new System.Windows.Forms.Panel();
            this.belowheader = new System.Windows.Forms.Panel();
            this.header = new System.Windows.Forms.Panel();
            this.menu = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.homebutton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.drawshow = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.drawhide = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.drawer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.content.SuspendLayout();
            this.belowheader.SuspendLayout();
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // drawer
            // 
            this.drawer.BackColor = System.Drawing.Color.White;
            this.drawer.Controls.Add(this.bunifuFlatButton2);
            this.drawer.Controls.Add(this.bunifuFlatButton1);
            this.drawer.Controls.Add(this.homebutton);
            this.drawer.Controls.Add(this.pictureBox1);
            this.drawhide.SetDecoration(this.drawer, BunifuAnimatorNS.DecorationType.None);
            this.drawshow.SetDecoration(this.drawer, BunifuAnimatorNS.DecorationType.None);
            this.drawer.Dock = System.Windows.Forms.DockStyle.Left;
            this.drawer.Location = new System.Drawing.Point(0, 0);
            this.drawer.Name = "drawer";
            this.drawer.Size = new System.Drawing.Size(265, 715);
            this.drawer.TabIndex = 0;
            this.drawer.Visible = false;
            // 
            // pictureBox1
            // 
            this.drawshow.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.drawhide.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(265, 178);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // content
            // 
            this.content.BackColor = System.Drawing.Color.White;
            this.content.Controls.Add(this.belowheader);
            this.drawhide.SetDecoration(this.content, BunifuAnimatorNS.DecorationType.None);
            this.drawshow.SetDecoration(this.content, BunifuAnimatorNS.DecorationType.None);
            this.content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.content.Location = new System.Drawing.Point(265, 0);
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(809, 715);
            this.content.TabIndex = 1;
            // 
            // belowheader
            // 
            this.belowheader.BackColor = System.Drawing.Color.Purple;
            this.belowheader.Controls.Add(this.header);
            this.drawhide.SetDecoration(this.belowheader, BunifuAnimatorNS.DecorationType.None);
            this.drawshow.SetDecoration(this.belowheader, BunifuAnimatorNS.DecorationType.None);
            this.belowheader.Dock = System.Windows.Forms.DockStyle.Top;
            this.belowheader.Location = new System.Drawing.Point(0, 0);
            this.belowheader.Name = "belowheader";
            this.belowheader.Size = new System.Drawing.Size(809, 104);
            this.belowheader.TabIndex = 0;
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(0)))), ((int)(((byte)(85)))));
            this.header.Controls.Add(this.bunifuImageButton1);
            this.header.Controls.Add(this.menu);
            this.drawhide.SetDecoration(this.header, BunifuAnimatorNS.DecorationType.None);
            this.drawshow.SetDecoration(this.header, BunifuAnimatorNS.DecorationType.None);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(809, 45);
            this.header.TabIndex = 1;
            this.header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseDown);
            this.header.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseMove);
            this.header.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseUp);
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(0)))), ((int)(((byte)(85)))));
            this.menu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.drawhide.SetDecoration(this.menu, BunifuAnimatorNS.DecorationType.None);
            this.drawshow.SetDecoration(this.menu, BunifuAnimatorNS.DecorationType.None);
            this.menu.Image = ((System.Drawing.Image)(resources.GetObject("menu.Image")));
            this.menu.ImageActive = null;
            this.menu.Location = new System.Drawing.Point(6, 4);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(30, 30);
            this.menu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.menu.TabIndex = 1;
            this.menu.TabStop = false;
            this.menu.Zoom = 10;
            this.menu.Click += new System.EventHandler(this.menu_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(0)))), ((int)(((byte)(85)))));
            this.drawhide.SetDecoration(this.bunifuImageButton1, BunifuAnimatorNS.DecorationType.None);
            this.drawshow.SetDecoration(this.bunifuImageButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(776, 4);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(30, 30);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 1;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // homebutton
            // 
            this.homebutton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.homebutton.BackColor = System.Drawing.Color.White;
            this.homebutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.homebutton.BorderRadius = 0;
            this.homebutton.ButtonText = "HOME";
            this.homebutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.drawhide.SetDecoration(this.homebutton, BunifuAnimatorNS.DecorationType.None);
            this.drawshow.SetDecoration(this.homebutton, BunifuAnimatorNS.DecorationType.None);
            this.homebutton.DisabledColor = System.Drawing.Color.Gray;
            this.homebutton.Dock = System.Windows.Forms.DockStyle.Top;
            this.homebutton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homebutton.ForeColor = System.Drawing.Color.Black;
            this.homebutton.Iconcolor = System.Drawing.Color.Transparent;
            this.homebutton.Iconimage = null;
            this.homebutton.Iconimage_right = null;
            this.homebutton.Iconimage_right_Selected = null;
            this.homebutton.Iconimage_Selected = null;
            this.homebutton.IconMarginLeft = 0;
            this.homebutton.IconMarginRight = 0;
            this.homebutton.IconRightVisible = true;
            this.homebutton.IconRightZoom = 0D;
            this.homebutton.IconVisible = true;
            this.homebutton.IconZoom = 90D;
            this.homebutton.IsTab = true;
            this.homebutton.Location = new System.Drawing.Point(0, 178);
            this.homebutton.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.homebutton.Name = "homebutton";
            this.homebutton.Normalcolor = System.Drawing.Color.White;
            this.homebutton.OnHovercolor = System.Drawing.Color.Gainsboro;
            this.homebutton.OnHoverTextColor = System.Drawing.Color.Purple;
            this.homebutton.selected = true;
            this.homebutton.Size = new System.Drawing.Size(265, 97);
            this.homebutton.TabIndex = 1;
            this.homebutton.Text = "HOME";
            this.homebutton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.homebutton.Textcolor = System.Drawing.Color.Gray;
            this.homebutton.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homebutton.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "HOME";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.drawhide.SetDecoration(this.bunifuFlatButton1, BunifuAnimatorNS.DecorationType.None);
            this.drawshow.SetDecoration(this.bunifuFlatButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuFlatButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.ForeColor = System.Drawing.Color.Black;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = null;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = true;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(0, 275);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.Gainsboro;
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.Purple;
            this.bunifuFlatButton1.selected = true;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(265, 97);
            this.bunifuFlatButton1.TabIndex = 2;
            this.bunifuFlatButton1.Text = "HOME";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "HOME";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.drawhide.SetDecoration(this.bunifuFlatButton2, BunifuAnimatorNS.DecorationType.None);
            this.drawshow.SetDecoration(this.bunifuFlatButton2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuFlatButton2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.ForeColor = System.Drawing.Color.Black;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = null;
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 90D;
            this.bunifuFlatButton2.IsTab = true;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(0, 372);
            this.bunifuFlatButton2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.Gainsboro;
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.Purple;
            this.bunifuFlatButton2.selected = true;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(265, 97);
            this.bunifuFlatButton2.TabIndex = 3;
            this.bunifuFlatButton2.Text = "HOME";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // drawshow
            // 
            this.drawshow.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.drawshow.Cursor = null;
            animation6.AnimateOnlyDifferences = true;
            animation6.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.BlindCoeff")));
            animation6.LeafCoeff = 0F;
            animation6.MaxTime = 1F;
            animation6.MinTime = 0F;
            animation6.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.MosaicCoeff")));
            animation6.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation6.MosaicShift")));
            animation6.MosaicSize = 0;
            animation6.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            animation6.RotateCoeff = 0F;
            animation6.RotateLimit = 0F;
            animation6.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.ScaleCoeff")));
            animation6.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.SlideCoeff")));
            animation6.TimeCoeff = 0F;
            animation6.TransparencyCoeff = 0F;
            this.drawshow.DefaultAnimation = animation6;
            // 
            // drawhide
            // 
            this.drawhide.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.drawhide.Cursor = null;
            animation5.AnimateOnlyDifferences = true;
            animation5.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.BlindCoeff")));
            animation5.LeafCoeff = 0F;
            animation5.MaxTime = 1F;
            animation5.MinTime = 0F;
            animation5.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.MosaicCoeff")));
            animation5.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation5.MosaicShift")));
            animation5.MosaicSize = 0;
            animation5.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            animation5.RotateCoeff = 0F;
            animation5.RotateLimit = 0F;
            animation5.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.ScaleCoeff")));
            animation5.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.SlideCoeff")));
            animation5.TimeCoeff = 0F;
            animation5.TransparencyCoeff = 0F;
            this.drawhide.DefaultAnimation = animation5;
            // 
            // material_test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1074, 715);
            this.Controls.Add(this.content);
            this.Controls.Add(this.drawer);
            this.drawshow.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.drawhide.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "material_test";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "material_test";
            this.drawer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.content.ResumeLayout(false);
            this.belowheader.ResumeLayout(false);
            this.header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.menu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel drawer;
        private System.Windows.Forms.Panel content;
        private System.Windows.Forms.Panel belowheader;
        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuImageButton menu;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuFlatButton homebutton;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private BunifuAnimatorNS.BunifuTransition drawhide;
        private BunifuAnimatorNS.BunifuTransition drawshow;
    }
}