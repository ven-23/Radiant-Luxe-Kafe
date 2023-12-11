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
        private string _username;
        private List<Coffee> coffeeList;
        private List<Coffee> shoppingCart = new List<Coffee>();

        private const string CONNECTION_STRING = "server=localhost;user id = root; password=; database=dbRLK;";

        public Main()
        {
            InitializeComponent();
            coffeeList = InitializeCoffeeList();
        }

        public Main(string username)
        {
            _username = username;
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
                    CoffeeName = "Caffe Misto",
                    Description = "A one-to-one combination of fresh-brewed coffee and steamed milk add up to one distinctly delicious coffee drink remarkably mixed.",
                    Price = 150,
                    Picture = "C:\\Users\\Rianne\\Desktop\\Radiant-Luxe-Kaffe\\Resources\\hot caffe misto1.png"
                },
                new Coffee
                {
                    Id = 3,
                    CoffeeName = "Espresso",
                    Description = "Our smooth signature Espresso Roast with rich flavor and caramelly sweetness is at the very heart of everything we do.",
                    Price = 140,
                    Picture = "C:\\Users\\Rianne\\Desktop\\Radiant-Luxe-Kaffe\\Resources\\hot espresso1.png"
                },
                new Coffee
                {
                    Id = 4,
                    CoffeeName = "Flat White",
                    Description = "Bold ristretto shots of espresso get the perfect amount of steamed whole milk to create a not too strong, not too creamy, just right flavor, finished with a beautiful dot.",
                    Price = 150,
                    Picture = "C:\\Users\\Rianne\\Desktop\\Radiant-Luxe-Kaffe\\Resources\\hot flat white1.png"
                },
                new Coffee
                {
                    Id = 5,
                    CoffeeName = "Signature Hot Chocolate",
                    Description = "Steamed milk and mocha sauce topped with sweetened whipped cream and a chocolate-flavored drizzle. A timeless classic made to sweeten your spirits.",
                    Price = 100,
                    Picture = "C:\\Users\\Rianne\\Desktop\\Radiant-Luxe-Kaffe\\Resources\\hot signature hot chocolate1.png"
                },
                new Coffee
                {
                    Id = 6,
                    CoffeeName = "White Hot Chocolate",
                    Description = "A traditional hot chocolate beverage made with white chocolate sauce and steamed milk, topped with whipped cream.",
                    Price = 150,
                    Picture = "C:\\Users\\Rianne\\Desktop\\Radiant-Luxe-Kaffe\\Resources\\hot white hot chocolate1.png"
                },
                // Iced Coffee
                new Coffee
                {
                    Id = 1,
                    CoffeeName = "Americano",
                    Description = "Espresso shots are topped with water to produce a light layer of crema, then served over ice. The result is this wonderfully rich cup with depth and nuance.",
                    Price = 100,
                    Picture = "C:\\Users\\Rianne\\Desktop\\Radiant-Luxe-Kaffe\\Resources\\iced americano1.png"
                },
                new Coffee
                {
                    Id = 2,
                    CoffeeName = "Caffe Mocha",
                    Description = "Espresso combined with bittersweet mocha sauce and milk over ice. Topped with sweetened whipped cream.",
                    Price = 150,
                    Picture = "C:\\Users\\Rianne\\Desktop\\Radiant-Luxe-Kaffe\\Resources\\iced caffe mocha1.png"
                },
                new Coffee
                {
                    Id = 3,
                    CoffeeName = "Cappuccino",
                    Description = "Dark, rich espresso lies in wait under a smoothed and stretched layer of thick milk foam. An alchemy of barista artistry and craft.",
                    Price = 140,
                    Picture = "C:\\Users\\Rianne\\Desktop\\Radiant-Luxe-Kaffe\\Resources\\iced cappuccino1.png"
                },
                new Coffee
                {
                    Id = 4,
                    CoffeeName = "Caramel Macchiato",
                    Description = "We combine our rich, full-bodied espresso with vanilla-flavored syrup, milk and ice, then top it off with caramel drizzle for an oh-so-sweet finish.",
                    Price = 150,
                    Picture = "C:\\Users\\Rianne\\Desktop\\Radiant-Luxe-Kaffe\\Resources\\iced caramel macchiato1.png"
                },
                new Coffee
                {
                    Id = 5,
                    CoffeeName = "Green Tea Latte",
                    Description = "Smooth and creamy matcha is lightly sweetened and served with milk and ice.",
                    Price = 100,
                    Picture = "C:\\Users\\Rianne\\Desktop\\Radiant-Luxe-Kaffe\\Resources\\iced green tea latte1.png"
                },
                new Coffee
                {
                    Id = 6,
                    CoffeeName = "White Chocolate Mocha",
                    Description = "Our signature espresso meets white chocolate sauce, milk and ice, then is finished off with sweetened whipped cream in this white chocolate delight.",
                    Price = 150,
                    Picture = "C:\\Users\\Rianne\\Desktop\\Radiant-Luxe-Kaffe\\Resources\\iced white chocolate mocha1.png"
                },
                // Blended Drinks
                new Coffee
                {
                    Id = 1,
                    CoffeeName = "Caramel Frappuccino",
                    Description = "Buttery caramel syrup meets coffee, milk and ice for a rendezvous in the blender. Then whipped cream and caramel sauce layer the love on top.",
                    Price = 100,
                    Picture = "C:\\Users\\Rianne\\Desktop\\Radiant-Luxe-Kaffe\\Resources\\blended caramel frappuccino1.png"
                },
                new Coffee
                {
                    Id = 2,
                    CoffeeName = "Dark Caramel Coffee Frappuccino",
                    Description = "Dark caramel coffee Frappuccino is topped with buttery dark caramel sauce and layered between signature whipped cream infused with cold brew, dark caramel sauce, and white chocolate mocha, and a dollop of dark caramel sauce at the bottom of the cup.\r\n",
                    Price = 150,
                    Picture = "C:\\Users\\Rianne\\Desktop\\Radiant-Luxe-Kaffe\\Resources\\blended dark caramel coffee frappuccino1.png"
                },
                new Coffee
                {
                    Id = 3,
                    CoffeeName = "Java Chip Frappuccino",
                    Description = "We blend mocha sauce and Frappuccino® chips with Frappuccino® roast coffee and milk and ice, then top with whipped cream and mocha drizzle to bring you endless java joy.\r\n",
                    Price = 140,
                    Picture = "C:\\Users\\Rianne\\Desktop\\Radiant-Luxe-Kaffe\\Resources\\blended java chip frappuccino1.png"
                },
                new Coffee
                {
                    Id = 4,
                    CoffeeName = "Strawberries & Cream Frappuccino",
                    Description = "Strawberries and milk are blended with ice and topped with a swirl of whipped cream. Sip on the crème of the crop.",
                    Price = 150,
                    Picture = "C:\\Users\\Rianne\\Desktop\\Radiant-Luxe-Kaffe\\Resources\\blended strawberries & cream frappuccino1.png"
                },
                new Coffee
                {
                    Id = 5,
                    CoffeeName = "Triple Mocha Frappuccino",
                    Description = "Your favorite Mocha Frappuccino is topped with rich dark mocha sauce and layered between the signature whipped cream infused with cold brew, dark caramel sauce, and white chocolate mocha, and a dollop of dark mocha sauce at the bottom of the cup.\r\n",
                    Price = 100,
                    Picture = "C:\\Users\\Rianne\\Desktop\\Radiant-Luxe-Kaffe\\Resources\\blended triple mocha frappuccino1.png"
                },
                new Coffee
                {
                    Id = 6,
                    CoffeeName = "Vanilla Cream Frappuccino",
                    Description = "This rich and creamy blend of vanilla bean, milk and ice topped with whipped cream takes va-va-vanilla flavor to another level.\r\n",
                    Price = 150,
                    Picture = "C:\\Users\\Rianne\\Desktop\\Radiant-Luxe-Kaffe\\Resources\\blended vanilla cream frappuccino1.png"
                },
                 // Add-ons
                new Coffee
                {
                    Id = 1,
                    CoffeeName = "Butter",
                    Description = "Butter for smoother mouthfeel and a slightly creamy taste",
                    Price = 100,
                    Picture = "C:\\Users\\Rianne\\Desktop\\Radiant-Luxe-Kaffe\\Resources\\butter.png"
                },
                new Coffee
                {
                    Id = 2,
                    CoffeeName = "Honey",
                    Description = "Honey for natural sweetness.",
                    Price = 150,
                    Picture = "C:\\Users\\Rianne\\Desktop\\Radiant-Luxe-Kaffe\\Resources\\honey.png"
                },
                new Coffee
                {
                    Id = 3,
                    CoffeeName = "Milk",
                    Description = "Milk for more creamier drink.",
                    Price = 140,
                    Picture = "C:\\Users\\Rianne\\Desktop\\Radiant-Luxe-Kaffe\\Resources\\milk.png"
                },
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

            // Check the entered username in the database
            string sqlQuery = $"SELECT * FROM customerinfo WHERE Username = @Username";

            using (MySqlConnection conn = new MySqlConnection(CONNECTION_STRING))
            using (MySqlCommand cmd = new MySqlCommand(sqlQuery, conn))
            {
                cmd.Parameters.AddWithValue("@Username", _username);

                try
                {
                    conn.Open();
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if(reader.Read())
                        {
                            //int userId = reader.GetInt32("Id");
                            string fullName = reader.GetString("FullName");
                            string address = reader.GetString("Address");
                            string phoneNumber = reader.GetString("PhoneNumber");
                            string gender = reader.GetString("Gender");
                            string username = reader.GetString("Username");
                            string password = reader.GetString("Password");

                            // Now you have the user information, and you can display it in the "Account" tab or store it as needed.

                            // For example, update labels in the "Account" tab:
                            //lblUserId.Text = userId.ToString();
                            lblFullName.Text = fullName;
                            lblAddress.Text = address;
                            lblPhoneNumber.Text = phoneNumber;
                            lblGender.Text = gender;
                            lblUsername.Text = username;
                            lblPassword.Text = password;

                            MessageBox.Show("User information loaded successfully!");
                        }
                        else
                        {
                            MessageBox.Show("User not found in the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void bDarkCaramelCoffeeFrappuccino_Click(object sender, EventArgs e)
        {
            ShowCoffeeDetails(13);
        }

        private void hBrewedCoffee_Click(object sender, EventArgs e)
        {
            ShowCoffeeDetails(0);

        }

        private void hCaffeMisto_Click(object sender, EventArgs e)
        {
            ShowCoffeeDetails(1);
        }

        private void hEspresso_Click(object sender, EventArgs e)
        {
            ShowCoffeeDetails(2);
        }

        private void hFlatWhite_Click(object sender, EventArgs e)
        {
            ShowCoffeeDetails(3);
        }

        private void hSignatureHotChocolate_Click(object sender, EventArgs e)
        {
            ShowCoffeeDetails(4);
        }

        private void hWhiteHotChocolate_Click(object sender, EventArgs e)
        {
            ShowCoffeeDetails(5);
        }

        private void iAmericano_Click(object sender, EventArgs e)
        {
            ShowCoffeeDetails(6);
        }

        private void iCaffeMocha_Click(object sender, EventArgs e)
        {
            ShowCoffeeDetails(7);
        }

        private void iCappuccino_Click(object sender, EventArgs e)
        {
            ShowCoffeeDetails(8);
        }

        private void iCaramelMacchiato_Click(object sender, EventArgs e)
        {
            ShowCoffeeDetails(9);
        }

        private void iGreenTeaLatte_Click(object sender, EventArgs e)
        {
            ShowCoffeeDetails(10);
        }

        private void iWhiteChocolateMocha_Click(object sender, EventArgs e)
        {
            ShowCoffeeDetails(11);
        }

        private void bCaramelFrappuccino_Click(object sender, EventArgs e)
        {
            ShowCoffeeDetails(12);
        }

        private void bJavaChipFrappuccino_Click(object sender, EventArgs e)
        {
            ShowCoffeeDetails(14);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            ShowCoffeeDetails(15);
        }

        private void bTripleMochaFrappuccino_Click(object sender, EventArgs e)
        {
            ShowCoffeeDetails(16);
        }

        private void bVanillaCreamFrappuccino_Click(object sender, EventArgs e)
        {
            ShowCoffeeDetails(17);
        }

        private void aButter_Click(object sender, EventArgs e)
        {
            ShowCoffeeDetails(18);
        }

        private void aHoney_Click(object sender, EventArgs e)
        {
            ShowCoffeeDetails(19);
        }

        private void aMilk_Click(object sender, EventArgs e)
        {
            ShowCoffeeDetails(20);
        }
    }
}
