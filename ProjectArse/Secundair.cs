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
    public partial class Secundair : Form
    {
        public Secundair()
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
            EV3Connect connection = new EV3Connect();
            connection.Show();
        }

        private void pictureBoxNotConnected_Click(object sender, EventArgs e)
        {
            this.pictureBoxNotConnected.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Nietverbondenklik));
            EV3Connect connection = new EV3Connect();
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
