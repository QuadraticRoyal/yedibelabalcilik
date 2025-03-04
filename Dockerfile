# .NET 9 SDK içeren temel imajı kullan
FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS base
WORKDIR /app
EXPOSE 5055

# SDK içeren imajı kullan (build işlemi için)
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src

# Proje dosyalarını kopyala ve build et
COPY . .  
RUN dotnet restore "./BalKasar.csproj"
RUN dotnet build "./BalKasar.csproj" -c Release -o /app/build

# Yayın (publish) aşaması
FROM build AS publish
RUN dotnet publish "./BalKasar.csproj" -c Release -o /app/publish

# Çalıştırma aşaması
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "BalKasar.dll"]
