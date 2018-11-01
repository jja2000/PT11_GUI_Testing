using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Net;
using EV3WifiLib;

namespace ProjectMarse
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void buttonAutomatic_Click(object sender, EventArgs e)
        {
            foreach (EV3Connect Connect in Application.OpenForms.OfType<EV3Connect>())
            {
                Connect.myEV3.SendMessage("Auto", "0");  // "0" means EV3_INBOX0
            }
            this.Close();
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            foreach (EV3Connect Connect in Application.OpenForms.OfType<EV3Connect>())
            {
                Connect.myEV3.SendMessage("Stop", "0");  // "0" means EV3_INBOX0
            }
        }

        private void buttonRight_Click(object sender, EventArgs e)
        {
            foreach (EV3Connect Connect in Application.OpenForms.OfType<EV3Connect>())
            {
                Connect.myEV3.SendMessage("Right", "0");  // "0" means EV3_INBOX0
            }
        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {
            foreach (EV3Connect Connect in Application.OpenForms.OfType<EV3Connect>())
            {
                Connect.myEV3.SendMessage("Left", "0");  // "0" means EV3_INBOX0
            }
        }

        private void buttonForward_Click(object sender, EventArgs e)
        {
            foreach (EV3Connect Connect in Application.OpenForms.OfType<EV3Connect>())
            {
                Connect.myEV3.SendMessage("Forward", "0");  // "0" means EV3_INBOX0
            }
        }

        private void buttonBackward_Click(object sender, EventArgs e)
        {
            foreach (EV3Connect Connect in Application.OpenForms.OfType<EV3Connect>())
            {
                Connect.myEV3.SendMessage("Backward", "0");  // "0" means EV3_INBOX0
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            foreach (EV3Connect Connect in Application.OpenForms.OfType<EV3Connect>())
            {
                if (Connect.myEV3.isConnected)
                {
                    Connect.myEV3.SendMessage("Stop", "0");  // "0" means EV3_INBOX0

                }
                else if (Connect.myEV3.isConnected)
                {
                    MessageBox.Show("Connection lost, try to reconnect.");
                }
            }
        }
    }
}
