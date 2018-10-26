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
    public partial class Geschiedenis : Form
    {
        public Geschiedenis()
        {
            InitializeComponent();
        }

        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            this.pictureBoxBack.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Terugklik));
            this.Close();
        }

        private void pictureBoxOpen_Click(object sender, EventArgs e)
        {
            this.pictureBoxOpen.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Openklik));
            this.Close();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem.ToString() == "Grot 1")
            {
                pictureGrot1.Visible = true;
                pictureGrot2.Visible = false;
                pictureGrot3.Visible = false;
                pictureGrot4.Visible = false;
                pictureGrot5.Visible = false;
            }
            else if (listBox2.SelectedItem.ToString() == "Grot 2")
            {
                pictureGrot1.Visible = false;
                pictureGrot2.Visible = true;
                pictureGrot3.Visible = false;
                pictureGrot4.Visible = false;
                pictureGrot5.Visible = false;
            }
            else if (listBox2.SelectedItem.ToString() == "Grot 3")
            {
                pictureGrot1.Visible = false;
                pictureGrot2.Visible = false;
                pictureGrot3.Visible = true;
                pictureGrot4.Visible = false;
                pictureGrot5.Visible = false;
            }
            else if (listBox2.SelectedItem.ToString() == "Grot 4")
            {
                pictureGrot1.Visible = false;
                pictureGrot2.Visible = false;
                pictureGrot3.Visible = false;
                pictureGrot4.Visible = true;
                pictureGrot5.Visible = false;
            }
            else if (listBox2.SelectedItem.ToString() == "Grot 5")
            {
                pictureGrot1.Visible = false;
                pictureGrot2.Visible = false;
                pictureGrot3.Visible = false;
                pictureGrot4.Visible = false;
                pictureGrot5.Visible = true;
            }
        }

        private void pictureBoxOpen_MouseEnter(object sender, EventArgs e)
        {
            this.pictureBoxOpen.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Openhover));
        }

        private void pictureBoxOpen_MouseLeave(object sender, EventArgs e)
        {
            this.pictureBoxOpen.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Opennormaal));
        }

        private void pictureBoxBack_MouseEnter(object sender, EventArgs e)
        {
            this.pictureBoxBack.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Terughover));
        }

        private void pictureBoxBack_MouseLeave(object sender, EventArgs e)
        {
            this.pictureBoxBack.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Terugnormaal));
        }
    }
}
