#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["src/CategoryApi/CategoryApi.csproj", "src/CategoryApi/"]
RUN dotnet restore "src/CategoryApi/CategoryApi.csproj"
COPY . .
WORKDIR "/src/src/CategoryApi"
RUN dotnet build "CategoryApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CategoryApi.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CodeAcademy.CategoryApi.dll"]