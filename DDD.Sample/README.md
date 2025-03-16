Domain-Driven Design (DDD) Microservice in ASP.NET Core 8
Overview
This project is a DDD-based Microservice implemented in ASP.NET Core 8, using Entity Framework Core (In-Memory Database). It follows a clean architecture approach with separate Core, Application, Infrastructure, and API layers.

Project Structure
DDDExample
├── Core
│   ├── Domain
│   │   ├── Entities (Order, OrderItem)
│   │   └── Interfaces (IOrderRepository)
│   ├── Application
│   │   ├── DTOs (OrderDTO, OrderItemDTO)
│   │   ├── UseCases (CreateOrderUseCase)
├── Infrastructure
│   ├── Persistence
│   │   ├── AppDbContext (EF Core)
│   │   ├── OrderRepository
├── API
│   ├── Controllers (OrderController)
│   ├── Program.cs
│   ├── appsettings.json

Technologies Used
ASP.NET Core 8
Entity Framework Core 8 (In-Memory)
Domain-Driven Design (DDD) Principles
Dependency Injection
Swagger for API Documentation

Project Details
Core Layer: Contains domain entities (Order, OrderItem) and the repository interface.
Application Layer: Includes DTOs and Use Cases (CreateOrderUseCase).
Infrastructure Layer: Implements EF Core (In-Memory DB) and repository.
API Layer: Exposes RESTful endpoints through OrderController.