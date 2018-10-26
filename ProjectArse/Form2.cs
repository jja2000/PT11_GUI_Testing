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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            this.pictureBoxBack.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Terugklik));
            this.Close();
        }

        private void pictureBoxBack_MouseEnter(object sender, EventArgs e)
        {
            this.pictureBoxBack.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Terughover));
        }

        private void pictureBoxBack_MouseLeave(object sender, EventArgs e)
        {
            this.pictureBoxBack.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Terugnormaal));
        }

        private void pictureBoxMoving_MouseEnter(object sender, EventArgs e)
        {
            this.pictureBoxMoving.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Verbondenhover));
        }

        private void pictureBoxMoving_MouseLeave(object sender, EventArgs e)
        {
            this.pictureBoxMoving.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Verbondennormaal));
        }

        private void pictureBoxMoving_Click(object sender, EventArgs e)
        {
            this.pictureBoxMoving.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Verbondenklik));
            Form5 connection = new Form5();
            connection.Show();
        }

        private void pictureBoxNotConnected_Click(object sender, EventArgs e)
        {
            this.pictureBoxNotConnected.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Nietverbondenklik));
            Form5 connection = new Form5();
            connection.Show();
        }

        private void pictureBoxNotConnected_MouseEnter(object sender, EventArgs e)
        {
            this.pictureBoxNotConnected.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Nietverbondenhover));
        }

        private void pictureBoxNotConnected_MouseLeave(object sender, EventArgs e)
        {
            this.pictureBoxNotConnected.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Nietverbondennormaal));
        }
    }
}
