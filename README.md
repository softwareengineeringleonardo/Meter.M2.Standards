# Meter.M2.Standards
A clean architecture sample project demonstrating SOLID principles, Domain-Driven Design (DDD), Command Query Responsibility Segregation (CQRS), Inversion of Control (IoC), 
and Event-Driven Architecture (EDA) using .NET Core with RESTful APIs and gRPC microservices.**

## Purpose
This repository serves as a reference architecture for building scalable, maintainable, and modular enterprise applications using modern software engineering best practices.
It is intended for developers, architects, and teams adopting microservices and .NET Core in distributed systems.

## Key Architectural Patterns

### SOLID Principles
The project adheres to the SOLID principles to ensure clean, testable, and maintainable code.

###  Domain-Driven Design (DDD)
Domain models are designed around business logic, with a focus on aggregates, value objects, and bounded contexts.

###  CQRS (Command Query Responsibility Segregation)
Separation of read and write operations to optimize scalability, performance, and clarity.

###  IoC (Inversion of Control)
Dependency injection is used extensively to promote loose coupling between components and improve testability.

###  EDA (Event-Driven Architecture)
Services communicate asynchronously through domain events, promoting decoupling and eventual consistency.
---

## Technology Stack

- **.NET Core 8+**
- **ASP.NET Core Web API**
- **gRPC** for high-performance inter-service communication
- **Entity Framework Core**
- **MediatR** for CQRS and application flow
- **Kafka/RabbitMQ** (abstracted for EDA)
- **Swagger/OpenAPI**
- **Docker** (optional for containerization)

---

# Project Structure C1
- Meter.M2.Standards/
- ├── src/
- │ ├── Meter.M2.API → RESTful API layer
- │ ├── Meter.M2.Grpc → gRPC service definition
- │ ├── Meter.M2.Application → CQRS handlers and service logic
- │ ├── Meter.M2.Domain → Core domain models and logic (DDD)
- │ ├── Meter.M2.Infrastructure → Data access, messaging, external integrations
- │ └── Meter.M2.IoC → Dependency injection configuration
- └── README.md
---

