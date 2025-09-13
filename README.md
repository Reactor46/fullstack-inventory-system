# fullstack-inventory-system
Fullstack Inventory Management App | .NET Microservices + React + SQL
---


# Sistema de Gestión de Inventario
Evaluación técnica para el puesto de Desarrollador Full Stack en Netby.

Esta aplicación implementa una arquitectura de microservicios en .NET Core para el backend yAngular, React para el frontend, usando SQL Server como base de datos.
Permite la gestión de productos y transacciones de compras y ventas, con validación de stock, paginación, filtros dinámicos y una interfaz web moderna y responsiva.


---


## 💻 Frontends Disponibles

Este proyecto incluye dos implementaciones de frontend que consumen los mismos microservicios:

| Framework | Carpeta             | Comando de ejecución       |
|-----------|----------------------|------------------------------|
| React     | `/frontend/inventory-react`     | `npm run dev` |
| Angular   | `/frontend/inventory-angular`   | `ng serve`    |




## ⚙️ Configuración de la Base de Datos

1. Crear dos bases de datos vacía en SQL Server para inventario y producto ejemplo: InventarioDB, ProductosDb
2. Configurar la cadena de conexión en los archivos `appsettings.json` de cada microservicio, por ejemplo:

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=localhost\\SQLEXPRESS;Database=InventarioDB;Trusted_Connection=True;TrustServerCertificate=True;"
}
```

---

## 💻 Ejecución del Backend

Cada microservicio se encuentra en la carpeta /backend/:

/backend/Productos.API
/backend/Transacciones.API

Pasos para ejecutar:

```bash
cd backend/Productos.API
dotnet restore
dotnet ef database update
dotnet run
```

```bash
Copiar código
cd backend/Transacciones.API
dotnet restore
dotnet ef database update
dotnet run
```