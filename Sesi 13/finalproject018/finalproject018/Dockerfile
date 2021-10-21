#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["finalproject018/finalproject018.csproj", "finalproject018/"]
RUN dotnet restore "finalproject018/finalproject018.csproj"
COPY . .
WORKDIR "/src/finalproject018"
RUN dotnet build "finalproject018.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "finalproject018.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "finalproject018.dll"]