FROM microsoft/aspnetcore-build:2.0 AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/aspnetcore-build:2.0 AS build
WORKDIR /src
COPY ApiServices/ApiServices.csproj ApiServices/
RUN dotnet restore ApiServices/ApiServices.csproj
COPY . .
WORKDIR /src/ApiServices
RUN dotnet build ApiServices.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish ApiServices.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "ApiServices.dll"]
