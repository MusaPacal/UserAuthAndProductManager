***🛡️ UserAuthAndProductManager***

 This is a layered ASP.NET Core 8.0 web    application that implements Object-Oriented Programming (OOP) and    N-Tier Architecture principles. The project includes a full    authentication system with ASP.NET Identity and product management    features. Ideal for learning enterprise architecture patterns in    .NET.
 

       🚀 Technologies Used ASP.NET Core 8.0
       Entity Framework Core
       ASP.NET Core Identity
       SQL Server
       Razor Pages & MVC
       FluentValidation
       Bootstrap (SB Admin 2 Theme)
       
***📁 Project Structure*** 

├── EntityLayer // Entity classes (AppUser,    AppRole, Product, etc.) 

├── DataAccessLayer // DbContext,    Repositories, EF Migrations 

├── BusinessLayer // Services, Managers,    Validators 

├── Demo_Product // Web UI (MVC Controllers & Views) 

├──    Models // ViewModels for forms (Login, Register)
       
       🧰 Features ✅ User registration with extended fields: Name, Surname,    Gender
       ✅ Login system with ASP.NET Identity
       ✅ Custom Identity Validator (password rules)
       ✅ Cookie-based login system with redirection
       ✅ Full CRUD for Products, Categories, and Customers
       ✅ Role management with AppRole
       ✅ FluentValidation-based form validation
       ✅ Solid OOP and N-Tier Architecture design
      
🖼️ Screenshots Replace the image links below with actual files under/screenshots:

