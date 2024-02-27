using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminGui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SidePanel.BackColor = Color.FromArgb(255, 8, 103, 67);
            
            label1.Parent = SidePanel;
            label1.BackColor = Color.Transparent;
            ConfirmOrderText.Parent = SidePanel;
            ConfirmOrderText.BackColor = Color.Transparent;
            DisplayQueueText.Parent = SidePanel;
            DisplayQueueText.BackColor = Color.Transparent;
            ViewStockText.Parent = SidePanel;
            ViewStockText.BackColor = Color.Transparent;

            AdminVideoPlayer.URL = "C:\\Users\\Test\\source\\repos\\practice\\Guis\\AdminGui\\Resources\\KioskVid.mp4";
            AdminVideoPlayer.uiMode = "none";
            AdminVideoPlayer.settings.setMode("loop", true);
            AdminVideoPlayer.settings.autoStart = true;
            AdminVideoPlayer.stretchToFit = true;

        }


    }
}
