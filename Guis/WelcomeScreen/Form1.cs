using AxWMPLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Guis
{
    public partial class Form1 : Form
    {
        //TODO
        // IMPLEMENT TEXT GUIDE
        // VIDEO

        //jesus lord above this is scuffed

        public Form1()
        {
            InitializeComponent();
            OrderLabel.cornerRadius = 30;
            OrderLabel.borderWidth = 2;
            OrderLabel.borderColor = Color.White;
            OrderLabel.Parent = pictureBox1;
            OrderLabel.BackColor = Color.Transparent;
            OrderLabel.Text = "ORDER HERE";

            ResName.Parent = pictureBox1;
            ResName.BackColor = Color.Transparent;

            ResKiosk.Parent = pictureBox4;
            ResKiosk.BackColor = Color.Transparent;

            pictureBox5.Parent = pictureBox4;
            pictureBox5.BackColor = Color.Transparent;  
            
            
            KioskVidPlayer.uiMode = "none";
            KioskVidPlayer.URL = "D:\\DownloadsPC\\Gear5th.mp4";
            KioskVidPlayer.settings.setMode("loop", true);
            KioskVidPlayer.settings.autoStart = true;
            KioskVidPlayer.stretchToFit = true;

            InfoPanel.FadeOut(0);

            label1.Parent = InfoPanel;








        }

        


        private void OrderLabel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("WORKS");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (InfoPanel.Hidden)
            {
                KioskVidPlayer.Ctlcontrols.pause();
                InfoPanel.FadeIn(500);
                fadePanel1.FadeIn(600);
                fadePanel2.FadeIn(700);
                fadePanel3.FadeIn(800);
                fadePanel4.FadeIn(900);
                fadePanel5.FadeIn(1000);
            }
            else if (!InfoPanel.Hidden)
            {
                InfoPanel.FadeOut(1000);
                fadePanel1.FadeOut(500);
                fadePanel2.FadeOut(600);
                fadePanel3.FadeOut(700);
                fadePanel4.FadeOut(800);
                fadePanel5.FadeOut(900);
                KioskVidPlayer.Ctlcontrols.play();

            }                

        }

    }
}