[![Register](https://private-user-images.githubusercontent.com/72446830/459937344-a4472cc7-842b-4c50-8df7-ba3c1021f76a.png?jwt=eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJnaXRodWIuY29tIiwiYXVkIjoicmF3LmdpdGh1YnVzZXJjb250ZW50LmNvbSIsImtleSI6ImtleTUiLCJleHAiOjE3NTEwMjg1MjQsIm5iZiI6MTc1MTAyODIyNCwicGF0aCI6Ii83MjQ0NjgzMC80NTk5MzczNDQtYTQ0NzJjYzctODQyYi00YzUwLThkZjctYmEzYzEwMjFmNzZhLnBuZz9YLUFtei1BbGdvcml0aG09QVdTNC1ITUFDLVNIQTI1NiZYLUFtei1DcmVkZW50aWFsPUFLSUFWQ09EWUxTQTUzUFFLNFpBJTJGMjAyNTA2MjclMkZ1cy1lYXN0LTElMkZzMyUyRmF3czRfcmVxdWVzdCZYLUFtei1EYXRlPTIwMjUwNjI3VDEyNDM0NFomWC1BbXotRXhwaXJlcz0zMDAmWC1BbXotU2lnbmF0dXJlPTYwN2E2YzYzMzc2OGY4MjJiMTc5M2VlNTI4ODVhNjlhZTEyZmMzYThlMGM3NmIyODI1ODFlMDAxOGY1Yjk1MTQmWC1BbXotU2lnbmVkSGVhZGVycz1ob3N0In0.P2yZVR5eQWDI6h3l_-u7pOyUNJVG-4Q82ptg8uTJlPI)](https://private-user-images.githubusercontent.com/72446830/459937344-a4472cc7-842b-4c50-8df7-ba3c1021f76a.png?jwt=eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJnaXRodWIuY29tIiwiYXVkIjoicmF3LmdpdGh1YnVzZXJjb250ZW50LmNvbSIsImtleSI6ImtleTUiLCJleHAiOjE3NTEwMjg1MjQsIm5iZiI6MTc1MTAyODIyNCwicGF0aCI6Ii83MjQ0NjgzMC80NTk5MzczNDQtYTQ0NzJjYzctODQyYi00YzUwLThkZjctYmEzYzEwMjFmNzZhLnBuZz9YLUFtei1BbGdvcml0aG09QVdTNC1ITUFDLVNIQTI1NiZYLUFtei1DcmVkZW50aWFsPUFLSUFWQ09EWUxTQTUzUFFLNFpBJTJGMjAyNTA2MjclMkZ1cy1lYXN0LTElMkZzMyUyRmF3czRfcmVxdWVzdCZYLUFtei1EYXRlPTIwMjUwNjI3VDEyNDM0NFomWC1BbXotRXhwaXJlcz0zMDAmWC1BbXotU2lnbmF0dXJlPTYwN2E2YzYzMzc2OGY4MjJiMTc5M2VlNTI4ODVhNjlhZTEyZmMzYThlMGM3NmIyODI1ODFlMDAxOGY1Yjk1MTQmWC1BbXotU2lnbmVkSGVhZGVycz1ob3N0In0.P2yZVR5eQWDI6h3l_-u7pOyUNJVG-4Q82ptg8uTJlPI)    [![Login](https://private-user-images.githubusercontent.com/72446830/459937477-9ffdc018-019d-4561-af62-4a7731ac2335.png?jwt=eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJnaXRodWIuY29tIiwiYXVkIjoicmF3LmdpdGh1YnVzZXJjb250ZW50LmNvbSIsImtleSI6ImtleTUiLCJleHAiOjE3NTEwMjg1MjQsIm5iZiI6MTc1MTAyODIyNCwicGF0aCI6Ii83MjQ0NjgzMC80NTk5Mzc0NzctOWZmZGMwMTgtMDE5ZC00NTYxLWFmNjItNGE3NzMxYWMyMzM1LnBuZz9YLUFtei1BbGdvcml0aG09QVdTNC1ITUFDLVNIQTI1NiZYLUFtei1DcmVkZW50aWFsPUFLSUFWQ09EWUxTQTUzUFFLNFpBJTJGMjAyNTA2MjclMkZ1cy1lYXN0LTElMkZzMyUyRmF3czRfcmVxdWVzdCZYLUFtei1EYXRlPTIwMjUwNjI3VDEyNDM0NFomWC1BbXotRXhwaXJlcz0zMDAmWC1BbXotU2lnbmF0dXJlPTUxYWU5MGE3ZmU4OWYyNTY2OGZkMmQ1MmE5YmZkZmQwM2EzYmI5YzBhYmIwYjY5MWRhMmY0Nzg2MjZhODIxYTImWC1BbXotU2lnbmVkSGVhZGVycz1ob3N0In0.pOSWo1EOoFvLK32jfV_THYoulvka_KsNzJ5hqdhwLU0)](https://private-user-images.githubusercontent.com/72446830/459937477-9ffdc018-019d-4561-af62-4a7731ac2335.png?jwt=eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJnaXRodWIuY29tIiwiYXVkIjoicmF3LmdpdGh1YnVzZXJjb250ZW50LmNvbSIsImtleSI6ImtleTUiLCJleHAiOjE3NTEwMjg1MjQsIm5iZiI6MTc1MTAyODIyNCwicGF0aCI6Ii83MjQ0NjgzMC80NTk5Mzc0NzctOWZmZGMwMTgtMDE5ZC00NTYxLWFmNjItNGE3NzMxYWMyMzM1LnBuZz9YLUFtei1BbGdvcml0aG09QVdTNC1ITUFDLVNIQTI1NiZYLUFtei1DcmVkZW50aWFsPUFLSUFWQ09EWUxTQTUzUFFLNFpBJTJGMjAyNTA2MjclMkZ1cy1lYXN0LTElMkZzMyUyRmF3czRfcmVxdWVzdCZYLUFtei1EYXRlPTIwMjUwNjI3VDEyNDM0NFomWC1BbXotRXhwaXJlcz0zMDAmWC1BbXotU2lnbmF0dXJlPTUxYWU5MGE3ZmU4OWYyNTY2OGZkMmQ1MmE5YmZkZmQwM2EzYmI5YzBhYmIwYjY5MWRhMmY0Nzg2MjZhODIxYTImWC1BbXotU2lnbmVkSGVhZGVycz1ob3N0In0.pOSWo1EOoFvLK32jfV_THYoulvka_KsNzJ5hqdhwLU0)    [![Product](https://private-user-images.githubusercontent.com/72446830/459937573-638ef0fd-641e-4788-ad0a-a3f1529af735.png?jwt=eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJnaXRodWIuY29tIiwiYXVkIjoicmF3LmdpdGh1YnVzZXJjb250ZW50LmNvbSIsImtleSI6ImtleTUiLCJleHAiOjE3NTEwMjg1MjQsIm5iZiI6MTc1MTAyODIyNCwicGF0aCI6Ii83MjQ0NjgzMC80NTk5Mzc1NzMtNjM4ZWYwZmQtNjQxZS00Nzg4LWFkMGEtYTNmMTUyOWFmNzM1LnBuZz9YLUFtei1BbGdvcml0aG09QVdTNC1ITUFDLVNIQTI1NiZYLUFtei1DcmVkZW50aWFsPUFLSUFWQ09EWUxTQTUzUFFLNFpBJTJGMjAyNTA2MjclMkZ1cy1lYXN0LTElMkZzMyUyRmF3czRfcmVxdWVzdCZYLUFtei1EYXRlPTIwMjUwNjI3VDEyNDM0NFomWC1BbXotRXhwaXJlcz0zMDAmWC1BbXotU2lnbmF0dXJlPTVjYTFlN2E0MWJkYmNjNjViZWMxNjFmMDA5MGRiOWU0ZDIzMGVmNDY5YmIwMGQ1NTVhZjViZTczNjY5ZTljODMmWC1BbXotU2lnbmVkSGVhZGVycz1ob3N0In0.iKemBpDGcUHcnX9W07Ez0CMKRHWqR_luHx1z4tDmvWc)](https://private-user-images.githubusercontent.com/72446830/459937573-638ef0fd-641e-4788-ad0a-a3f1529af735.png?jwt=eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJnaXRodWIuY29tIiwiYXVkIjoicmF3LmdpdGh1YnVzZXJjb250ZW50LmNvbSIsImtleSI6ImtleTUiLCJleHAiOjE3NTEwMjg1MjQsIm5iZiI6MTc1MTAyODIyNCwicGF0aCI6Ii83MjQ0NjgzMC80NTk5Mzc1NzMtNjM4ZWYwZmQtNjQxZS00Nzg4LWFkMGEtYTNmMTUyOWFmNzM1LnBuZz9YLUFtei1BbGdvcml0aG09QVdTNC1ITUFDLVNIQTI1NiZYLUFtei1DcmVkZW50aWFsPUFLSUFWQ09EWUxTQTUzUFFLNFpBJTJGMjAyNTA2MjclMkZ1cy1lYXN0LTElMkZzMyUyRmF3czRfcmVxdWVzdCZYLUFtei1EYXRlPTIwMjUwNjI3VDEyNDM0NFomWC1BbXotRXhwaXJlcz0zMDAmWC1BbXotU2lnbmF0dXJlPTVjYTFlN2E0MWJkYmNjNjViZWMxNjFmMDA5MGRiOWU0ZDIzMGVmNDY5YmIwMGQ1NTVhZjViZTczNjY5ZTljODMmWC1BbXotU2lnbmVkSGVhZGVycz1ob3N0In0.iKemBpDGcUHcnX9W07Ez0CMKRHWqR_luHx1z4tDmvWc)



 ***⚙️ How to Run This Project***
   
   **1.  Clone the repository** 
   git clone [https://github.com/MusaPacal/UserAuthAndProductManager.git]
   
   ***2.  Open in Visual Studio Open Demo_Product.sln***
   ***3.  Update SQL Server Connection String In DataAccessLayer/Concrete/Context.cs:***
   
    optionsBuilder.UseSqlServer("Server=YOUR_SERVER;Database=DbNewCoreProjeOustServerCertificate=True;");        
 Replace YOUR_SERVER with your SQL Server instance.
   
   ******4.***  Apply Migrations In the Package Manager Console:***
       Add-Migration InitialCreate Update-Database
   
 ***5.  Run the Application Press F5 or click "Start" in Visual Studio***
       App opens on /Register/Index
       After registration, user redirected to /Login/Index
       After login, redirected to /Product/Index
       
   🔐 Authentication 
       
 Uses ASP.NET Core Identity with custom AppUser and    AppRoleLogin path configured as:
 

      builder.Services.ConfigureApplicationCookie(options => {    options.LoginPath = "/Login/Index"; });
       
       
 ✅ Sample Test User You can manually add a user or seed with the 
      following:
      
       Username: testuser
       Password: Test123!

Make sure it matches the password rules in your    CustomIdentityValidator.
       
🧱 Architectural 

 Highlights Clean separation of concerns
 
 Interface-based service injection (DI)
 
 FluentValidation for model-level validation
 
 SOLID principles used throughout 

