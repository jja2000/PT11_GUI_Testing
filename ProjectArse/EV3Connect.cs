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
    public partial class EV3Connect : Form
    {
        public static EV3Connect staticVar = null;

        public EV3Wifi myEV3;
        public EV3Connect()
        {
            myEV3 = new EV3Wifi();
            InitializeComponent();
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            foreach (Start Homescreen in Application.OpenForms.OfType<Start>())
            {
                string ipAddress = ipAddressBox.Text;
                if (!IPAddress.TryParse(ipAddress, out IPAddress address))
                {
                    MessageBox.Show("Fill in valid IP address of EV3");
                }
                else if (myEV3.Connect("1234", ipAddress) == true)
                {
                    Homescreen.UpdateButtonsAndConnectionInfo();
                    Homescreen.messageReceiveTimer.Start();
                }
                else
                {
                    myEV3.Disconnect();
                    MessageBox.Show("Failed to connect to EV3 with IP address " + ipAddress);
                }
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
            bool isConnected = myEV3.isConnected;
            this.pictureBack.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Terugklik));
            if (isConnected)
            {
                staticVar = this;
                this.Hide();
            }
            else if (!isConnected)
            {
                this.Close();
            }
        }

        private void disconnectButton_Click(object sender, EventArgs e)
        {
            foreach (Start Homescreen in Application.OpenForms.OfType<Start>())
            {
                Homescreen.messageReceiveTimer.Stop();
                myEV3.Disconnect();
                Homescreen.UpdateButtonsAndConnectionInfo();
                Homescreen.pictureBoxConnection.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Nietverbondenhover));
                staticVar = null;
            }
        }
    }
}
