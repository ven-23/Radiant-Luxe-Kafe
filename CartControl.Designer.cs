namespace Radiant_Luxe_Kafe
{
    partial class CartControl
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
            this.lblCartCoffeeName = new System.Windows.Forms.Label();
            this.lblCartPrice = new System.Windows.Forms.Label();
            this.pbCartCoffee = new System.Windows.Forms.PictureBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.lblCartQty = new System.Windows.Forms.Label();
            this.lblItemTotalPrice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbCartCoffee)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCartCoffeeName
            // 
            this.lblCartCoffeeName.AutoSize = true;
            this.lblCartCoffeeName.Location = new System.Drawing.Point(112, 15);
            this.lblCartCoffeeName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCartCoffeeName.Name = "lblCartCoffeeName";
            this.lblCartCoffeeName.Size = new System.Drawing.Size(66, 13);
            this.lblCartCoffeeName.TabIndex = 1;
            this.lblCartCoffeeName.Text = "CoffeeName";
            // 
            // lblCartPrice
            // 
            this.lblCartPrice.AutoSize = true;
            this.lblCartPrice.Location = new System.Drawing.Point(276, 41);
            this.lblCartPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCartPrice.Name = "lblCartPrice";
            this.lblCartPrice.Size = new System.Drawing.Size(31, 13);
            this.lblCartPrice.TabIndex = 2;
            this.lblCartPrice.Text = "Price";
            // 
            // pbCartCoffee
            // 
            this.pbCartCoffee.Location = new System.Drawing.Point(13, 15);
            this.pbCartCoffee.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbCartCoffee.Name = "pbCartCoffee";
            this.pbCartCoffee.Size = new System.Drawing.Size(82, 88);
            this.pbCartCoffee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCartCoffee.TabIndex = 0;
            this.pbCartCoffee.TabStop = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(118, 79);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(23, 24);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSubtract
            // 
            this.btnSubtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubtract.Location = new System.Drawing.Point(147, 79);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(23, 24);
            this.btnSubtract.TabIndex = 13;
            this.btnSubtract.Text = "-";
            this.btnSubtract.UseVisualStyleBackColor = true;
            this.btnSubtract.Click += new System.EventHandler(this.btnSubtract_Click);
            // 
            // lblCartQty
            // 
            this.lblCartQty.AutoSize = true;
            this.lblCartQty.Location = new System.Drawing.Point(118, 41);
            this.lblCartQty.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCartQty.Name = "lblCartQty";
            this.lblCartQty.Size = new System.Drawing.Size(23, 13);
            this.lblCartQty.TabIndex = 14;
            this.lblCartQty.Text = "Qty";
            // 
            // lblItemTotalPrice
            // 
            this.lblItemTotalPrice.AutoSize = true;
            this.lblItemTotalPrice.Location = new System.Drawing.Point(276, 86);
            this.lblItemTotalPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblItemTotalPrice.Name = "lblItemTotalPrice";
            this.lblItemTotalPrice.Size = new System.Drawing.Size(58, 13);
            this.lblItemTotalPrice.TabIndex = 15;
            this.lblItemTotalPrice.Text = "Total Price";
            // 
            // CartControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblItemTotalPrice);
            this.Controls.Add(this.lblCartQty);
            this.Controls.Add(this.btnSubtract);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblCartPrice);
            this.Controls.Add(this.lblCartCoffeeName);
            this.Controls.Add(this.pbCartCoffee);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CartControl";
            this.Size = new System.Drawing.Size(394, 122);
            this.Load += new System.EventHandler(this.CartControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbCartCoffee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCartCoffee;
        private System.Windows.Forms.Label lblCartCoffeeName;
        private System.Windows.Forms.Label lblCartPrice;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSubtract;
        private System.Windows.Forms.Label lblCartQty;
        private System.Windows.Forms.Label lblItemTotalPrice;
    }
}
