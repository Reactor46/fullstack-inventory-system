# fullstack-inventory-system
Fullstack Inventory Management App | .NET Microservices + React + SQL
---

# Inventory Management System
Technical assessment for the Full Stack Developer position.

This application implements a microservices architecture in .NET Core for the backend and Angular, React for the frontend, using SQL Server as the database.
It allows the management of products and purchase and sales transactions, with stock validation, pagination, dynamic filters, and a modern, responsive web interface.

---

## 💻 Available Frontends

This project includes two frontend implementations that consume the same microservices:

| Framework | Folder             | Run command       |
|-----------|----------------------|------------------|
| React     | `/frontend/inventory-react`     | `npm run dev` |
| Angular   | `/frontend/inventory-angular`   | `ng serve`    |


## 💻 Available Backends

| Microservice       | Folder                  | Run command | Description |
|--------------------|-------------------------|-------------|-------------|
| Productos.API      | `/backend/Productos.API`       | `dotnet run`        | Product CRUD and stock management |
| Transacciones.API  | `/backend/Transacciones.API`   | `dotnet run`        | Record of purchases/sales, stock validation and adjustment |
| Shared             | `/backend/Shared`              | N/A                 | Shared common classes and DTOs |




## ⚙️ Database Configuration

1. Create two empty databases in SQL Server for inventory and products, for example: InventarioDB, ProductosDb
2. Configure the connection string in the `appsettings.json` files of each microservice, for example:

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=localhost\\SQLEXPRESS;Database=InventarioDB;Trusted_Connection=True;TrustServerCertificate=True;"
}
```

### Migrations and Database

1. Create the database:
   ```sql
   CREATE DATABASE InventarioDB;
   CREATE DATABASE ProductosDb;
   ```
---

## 💻 Running the Backend

Each microservice is located in the /backend/ folder:

/backend/Productos.API  
/backend/Transacciones.API

Steps to run:

```bash
cd backend/Productos.API
dotnet restore
dotnet ef database update
dotnet run
```

```bash
cd backend/Transacciones.API
dotnet restore
dotnet ef database update
dotnet run
```
