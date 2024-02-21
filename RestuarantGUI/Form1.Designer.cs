namespace RestuarantGUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.Chicken = new System.Windows.Forms.RadioButton();
            this.Rice = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Sidebar.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Sidebar
            // 
            this.Sidebar.AutoScroll = true;
            this.Sidebar.Controls.Add(this.Chicken);
            this.Sidebar.Controls.Add(this.Rice);
            this.Sidebar.Controls.Add(this.radioButton1);
            this.Sidebar.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.Sidebar.Location = new System.Drawing.Point(12, 12);
            this.Sidebar.Name = "Sidebar";
            this.Sidebar.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.Sidebar.Size = new System.Drawing.Size(175, 382);
            this.Sidebar.TabIndex = 0;
            this.Sidebar.WrapContents = false;
            // 
            // Chicken
            // 
            this.Chicken.Appearance = System.Windows.Forms.Appearance.Button;
            this.Chicken.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Chicken.BackgroundImage = global::RestuarantGUI.Properties.Resources.Chimken;
            this.Chicken.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Chicken.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Chicken.Cursor = System.Windows.Forms.Cursors.Default;
            this.Chicken.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Chicken.Location = new System.Drawing.Point(3, 3);
            this.Chicken.Name = "Chicken";
            this.Chicken.Size = new System.Drawing.Size(139, 144);
            this.Chicken.TabIndex = 0;
            this.Chicken.UseVisualStyleBackColor = false;
            this.Chicken.CheckedChanged += new System.EventHandler(this.Chicken_CheckedChanged);
            // 
            // Rice
            // 
            this.Rice.Appearance = System.Windows.Forms.Appearance.Button;
            this.Rice.BackgroundImage = global::RestuarantGUI.Properties.Resources.Roice;
            this.Rice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Rice.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Rice.Location = new System.Drawing.Point(3, 153);
            this.Rice.Name = "Rice";
            this.Rice.Size = new System.Drawing.Size(139, 125);
            this.Rice.TabIndex = 1;
            this.Rice.UseVisualStyleBackColor = true;
            this.Rice.CheckedChanged += new System.EventHandler(this.Rice_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton1.BackgroundImage = global::RestuarantGUI.Properties.Resources.Spaghetti;
            this.radioButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.radioButton1.Cursor = System.Windows.Forms.Cursors.Default;
            this.radioButton1.Location = new System.Drawing.Point(3, 284);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(149, 111);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button2, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(262, 165);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(710, 468);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(348, 226);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(358, 237);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(349, 228);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(366, 70);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(990, 658);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.Sidebar);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Form1";
            this.Sidebar.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel Sidebar;
        private System.Windows.Forms.RadioButton Chicken;
        private System.Windows.Forms.RadioButton Rice;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

