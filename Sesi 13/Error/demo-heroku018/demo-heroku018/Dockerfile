#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["demo-heroku018/demo-heroku018.csproj", "demo-heroku018/"]
RUN dotnet restore "demo-heroku018/demo-heroku018.csproj"
COPY . .
WORKDIR "/src/demo-heroku018"
RUN dotnet build "demo-heroku018.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "demo-heroku018.csproj" -c Release -o /app/publish
 
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "demo-heroku018.dll"]