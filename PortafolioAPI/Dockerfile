#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["PortafolioAPI/API.Portafolio.csproj", "PortafolioAPI/"]
COPY ["Org.Sdt.Users/Org.Sdt.Users.csproj", "Org.Sdt.Users/"]
COPY ["org.sdt.architecture.core/Org.Sdt.Architecture.Core.csproj", "org.sdt.architecture.core/"]
COPY ["org.sdt.model.projects/Org.Sdt.Projects.csproj", "org.sdt.model.projects/"]
RUN dotnet restore "PortafolioAPI/API.Portafolio.csproj"
COPY . .
WORKDIR "/src/PortafolioAPI"
RUN dotnet build "API.Portafolio.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "API.Portafolio.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "API.Portafolio.dll"]