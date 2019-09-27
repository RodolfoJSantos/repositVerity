FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["CSF.Api.Campanha.BlackList/CSF.Api.Campanha.BlackList.csproj", "CSF.Api.Campanha.BlackList/"]
RUN dotnet restore "CSF.Api.Campanha.BlackList/CSF.Api.Campanha.BlackList.csproj"
COPY . .
WORKDIR "/src/CSF.Api.Campanha.BlackList"
RUN dotnet build "CSF.Api.Campanha.BlackList.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "CSF.Api.Campanha.BlackList.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "CSF.Api.Campanha.BlackList.dll"]