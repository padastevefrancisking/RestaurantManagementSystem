using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantGUITemp
{
    public partial class Form1 : Form
    {
        
        FlowLayoutPanel categoryPNL = new FlowLayoutPanel();
        public Form1()
        {
            InitializeComponent();
            //Lord Jesus Forgive me for my sins

            categoryPNL.Anchor = AnchorStyles.Left | AnchorStyles.Top;
            categoryPNL.FlowDirection = FlowDirection.TopDown;
            categoryPNL.Dock = DockStyle.Left;
            categoryPNL.WrapContents = false;
            categoryPNL.AutoScroll = true;
            categoryPNL.VerticalScroll.Visible = false;
            categoryPNL.VerticalScroll.Maximum = 280;
            categoryPNL.AutoSize = false;
            categoryPNL.Padding = new System.Windows.Forms.Padding(0,0,25,0);

            for (int i = 0; i < 4; i++)
            {
                RadioButton r = new RadioButton();
                Object rm = Properties.Resources.ResourceManager.GetObject("Picture" + (i+1).ToString());
                Bitmap myImage = (Bitmap)rm;
                Image image = myImage;
                r.BackgroundImage = image;
                r.BackgroundImageLayout = ImageLayout.Stretch;
                r.AutoSize = false;
                r.Name = i.ToString();
                r.Size = new Size(150, 150);
                r.Dock = DockStyle.Left;
                r.Appearance = Appearance.Button;
                r.CheckedChanged += RBEvent;
                categoryPNL.Controls.Add(r);
                
            }

            this.Controls.Add(categoryPNL);





        }

        private void RBEvent(object sender, EventArgs e) 
        { 
           RadioButton rb = (RadioButton)sender;

           if (rb.Checked && rb.Name == "0")
            {
                tableLayoutPanel1.Visible = true;
            }

           else
            {
                tableLayoutPanel1.Visible = false;
            }
            
        
        
        
        }
        

    }
}
