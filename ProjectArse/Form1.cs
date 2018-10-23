using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectArse
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void pictureBoxStart_Click(object sender, EventArgs e)
        {
            this.pictureBoxStart.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Startklik));
            pictureBoxStart.Visible = false;
            pictureBoxStop.Visible = true;
            pictureBoxRemote.Visible = true;
        }

        private void pictureBoxStart_MouseEnter(object sender, EventArgs e)
        {
            this.pictureBoxStart.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Starthover));
        }

        private void pictureBoxStart_MouseLeave(object sender, EventArgs e)
        {
            this.pictureBoxStart.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Startnormaal));
        }

        private void pictureBoxStop_Click(object sender, EventArgs e)
        {
            this.pictureBoxStop.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Stopklik));
            pictureBoxStart.Visible = true;
            pictureBoxStop.Visible = false;
            pictureBoxRemote.Visible = false;
        }

        private void pictureBoxStop_MouseEnter(object sender, EventArgs e)
        {
            this.pictureBoxStop.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Stophover));
        }

        private void pictureBoxStop_MouseLeave(object sender, EventArgs e)
        {
            this.pictureBoxStop.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Stopnormaal));
        }

        private void pictureBoxStatistics_Click(object sender, EventArgs e)
        {
            this.pictureBoxStatistics.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Statistiekklik));
            Form2 statistics = new Form2();
            statistics.Show();
        }

        private void pictureBoxStatistics_MouseEnter(object sender, EventArgs e)
        {
            this.pictureBoxStatistics.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Statistiekhover));
        }

        private void pictureBoxStatistics_MouseLeave(object sender, EventArgs e)
        {
            this.pictureBoxStatistics.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Statistieknormaal));
        }

        private void pictureBoxHistory_Click(object sender, EventArgs e)
        {
            this.pictureBoxHistory.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Geschiedenisklik));
            Form4 history = new Form4();
            history.Show();
        }

        private void pictureBoxHistory_MouseEnter(object sender, EventArgs e)
        {
            this.pictureBoxHistory.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Geschiedenishover));
        }

        private void pictureBoxHistory_MouseLeave(object sender, EventArgs e)
        {
            this.pictureBoxHistory.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Geschiedenisnormaal));
        }

        private void pictureBoxRemote_Click(object sender, EventArgs e)
        {
            this.pictureBoxRemote.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Handmatigklik));
            Form3 remote = new Form3();
            remote.Show();
        }

        private void pictureBoxRemote_MouseEnter(object sender, EventArgs e)
        {
            this.pictureBoxRemote.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Handmatighover));
        }

        private void pictureBoxRemote_MouseLeave(object sender, EventArgs e)
        {
            this.pictureBoxRemote.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Handmatignormaal));
        }

        private void pictureBoxConnection_Click(object sender, EventArgs e)
        {
            this.pictureBoxConnection.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Verbondenklik));
            Form5 connection = new Form5();
            connection.Show();
        }

        private void pictureBoxConnection_MouseEnter(object sender, EventArgs e)
        {
            this.pictureBoxConnection.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Verbondenhover));
        }

        private void pictureBoxConnection_MouseLeave(object sender, EventArgs e)
        {
            this.pictureBoxConnection.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Verbondennormaal));
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
