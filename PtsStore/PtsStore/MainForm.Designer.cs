
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
            this.lbDate = new Bunifu.UI.WinForms.BunifuLabel();
            this.lbTime = new Bunifu.UI.WinForms.BunifuLabel();
            this.lbHello = new Bunifu.UI.WinForms.BunifuLabel();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.pnMenu = new System.Windows.Forms.Panel();
            this.panelSide = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.btnMinize = new Bunifu.UI.WinForms.BunifuImageButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnBookSale = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.pnMenu.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbDate
            // 
            this.lbDate.AllowParentOverrides = false;
            this.lbDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDate.AutoEllipsis = false;
            this.lbDate.CursorType = null;
            this.lbDate.Font = new System.Drawing.Font("Comic Sans MS", 18F);
            this.lbDate.Location = new System.Drawing.Point(890, 49);
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
            this.lbTime.Font = new System.Drawing.Font("Comic Sans MS", 17.25F);
            this.lbTime.Location = new System.Drawing.Point(905, 19);
            this.lbTime.Name = "lbTime";
            this.lbTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbTime.Size = new System.Drawing.Size(98, 31);
            this.lbTime.TabIndex = 1;
            this.lbTime.Text = "24:24:24";
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
            this.lbHello.Location = new System.Drawing.Point(22, 34);
            this.lbHello.Name = "lbHello";
            this.lbHello.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbHello.Size = new System.Drawing.Size(192, 27);
            this.lbHello.TabIndex = 0;
            this.lbHello.Text = "Hello Phạm Tiến Sỹ";
            this.lbHello.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lbHello.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // pnMenu
            // 
            this.pnMenu.BackColor = System.Drawing.Color.SeaGreen;
            this.pnMenu.Controls.Add(this.panelSide);
            this.pnMenu.Controls.Add(this.panel4);
            this.pnMenu.Controls.Add(this.button1);
            this.pnMenu.Controls.Add(this.button2);
            this.pnMenu.Controls.Add(this.btnBookSale);
            this.pnMenu.Controls.Add(this.btnHome);
            this.pnMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnMenu.Location = new System.Drawing.Point(0, 0);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(240, 811);
            this.pnMenu.TabIndex = 4;
            // 
            // panelSide
            // 
            this.panelSide.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelSide.Location = new System.Drawing.Point(0, 240);
            this.panelSide.Name = "panelSide";
            this.panelSide.Size = new System.Drawing.Size(8, 60);
            this.panelSide.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnMinize);
            this.panel4.Controls.Add(this.bunifuLabel2);
            this.panel4.Controls.Add(this.bunifuLabel1);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(240, 180);
            this.panel4.TabIndex = 22;
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.CursorType = null;
            this.bunifuLabel2.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel2.Location = new System.Drawing.Point(58, 138);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(101, 29);
            this.bunifuLabel2.TabIndex = 6;
            this.bunifuLabel2.Text = "Book Shop";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel1.Location = new System.Drawing.Point(91, 110);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(36, 57);
            this.bunifuLabel1.TabIndex = 5;
            this.bunifuLabel1.Text = "PtS\r\n\r\n";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SeaGreen;
            this.panel3.Controls.Add(this.lbDate);
            this.panel3.Controls.Add(this.lbHello);
            this.panel3.Controls.Add(this.lbTime);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(240, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1044, 90);
            this.panel3.TabIndex = 6;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
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
            this.btnMinize.Location = new System.Drawing.Point(186, 3);
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
            this.btnMinize.Click += new System.EventHandler(this.btnMinize_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(58, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(101, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.SeaGreen;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::PtsStore.Properties.Resources.home;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(4, 510);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(2);
            this.button1.Size = new System.Drawing.Size(233, 60);
            this.button1.TabIndex = 21;
            this.button1.Text = "   Home";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.BackColor = System.Drawing.Color.SeaGreen;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::PtsStore.Properties.Resources.home;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(4, 420);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(2);
            this.button2.Size = new System.Drawing.Size(233, 60);
            this.button2.TabIndex = 20;
            this.button2.Text = "   Home";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btnBookSale
            // 
            this.btnBookSale.AutoSize = true;
            this.btnBookSale.BackColor = System.Drawing.Color.SeaGreen;
            this.btnBookSale.FlatAppearance.BorderSize = 0;
            this.btnBookSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookSale.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookSale.ForeColor = System.Drawing.Color.White;
            this.btnBookSale.Image = global::PtsStore.Properties.Resources.home;
            this.btnBookSale.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBookSale.Location = new System.Drawing.Point(4, 330);
            this.btnBookSale.Name = "btnBookSale";
            this.btnBookSale.Padding = new System.Windows.Forms.Padding(2);
            this.btnBookSale.Size = new System.Drawing.Size(233, 60);
            this.btnBookSale.TabIndex = 19;
            this.btnBookSale.Text = "   Sale";
            this.btnBookSale.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBookSale.UseVisualStyleBackColor = false;
            this.btnBookSale.Click += new System.EventHandler(this.btnBookSale_Click_1);
            // 
            // btnHome
            // 
            this.btnHome.AutoSize = true;
            this.btnHome.BackColor = System.Drawing.Color.SeaGreen;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = global::PtsStore.Properties.Resources.home;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(4, 240);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(2);
            this.btnHome.Size = new System.Drawing.Size(233, 60);
            this.btnHome.TabIndex = 18;
            this.btnHome.Text = "   Home";
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click_1);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 811);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnMenu);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.pnMenu.ResumeLayout(false);
            this.pnMenu.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuLabel lbTime;
        private Bunifu.UI.WinForms.BunifuLabel lbHello;
        private System.Windows.Forms.Timer timer2;
        private Bunifu.UI.WinForms.BunifuLabel lbDate;
        private System.Windows.Forms.Panel pnMenu;
        private System.Windows.Forms.Panel panelSide;
        private Bunifu.UI.WinForms.BunifuImageButton btnMinize;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnBookSale;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel panel4;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer3;
    }
}