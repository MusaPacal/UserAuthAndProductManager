🛡️ UserAuthAndProductManager
This is a layered ASP.NET Core 8.0 web application that implements Object-Oriented Programming (OOP) and N-Tier Architecture principles. The project includes a full authentication system with ASP.NET Identity and product management features. Ideal for learning enterprise architecture patterns in .NET.

🚀 Technologies Used
ASP.NET Core 8.0

Entity Framework Core

ASP.NET Core Identity

SQL Server

Razor Pages & MVC

FluentValidation


Bootstrap (SB Admin 2 Theme)

📁 Project Structure
├── EntityLayer           // Entity classes (AppUser, AppRole, Product, etc.)
├── DataAccessLayer       // DbContext, Repositories, EF Migrations
├── BusinessLayer         // Services, Managers, Validators
├── Demo_Product          // Web UI (MVC Controllers & Views)
├── Models                // ViewModels for forms (Login, Register)

🧰 Features
✅ User registration with extended fields: Name, Surname, Gender

✅ Login system with ASP.NET Identity

✅ Custom Identity Validator (password rules)

✅ Cookie-based login system with redirection

✅ Full CRUD for Products, Categories, and Customers

✅ Role management with AppRole

✅ FluentValidation-based form validation

✅ Solid OOP and N-Tier Architecture design

🖼️ Screenshots
Replace the image links below with actual files under /screenshots:
![Register](https://github.com/user-attachments/assets/a4472cc7-842b-4c50-8df7-ba3c1021f76a)
![Login](https://github.com/user-attachments/assets/9ffdc018-019d-4561-af62-4a7731ac2335)
![Product](https://github.com/user-attachments/assets/638ef0fd-641e-4788-ad0a-a3f1529af735)


⚙️ How to Run This Project
1. Clone the repository

git clone https://github.com/MusaPacal/UserAuthAndProductManager.git

2. Open in Visual Studio
Open Demo_Product.sln

3. Update SQL Server Connection String
In DataAccessLayer/Concrete/Context.cs:

optionsBuilder.UseSqlServer("Server=YOUR_SERVER;Database=DbNewCoreProje-OOP;Trusted_Connection=True;TrustServerCertificate=True;");

Replace YOUR_SERVER with your SQL Server instance.

4. Apply Migrations
In the Package Manager Console:

Add-Migration InitialCreate
Update-Database

5. Run the Application
Press F5 or click "Start" in Visual Studio

App opens on /Register/Index

After registration, user redirected to /Login/Index

After login, redirected to /Product/Index

🔐 Authentication
Uses ASP.NET Core Identity with custom AppUser and AppRole

Login path configured as:

builder.Services.ConfigureApplicationCookie(options => {
    options.LoginPath = "/Login/Index";
});

✅ Sample Test User
You can manually add a user or seed with the following:

Username: testuser

Password: Test123!

Make sure it matches the password rules in your CustomIdentityValidator.

🧱 Architectural Highlights
Clean separation of concerns

Interface-based service injection (DI)

FluentValidation for model-level validation

SOLID principles used throughout
