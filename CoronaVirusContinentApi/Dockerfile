FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["CoronaVirusContinentApi/CoronaVirusContinentApi.csproj", "CoronaVirusContinentApi/"]
RUN dotnet restore "CoronaVirusContinentApi/CoronaVirusContinentApi.csproj"
COPY . .
WORKDIR "/src/CoronaVirusContinentApi"
RUN dotnet build "CoronaVirusContinentApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CoronaVirusContinentApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CoronaVirusContinentApi.dll"]