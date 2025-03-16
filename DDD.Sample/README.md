# Domain-Driven Design (DDD) Microservice in ASP.NET Core 8

## 📌 Overview
This project is a **DDD-based Microservice** built with **ASP.NET Core 8**. It follows **Clean Architecture**, using **Entity Framework Core (In-Memory DB)** and **RESTful API principles**.

## 🏗️ Project Structure
DDDExample ├── Core │ ├── Domain │ │ ├── Entities (Order, OrderItem) │ │ ├── Interfaces (IOrderRepository) │ ├── Application │ │ ├── DTOs (OrderDTO, OrderItemDTO) │ │ ├── UseCases (CreateOrderUseCase) ├── Infrastructure │ ├── Persistence │ │ ├── AppDbContext (EF Core) │ │ ├── OrderRepository ├── API │ ├── Controllers (OrderController) │ ├── Program.cs │ ├── appsettings.json

## 🚀 Technologies Used
- **ASP.NET Core 8**
- **Entity Framework Core 8 (In-Memory DB)**
- **Domain-Driven Design (DDD)**
- **Dependency Injection**
- **Swagger for API Documentation**
## 🛠️ Project Structure Details

| Layer          | Description  |
|---------------|-------------|
| **Core**       | Defines domain entities (`Order`, `OrderItem`) and repository interface (`IOrderRepository`). |
| **Application** | Contains DTOs and Use Cases (`CreateOrderUseCase`). |
| **Infrastructure** | Implements **EF Core** (`AppDbContext`, `OrderRepository`). |
| **API**         | Exposes RESTful endpoints (`OrderController`). |
