# ☕ RadiantLuxe Kafé 

"RadiantLuxe Kafé" is a sophisticated coffee shopping and ordering application developed as a project for the College of Computer Studies at Angeles University Foundation. It is a C# Windows Form application built using Visual Studio 2022. The application provides a seamless and convenient experience for users to explore, order, and manage their favorite coffee blends from the comfort of their homes or on the go.

## 🌟 Key Features

* **User Authentication:** Secure user registration and login system.
* **Personalized Accounts:** Users can create and manage personal profiles, which display their details (username, address, phone number, gender) on a dedicated "Account" page.
* **Interactive Menu:** A user-friendly interface to browse coffee options, categorized into Hot Coffee, Iced Coffee, Blended Drinks, and Add-Ons.
* **Shopping Cart:** A fully functional cart where users can add items, adjust quantities, and see a running total.
* **Receipt Generation:** Automatically generates a detailed, itemized receipt for each order, which is displayed in the cart.
* **Splash Screen:** A loading screen that appears when the application starts.
* **About Page:** Includes the café's Mission and Vision statements.

## 💻 Technologies Used

* **Language:** C#
* **Framework:** .NET Windows Forms
* **IDE:** Visual Studio 2022
* **Database:** MySQL
* **UI Library:** Guna Framework (Guna.UI2)

## 🛠️ Setup and Installation

To run this project locally:

1.  **Clone the repository.**
2.  **Database Setup:**
    * Ensure you have a MySQL server running (e.g., XAMPP).
    * Create a database named `dbRLK`.
    * Create a `customerinfo` table. Based on the source code, it should include the following columns:
        * `FullName`
        * `Address`
        * `PhoneNumber`
        * `Gender`
        * `Username`
        * `Password`
        * `Confirm Password`
    * Update the `CONNECTION_STRING` in `Main.cs`, `Login.cs`, and `Register.cs` if your MySQL server credentials (user, password) are different from the default (`server=localhost; user id=root; password=;`).
3.  **Open in Visual Studio:**
    * Open the `.sln` file in Visual Studio 2022.
    * Ensure the necessary NuGet packages (like `MySql.Data` and `Guna.UI2`) are restored.
4.  **Run the application.**
