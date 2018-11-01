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
        public int USDistance;
        public int Angle;
        public int SonarDistanceLinks;
        public int SonarDistanceRechts;

        public Secundair()
        {
            InitializeComponent();
            afstandLinks.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
            afstandRechts.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
        }

        public void UpdateDistanceIcons()
        {
            if (USDistance < 25)
            {
                this.afstandVoor.Image = ((System.Drawing.Image)(Properties.Resources.three));
            }
            else if (USDistance >= 25 && USDistance < 30)
            {
                this.afstandVoor.Image = ((System.Drawing.Image)(Properties.Resources.two));
            }
            else if (USDistance >= 30)
            {
                this.afstandVoor.Image = ((System.Drawing.Image)(Properties.Resources.one));
            }

            if (SonarDistanceRechts < 10)
            {
                this.afstandRechts.Image = ((System.Drawing.Image)(Properties.Resources.three));
                afstandRechts.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            }
            else if (SonarDistanceRechts >= 10 && SonarDistanceRechts < 17)
            {
                this.afstandRechts.Image = ((System.Drawing.Image)(Properties.Resources.two));
                afstandRechts.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            }
            else if (SonarDistanceRechts >= 17)
            {
                this.afstandRechts.Image = ((System.Drawing.Image)(Properties.Resources.one));
                afstandRechts.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            }

            if (SonarDistanceLinks < 10)
            {
                this.afstandLinks.Image = ((System.Drawing.Image)(Properties.Resources.three));
                afstandLinks.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
            }
            else if (SonarDistanceLinks >= 10 && SonarDistanceLinks < 17)
            {
                this.afstandLinks.Image = ((System.Drawing.Image)(Properties.Resources.two));
                afstandLinks.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
            }
            else if (SonarDistanceLinks >= 17)
            {
                this.afstandLinks.Image = ((System.Drawing.Image)(Properties.Resources.one));
                afstandLinks.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
            }
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
    }
}
