namespace Radiant_Luxe_Kafe
{
    partial class ShowCoffeePanel
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
            this.btnAddtoCart = new Guna.UI2.WinForms.Guna2Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblCoffeeName = new System.Windows.Forms.Label();
            this.pbCoffee = new System.Windows.Forms.PictureBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.lblQty = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbCoffee)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddtoCart
            // 
            this.btnAddtoCart.BackColor = System.Drawing.Color.Transparent;
            this.btnAddtoCart.BorderColor = System.Drawing.Color.Transparent;
            this.btnAddtoCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddtoCart.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddtoCart.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddtoCart.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddtoCart.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddtoCart.FillColor = System.Drawing.Color.Transparent;
            this.btnAddtoCart.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddtoCart.ForeColor = System.Drawing.Color.Transparent;
            this.btnAddtoCart.Location = new System.Drawing.Point(534, 338);
            this.btnAddtoCart.Name = "btnAddtoCart";
            this.btnAddtoCart.Size = new System.Drawing.Size(126, 20);
            this.btnAddtoCart.TabIndex = 13;
            this.btnAddtoCart.UseTransparentBackground = true;
            this.btnAddtoCart.Click += new System.EventHandler(this.btnAddtoCart_Click);
            // 
            // btnSub
            // 
            this.btnSub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSub.Location = new System.Drawing.Point(376, 305);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(38, 33);
            this.btnSub.TabIndex = 12;
            this.btnSub.Text = "-";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Font = new System.Drawing.Font("Lucida Sans", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(320, 305);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(38, 33);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // rtbDescription
            // 
            this.rtbDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(212)))), ((int)(((byte)(205)))));
            this.rtbDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbDescription.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.rtbDescription.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbDescription.Location = new System.Drawing.Point(327, 166);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.ReadOnly = true;
            this.rtbDescription.ShortcutsEnabled = false;
            this.rtbDescription.Size = new System.Drawing.Size(320, 82);
            this.rtbDescription.TabIndex = 10;
            this.rtbDescription.TabStop = false;
            this.rtbDescription.Text = "";
            this.rtbDescription.TextChanged += new System.EventHandler(this.rtbDescription_TextChanged);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(212)))), ((int)(((byte)(205)))));
            this.lblPrice.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(345, 128);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(59, 22);
            this.lblPrice.TabIndex = 9;
            this.lblPrice.Text = "Price";
            // 
            // lblCoffeeName
            // 
            this.lblCoffeeName.AutoSize = true;
            this.lblCoffeeName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(212)))), ((int)(((byte)(205)))));
            this.lblCoffeeName.Font = new System.Drawing.Font("Lucida Calligraphy", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoffeeName.Location = new System.Drawing.Point(322, 90);
            this.lblCoffeeName.Name = "lblCoffeeName";
            this.lblCoffeeName.Size = new System.Drawing.Size(165, 27);
            this.lblCoffeeName.TabIndex = 1;
            this.lblCoffeeName.Text = "Coffee Name";
            // 
            // pbCoffee
            // 
            this.pbCoffee.BackColor = System.Drawing.Color.Transparent;
            this.pbCoffee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbCoffee.Location = new System.Drawing.Point(26, 47);
            this.pbCoffee.Name = "pbCoffee";
            this.pbCoffee.Size = new System.Drawing.Size(276, 291);
            this.pbCoffee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCoffee.TabIndex = 7;
            this.pbCoffee.TabStop = false;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.Transparent;
            this.guna2Button1.Location = new System.Drawing.Point(683, 4);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(27, 26);
            this.guna2Button1.TabIndex = 16;
            this.guna2Button1.UseTransparentBackground = true;
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(212)))), ((int)(((byte)(205)))));
            this.lblQty.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQty.Location = new System.Drawing.Point(355, 269);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(45, 22);
            this.lblQty.TabIndex = 15;
            this.lblQty.Text = "Qty";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(212)))), ((int)(((byte)(205)))));
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(322, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 27);
            this.label1.TabIndex = 17;
            this.label1.Text = "₱";
            // 
            // ShowCoffeePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Radiant_Luxe_Kafe.Properties.Resources.bg_order_panel;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(712, 406);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.lblQty);
            this.Controls.Add(this.btnAddtoCart);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.rtbDescription);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblCoffeeName);
            this.Controls.Add(this.pbCoffee);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ShowCoffeePanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShowCoffeePanel";
            this.Load += new System.EventHandler(this.ShowCoffeePanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbCoffee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnAddtoCart;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblCoffeeName;
        private System.Windows.Forms.PictureBox pbCoffee;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.Label label1;
    }
}