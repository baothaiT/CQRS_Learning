# Stage 1: Build the application
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Copy the solution file
COPY ./src/API/*.sln ./

# Maintain folder structure and copy all projects
COPY ./src/CQRS.API/ ./CQRS.API/
COPY ./src/CQRS.Application/ ./CQRS.Application/
COPY ./src/CQRS.Contract/ ./CQRS.Contract/
COPY ./src/CQRS.Domain/ ./CQRS.Domain/
COPY ./src/CQRS.Infrastructure/ ./CQRS.Infrastructure/
COPY ./src/CQRS.Persistence/ ./CQRS.Persistence/

# Restore dependencies
WORKDIR /app/CQRS.API
RUN dotnet restore

# Build the project
RUN dotnet publish -c Release -o /app/out

# Stage 2: Create a runtime image
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app

# Copy build output from the previous stage
COPY --from=build /app/out .

# Expose port 80
EXPOSE 8080

# Set the entry point
ENTRYPOINT ["dotnet", "CQRS.API.dll"]
