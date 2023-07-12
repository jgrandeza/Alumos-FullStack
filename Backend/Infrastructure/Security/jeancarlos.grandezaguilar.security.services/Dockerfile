#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Backend/Infrastructure/Security/jeancarlos.grandezaguilar.security.services/jeancarlos.grandezaguilar.security.services.csproj", "Backend/Infrastructure/Security/jeancarlos.grandezaguilar.security.services/"]
RUN dotnet restore "Backend/Infrastructure/Security/jeancarlos.grandezaguilar.security.services/jeancarlos.grandezaguilar.security.services.csproj"
COPY . .
WORKDIR "/src/Backend/Infrastructure/Security/jeancarlos.grandezaguilar.security.services"
RUN dotnet build "jeancarlos.grandezaguilar.security.services.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "jeancarlos.grandezaguilar.security.services.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "jeancarlos.grandezaguilar.security.services.dll"]
