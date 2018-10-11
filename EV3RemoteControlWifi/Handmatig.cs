using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Net;
using EV3WifiLib;


namespace EV3RemoteControl
{
    public partial class Handmatig : Form
    {
        private EV3Wifi myEV3;
        public Handmatig()
        {
            InitializeComponent();
        }

        private void buttonForward_Click(object sender, EventArgs e)
        {
            // Send message "Forward" to EV3.
            if (myEV3.isConnected)
            {
                myEV3.SendMessage("Forward", "0");  // "0" means EV3_INBOX0
            }
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            if (myEV3.isConnected)
            {
                myEV3.SendMessage("Stop", "0");  // "0" means EV3_INBOX0
            }
            this.Close();
        }
    }
}
