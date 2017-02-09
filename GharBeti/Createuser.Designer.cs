namespace GharBeti
{
    partial class Createuser
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblCreateuser = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblViewuser = new System.Windows.Forms.Label();
            this.lblEdituser = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 42);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 220);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(284, 41);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel3.Controls.Add(this.lblEdituser);
            this.panel3.Controls.Add(this.lblViewuser);
            this.panel3.Controls.Add(this.lblCreateuser);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 42);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(86, 178);
            this.panel3.TabIndex = 0;
            // 
            // lblCreateuser
            // 
            this.lblCreateuser.BackColor = System.Drawing.Color.Yellow;
            this.lblCreateuser.Location = new System.Drawing.Point(0, 3);
            this.lblCreateuser.Name = "lblCreateuser";
            this.lblCreateuser.Size = new System.Drawing.Size(86, 27);
            this.lblCreateuser.TabIndex = 0;
            this.lblCreateuser.Text = "Create User";
            this.lblCreateuser.MouseLeave += new System.EventHandler(this.lblCreateuser_MouseLeave);
            this.lblCreateuser.MouseHover += new System.EventHandler(this.lblCreateuser_MouseHover);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Lime;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(86, 42);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(198, 178);
            this.panel4.TabIndex = 2;
            // 
            // lblViewuser
            // 
            this.lblViewuser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblViewuser.Location = new System.Drawing.Point(0, 56);
            this.lblViewuser.Name = "lblViewuser";
            this.lblViewuser.Size = new System.Drawing.Size(83, 27);
            this.lblViewuser.TabIndex = 1;
            this.lblViewuser.Text = "View User";
            // 
            // lblEdituser
            // 
            this.lblEdituser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblEdituser.Location = new System.Drawing.Point(0, 103);
            this.lblEdituser.Name = "lblEdituser";
            this.lblEdituser.Size = new System.Drawing.Size(86, 27);
            this.lblEdituser.TabIndex = 2;
            this.lblEdituser.Text = "Edit User";
            // 
            // Createuser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Createuser";
            this.Text = "Createuser";
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblCreateuser;
        private System.Windows.Forms.Label lblEdituser;
        private System.Windows.Forms.Label lblViewuser;
    }
}