using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectMarse
{
    public partial class EV3Connect : Form
    {
        public EV3Connect()
        {
            InitializeComponent();
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            if (ipAddressBox.Text.Length == 0)
            {
                MessageBox.Show("Fill in valid IP address of EV3.");
            }
            else
            {
                MessageBox.Show("EV3 connected.");
            }
        }

        private void pictureBack_MouseEnter(object sender, EventArgs e)
        {
            this.pictureBack.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Terughover));
        }

        private void pictureBack_MouseLeave(object sender, EventArgs e)
        {
            this.pictureBack.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Terugnormaal));
        }

        private void pictureBack_MouseClick(object sender, MouseEventArgs e)
        {
            this.pictureBack.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Terugklik));
            this.Close();
        }
    }
}
