# Pluto Lite POS

A desktop-based Point of Sale (POS) application built with C# and Windows Forms for managing retail sales, inventory, and customer data.

## Overview

Pluto Lite POS is a comprehensive solution designed for small to medium-sized businesses to handle their daily sales operations. It features a user-friendly interface and modules for managing every aspect of a retail workflow, from inventory and sales to customer and vendor management. The application uses a local SQL Server Compact database for data storage.

## Features

- **Sales Management:** Create, edit, and track sales transactions. Supports both walk-in and registered customers.
- **Customer Management:** Maintain a database of customers, including their contact information and transaction history.
- **Product & Inventory:** Manage products, categorize them by type, set alert levels for low stock, and handle inventory through invoices.
- **Invoice Management:** Track incoming stock and update inventory levels by creating invoices from vendors.
- **Vendor Management:** Keep a record of all vendors and their contact details.
- **Expense Tracking:** Record and monitor business expenses.
- **Reporting:** Generate reports for sales, invoices, and product inventory. Includes barcode generation and printing capabilities.
- **User Management:** Secure access with a login system and different user roles.
- **Settings:** Configure company details, receipt notes, and SMS notifications.

## Technology Stack

- **Backend:** C# with .NET Framework 4.8
- **Frontend:** Windows Forms (WinForms)
- **ORM:** Entity Framework 6
- **Database:** SQL Server Compact 4.0
- **Libraries:**
    - Newtonsoft.Json: For JSON serialization and deserialization.
    - Zen.Barcode.Rendering.Framework: For generating barcodes.
    - Bunifu UI: For custom UI controls.

## Database

The application uses a SQL Server Compact Edition (`.sdf`) database file named `PlutoDB.sdf`.

- **Connection String:** The connection string is located in the `POS mini/App.config` file.
- **Schema:** The database schema is defined in the `POS mini/Models/DBTables.cs` file using code-first migrations with Entity Framework. Key tables include `Sales`, `Customers`, `Products`, `Invoices`, and `Vendors`.

## Getting Started

To run this project, you will need Visual Studio and the .NET Framework 4.8 SDK.

1.  **Clone the repository:**
    ```sh
    git clone <repository-url>
    ```
2.  **Open the solution:**
    Open the `POS mini.sln` file in Visual Studio.
3.  **Restore NuGet Packages:**
    Visual Studio should automatically restore the required NuGet packages upon opening the solution. If not, open the Package Manager Console (`Tools > NuGet Package Manager > Package Manager Console`) and run:
    ```powershell
    Update-Package -reinstall
    ```
4.  **Build and Run:**
    - Build the solution (`Build > Build Solution`).
    - Start the application by pressing `F5` or clicking the "Start" button. The application will start with the `Login` screen.

## Dependencies

The project relies on the following main NuGet packages:

- `EntityFramework`
- `EntityFramework.SqlServerCompact`
- `Microsoft.SqlServer.Compact`
- `Newtonsoft.Json`
- `Zen.Barcode.Rendering.Framework`
