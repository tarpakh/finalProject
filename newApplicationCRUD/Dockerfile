# Use the official ASP.NET Core runtime as a base image
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80

# Use the official .NET SDK as a build image
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copy the project file and restore dependencies
COPY ["newApplicationCRUD/newApplicationCRUD.csproj", "newApplicationCRUD/"]
RUN dotnet restore "newApplicationCRUD/newApplicationCRUD.csproj"

# Copy the entire application and build
COPY . .
WORKDIR "/src/newApplicationCRUD"
RUN dotnet build "newApplicationCRUD.csproj" -c Release -o /app/build

# Publish the app
FROM build AS publish
RUN dotnet publish "newApplicationCRUD.csproj" -c Release -o /app/publish

# Final stage/image
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "newApplicationCRUD.dll"]