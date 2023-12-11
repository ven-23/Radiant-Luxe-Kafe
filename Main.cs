using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Guna.UI2.Native.WinApi;

namespace Radiant_Luxe_Kafe
{
    public partial class Main : Form
    {
        private List<Coffee> coffeeList;
        private List<Coffee> shoppingCart = new List<Coffee>();

        private const string CONNECTION_STRING = "server=localhost;user id = root; password=; database=dbRLK;";

        public Main()
        {
            InitializeComponent();
            coffeeList = InitializeCoffeeList();
        }

        private List<Coffee> InitializeCoffeeList()
        {
            return new List<Coffee>
            {
                //Hot Coffee
                new Coffee
                {
                    Id = 1,
                    CoffeeName = "Hot Brewed Coffee",
                    Description = "Swing by and warm up while enjoying any of our three roasts brewed daily.",
                    Price = 100,
                    Picture = "C:\\Users\\Rianne\\Desktop\\Radiant-Luxe-Kaffe\\Resources\\hot brewed coffee1.png"
                },
                new Coffee
                {
                    Id = 2,
                    CoffeeName = "Mlay ko",
                    Description = "Coffee 2 Desc",
                    Price = 150,
                    Picture = "C:\\Users\\Kyla De Leon\\source\\repos\\Radiant-Luxe-Kafe\\Resources\\examplecoffee.jpg"
                },
                new Coffee
                {
                    Id = 3,
                    CoffeeName = "Tulog",
                    Description = "Coffee 3 Desc",
                    Price = 140,
                    Picture = "C:\\Users\\Kyla De Leon\\source\\repos\\Radiant-Luxe-Kafe\\Resources\\examplecoffee.jpg"
                },
                new Coffee
                {
                    Id = 4,
                    CoffeeName = "Mlay ko",
                    Description = "Coffee 2 Desc",
                    Price = 150,
                    Picture = "C:\\Users\\Kyla De Leon\\source\\repos\\Radiant-Luxe-Kafe\\Resources\\examplecoffee.jpg"
                },
                new Coffee
                {
                    Id = 5,
                    CoffeeName = "Cappuccino",
                    Description = "Coffee 1 Desc",
                    Price = 100,
                    Picture = "C:\\Users\\Kyla De Leon\\source\\repos\\Radiant-Luxe-Kafe\\Resources\\examplecoffee.jpg"
                },
                new Coffee
                {
                    Id = 6,
                    CoffeeName = "Mlay ko",
                    Description = "Coffee 2 Desc",
                    Price = 150,
                    Picture = "C:\\Users\\Kyla De Leon\\source\\repos\\Radiant-Luxe-Kafe\\Resources\\examplecoffee.jpg"
                }
                // Cold Coffee
            };
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            TabPane.SelectedTab = Menu;
        }

        private void Menu_Click(object sender, EventArgs e)
        {

        }

        private void lblCoffee1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ShowCoffeeDetails(0);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ShowCoffeeDetails(1);
        }

        private void ShowCoffeeDetails(int coffeeIndex)
        {
            if (coffeeIndex >= 0 && coffeeIndex < coffeeList.Count)
            {
                var coffee = coffeeList[coffeeIndex];

                // Check if the coffee is already in the cart
                var existingCoffee = shoppingCart.FirstOrDefault(c => c.Id == coffee.Id);

                if (existingCoffee != null)
                {
                    // Coffee already in the cart, increment the quantity
                    existingCoffee.Quantity++;
                }
                else
                {
                    // Coffee not in the cart, add a new item with quantity 1
                    coffee.Quantity = 1;
                    shoppingCart.Add(coffee);
                }

                DisplayCart(); // Update the cart display with the new item
                ShowCoffeePanel coffeePanel = new ShowCoffeePanel(coffee);
                coffeePanel.ShowDialog();
            }
        }

        private void DisplayCart()
        {
            CartPanel.Controls.Clear();

            decimal total = 0;

            foreach (var coffee in shoppingCart)
            {
                var control = new CartControl(coffee, RemoveCoffeeFromCart);
                CartPanel.Controls.Add(control);

                // Append quantity, coffee name, and total price for each item in the cart
                rtbReceipt.AppendText($" * {coffee.Quantity} x {coffee.CoffeeName}: {coffee.Price:C} each\n");

                // Calculate and accumulate the total price for all items
                total += coffee.Price * coffee.Quantity;
            }

            // Display the total price at the end
            rtbReceipt.AppendText($"\nTotal Price: {total.ToString("C")}");
        }

        private void RemoveCoffeeFromCart(Coffee coffee)
        {
            shoppingCart.Remove(coffee);
            DisplayCart();  // Update the cart display after removing the coffee
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TabPane.SelectedTab = Cart;
            DisplayCart();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TabPane.SelectedTab = Menu;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            ShowCoffeeDetails(2);
        }

        private void ClearCart()
        {
            // Clear the shopping cart
            shoppingCart.Clear();

            // Clear the CartPanel controls
            CartPanel.Controls.Clear();

            // Clear the rich text box
            rtbReceipt.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearCart();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            TabPane.SelectedTab = Account;
            
        }

        
        private void Account_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            TabPane.SelectedTab = Home;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            TabPane.SelectedTab = Menu;
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            TabPane.SelectedTab = Cart;
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            TabPane.SelectedTab = About;
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            TabPane.SelectedTab = Account;
        }

        private void bDarkCaramelCoffeeFrappuccino_Click(object sender, EventArgs e)
        {

        }

        private void hBrewedCoffee_Click(object sender, EventArgs e)
        {
            ShowCoffeeDetails(0);

        }
    }
}
