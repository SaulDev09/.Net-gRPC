## 👨‍💻 Structure: Version 3 - feature/03-Persistence-DB

```
Solution
|
|-- Application/
|   |-- Interfaces
|   |-- UseCases
|
|-- Domain/
|   |-- Domain
|       |-- Commons/
|	|   |-- BaseAuditableEntity.cs
|	|   |-- BaseEntity.cs
|	|   |-- BaseEvent.cs
|	|
|       |-- Entities/
|	|   |-- Order.cs 📝
|	|
|       |-- Enums/
|	|   |-- OrderSide.cs
|	|   |-- OrderType.cs
|	|
|       |-- Events/
|	    |-- OrderCanceledEvent.cs
|	    |-- OrderCreatedEvent.cs
|	    |-- OrderUpdatedEvent.cs 📝
|
|-- Infrastructure/
|   |-- Infrastructure
|   |-- Persistence
|       |-- Configuration/ ✅
|	|   |-- OrderConfiguration.cs ✅
|	|
|       |-- Contexts/ ✅
|	|   |-- ApplicationDbContext.cs ✅
|	|
|       |-- Interceptors/ ✅
|	|   |-- AuditableEntitySaveChangesInterceptor.cs ✅
|	|
|       |-- Migrations/ ✅
|	|   |-- 20250506200037_CreateInitialScheme.cs ✅
|	|   |-- 20250507164651_AlterOrderScheme.cs ✅
|	|   |-- ApplicationDbContextModelSnapshot.cs ✅
|	|
|       |-- Seeders/ ✅
|	|   |-- OrderSeeder.cs ✅
|	|
|       |-- DependencyInjection.cs ✅
|
|-- Presentation/
    |-- Services.gRPC
        |-- appsettings.json 📝
        |-- Program.cs 📝

    
```

## Projects:

📁 Application:  
### 🧩 Interfaces  
	Class Library, .NET 8.0  

### 🧩 UseCases  
	Class Library, .NET 8.0  

📁 Domain  
### 🧩 Domain  
	Class Library, .NET 8.0  

📁 Infrastructure  
### 🧩 Infrastructure  
	Class Library, .NET 8.0  

### 🧩 Persistence  
	Class Library, .NET 8.0  
 
 	🔧 Projects:
	    Domain.csproj ✅

	 📦 Dependencies:
	    Microsoft.EntityFrameworkCore (8.0.15) ✅
	    Microsoft.EntityFrameworkCore.Relational (8.0.15) ✅
	    Microsoft.EntityFrameworkCore.SqlServer (8.0.15) ✅

📁 Presentation  
### 🌐 Services.gRPC  
	ASP.NET Core gRPC Service .NET 8.0
 
 	🔧 Projects:
	    Persistence.csproj ✅

	 📦 Dependencies:
	    Microsoft.EntityFrameworkCore.Design (8.0.15) ✅


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

