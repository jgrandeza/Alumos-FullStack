#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Backend/Domain/Escuela/jeancarlos.grandezaguilar.alumnos.services/jeancarlos.grandezaguilar.alumnos.services.csproj", "Backend/Domain/Escuela/jeancarlos.grandezaguilar.alumnos.services/"]
RUN dotnet restore "Backend/Domain/Escuela/jeancarlos.grandezaguilar.alumnos.services/jeancarlos.grandezaguilar.alumnos.services.csproj"
COPY . .
WORKDIR "/src/Backend/Domain/Escuela/jeancarlos.grandezaguilar.alumnos.services"
RUN dotnet build "jeancarlos.grandezaguilar.alumnos.services.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "jeancarlos.grandezaguilar.alumnos.services.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "jeancarlos.grandezaguilar.alumnos.services.dll"]
