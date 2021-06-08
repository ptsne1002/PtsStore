
namespace PtsStore
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbDate = new Bunifu.UI.WinForms.BunifuLabel();
            this.lbTime = new Bunifu.UI.WinForms.BunifuLabel();
            this.lbHello = new Bunifu.UI.WinForms.BunifuLabel();
            this.panelMenu = new Bunifu.UI.WinForms.BunifuPanel();
            this.panelSide = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnBookSale = new System.Windows.Forms.Button();
            this.bunifuPanel2 = new Bunifu.UI.WinForms.BunifuPanel();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.btnMinize = new Bunifu.UI.WinForms.BunifuImageButton();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnHome = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel2.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.bunifuPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SeaGreen;
            this.panel2.Controls.Add(this.lbDate);
            this.panel2.Controls.Add(this.lbTime);
            this.panel2.Controls.Add(this.lbHello);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(255, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1029, 71);
            this.panel2.TabIndex = 2;
            // 
            // lbDate
            // 
            this.lbDate.AllowParentOverrides = false;
            this.lbDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDate.AutoEllipsis = false;
            this.lbDate.CursorType = null;
            this.lbDate.Font = new System.Drawing.Font("Comic Sans MS", 18F);
            this.lbDate.Location = new System.Drawing.Point(863, 35);
            this.lbDate.Name = "lbDate";
            this.lbDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbDate.Size = new System.Drawing.Size(128, 33);
            this.lbDate.TabIndex = 2;
            this.lbDate.Text = "11/12/2021";
            this.lbDate.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lbDate.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lbTime
            // 
            this.lbTime.AllowParentOverrides = false;
            this.lbTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTime.AutoEllipsis = false;
            this.lbTime.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbTime.CursorType = System.Windows.Forms.Cursors.Default;
            this.lbTime.Font = new System.Drawing.Font("Comic Sans MS", 18F);
            this.lbTime.Location = new System.Drawing.Point(884, 0);
            this.lbTime.Name = "lbTime";
            this.lbTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbTime.Size = new System.Drawing.Size(80, 33);
            this.lbTime.TabIndex = 1;
            this.lbTime.Text = "11:11:11";
            this.lbTime.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lbTime.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lbHello
            // 
            this.lbHello.AllowParentOverrides = false;
            this.lbHello.AutoEllipsis = false;
            this.lbHello.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbHello.CursorType = System.Windows.Forms.Cursors.Default;
            this.lbHello.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.lbHello.Location = new System.Drawing.Point(26, 19);
            this.lbHello.Name = "lbHello";
            this.lbHello.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbHello.Size = new System.Drawing.Size(192, 27);
            this.lbHello.TabIndex = 0;
            this.lbHello.Text = "Hello Phạm Tiến Sỹ";
            this.lbHello.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lbHello.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // panelMenu
            // 
            this.panelMenu.BackgroundColor = System.Drawing.Color.SeaGreen;
            this.panelMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelMenu.BackgroundImage")));
            this.panelMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelMenu.BorderColor = System.Drawing.Color.Transparent;
            this.panelMenu.BorderRadius = 3;
            this.panelMenu.BorderThickness = 1;
            this.panelMenu.Controls.Add(this.panelSide);
            this.panelMenu.Controls.Add(this.button4);
            this.panelMenu.Controls.Add(this.button3);
            this.panelMenu.Controls.Add(this.btnBookSale);
            this.panelMenu.Controls.Add(this.bunifuPanel2);
            this.panelMenu.Controls.Add(this.btnHome);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.ShowBorders = true;
            this.panelMenu.Size = new System.Drawing.Size(255, 811);
            this.panelMenu.TabIndex = 0;
            // 
            // panelSide
            // 
            this.panelSide.Location = new System.Drawing.Point(3, 200);
            this.panelSide.Name = "panelSide";
            this.panelSide.Size = new System.Drawing.Size(10, 60);
            this.panelSide.TabIndex = 3;
            // 
            // button4
            // 
            this.button4.AutoSize = true;
            this.button4.BackColor = System.Drawing.Color.SeaGreen;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(16, 470);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(2);
            this.button4.Size = new System.Drawing.Size(233, 60);
            this.button4.TabIndex = 17;
            this.button4.Text = "   Home";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.BackColor = System.Drawing.Color.SeaGreen;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(16, 380);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(2);
            this.button3.Size = new System.Drawing.Size(233, 60);
            this.button3.TabIndex = 16;
            this.button3.Text = "   Home";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // btnBookSale
            // 
            this.btnBookSale.AutoSize = true;
            this.btnBookSale.BackColor = System.Drawing.Color.SeaGreen;
            this.btnBookSale.FlatAppearance.BorderSize = 0;
            this.btnBookSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookSale.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookSale.ForeColor = System.Drawing.Color.White;
            this.btnBookSale.Image = ((System.Drawing.Image)(resources.GetObject("btnBookSale.Image")));
            this.btnBookSale.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBookSale.Location = new System.Drawing.Point(16, 290);
            this.btnBookSale.Name = "btnBookSale";
            this.btnBookSale.Padding = new System.Windows.Forms.Padding(2);
            this.btnBookSale.Size = new System.Drawing.Size(233, 60);
            this.btnBookSale.TabIndex = 15;
            this.btnBookSale.Text = "   Home";
            this.btnBookSale.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBookSale.UseVisualStyleBackColor = false;
            this.btnBookSale.Click += new System.EventHandler(this.btnBookSale_Click);
            // 
            // bunifuPanel2
            // 
            this.bunifuPanel2.BackgroundColor = System.Drawing.Color.SeaGreen;
            this.bunifuPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel2.BackgroundImage")));
            this.bunifuPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel2.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel2.BorderRadius = 3;
            this.bunifuPanel2.BorderThickness = 1;
            this.bunifuPanel2.Controls.Add(this.bunifuLabel2);
            this.bunifuPanel2.Controls.Add(this.btnMinize);
            this.bunifuPanel2.Controls.Add(this.bunifuLabel1);
            this.bunifuPanel2.Controls.Add(this.pictureBox1);
            this.bunifuPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuPanel2.Location = new System.Drawing.Point(0, 0);
            this.bunifuPanel2.Name = "bunifuPanel2";
            this.bunifuPanel2.ShowBorders = true;
            this.bunifuPanel2.Size = new System.Drawing.Size(255, 180);
            this.bunifuPanel2.TabIndex = 3;
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.CursorType = null;
            this.bunifuLabel2.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel2.Location = new System.Drawing.Point(75, 141);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(112, 33);
            this.bunifuLabel2.TabIndex = 3;
            this.bunifuLabel2.Text = "BookShop";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // btnMinize
            // 
            this.btnMinize.ActiveImage = null;
            this.btnMinize.AllowAnimations = true;
            this.btnMinize.AllowBuffering = false;
            this.btnMinize.AllowToggling = false;
            this.btnMinize.AllowZooming = true;
            this.btnMinize.AllowZoomingOnFocus = false;
            this.btnMinize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMinize.BackgroundImage")));
            this.btnMinize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMinize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinize.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnMinize.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnMinize.ErrorImage")));
            this.btnMinize.FadeWhenInactive = false;
            this.btnMinize.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnMinize.Image = null;
            this.btnMinize.ImageActive = null;
            this.btnMinize.ImageLocation = null;
            this.btnMinize.ImageMargin = 40;
            this.btnMinize.ImageSize = new System.Drawing.Size(10, 9);
            this.btnMinize.ImageZoomSize = new System.Drawing.Size(50, 49);
            this.btnMinize.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnMinize.InitialImage")));
            this.btnMinize.Location = new System.Drawing.Point(202, 3);
            this.btnMinize.Name = "btnMinize";
            this.btnMinize.Rotation = 0;
            this.btnMinize.ShowActiveImage = true;
            this.btnMinize.ShowCursorChanges = true;
            this.btnMinize.ShowImageBorders = true;
            this.btnMinize.ShowSizeMarkers = false;
            this.btnMinize.Size = new System.Drawing.Size(50, 49);
            this.btnMinize.TabIndex = 2;
            this.btnMinize.ToolTipText = "";
            this.btnMinize.WaitOnLoad = false;
            this.btnMinize.Zoom = 40;
            this.btnMinize.ZoomSpeed = 10;
            this.btnMinize.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel1.Location = new System.Drawing.Point(102, 110);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(40, 64);
            this.bunifuLabel1.TabIndex = 1;
            this.bunifuLabel1.Text = "PtS\r\n\r\n";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(75, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnHome
            // 
            this.btnHome.AutoSize = true;
            this.btnHome.BackColor = System.Drawing.Color.SeaGreen;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(16, 200);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(2);
            this.btnHome.Size = new System.Drawing.Size(233, 60);
            this.btnHome.TabIndex = 14;
            this.btnHome.Text = "   Home";
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 811);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelMenu);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.bunifuPanel2.ResumeLayout(false);
            this.bunifuPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel panelMenu;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel2;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.UI.WinForms.BunifuImageButton btnMinize;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnHome;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnBookSale;
        private System.Windows.Forms.Panel panelSide;
        private Bunifu.UI.WinForms.BunifuLabel lbTime;
        private Bunifu.UI.WinForms.BunifuLabel lbHello;
        private System.Windows.Forms.Timer timer2;
        private Bunifu.UI.WinForms.BunifuLabel lbDate;
    }
}