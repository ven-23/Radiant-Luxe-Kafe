using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Guna.UI2.Native.WinApi;

namespace Radiant_Luxe_Kafe
{
    public partial class ShowCoffeePanel : Form
    {
      
        private Coffee coffee;


        public ShowCoffeePanel(Coffee coffee)
        {
            InitializeComponent();
            rtbDescription.HideSelection = true;
            rtbDescription.Text = coffee.Description;
            lblCoffeeName.Text = coffee.CoffeeName;
            lblPrice.Text = coffee.Price.ToString();
            lblQty.Text = coffee.Quantity.ToString();  // Display the initial quantity
            pbCoffee.Image = Image.FromFile(coffee.Picture);

            // Set the coffee and cart instances
            this.coffee = coffee;
        }


        private void ShowCoffeePanel_Load(object sender, EventArgs e)
        {

        }

        private void btnAddtoCart_Click(object sender, EventArgs e)
        {

            var itemadded = new mItemAdded();
            itemadded.ShowDialog();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            coffee.Quantity++;
            lblQty.Text = coffee.Quantity.ToString();
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            if (coffee.Quantity > 1)
            {
                coffee.Quantity--;
                lblQty.Text = coffee.Quantity.ToString();
            }
        }

        private void rtbDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
