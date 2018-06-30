FROM microsoft/aspnetcore:2.0 AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/aspnetcore-build:2.0 AS build
WORKDIR /src
COPY Ex_18_DockerApp/Ex_18_DockerApp.csproj Ex_18_DockerApp/
RUN dotnet restore Ex_18_DockerApp/Ex_18_DockerApp.csproj
COPY . .
WORKDIR /src/Ex_18_DockerApp
RUN dotnet build Ex_18_DockerApp.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish Ex_18_DockerApp.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Ex_18_DockerApp.dll"]
RUN Update-database
