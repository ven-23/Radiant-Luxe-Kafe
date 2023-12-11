namespace Radiant_Luxe_Kafe
{
    partial class mLoginSuccess
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnOk = new Guna.UI2.WinForms.Guna2Button();
            this.gbtnExit = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Radiant_Luxe_Kafe.Properties.Resources.m_login_success;
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(368, 198);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.Transparent;
            this.btnOk.BorderColor = System.Drawing.Color.Transparent;
            this.btnOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOk.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnOk.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnOk.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnOk.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnOk.FillColor = System.Drawing.Color.Transparent;
            this.btnOk.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnOk.ForeColor = System.Drawing.Color.Transparent;
            this.btnOk.Location = new System.Drawing.Point(295, 158);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(55, 21);
            this.btnOk.TabIndex = 19;
            this.btnOk.UseTransparentBackground = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // gbtnExit
            // 
            this.gbtnExit.BackColor = System.Drawing.Color.Transparent;
            this.gbtnExit.BorderColor = System.Drawing.Color.Transparent;
            this.gbtnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gbtnExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gbtnExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gbtnExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gbtnExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gbtnExit.FillColor = System.Drawing.Color.Transparent;
            this.gbtnExit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gbtnExit.ForeColor = System.Drawing.Color.Transparent;
            this.gbtnExit.Location = new System.Drawing.Point(359, 2);
            this.gbtnExit.Name = "gbtnExit";
            this.gbtnExit.Size = new System.Drawing.Size(10, 14);
            this.gbtnExit.TabIndex = 22;
            this.gbtnExit.UseTransparentBackground = true;
            this.gbtnExit.Click += new System.EventHandler(this.gbtnExit_Click);
            // 
            // mLoginSuccess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 200);
            this.Controls.Add(this.gbtnExit);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "mLoginSuccess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mLoginSuccess";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnOk;
        private Guna.UI2.WinForms.Guna2Button gbtnExit;
    }
}