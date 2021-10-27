#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Northwind.API/Northwind.API.csproj", "Northwind.API/"]
COPY ["Northwind.Common/Northwind.Common.csproj", "Northwind.Common/"]
COPY ["Northwind.BusinessLogic/Northwind.BusinessLogic.csproj", "Northwind.BusinessLogic/"]
COPY ["Northwind.DataAccess/Northwind.DataAccess.csproj", "Northwind.DataAccess/"]
COPY ["Northwind.Domain/Northwind.Domain.csproj", "Northwind.Domain/"]
RUN dotnet restore "Northwind.API/Northwind.API.csproj"
COPY . .
WORKDIR "/src/Northwind.API"
RUN dotnet build "Northwind.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Northwind.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Northwind.API.dll"]
