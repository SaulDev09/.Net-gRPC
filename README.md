## 👨‍💻 Structure: Version 11 - feature/11-UpgradeNet9

```
Solution
|
|-- 📁 Application/
|   |-- 🛠️ Interfaces
|   |   |-- 📁 Persistence/
|   |       |-- 📄 IApplicationDbContext.cs
|   |
|   |-- 🛠️ UseCases
|       |-- 📁 Commons/
|	|   |-- 📁 Mappings/
|	|   |	|--📄 MappingsProfile.cs
|	|   |
|	|   |-- 📁 Behaviors/
|	|   |	|--📄 LoggingBehavior.cs
|	|   |	|--📄 ValidationBehavior.cs
|	|   |	|--📄 PerformanceBehavior.cs
|	|   |
|	|   |-- 📁 Exceptions/
|	|   	|--📄 ValidationExceptionCustom.cs
|	|
|       |-- 📁 Features/
|	|   |-- 📁 Orders/
|	|   	|-- 📁 Commands/
|	|  	|   |-- 📁 CancelOrder/
|	|  	|   |	|--📄 CancelOrderCommand.cs
|	|  	|   |   |--📄 CancelOrderHandler.cs
|	|  	|   |   |--📄 CancelOrderValidator.cs
|	|  	|   |
|	|  	|   |-- 📁 CreateOrder/
|	|  	|   |	|--📄 CreateOrderCommand.cs
|	|  	|   |   |--📄 CreateOrderHandler.cs
|	|  	|   |   |--📄 CreateOrderValidator.cs
|	|  	|   |
|	|  	|   |-- 📁 UpdateOrder/
|	|  	|	|--📄 UpdateOrderCommand.cs
|	|  	|       |--📄 UpdateOrderHandler.cs
|	|  	|   |   |--📄 UpdateOrderValidator.cs
|	|  	|
|	|  	|-- 📁 Queries/
|	|  	    |-- 📁 GetAllOrder/
|	|  	    |	|--📄 GetAllOrderHandler.cs
|	|  	    |   |--📄 GetAllOrderQuery.cs
|	|  	    |   |--📄 GetAllOrderResponseDto.cs
|	|  	    |
|	|  	    |-- 📁 GetOrder/
|	|  	    	|--📄 GetOrderHandler.cs
|	|  	        |--📄 GetOrderQuery.cs
|	|  	        |--📄 GetOrderResponseDto.cs
|	|  	   	|--📄 GetOrderValidator.cs
|	|
|       |-- 📄 DependencyInjection.cs
|
|-- 📁 Domain/
|   |-- 🛠️ Domain
|       |-- 📁 Commons/
|	|   |--📄 BaseAuditableEntity.cs
|	|   |--📄 BaseEntity.cs
|	|   |--📄 BaseEvent.cs
|	|
|       |-- 📁 Entities/
|	|   |--📄 Order.cs
|	|
|       |-- 📁 Enums/
|	|   |--📄 OrderSide.cs
|	|   |--📄 OrderType.cs
|	|
|       |-- 📁 Events/
|	    |--📄 OrderCanceledEvent.cs
|	    |--📄 OrderCreatedEvent.cs
|	    |--📄 OrderUpdatedEvent.cs
|
|-- 📁 Infrastructure/
|   |-- 🛠️ Infrastructure
|   |-- 🛠️ Persistence
|       |-- 📁 Configuration/
|	|   |--📄 OrderConfiguration.cs
|	|
|       |-- 📁 Contexts/
|	|   |--📄 ApplicationDbContext.cs
|	|
|       |-- 📁 Interceptors/
|	|   |--📄 AuditableEntitySaveChangesInterceptor.cs
|	|
|       |-- 📁 Migrations/
|	|   |--📄 20250506200037_CreateInitialScheme.cs
|	|   |--📄 20250507164651_AlterOrderScheme.cs
|	|   |--📄 ApplicationDbContextModelSnapshot.cs
|	|
|       |-- 📁 Seeders/
|	|   |--📄 OrderSeeder.cs
|	|
|       |--📄 DependencyInjection.cs
|
|-- 📁 Presentation/
    |-- 🌐 Services.gRPC
	|-- 📁 Commons/
    	|   |-- 📁 Mappings/
	|   |	|--📄 MappingsProfile.cs
	|   |
    	|   |-- 📁 GlobalException/
	|	|--📄 GlobalExceptionHandler.cs
	|
       	|-- 📁 Protos/
    	|   |-- 📄 Order.proto
	|
	|-- 📁 Services/
    	|   |--📄 OrderService.cs
	|
        |--📄 appsettings.json
        |--📄 Program.cs
       	|--📄 DependencyInjection.cs
    
```

