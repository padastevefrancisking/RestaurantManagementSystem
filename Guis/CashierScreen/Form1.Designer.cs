namespace AdminGui
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ConfirmOrderText = new System.Windows.Forms.Label();
            this.DisplayQueueText = new System.Windows.Forms.Label();
            this.ViewStockText = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.roundLabel3 = new RoundBorderLabel.RoundLabel();
            this.roundLabel2 = new RoundBorderLabel.RoundLabel();
            this.roundLabel1 = new RoundBorderLabel.RoundLabel();
            this.AdminVideoPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AdminVideoPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 780F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Saira SemiCondensed SemiCond", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 1);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 449);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.AdminVideoPlayer);
            this.panel1.Location = new System.Drawing.Point(20, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.tableLayoutPanel1.SetRowSpan(this.panel1, 2);
            this.panel1.Size = new System.Drawing.Size(780, 449);
            this.panel1.TabIndex = 0;
            // 
            // ConfirmOrderText
            // 
            this.ConfirmOrderText.BackColor = System.Drawing.Color.DimGray;
            this.ConfirmOrderText.Font = new System.Drawing.Font("Saira SemiCondensed SemiCond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmOrderText.ForeColor = System.Drawing.Color.White;
            this.ConfirmOrderText.Location = new System.Drawing.Point(0, 155);
            this.ConfirmOrderText.Margin = new System.Windows.Forms.Padding(0);
            this.ConfirmOrderText.Name = "ConfirmOrderText";
            this.ConfirmOrderText.Size = new System.Drawing.Size(140, 33);
            this.ConfirmOrderText.TabIndex = 4;
            this.ConfirmOrderText.Text = "Confirm Order\r\n\r\n";
            this.ConfirmOrderText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DisplayQueueText
            // 
            this.DisplayQueueText.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DisplayQueueText.BackColor = System.Drawing.Color.DimGray;
            this.DisplayQueueText.Font = new System.Drawing.Font("Saira SemiCondensed SemiCond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayQueueText.ForeColor = System.Drawing.Color.White;
            this.DisplayQueueText.Location = new System.Drawing.Point(0, 281);
            this.DisplayQueueText.Margin = new System.Windows.Forms.Padding(0);
            this.DisplayQueueText.Name = "DisplayQueueText";
            this.DisplayQueueText.Size = new System.Drawing.Size(140, 23);
            this.DisplayQueueText.TabIndex = 5;
            this.DisplayQueueText.Text = "DIsplay Queue";
            this.DisplayQueueText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ViewStockText
            // 
            this.ViewStockText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ViewStockText.BackColor = System.Drawing.Color.DimGray;
            this.ViewStockText.Font = new System.Drawing.Font("Saira SemiCondensed SemiCond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewStockText.ForeColor = System.Drawing.Color.White;
            this.ViewStockText.Location = new System.Drawing.Point(0, 399);
            this.ViewStockText.Margin = new System.Windows.Forms.Padding(0);
            this.ViewStockText.Name = "ViewStockText";
            this.ViewStockText.Size = new System.Drawing.Size(143, 24);
            this.ViewStockText.TabIndex = 6;
            this.ViewStockText.Text = "View Stock";
            this.ViewStockText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::CashierGui.Properties.Resources._2024_02_26_16_35_11_firefox;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(35, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 65);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox2.BackgroundImage = global::CashierGui.Properties.Resources._2024_02_26_16_47_32_firefox;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(35, 203);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(69, 65);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DimGray;
            this.label1.Font = new System.Drawing.Font("Saira SemiCondensed SemiCond", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Mode";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox3.BackgroundImage = global::CashierGui.Properties.Resources._2024_02_26_16_47_50_firefox;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(35, 320);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(69, 65);
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // SidePanel
            // 
            this.SidePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.SidePanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(103)))), ((int)(((byte)(67)))));
            this.SidePanel.Controls.Add(this.pictureBox3);
            this.SidePanel.Controls.Add(this.label1);
            this.SidePanel.Controls.Add(this.pictureBox2);
            this.SidePanel.Controls.Add(this.pictureBox1);
            this.SidePanel.Controls.Add(this.ViewStockText);
            this.SidePanel.Controls.Add(this.DisplayQueueText);
            this.SidePanel.Controls.Add(this.ConfirmOrderText);
            this.SidePanel.Controls.Add(this.roundLabel3);
            this.SidePanel.Controls.Add(this.roundLabel2);
            this.SidePanel.Controls.Add(this.roundLabel1);
            this.SidePanel.Location = new System.Drawing.Point(2, 1);
            this.SidePanel.Margin = new System.Windows.Forms.Padding(0);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(143, 449);
            this.SidePanel.TabIndex = 2;
            // 
            // roundLabel3
            // 
            this.roundLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.roundLabel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(77)))), ((int)(((byte)(53)))));
            this.roundLabel3.Location = new System.Drawing.Point(22, 307);
            this.roundLabel3.Name = "roundLabel3";
            this.roundLabel3.Size = new System.Drawing.Size(93, 92);
            this.roundLabel3.TabIndex = 3;
            // 
            // roundLabel2
            // 
            this.roundLabel2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.roundLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(77)))), ((int)(((byte)(53)))));
            this.roundLabel2.Location = new System.Drawing.Point(22, 191);
            this.roundLabel2.Name = "roundLabel2";
            this.roundLabel2.Size = new System.Drawing.Size(93, 90);
            this.roundLabel2.TabIndex = 2;
            // 
            // roundLabel1
            // 
            this.roundLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(77)))), ((int)(((byte)(53)))));
            this.roundLabel1.Location = new System.Drawing.Point(22, 63);
            this.roundLabel1.Name = "roundLabel1";
            this.roundLabel1.Size = new System.Drawing.Size(93, 92);
            this.roundLabel1.TabIndex = 1;
            // 
            // AdminVideoPlayer
            // 
            this.AdminVideoPlayer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AdminVideoPlayer.Enabled = true;
            this.AdminVideoPlayer.Location = new System.Drawing.Point(123, 0);
            this.AdminVideoPlayer.Margin = new System.Windows.Forms.Padding(0);
            this.AdminVideoPlayer.Name = "AdminVideoPlayer";
            this.AdminVideoPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("AdminVideoPlayer.OcxState")));
            this.AdminVideoPlayer.Size = new System.Drawing.Size(657, 449);
            this.AdminVideoPlayer.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SidePanel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.SidePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AdminVideoPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private RoundBorderLabel.RoundLabel roundLabel1;
        private RoundBorderLabel.RoundLabel roundLabel2;
        private RoundBorderLabel.RoundLabel roundLabel3;
        private System.Windows.Forms.Label ConfirmOrderText;
        private System.Windows.Forms.Label DisplayQueueText;
        private System.Windows.Forms.Label ViewStockText;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Panel panel1;
        private AxWMPLib.AxWindowsMediaPlayer AdminVideoPlayer;
    }
}

