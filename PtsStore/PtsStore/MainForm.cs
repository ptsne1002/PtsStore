using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PtsStore
{
    public partial class MainForm : Form
    {
        int panelWidth;
        bool isCollapsed;
        public MainForm()
        {
            InitializeComponent();
            panelWidth = panelMenu.Width;
            isCollapsed = false;
            timer2.Start();
            lbHello.Text = "Hello "+Temp.staffName;
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hello");
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void movieSidePanel(Control btn)
        {
            panelSide.Top = btn.Top;
            panelSide.Height = btn.Height;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                panelMenu.Width = panelMenu.Width + 20;
                if (panelMenu.Width >= panelWidth)
                {
                    timer1.Stop();
                    isCollapsed = false;
                    this.Refresh();
                }
            }
            else
            {
                panelMenu.Width = panelMenu.Width - 20;
                if(panelMenu.Width <= 65)
                {
                    timer1.Stop();
                    isCollapsed = true;
                    this.Refresh();
                }
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            movieSidePanel(btnHome);
        }

        private void btnBookSale_Click(object sender, EventArgs e)
        {
            movieSidePanel(btnBookSale);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            lbTime.Text = DateTime.Now.ToString("HH:mm:ss");
            lbDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

    }
}
