namespace WindowsFormsApp1
{
    partial class Menu2
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flow2 = new System.Windows.Forms.FlowLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.flow2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flow2
            // 
            this.flow2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.flow2.Controls.Add(this.textBox1);
            this.flow2.Location = new System.Drawing.Point(0, 0);
            this.flow2.Name = "flow2";
            this.flow2.Size = new System.Drawing.Size(1495, 938);
            this.flow2.TabIndex = 0;
            this.flow2.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "FRANCIS";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Menu2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flow2);
            this.Name = "Menu2";
            this.Size = new System.Drawing.Size(1495, 938);
            this.flow2.ResumeLayout(false);
            this.flow2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flow2;
        private System.Windows.Forms.TextBox textBox1;
    }
}