## Getting Started
### Prerequisites
- [.NET SDK 7+](https://dotnet.microsoft.com/)
- [Docker](https://www.docker.com/) (optional)
- [Git](https://git-scm.com/)
- [Kafka or RabbitMQ] for event bus (optional)

  
## Run the API locally
## bash
cd src/Meter.M2.API
dotnet run

## Contributing
Contributions are welcome! Please open issues or submit pull requests with improvements, examples, or bug fixes.

## License
This project is licensed under the MIT License.

## About the Author
Created by Leonardo — Software Engineer & Solution Architect passionate about clean architecture, distributed systems, and modern .NET development.
- ⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣀⣠⣶⣶⣶⣶⣤⣤⣤⣤⣤⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
- ⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣠⣴⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣦⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
- ⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣀⣴⣾⣿⣿⣿⣿⣿⣿⣿⣿⣿⠿⠟⠛⠛⠛⠿⠿⣿⣿⣿⣧⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
- ⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢠⡾⣿⣿⣿⣿⣿⣿⣿⣿⣿⡏⠁⠀⢀⣀⣀⠀⠀⠀⠀⠈⢻⣿⢻⡷⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
- ⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠹⠛⣽⣿⣿⣿⣿⣿⣿⣿⠃⠀⠘⢋⣡⣍⣓⡶⠖⣶⣤⣤⣿⡄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
- ⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢿⡿⠟⠋⠉⠀⠀⠀⠙⢿⣭⣿⣿⣿⢘⣻⣽⣮⡝⣇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
- ⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢠⣾⣿⡳⣦⠰⡄⠀⠀⠀⠀⠈⠻⡿⠿⠋⠘⣟⠛⠛⠉⢻⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
- ⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢾⣟⣽⢿⡆⠀⠙⠦⣄⠀⠀⠀⠀⠀⢉⣾⣦⣽⣧⠀⠀⠘⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
- ⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠘⢿⡟⠻⢿⡄⠀⣰⠋⠀⠀⠀⠀⠀⣾⠉⣡⣿⣾⣇⠀⠀⢿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
- ⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠉⢻⡟⡅⠀⢹⡀⠀⠀⠀⠀⠰⠏⣴⣿⣿⣿⣏⠀⣸⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
- ⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⣧⠸⡄⠀⠹⣶⠀⠀⠀⢠⣼⠃⠘⠛⠛⠉⡜⠋⣼⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
- ⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢠⣬⣷⣦⣄⡀⠈⠙⠛⠋⠈⠻⢦⣤⣤⣴⠞⢁⡼⠃⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
- ⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣴⣿⣿⣿⣿⣿⣿⣷⣤⣀⡀⠀⠒⠀⠀⢀⣠⡴⠛⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
- ⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣰⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣷⣾⣿⣿⡅⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
- ⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢠⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡏⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
- ⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣾⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣷⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
- ⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢰⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣧⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
- ⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣧⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
- ⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣶⣄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
- ⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣀⣀⣀⡀⠀⠀⣀⢀⣰⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⢫⣽⣿⣿⣿⡷⠶⠖⠚⠛⠛⠛⠛⠛⠛⢛⣒⠲⠶⠤⣄⣀⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
- ⣀⣀⣠⣤⣤⡴⠶⠖⢛⣛⡋⠉⠉⠉⢿⣷⣄⣻⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⠋⠉⣽⣿⣿⣿⣶⠟⠉⠉⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠉⠛⠒⠾⢯⣟⣲⢦⣄⣀⠀⠀⠀⠀⠀⠀
- ⠹⣿⡴⠖⠒⠋⠉⠁⠀⠀⠀⠀⠀⣀⣘⣧⠉⠻⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣏⣀⣠⣤⣿⣿⣿⠿⠋⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠙⠓⠯⣟⣶⣤⣀⠀⠀
- ⠀⠈⠻⣦⣀⣀⣤⡤⠴⠶⣒⣿⣿⡿⠿⠿⠛⠿⢿⣍⣙⠻⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠋⠉⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠉⠳⢿⡷⣤
- ⠀⠀⠀⠘⢿⣌⠀⢀⣴⣾⠋⠁⠀⠀⠀⠀⠀⠀⠀⠀⠉⠉⠉⠉⠉⠉⠉⢠⣾⣿⣿⣿⣿⣿⡇⠀⠀⠀⢀⣤⣶⠶⠶⠶⣤⣀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⡤⠶⢚⠃⣽
- ⠀⠀⠀⠀⠀⠙⠓⣿⣻⠋⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠛⣿⣿⣿⣿⣿⡟⠀⠀⣴⣿⣿⣿⡄⠀⠀⣰⣿⣷⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠐⠋⣉⣠⣴⣿⡿⠃
- ⠀⠀⠀⠀⠀⠀⢸⣷⡏⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠻⣿⣿⣯⡉⠀⠀⢸⡿⠿⠿⢿⣿⣦⣾⣿⣿⣿⣷⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣀⡤⠶⠛⠉⣹⡿⠋⠀⠀
- ⠀⠀⠀⠀⠀⠀⣿⢿⠃⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠻⠿⠃⠀⠀⠸⣧⠀⠀⢀⣽⣿⠁⠉⠉⢹⡿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣀⣠⡤⠶⠚⠋⠁⠀⠀⣠⡾⠋⠀⠀⠀⠀
- ⠀⠀⠀⠀⠀⠀⣿⠿⠀⠀⢀⣀⣀⣠⣤⣴⣦⣤⣄⣀⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠻⣧⣴⣿⣿⣿⣇⠀⣠⡿⠁⠀⠀⠀⠀⢀⣀⣠⡤⠶⠒⠛⠉⠉⠀⠀⠀⠀⠀⢀⣤⠞⠋⠀⠀⠀⠀⠀⠀
- ⢀⣀⣤⡤⠤⠶⠟⠛⠛⠋⠉⢉⣀⣀⣤⣼⣷⣾⡿⠛⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠙⠻⠿⠿⠿⣟⣉⣀⣤⡤⠶⠞⠛⠉⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣠⡶⠛⠁⠀⠀⠀⠀⠀⠀⠀⠀
- ⠸⣧⣀⣤⣤⣤⣶⣶⣶⣿⣿⠿⢿⣛⣛⣿⠿⠋⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣀⣠⣤⠤⠴⠶⠚⠛⠋⠉⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣀⣤⠶⠛⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
- ⠀⠛⠛⠋⠉⠉⠉⢿⡟⠒⠛⠉⠉⠉⠀⠀⠀⠀⠀⠀⠀⢀⣀⣀⣀⣠⡤⠤⠴⠶⠒⠚⠛⠉⠉⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣀⣀⣠⣤⠶⠞⠛⠉⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
- ⠀⠀⠀⠀⠀⠀⠀⠘⣧⣀⣀⣀⣠⣤⡤⠤⠶⠒⠒⠛⠋⠉⠉⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣀⣀⣀⣤⣤⠴⠶⠖⠛⠛⠋⠉⠉⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
- ⠀⠀⠀⠀⠀⠀⠀⠀⠘⣿⡉⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣀⣀⣤⣤⡤⠴⠶⠖⠛⠋⠉⠉⠉⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
- ⠀⠀⠀⠀⠀⠀⠀⠀⢀⣬⣿⣦⣀⠀⠀⠀⠀⠀⢀⣀⣀⣤⣤⣤⠴⠶⠶⠒⠛⠛⠉⠉⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
- ⠀⠀⠀⠀⠀⠀⠀⠀⣼⣃⠀⠈⠉⠛⠛⠛⠛⠋⠉⣩⡿⣻⡿⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
- ⠀⠀⠀⠀⠀⠀⠀⣸⡏⠀⠀⠀⠀⠀⠀⢀⣀⣠⡾⠏⣰⠟⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
- ⠀⠀⠀⠀⠀⠀⢠⣿⠤⠴⠶⠒⠚⠛⠋⢉⣉⣉⣤⣼⠏⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
- ⠀⠀⠀⠀⠀⠀⣿⣥⡤⠴⠶⠶⠚⠛⠋⠉⠉⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
- ⠀⠀⠀⠀⠀⠀⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
