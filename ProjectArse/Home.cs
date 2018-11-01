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

    public partial class Start : Form
    {
        public EV3Wifi myEV3;

        public Timer messageReceiveTimer;

        public bool started = false;

        EV3Connect connection = new EV3Connect();
        Secundair statistics = new Secundair();

        int i;

        public Start()
        {
                InitializeComponent();
                myEV3 = new EV3Wifi();
                messageReceiveTimer = new Timer();
                messageReceiveTimer.Interval = 100;

                messageReceiveTimer.Tick += new System.EventHandler(messageReadTimer_Tick);
                UpdateButtonsAndConnectionInfo();
        }

        public void messageReadTimer_Tick(object sender, EventArgs e)
        {
            if (myEV3.isConnected)
            {
                this.pictureBoxConnection.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Nietverbondennormaal));                
            }
            else if (!myEV3.isConnected)
            {
                this.pictureBoxConnection.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Verbondennormaal));
                // EV3: ReceiveMessage is asynchronous so it actually gets the message read at the previous call to ReceiveMessage
                //      and it triggers reading the next message from the specified mailbox.
                //      Due to the simple implementation the message read does not contain information of the mailbox it came from.
                //      Therefore the advise is to only use one mailbox to read from: EV3_OUTBOX0.
                foreach (EV3Connect Connect in Application.OpenForms.OfType<EV3Connect>())
                {
                    string strMessage = Connect.myEV3.ReceiveMessage("EV3_OUTBOX0");

                    if (strMessage != "")
                    {
                        string[] data = strMessage.Split(' ');
                        if (data.Length == 4)
                        {
                            foreach (Secundair statistics in Application.OpenForms.OfType<Secundair>())
                            {
                                statistics.Angle = Convert.ToInt32(data[0]);
                                statistics.USDistance = Convert.ToInt32(data[1]);
                                statistics.SonarDistanceRechts = Convert.ToInt32(data[2]);
                                statistics.SonarDistanceLinks = Convert.ToInt32(data[3]);
                            }
                        }
                    }
                }
                statistics.UpdateDistanceIcons();
            }
        }

        public void UpdateButtonsAndConnectionInfo()
        {
            foreach (EV3Connect Connect in Application.OpenForms.OfType<EV3Connect>())
            {
                bool isConnected = Connect.myEV3.isConnected;

                Connect.connectButton.Enabled = !isConnected;
                Connect.disconnectButton.Enabled = isConnected;

                if (isConnected)
                {
                    Connect.connectedDeviceLabel.Text = "Connected to EV3\n" + "IP address:" + Connect.myEV3.ipAddress;
                    Connect.connectedDeviceLabel.BackColor = Color.LightGreen;
                }
                else
                {
                    Connect.connectedDeviceLabel.Text = "No connection";
                    Connect.connectedDeviceLabel.BackColor = Color.Red;
                }
            }
                
        }

        private void pictureBoxStart_Click(object sender, EventArgs e)
        {
            foreach (EV3Connect Connect in Application.OpenForms.OfType<EV3Connect>())
            {
                if (Connect.myEV3.isConnected)
                {
                    Connect.myEV3.SendMessage("Auto", "0");  // "0" means EV3_INBOX0
                    pictureBoxStart.Visible = false;
                    pictureBoxStop.Visible = true;
                    pictureBoxRemote.Visible = true;
                }
            }
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
            foreach (EV3Connect Connect in Application.OpenForms.OfType<EV3Connect>())
            {
                if (Connect.myEV3.isConnected)
                {
                    Connect.myEV3.SendMessage("Stop", "0");  // "0" means EV3_INBOX0
                    this.pictureBoxStop.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Stopklik));
                    pictureBoxStart.Visible = true;
                    pictureBoxStop.Visible = false;
                    pictureBoxRemote.Visible = false;
                }
                else if (Connect.myEV3.isConnected)
                {
                    MessageBox.Show("Connection lost, try to reconnect.");
                }
            }
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
            //Secundair statistics = new Secundair();
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
            Geschiedenis history = new Geschiedenis();
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
                if (EV3Connect.staticVar == null)
                {
                    EV3Connect connection = new EV3Connect();
                    connection.Show();
                }
                else if (EV3Connect.staticVar != null)
                {
                    EV3Connect.staticVar.Show();
                }
        }

        private void pictureBoxConnection_MouseEnter(object sender, EventArgs e)
        {
            if (EV3Connect.staticVar == null)
            {
                this.pictureBoxConnection.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Nietverbondenhover));
            }
            else if (EV3Connect.staticVar != null)
            {
                this.pictureBoxConnection.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Verbondenhover));
            }
        }

        private void pictureBoxConnection_MouseLeave(object sender, EventArgs e)
        {
            if (EV3Connect.staticVar == null)
            {
                this.pictureBoxConnection.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Nietverbondennormaal));
            }
            else if (EV3Connect.staticVar != null)
            {
                this.pictureBoxConnection.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Verbondennormaal));
            }
        }

        private void Start_KeyDown(object sender, KeyEventArgs e)
        {
                if (i == 0)
                {
                    this.pictureBoxMap.Image = null;
                    if (e.KeyCode == Keys.Right)
                    {
                        i++;
                    }
                }
                else if (i == 1)
                {
                    this.pictureBoxMap.Image = ((System.Drawing.Image)(Properties.Resources.Mapping1));
                    if (e.KeyCode == Keys.Right)
                    {
                        i++;
                    }
                }
                else if (i == 2)
                {
                    this.pictureBoxMap.Image = ((System.Drawing.Image)(Properties.Resources.Mapping2));
                    if (e.KeyCode == Keys.Right)
                    {
                        i++;
                    }
                }
                else if (i == 3)
                {
                    this.pictureBoxMap.Image = ((System.Drawing.Image)(Properties.Resources.Mapping3));
                    if (e.KeyCode == Keys.Right)
                    {
                        i++;
                    }
                }

                else if (i == 4)
                {
                    this.pictureBoxMap.Image = ((System.Drawing.Image)(Properties.Resources.Mapping4));
                    if (e.KeyCode == Keys.Right)
                    {
                        i++;
                    }
                }

                else if (i == 5)
                {
                    this.pictureBoxMap.Image = ((System.Drawing.Image)(Properties.Resources.Mapping5));
                    if (e.KeyCode == Keys.Right)
                    {
                        i++;
                    }
                }
                else if (i == 6)
                {
                    i = 0;
                }
                

        }
    }
}
