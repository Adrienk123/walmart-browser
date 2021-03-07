using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Custom_browser
{
    public partial class Main : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")] 
        private static extern IntPtr CreateRoundRectRgn
         (
         int nLeftRect,
         int nTopRect,
         int nRightRect,
         int nBottomRect,
         int nWidthEllipse,
         int nHeightEllipse
         );
        public Main()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 5, 5));
        }
        Point lastPoint;
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizebutton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void settingsbutton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Debug");
        }

        private void url_TextChanged(object sender, EventArgs e)
        {

        }

        private void search_Click(object sender, EventArgs e)
        {
            string website = url.Text;
            string w = "www";
            if (url.Text == "")
            {
                MessageBox.Show("Please enter a URL to lookup!", "Walmart Browser");
            }

            try 
            {
                browser.Url = new System.Uri($"{website}", System.UriKind.Absolute);
            }

            catch
            {
                MessageBox.Show($"{w} was not provided in the url.{Environment.NewLine} Example Url: https://www.youtube.com", "Walmart browser");
            }
            
        }

        private void dragbar_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void dragbar_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
    }
}
