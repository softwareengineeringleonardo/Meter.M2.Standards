FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["Meter.M2.Api/Meter.M2.Api.csproj","Meter.M2.Api/"]
COPY ["Meter.M2.Application/Meter.M2.Application.csproj","Meter.M2.Application/"]
COPY ["Meter.M2.Domain/Meter.M2.Domain.csproj","Meter.M2.Domain/"]
COPY ["Meter.M2.Infrastructure/Meter.M2.Infrastructure.csproj","Meter.M2.Infrastructure/"]
COPY ["Meter.M2.Infrastructure.IoC/Meter.M2.Infrastructure.IoC.csproj","Meter.M2.Infrastructure.IoC/"]
RUN dotnet restore "Meter.M2.Api/Meter.M2.Api.csproj"
COPY . .
WORKDIR "/src/Meter.M2.Api"
RUN dotnet publish -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet","Meter.M2.Api.dll"]
