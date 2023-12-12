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
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbCartCoffee)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCartCoffeeName
            // 
            this.lblCartCoffeeName.AutoSize = true;
            this.lblCartCoffeeName.Font = new System.Drawing.Font("Lucida Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCartCoffeeName.Location = new System.Drawing.Point(116, 18);
            this.lblCartCoffeeName.Name = "lblCartCoffeeName";
            this.lblCartCoffeeName.Size = new System.Drawing.Size(117, 21);
            this.lblCartCoffeeName.TabIndex = 1;
            this.lblCartCoffeeName.Text = "CoffeeName";
            // 
            // lblCartPrice
            // 
            this.lblCartPrice.AutoSize = true;
            this.lblCartPrice.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCartPrice.Location = new System.Drawing.Point(272, 69);
            this.lblCartPrice.Name = "lblCartPrice";
            this.lblCartPrice.Size = new System.Drawing.Size(54, 22);
            this.lblCartPrice.TabIndex = 2;
            this.lblCartPrice.Text = "Price";
            // 
            // pbCartCoffee
            // 
            this.pbCartCoffee.Location = new System.Drawing.Point(15, 18);
            this.pbCartCoffee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbCartCoffee.Name = "pbCartCoffee";
            this.pbCartCoffee.Size = new System.Drawing.Size(100, 130);
            this.pbCartCoffee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCartCoffee.TabIndex = 0;
            this.pbCartCoffee.TabStop = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(155, 123);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(31, 30);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSubtract
            // 
            this.btnSubtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubtract.Location = new System.Drawing.Point(201, 123);
            this.btnSubtract.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(31, 30);
            this.btnSubtract.TabIndex = 13;
            this.btnSubtract.Text = "-";
            this.btnSubtract.UseVisualStyleBackColor = true;
            this.btnSubtract.Click += new System.EventHandler(this.btnSubtract_Click);
            // 
            // lblCartQty
            // 
            this.lblCartQty.AutoSize = true;
            this.lblCartQty.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCartQty.Location = new System.Drawing.Point(172, 96);
            this.lblCartQty.Name = "lblCartQty";
            this.lblCartQty.Size = new System.Drawing.Size(44, 22);
            this.lblCartQty.TabIndex = 14;
            this.lblCartQty.Text = "Qty";
            // 
            // lblItemTotalPrice
            // 
            this.lblItemTotalPrice.AutoSize = true;
            this.lblItemTotalPrice.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemTotalPrice.Location = new System.Drawing.Point(272, 128);
            this.lblItemTotalPrice.Name = "lblItemTotalPrice";
            this.lblItemTotalPrice.Size = new System.Drawing.Size(118, 22);
            this.lblItemTotalPrice.TabIndex = 15;
            this.lblItemTotalPrice.Text = "Total Price";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-3, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(450, 22);
            this.label1.TabIndex = 16;
            this.label1.Text = "____________________________________________";
            // 
            // CartControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(238)))), ((int)(((byte)(221)))));
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblItemTotalPrice);
            this.Controls.Add(this.lblCartQty);
            this.Controls.Add(this.btnSubtract);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblCartPrice);
            this.Controls.Add(this.lblCartCoffeeName);
            this.Controls.Add(this.pbCartCoffee);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CartControl";
            this.Size = new System.Drawing.Size(400, 174);
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
        private System.Windows.Forms.Label label1;
    }
}
