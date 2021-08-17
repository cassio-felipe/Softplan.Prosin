FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["JurosAPI/JurosAPI.csproj", "JurosAPI/"]
RUN dotnet restore "JurosAPI/JurosAPI.csproj"
COPY . .
WORKDIR "/src/JurosAPI"
RUN dotnet build "JurosAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "JurosAPI.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "JurosAPI.dll"]
