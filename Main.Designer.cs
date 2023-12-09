namespace Radiant_Luxe_Kafe
{
    partial class Main
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
            this.TabPane = new Guna.UI2.WinForms.Guna2TabControl();
            this.Account = new System.Windows.Forms.TabPage();
            this.Menu = new System.Windows.Forms.TabPage();
            this.Cart = new System.Windows.Forms.TabPage();
            this.About = new System.Windows.Forms.TabPage();
            this.Home = new System.Windows.Forms.TabPage();
            this.btnStart = new Guna.UI2.WinForms.Guna2Button();
            this.TabPane.SuspendLayout();
            this.Home.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabPane
            // 
            this.TabPane.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.TabPane.Controls.Add(this.Home);
            this.TabPane.Controls.Add(this.Account);
            this.TabPane.Controls.Add(this.Menu);
            this.TabPane.Controls.Add(this.Cart);
            this.TabPane.Controls.Add(this.About);
            this.TabPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabPane.ItemSize = new System.Drawing.Size(180, 40);
            this.TabPane.Location = new System.Drawing.Point(0, 0);
            this.TabPane.Name = "TabPane";
            this.TabPane.SelectedIndex = 0;
            this.TabPane.Size = new System.Drawing.Size(984, 611);
            this.TabPane.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.TabPane.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.TabPane.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.TabPane.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.TabPane.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.TabPane.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.TabPane.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.TabPane.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.TabPane.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.TabPane.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.TabPane.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.TabPane.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.TabPane.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.TabPane.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.TabPane.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.TabPane.TabButtonSize = new System.Drawing.Size(180, 40);
            this.TabPane.TabIndex = 0;
            this.TabPane.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.TabPane.TabMenuVisible = false;
            // 
            // Account
            // 
            this.Account.Location = new System.Drawing.Point(5, 4);
            this.Account.Name = "Account";
            this.Account.Padding = new System.Windows.Forms.Padding(3);
            this.Account.Size = new System.Drawing.Size(975, 603);
            this.Account.TabIndex = 1;
            this.Account.Text = "Account";
            this.Account.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            this.Menu.Location = new System.Drawing.Point(5, 4);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(975, 603);
            this.Menu.TabIndex = 2;
            this.Menu.Text = "Menu";
            this.Menu.UseVisualStyleBackColor = true;
            // 
            // Cart
            // 
            this.Cart.Location = new System.Drawing.Point(5, 4);
            this.Cart.Name = "Cart";
            this.Cart.Size = new System.Drawing.Size(975, 603);
            this.Cart.TabIndex = 3;
            this.Cart.Text = "Cart";
            this.Cart.UseVisualStyleBackColor = true;
            // 
            // About
            // 
            this.About.Location = new System.Drawing.Point(5, 4);
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(975, 603);
            this.About.TabIndex = 4;
            this.About.Text = "About";
            this.About.UseVisualStyleBackColor = true;
            // 
            // Home
            // 
            this.Home.BackgroundImage = global::Radiant_Luxe_Kafe.Properties.Resources.bg_home;
            this.Home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Home.Controls.Add(this.btnStart);
            this.Home.Location = new System.Drawing.Point(5, 4);
            this.Home.Name = "Home";
            this.Home.Padding = new System.Windows.Forms.Padding(3);
            this.Home.Size = new System.Drawing.Size(975, 603);
            this.Home.TabIndex = 0;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Transparent;
            this.btnStart.BorderColor = System.Drawing.Color.Transparent;
            this.btnStart.Checked = true;
            this.btnStart.CheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.btnStart.CheckedState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnStart.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.btnStart.CheckedState.ForeColor = System.Drawing.Color.Transparent;
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnStart.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStart.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnStart.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStart.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnStart.FillColor = System.Drawing.Color.Transparent;
            this.btnStart.FocusedColor = System.Drawing.Color.Transparent;
            this.btnStart.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnStart.ForeColor = System.Drawing.Color.Transparent;
            this.btnStart.Location = new System.Drawing.Point(444, 387);
            this.btnStart.Name = "btnStart";
            this.btnStart.PressedColor = System.Drawing.Color.Transparent;
            this.btnStart.ShadowDecoration.Color = System.Drawing.Color.Transparent;
            this.btnStart.Size = new System.Drawing.Size(157, 33);
            this.btnStart.TabIndex = 3;
            this.btnStart.UseTransparentBackground = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.TabPane);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.TabPane.ResumeLayout(false);
            this.Home.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TabControl TabPane;
        private System.Windows.Forms.TabPage Home;
        private System.Windows.Forms.TabPage Account;
        private System.Windows.Forms.TabPage Menu;
        private System.Windows.Forms.TabPage Cart;
        private System.Windows.Forms.TabPage About;
        private Guna.UI2.WinForms.Guna2Button btnStart;
    }
}