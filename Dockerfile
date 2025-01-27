# Use uma imagem do .NET SDK mais recente, que é compatível com o Vercel
FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS base
WORKDIR /app
EXPOSE 80

# Use a imagem do SDK do .NET para compilar
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src
COPY ["RandomQuotesAPI/RandomQuotesAPI.csproj", "RandomQuotesAPI/"]
RUN dotnet restore "RandomQuotesAPI/RandomQuotesAPI.csproj"
COPY . .
WORKDIR "/src/RandomQuotesAPI"
RUN dotnet build "RandomQuotesAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "RandomQuotesAPI.csproj" -c Release -o /app/publish

# Defina a imagem final para a execução
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "RandomQuotesAPI.dll"]
