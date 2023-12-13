using MySql.Data.MySqlClient;
using Radiant_Luxe_Kafe.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
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
        

        private PrintDocument printDocument;

        private const string CONNECTION_STRING = "server=localhost;user id = root; password=; database=dbRLK;";

        public Main()
        {
            InitializeComponent();
            coffeeList = InitializeCoffeeList();

            printDocument = new PrintDocument();
            printDocument.PrintPage += PrintPageHandler;
        }

        public Main(string username)
        {
            InitializeComponent();
            _username = username;
            lblHello.Text = $"Hello, {username}.";
            coffeeList = InitializeCoffeeList();

            if (string.IsNullOrEmpty(_username))
            {
                guna2Button27.Text = "Sign In";
            }
            else
            {
                guna2Button27.Text = "Sign Out";
            }
        }

        private List<Coffee> InitializeCoffeeList()
        {
            return new List<Coffee>
            {
                //Hot Coffee
                new Coffee
                {
                    Id = 0,
                    CoffeeName = "Hot Brewed Coffee",
                    Description = "Swing by and warm up while enjoying any of our three roasts brewed daily.",
                    Price = 99,
                    Picture = "C:\\Users\\Kyla De Leon\\source\\repos\\Radiant-Luxe-Kafe\\Resources\\hot brewed coffee1.png"
                },
                new Coffee
                {
                    Id = 1,
                    CoffeeName = "Caffe Misto",
                    Description = "A one-to-one combination of fresh-brewed coffee and steamed milk add up to one distinctly delicious coffee drink remarkably mixed.",
                    Price = 120,
                    Picture = "C:\\Users\\Kyla De Leon\\source\\repos\\Radiant-Luxe-Kafe\\Resources\\hot caffe misto1.png"
                },
                new Coffee
                {
                    Id = 2,
                    CoffeeName = "Espresso",
                    Description = "Our smooth signature Espresso Roast with rich flavor and caramelly sweetness is at the very heart of everything we do.",
                    Price = 150,
                    Picture = "C:\\Users\\Kyla De Leon\\source\\repos\\Radiant-Luxe-Kafe\\Resources\\hot espresso1.png"
                },
                new Coffee
                {
                    Id = 3,
                    CoffeeName = "Flat White",
                    Description = "Bold ristretto shots of espresso get the perfect amount of steamed whole milk to create a not too strong, not too creamy, just right flavor, finished with a beautiful dot.",
                    Price = 150,
                    Picture = "C:\\Users\\Kyla De Leon\\source\\repos\\Radiant-Luxe-Kafe\\Resources\\hot flat white1.png"
                },
                new Coffee
                {
                    Id = 4,
                    CoffeeName = "Signature Hot Chocolate",
                    Description = "Steamed milk and mocha sauce topped with sweetened whipped cream and a chocolate-flavored drizzle. A timeless classic made to sweeten your spirits.",
                    Price = 190,
                    Picture = "C:\\Users\\Kyla De Leon\\source\\repos\\Radiant-Luxe-Kafe\\Resources\\hot signature hot chocolate1.png"
                },
                new Coffee
                {
                    Id = 5,
                    CoffeeName = "White Hot Chocolate",
                    Description = "A traditional hot chocolate beverage made with white chocolate sauce and steamed milk, topped with whipped cream.",
                    Price = 190,
                    Picture = "C:\\Users\\Kyla De Leon\\source\\repos\\Radiant-Luxe-Kafe\\Resources\\hot white hot chocolate1.png"
                },
                // Iced Coffee
                new Coffee
                {
                    Id = 6,
                    CoffeeName = "Americano",
                    Description = "Espresso shots are topped with water to produce a light layer of crema, then served over ice. The result is this wonderfully rich cup with depth and nuance.",
                    Price = 120,
                    Picture = "C:\\Users\\Kyla De Leon\\source\\repos\\Radiant-Luxe-Kafe\\Resources\\iced americano1.png"
                },
                new Coffee
                {
                    Id = 7,
                    CoffeeName = "Caffe Mocha",
                    Description = "Espresso combined with bittersweet mocha sauce and milk over ice. Topped with sweetened whipped cream.",
                    Price = 130,
                    Picture = "C:\\Users\\Kyla De Leon\\source\\repos\\Radiant-Luxe-Kafe\\Resources\\iced caffe mocha1.png"
                },
                new Coffee
                {
                    Id = 8,
                    CoffeeName = "Cappuccino",
                    Description = "Dark, rich espresso lies in wait under a smoothed and stretched layer of thick milk foam. An alchemy of barista artistry and craft.",
                    Price = 140,
                    Picture = "C:\\Users\\Kyla De Leon\\source\\repos\\Radiant-Luxe-Kafe\\Resources\\iced cappuccino1.png"
                },
                new Coffee
                {
                    Id = 9,
                    CoffeeName = "Caramel Macchiato",
                    Description = "We combine our rich, full-bodied espresso with vanilla-flavored syrup, milk and ice, then top it off with caramel drizzle for an oh-so-sweet finish.",
                    Price = 150,
                    Picture = "C:\\Users\\Kyla De Leon\\source\\repos\\Radiant-Luxe-Kafe\\Resources\\iced caramel macchiato1.png"
                },
                new Coffee
                {
                    Id = 10,      
                    CoffeeName = "Green Tea Latte",
                    Description = "Smooth and creamy matcha is lightly sweetened and served with milk and ice.",
                    Price = 190,
                    Picture = "C:\\Users\\Kyla De Leon\\source\\repos\\Radiant-Luxe-Kafe\\Resources\\iced green tea latte1.png"
                },
                new Coffee
                {
                    Id = 11,
                    CoffeeName = "White Chocolate Mocha",
                    Description = "Our signature espresso meets white chocolate sauce, milk and ice, then is finished off with sweetened whipped cream in this white chocolate delight.",
                    Price = 190,
                    Picture = "C:\\Users\\Kyla De Leon\\source\\repos\\Radiant-Luxe-Kafe\\Resources\\iced white chocolate mocha1.png"
                },
                // Blended Drinks
                new Coffee
                {
                    Id = 12,
                    CoffeeName = "Caramel Frappuccino",
                    Description = "Buttery caramel syrup meets coffee, milk and ice for a rendezvous in the blender. Then whipped cream and caramel sauce layer the love on top.",
                    Price = 160,
                    Picture = "C:\\Users\\Kyla De Leon\\source\\repos\\Radiant-Luxe-Kafe\\Resources\\blended caramel frappuccino1.png"
                },
                new Coffee
                {
                    Id = 13,
                    CoffeeName = "Dark Caramel Coffee",
                    Description = "Dark caramel coffee Frappuccino is topped with buttery dark caramel sauce and layered between signature whipped cream infused with cold brew, dark caramel sauce, and white chocolate mocha, and a dollop of dark caramel sauce at the bottom of the cup.\r\n",
                    Price = 170,
                    Picture = "C:\\Users\\Kyla De Leon\\source\\repos\\Radiant-Luxe-Kafe\\Resources\\blended dark caramel coffee frappuccino1.png"
                },
                new Coffee
                {
                    Id = 14,
                    CoffeeName = "Java Chip Frappuccino",
                    Description = "We blend mocha sauce and Frappuccino® chips with Frappuccino® roast coffee and milk and ice, then top with whipped cream and mocha drizzle to bring you endless java joy.\r\n",
                    Price = 170,
                    Picture = "C:\\Users\\Kyla De Leon\\source\\repos\\Radiant-Luxe-Kafe\\Resources\\blended java chip frappuccino1.png"
                },
                new Coffee
                {
                    Id = 15,
                    CoffeeName = "Strawberries n' Cream",
                    Description = "Strawberries and milk are blended with ice and topped with a swirl of whipped cream. Sip on the crème of the crop.",
                    Price = 190,
                    Picture = "C:\\Users\\Kyla De Leon\\source\\repos\\Radiant-Luxe-Kafe\\Resources\\blended strawberries & cream frappuccino1.png"
                },
                new Coffee
                {
                    Id = 16,      
                    CoffeeName = "Triple Mocha Frappuccino",
                    Description = "Your favorite Mocha Frappuccino is topped with rich dark mocha sauce and layered between the signature whipped cream infused with cold brew, dark caramel sauce, and white chocolate mocha, and a dollop of dark mocha sauce at the bottom of the cup.\r\n",
                    Price = 190,
                    Picture = "C:\\Users\\Kyla De Leon\\source\\repos\\Radiant-Luxe-Kafe\\Resources\\blended triple mocha frappuccino1.png"
                },
                new Coffee
                {
                    Id = 17,      
                    CoffeeName = "Vanilla Cream Frappuccino",
                    Description = "This rich and creamy blend of vanilla bean, milk and ice topped with whipped cream takes va-va-vanilla flavor to another level.\r\n",
                    Price = 200,
                    Picture = "C:\\Users\\Kyla De Leon\\source\\repos\\Radiant-Luxe-Kafe\\Resources\\blended vanilla cream frappuccino1.png"
                },
                 // Add-ons
                new Coffee
                {
                    Id = 18,      
                    CoffeeName = "Butter",
                    Description = "Butter for smoother mouthfeel and a slightly creamy taste",
                    Price = 35,
                    Picture = "C:\\Users\\Kyla De Leon\\source\\repos\\Radiant-Luxe-Kafe\\Resources\\butter.png"
                },
                new Coffee
                {
                    Id = 19,      
                    CoffeeName = "Honey",
                    Description = "Honey for natural sweetness.",
                    Price = 20,
                    Picture = "C:\\Users\\Kyla De Leon\\source\\repos\\Radiant-Luxe-Kafe\\Resources\\honey.png"
                },
                new Coffee
                {
                    Id = 20,      
                    CoffeeName = "Milk",
                    Description = "Milk for more creamier drink.",
                    Price = 30,
                    Picture = "C:\\Users\\Kyla De Leon\\source\\repos\\Radiant-Luxe-Kafe\\Resources\\milk.png"
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

            rtbReceipt.Clear();
            rtbReceipt.AppendText("\r\n\t\tOFFICIAL RECEIPT\r\n");
            rtbReceipt.AppendText("\r\n••••••••••••••••••••••••••••••••••••••\r\n");
            rtbReceipt.AppendText("\n");
            rtbReceipt.AppendText("\t\tRadiantLuxe Kafé\t\r\n");
            rtbReceipt.AppendText("\t        MacArthur Hwy, Angeles,\t\r\n");
            rtbReceipt.AppendText("\t\t  2009 Pampanga\r\n");
            rtbReceipt.AppendText("\r\n••••••••••••••••••••••••••••••••••••••\r\n");
            rtbReceipt.AppendText($"\r\n\t\t{DateTime.Now:MMMM dd, yyyy}");
            rtbReceipt.AppendText($"\r\n\t\t        {DateTime.Now:hh:mm tt}\t\t\r\n");
            rtbReceipt.AppendText("\n");
            rtbReceipt.AppendText("••••••••••••••••••••••••••••••••••••••\r\n");
            rtbReceipt.AppendText("Qty:\tItem:\t\t\t\tPrice:\n");
            rtbReceipt.AppendText("••••••••••••••••••••••••••••••••••••••\r\n");
            rtbReceipt.AppendText("\n");

            foreach (var coffee in shoppingCart)
            {
                var control = new CartControl(coffee, RemoveCoffeeFromCart);
                CartPanel.Controls.Add(control);
                total += coffee.Price * coffee.Quantity;

            

                if (coffee.CoffeeName.Length < 7)
                {
                    rtbReceipt.AppendText($"{coffee.Quantity}\t{coffee.CoffeeName}\t\t\t\t{coffee.Price * coffee.Quantity:C}\r\n");
                }
                else if(coffee.CoffeeName.Length < 15)
                {
                    rtbReceipt.AppendText($"{coffee.Quantity}\t{coffee.CoffeeName}\t\t\t{coffee.Price * coffee.Quantity:C}\r\n");
                }
                else if (coffee.CoffeeName.Length < 22)
                {
                    rtbReceipt.AppendText($"{coffee.Quantity}\t{coffee.CoffeeName}\t\t{coffee.Price * coffee.Quantity:C}\r\n");
                }
                else
                {
                    rtbReceipt.AppendText($"{coffee.Quantity}\t{coffee.CoffeeName}\t{coffee.Price * coffee.Quantity:C}\r\n");
                }
            }                                                                 

            rtbReceipt.AppendText("\n");
            rtbReceipt.AppendText("••••••••••••••••••••••••••••••••••••••\r\n");
            rtbReceipt.AppendText($"\nTOTAL:{"".PadLeft(30)}\t\t{total.ToString("C")}\r\n");
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

        private void Home_Click(object sender, EventArgs e)
        {
            
        }

        private void lblAddress_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button11_Click(object sender, EventArgs e)
        {
            TabPane.SelectedTab = Home;
        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {
            TabPane.SelectedTab = Menu;
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            TabPane.SelectedTab = Cart;
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            TabPane.SelectedTab = About;
        }

        private void guna2Button14_Click(object sender, EventArgs e)
        {
            TabPane.SelectedTab = Cart;
            rtbReceipt.SelectAll();
            rtbReceipt.SelectionAlignment = HorizontalAlignment.Center;
            DisplayCart();
        }

        private void guna2Button16_Click(object sender, EventArgs e)
        {
            TabPane.SelectedTab = Home;
        }

        private void guna2Button15_Click(object sender, EventArgs e)
        {
            TabPane.SelectedTab = Menu;
        }

        private void guna2Button13_Click(object sender, EventArgs e)
        {
            TabPane.SelectedTab = About;
        }

        private void homeBtn(object sender, EventArgs e)
        {
            TabPane.SelectedTab = Home;
        }

        private void menuBtn(object sender, EventArgs e)
        {
            TabPane.SelectedTab = Menu;
        }

        private void cartBtn(object sender, EventArgs e)
        {
            TabPane.SelectedTab = Cart;
        }

        private void About_Click(object sender, EventArgs e)
        {
            TabPane.SelectedTab = About;
        }

        private void TabPane_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Cart_Click(object sender, EventArgs e)
        {

        }

        private void rtbReceipt_TextChanged(object sender, EventArgs e)
        {

        }

        private void CartPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }

        private void lblGender_Click(object sender, EventArgs e)
        {

        }

        private void lblPhoneNumber_Click(object sender, EventArgs e)
        {

        }

        private void lblFullName_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button18_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button19_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button20_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button21_Click(object sender, EventArgs e)
        {

        }

        private void aboutBtn(object sender, EventArgs e)
        {
            TabPane.SelectedTab = About;
        }

        private void loginBtn(object sender, EventArgs e)
        {
        }

        private void exitBtn(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minBtn(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void accBtn(object sender, EventArgs e)
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
                        if (reader.Read())
                        {
                            string fullName = reader.GetString("FullName");
                            string address = reader.GetString("Address");
                            string phoneNumber = reader.GetString("PhoneNumber");
                            string gender = reader.GetString("Gender");
                            string username = reader.GetString("Username");
                            string password = reader.GetString("Password");
                            
                            lblFullName.Text = fullName;
                            lblAddress.Text = address;
                            lblPhoneNumber.Text = phoneNumber;
                            lblGender.Text = gender;
                            lblUsername.Text = username;
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

        private void guna2Button27_Click(object sender, EventArgs e)
        {
            

            if (string.IsNullOrEmpty(_username))
            {
                guna2Button27.Text = "Sign In";
                this.Hide();
                Login login = new Login();
                login.Show();
            }
            else
            {
                guna2Button27.Text = "Sign Out";
                mLogout logout = new mLogout();
                logout.Show();
                this.Hide();
            }
        }

        private void guna2Button37_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button38_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
      
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Print();
        }

        private void Print()
        {
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        private void PrintPageHandler(object sender, PrintPageEventArgs e)
        {
            string originalText = rtbReceipt.Text;
            string cleanedText = originalText.Replace("•", "");

            using (StringFormat stringFormat = new StringFormat())
            {
                stringFormat.Alignment = StringAlignment.Center;
                stringFormat.LineAlignment = StringAlignment.Center;

                // Remove the header drawstring

                float yPos = e.MarginBounds.Top;  // Adjust yPos based on your layout needs

                using (Font contentFont = new Font("Arial", 12))
                {
                    string[] lines = cleanedText.Split('\n');

                    foreach (string line in lines)
                    {
                        // Draw each line with left alignment
                        e.Graphics.DrawString(line, contentFont, Brushes.Black, e.MarginBounds.Left, yPos);
                        yPos += contentFont.GetHeight();
                    }
                }
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            CartPanel.Controls.Clear();

            decimal total = 0;

            rtbReceipt.Clear();
            rtbReceipt.AppendText("\r\n\t\tOFFICIAL RECEIPT\r\n");
            rtbReceipt.AppendText("\r\n••••••••••••••••••••••••••••••••••••••\r\n");
            rtbReceipt.AppendText("\n");
            rtbReceipt.AppendText("\t\tRadiantLuxe Kafé\t\r\n");
            rtbReceipt.AppendText("\t        MacArthur Hwy, Angeles,\t\r\n");
            rtbReceipt.AppendText("\t\t  2009 Pampanga\r\n");
            rtbReceipt.AppendText("\r\n••••••••••••••••••••••••••••••••••••••\r\n");
            rtbReceipt.AppendText($"\r\n\t\t{DateTime.Now:MMMM dd, yyyy}");
            rtbReceipt.AppendText($"\r\n\t\t        {DateTime.Now:hh:mm tt}\t\t\r\n");
            rtbReceipt.AppendText("\n");
            rtbReceipt.AppendText("••••••••••••••••••••••••••••••••••••••\r\n");
            rtbReceipt.AppendText("Qty:\tItem:\t\t\t\tPrice:\n");
            rtbReceipt.AppendText("••••••••••••••••••••••••••••••••••••••\r\n");
            rtbReceipt.AppendText("\n");

            foreach (var coffee in shoppingCart)
            {
                var control = new CartControl(coffee, RemoveCoffeeFromCart);
                CartPanel.Controls.Add(control);
                total += coffee.Price * coffee.Quantity;

                if (coffee.CoffeeName.Length < 7)
                {
                    rtbReceipt.AppendText($"{coffee.Quantity}\t{coffee.CoffeeName}\t\t\t\t{coffee.Price * coffee.Quantity:C}\r\n");
                }
                else if (coffee.CoffeeName.Length < 15)
                {
                    rtbReceipt.AppendText($"{coffee.Quantity}\t{coffee.CoffeeName}\t\t\t{coffee.Price * coffee.Quantity:C}\r\n");
                }
                else if (coffee.CoffeeName.Length < 22)
                {
                    rtbReceipt.AppendText($"{coffee.Quantity}\t{coffee.CoffeeName}\t\t{coffee.Price * coffee.Quantity:C}\r\n");
                }
                else
                {
                    rtbReceipt.AppendText($"{coffee.Quantity}\t{coffee.CoffeeName}\t{coffee.Price * coffee.Quantity:C}\r\n");
                }
            }

            rtbReceipt.AppendText("\n");
            rtbReceipt.AppendText("••••••••••••••••••••••••••••••••••••••\r\n");
            rtbReceipt.AppendText($"\nTOTAL:{"".PadLeft(30)}\t\t{total.ToString("C")}\r\n");
        }
    }
}
