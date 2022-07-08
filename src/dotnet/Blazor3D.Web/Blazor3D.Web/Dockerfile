#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Blazor3D.Web/Blazor3D.Web.csproj", "Blazor3D.Web/"]
RUN dotnet restore "Blazor3D.Web/Blazor3D.Web.csproj"
COPY . .
WORKDIR "/src/Blazor3D.Web"
RUN dotnet build "Blazor3D.Web.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Blazor3D.Web.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Blazor3D.Web.dll"]