#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Blazor3D.Web.MVC/Blazor3D.Web.MVC.csproj", "Blazor3D.Web.MVC/"]
RUN dotnet restore "Blazor3D.Web.MVC/Blazor3D.Web.MVC.csproj"
COPY . .
WORKDIR "/src/Blazor3D.Web.MVC"
RUN dotnet build "Blazor3D.Web.MVC.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Blazor3D.Web.MVC.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Blazor3D.Web.MVC.dll"]