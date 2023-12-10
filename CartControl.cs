using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Radiant_Luxe_Kafe
{
    public partial class CartControl : UserControl
    {
        private Coffee coffee;
        private Action<Coffee> removeAction;

        public CartControl(Coffee coffee, Action<Coffee> removeAction)
        {
            InitializeComponent();
            this.coffee = coffee;
            this.removeAction = removeAction;
            lblCartCoffeeName.Text = coffee.CoffeeName;
            lblCartPrice.Text = coffee.Price.ToString("C");
            pbCartCoffee.Image = Image.FromFile(coffee.Picture);

            // Set the initial quantity and update the label
            SetQuantityLabel();
        }

        private void SetQuantityLabel()
        {
            lblCartQty.Text = $"Qty: {coffee.Quantity}";
            decimal ItemPrice = coffee.Quantity * coffee.Price;
            lblItemTotalPrice.Text = ItemPrice.ToString("C");
        }

        private void CartControl_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            coffee.Quantity++;  // Increment the quantity
            SetQuantityLabel();  // Update the label
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            if (coffee.Quantity > 0)
            {
                coffee.Quantity--;
                SetQuantityLabel();
            }

            if (coffee.Quantity == 0)
            {
                removeAction?.Invoke(coffee);  // Invoke the remove action if it's not null
            }
        }
    }
}
