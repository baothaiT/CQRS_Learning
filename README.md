# Package

dotnet add package Microsoft.EntityFrameworkCore.Tools
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.Sqlite
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Microsoft.EntityFrameworkCore

dotnet add package Newtonsoft.Json

dotnet add package EPPlus

Install-Package Microsoft.EntityFrameworkCore.SqlServer
Install-Package Microsoft.EntityFrameworkCore.Sqlite
Install-Package Microsoft.EntityFrameworkCore.Tools
Install-Package Microsoft.EntityFrameworkCore

Install-Package MediatR -Version 11.1.0
Install-Package MediatR.Extensions.Microsoft.DependencyInjection -Version 11.1.0
Install-Package MediatR.CommandQuery.EntityFrameworkCore -Version 11.0.750

Install-Package AutoMapper
Install-Package AutoMapper.Extensions.Microsoft.DependencyInjection

## Command EF
Add-Migration InitialCreate
Update-Database

dotnet ef migrations add init
dotnet ef database update 
dotnet tool uninstall

dotnet sln add (ls -r **/*.csproj)

dotnet add reference ./../CQRS.Infrastructure.OKX/CQRS.Infrastructure.OKX.csproj
dotnet add reference ./../CQRS.Domain/CQRS.Domain.csproj

dotnet sln add src/CQRS.Infrastructure.OKX/CQRS.Infrastructure.OKX.csproj

## Architecture
### API
CQRS.API
CQRS.Worker
CQRS.Application
CQRS.Contract
CQRS.Domain
CQRS.Infrastructure
CQRS.Infrastructure.MessageBus
CQRS.Infrastructure.Mongo
CQRS.Persistence

### Worker
MMO.Worker
MMO.Application
MMO.Infrastructure.OKX

# Layer Code

Solution/
├── Solution items/
│   ├── .editorconfig
│   ├── Directory.Build.props
│   ├── README.md
│   └── .gitignore
├── src -->'Source code'/
│   ├── API --> 'Expose apis for application'/
│   │   ├── (ref: Application-Infrastructure--Persistence-Presentation)
│   │   └── Folders/
│   │       ├── Abstractions
│   │       └── DependencyInjection/
│   │           ├── Extensions
│   │           └── Options
│   ├── ==================================================================
│   ├── Application --> 'Handler usercase using mediatR library'/
│   │   ├── (ref: Domain) => User Repository interface at domainlayer
│   │   └── Folders/
│   │       ├── Abstractions
│   │       ├── Behaviors
│   │       ├── DependencyInjection/
│   │       │   ├── Extensions
│   │       │   └── Options
│   │       └── UserCases/
│   │           ├── V1/
│   │           │   ├── Commands/
│   │           │   │   ├── Account
│   │           │   │   ├── Identity
│   │           │   │   ├── Catalog
│   │           │   │   ├── Communication
│   │           │   │   ├── Customer
│   │           │   │   ├── Order
│   │           │   │   ├── Enventory
│   │           │   │   └── ...
│   │           │   └── Queries/
│   │           │       ├── Account
│   │           │       ├── Identity
│   │           │       ├── Catalog
│   │           │       ├── Communication
│   │           │       ├── Customer
│   │           │       ├── Order
│   │           │       ├── Enventory
│   │           │       └── ...
│   │           ├── V2
│   │           └── ...
│   ├── ==================================================================
│   ├── Domain --> 'Store entity and bussiness logic -> Core application'/
│   │   ├── (ref: None)
│   │   └── Folders/
│   │       ├── Abstractions/
│   │       │   ├── IDomainEvent.cs
│   │       │   ├── IMessage.cs
│   │       │   ├── Aggregates/
│   │       │   │   ├── IAggregateRoot : IEntity
│   │       │   │   └── abstract class AggregateRoot<TValidator> : Entity<TValidator>, IAggregateRoot
│   │       │   ├── Entities/
│   │       │   │   ├── IEntity.cs
│   │       │   │   └── abstract class Entity<TValidator> : IEntity
│   │       │   └── Repositories --> Interface
│   │       ├── Aggregates
│   │       ├── Entities/
│   │       │   ├── Profiles
│   │       │   ├── Addresses
│   │       │   ├── CatalogItems
│   │       │   ├── OrderItems
│   │       │   ├── PaymentMethods
│   │       │   ├── CartItems
│   │       │   ├── InventoryItems
│   │       │   └── ...
│   │       ├── Enumerations
│   │       └── ValueObject/
│   │           ├── Product(string Description, string Name, string Brand, string Category, string Unit, string Sku)
│   │           ├── Currency(string IsoCode, string Symbol, int DecimalPlaces, string Name, string Country, string CultureInfo)
│   │           ├── Money(decimal Amount, Currency Currency)
│   │           ├── Email(string Address, string Subject, string Body)
│   │           └── Address(string Street, string City, string State, string ZipCode, string Country, int? Number, string? Complement)
│   ├── ==================================================================
│   ├── Infrastructure --> 'Integration with external likes Job, email, provider token ...'/
│   │   ├── (ref: Application-Persistence)
│   │   └── Folders/
│   │       ├── Abstractions
│   │       ├── Authentication
│   │       ├── BackgroundJobs/
│   │       │   └── ProcessOutboxMessagesJob.cs
│   │       ├── DependencyInjection/
│   │       │   ├── Extensions
│   │       │   └── Options
│   │       └── EmailService
│   ├── ==================================================================
│   ├── Infrastructure.MessageBus --> 'Working with rabbitMQ: Consume Command and Event'/
│   │   ├── (ref: Application)
│   │   └── Folders/
│   │       ├── Abstractions
│   │       ├── Consumers/
│   │       │   ├── Commands
│   │       │   └── Events
│   │       ├── DependencyInjection/
│   │       │   ├── Extensions
│   │       │   └── Options
│   │       ├── PipeFilters
│   │       └── PipeObservers
│   ├── ==================================================================
│   ├── Persistence | Infrastructure.EF --> 'Working with database'/
│   │   ├── (ref: Domain)
│   │   └── Fodlers/
│   │       ├── Configurations
│   │       ├── Constants/
│   │       │   └── TableNames.cs
│   │       ├── Infrastructure/
│   │       │   └── PrivateResolver.cs
│   │       ├── Interceptors/
│   │       │   ├── ConvertDomainEventsToOutboxMessagesInterceptor.cs
│   │       │   └── UpdateAuditableEntitiesInterceptor.cs
│   │       ├── Migrations
│   │       ├── Outbox/
│   │       │   └── OutboxMessage.cs
│   │       ├── Repositories
│   │       ├── ApplicationDbContext.cs
│   │       └── UnitOfWork.cs
│   ├── ==================================================================
│   ├── Infrastructure.Mongo
│   ├── (ref: Domain)
│   ├── Folders/
│   │   ├── Abstractions/
│   │   │   ├── IMongoDbContext.cs
│   │   │   └── MongoDbContext.cs
│   │   ├── DependencyInjection/
│   │   │   ├── Extensions
│   │   │   └── Options
│   │   ├── Idempotence/
│   │   │   └── IdempotentDomainEventHandler.cs
│   │   ├── ProjectionDbContext.cs
│   │   └── ProjectionGateway.cs --> Repository
│   ├── ==================================================================
│   ├── Presentation  --> 'Define api using apicontroller or minimalapi(recommand but will hard maintanin)' /
│   │   ├── (ref: Application-Infrastructure)
│   │   └── Folders/
│   │       ├── Abstractions/
│   │       │   ├── ApiController.cs
│   │       │   └── ApplicationApi.cs
│   │       ├── Controllers/
│   │       │   ├── V1
│   │       │   ├── V2
│   │       │   └── ...
│   │       ├── APIs/
│   │       │   ├── Accounts => Asp.Versioning.Builder =>> HasApiVersion
│   │       │   ├── Catalogs => Asp.Versioning.Builder =>> HasApiVersion
│   │       │   ├── Communications => Asp.Versioning.Builder =>> HasApiVersion
│   │       │   ├── Identities => Asp.Versioning.Builder =>> HasApiVersion
│   │       │   ├── Orders => Asp.Versioning.Builder =>> HasApiVersion
│   │       │   ├── Payments => Asp.Versioning.Builder =>> HasApiVersion
│   │       │   ├── ShoppingCarts => Asp.Versioning.Builder =>> HasApiVersion
│   │       │   └── Warehouses => Asp.Versioning.Builder =>> HasApiVersion
│   │       └── DependencyInjection/
│   │           ├── Extensions
│   │           └── Options
│   ├── ======================
│   └── Contract --> 'Defined common for project'/
│       └── Folders/
│           ├── Abstractions
│           ├── DataTransferObjects
│           ├── Enumerations
│           ├── JsonConverters
│           ├── Shared/
│           │   ├── Result.cs
│           │   └── ResultT.cs
│           └── Services/
│               ├── Account/
│               │   ├── Account.proto
│               │   ├── Command.cs
│               │   ├── DomainEvent.cs
│               │   ├── Projection.cs
│               │   └── Query.cs
│               ├── Catalog
│               ├── Communication
│               ├── Identity
│               ├── Order
│               ├── Payment
│               ├── ShoppingCart
│               └── Warehouse
├── ==================================================================
└── test --> 'Unit test' /
    ├── Architecture.Tests
    ├── API.Tests
    ├── Application.Tests
    ├── Domain.Tests
    ├── Infrastructure.Tests
    ├── Persistance.Tests
    └── Presentation.Tests
