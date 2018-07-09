FROM microsoft/aspnetcore-build:2.0 AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/aspnetcore-build:2.0 AS build
WORKDIR /src
COPY Ex_Ad_18_1_DockerServices/Ex_Ad_18_1_DockerServices.csproj Ex_Ad_18_1_DockerServices/
RUN dotnet restore Ex_Ad_18_1_DockerServices/Ex_Ad_18_1_DockerServices.csproj
COPY . .
WORKDIR /src/Ex_Ad_18_1_DockerServices
RUN dotnet build Ex_Ad_18_1_DockerServices.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish Ex_Ad_18_1_DockerServices.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Ex_Ad_18_1_DockerServices.dll"]