![Net-gRPC-Page-2](https://github.com/user-attachments/assets/50b5bd9e-b807-4ff2-a3ea-64a72e4558f3)

## 🎥 Demo in Video

<p align="center">
  <a href="https://www.youtube.com/watch?v=sA3shrkjCDo" target="_blank">
    <img src="https://img.youtube.com/vi/sA3shrkjCDo/0.jpg" alt="Demo Video" width="480"/>
  </a>
</p>


## Projects:

📁 Application:  
### 🛠️ Interfaces  
	Class Library, .NET 8.0  
 
 	🔧 Projects:
	    Domain.csproj

	 📦 Dependencies:
	    Microsoft.EntityFrameworkCore (8.0.15)
     
### 🛠️ UseCases  
	Class Library, .NET 8.0  

 	🔧 Projects:
	    Application.Interfaces.csproj

	 📦 Dependencies:
	    AutoMapper (14.0.0)
	    FluentValidation (12.0.0)
	    FluentValidation.DependencyInjectionExtensions (12.0.0)
	    MediatR (12.5.0)
 
📁 Domain  
### 🛠️ Domain  
	Class Library, .NET 8.0  

📁 Infrastructure  
### 🛠️ Infrastructure  
	Class Library, .NET 8.0  

### 🛠️ Persistence  
	Class Library, .NET 8.0  
 
 	🔧 Projects:
  	    Application.Interfaces.csproj
	    Domain.csproj

	 📦 Dependencies:
	    Microsoft.EntityFrameworkCore (8.0.15)
	    Microsoft.EntityFrameworkCore.Relational (8.0.15)
	    Microsoft.EntityFrameworkCore.SqlServer (8.0.15)

📁 Presentation  
### 🌐 Services.gRPC  
	ASP.NET Core gRPC Service .NET 8.0
 
 	🔧 Projects:
	    Application.UseCases.csproj
	    Persistence.csproj

	 📦 Dependencies:
	    Grpc.AspNetCore (2.71.0)
	    Microsoft.EntityFrameworkCore.Design (8.0.15)
	    Grpc.AspNetCore.Server.Reflection (2.71.0)


**Entity Framework Commands**
```
dotnet tool install --global dotnet-ef
cd D:\...\Sc.Trade\src
dotnet ef migrations add CreateInitialScheme -s Sc.Trade.Services.gRPC -p Sc.Trade.Persistence -o Migrations
dotnet ef database update -s Sc.Trade.Services.gRPC -p Sc.Trade.Persistence
```

**Update Entity**
```
dotnet ef migrations add AlterOrderScheme -s Sc.Trade.Services.gRPC -p Sc.Trade.Persistence -o Migrations
dotnet ef database update -s Sc.Trade.Services.gRPC -p Sc.Trade.Persistence
```

## 🧩 gRPC Services Overview

### 🚀 Service: `OrderService`

**RPC Methods:**

- `CreateOrder (CreateOrderRequest) returns (CreateOrderResponse)`
- `UpdateOrder (UpdateOrderRequest) returns (UpdateOrderResponse)`
- `CancelOrder (CancelOrderRequest) returns (CancelOrderResponse)`
- `GetOrder (GetOrderRequest) returns (GetOrderResponse)`
- `GetAllOrder (GetAllOrderRequest) returns (GetAllOrderResponse)`

### 📝 Example Request (Postman gRPC Tab)

Service URL:
grpc://localhost:5210

**1. GetAllOrder**  
Service: `Order`  
Method: `GetAllOrder`

Request Message:
json
```
{}
```

**2. GetOrder**  
Service: `Order`  
Method: `GetOrder`

Request Message:
json
```
{
    "Id": 5
}
```

**3. CreateOrder**  
Service: `Order`  
Method: `CreateOrder`

Request Message:
json
```
{
    "Id": 5,
    "Symbol": "MSFT",
    "Side": "BUY",
    "TransactTime": {
        "seconds": "1746810670",
        "nanos": 0
    },
    "Quanty": 7,
    "Type": "LIMIT",
    "Price": 777,
    "Currency": "USD",
    "Text": "TS01"
}
```

**4. UpdateOrder**  
Service: `Order`  
Method: `UpdateOrder`

Request Message:
json
```
{
    "Id": 5,
    "Quanty": 8,
    "Type": "LIMIT",
    "Price": 555,
    "Text": "TS01-2" 
}
```

**5. CancelOrder**  
Service: `Order`  
Method: `CancelOrder`

Request Message:
json
```
{
    "Id": 5
}
```
