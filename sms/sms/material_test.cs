using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sms
{
    public partial class material_test : Form
    {
        public material_test()
        {
            InitializeComponent();
        }

        private bool mouseDown;
        private Point lastLocation;
        #region panel drag

        private void panelHeader_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void panelHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point((this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();
            }
        }

        private void panelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;

        }
        #endregion

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void menu_Click(object sender, EventArgs e)
        {
            if (drawer.Visible) drawhide.HideSync(drawer);
            else drawshow.ShowSync(drawer);
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {

        }
    }
}
