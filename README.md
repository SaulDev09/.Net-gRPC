# .Net-gRPC

## 👨‍💻 Structure: Version 2 - feature/02-Domain

```
Solution
|
|-- Application/
|   |-- Interfaces
|   |-- UseCases
|
|-- Domain/
|   |-- Domain
|       |-- Commons/ ✅
|	|   |-- BaseAuditableEntity.cs ✅
|	|   |-- BaseEntity.cs ✅
|	|   |-- BaseEvent.cs ✅
|	|
|       |-- Entities/ ✅
|	|   |-- Order.cs ✅
|	|
|       |-- Enums/ ✅
|	|   |-- OrderSide.cs ✅
|	|   |-- OrderType.cs ✅
|	|
|       |-- Events/ ✅
|	    |-- OrderCanceledEvent.cs ✅
|	    |-- OrderCreatedEvent.cs ✅
|	    |-- OrderUpdatedEvent.cs ✅
|
|-- Infrastructure/
|   |-- Infrastructure
|   |-- Persistence
|
|-- Presentation/
    |-- Services.gRPC
```

## Projects:

📁 Application:  
🧩 Interfaces  
	Class Library, .NET 8.0  

🧩 UseCases  
	Class Library, .NET 8.0  

📁 Domain  
🧩 Domain  
	Class Library, .NET 8.0  

📁 Infrastructure  
🧩 Infrastructure  
	Class Library, .NET 8.0  

🧩 Persistence  
	Class Library, .NET 8.0  

📁 Presentation  
🌐 Services.gRPC  
	ASP.NET Core gRPC Service .NET 8.0

