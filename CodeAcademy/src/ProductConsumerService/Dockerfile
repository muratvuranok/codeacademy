#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["src/ProductConsumerService/ProductConsumerService.csproj", "src/ProductConsumerService/"]
COPY ["src/Models/Models.csproj", "src/Models/"]
RUN dotnet restore "src/ProductConsumerService/ProductConsumerService.csproj"
COPY . .
WORKDIR "/src/src/ProductConsumerService"
RUN dotnet build "ProductConsumerService.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ProductConsumerService.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CodeAcademy.ProductConsumerService.dll"]