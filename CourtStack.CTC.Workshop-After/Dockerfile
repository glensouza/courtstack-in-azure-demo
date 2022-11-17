# Runtime image
FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

# SDK image
FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
# Copy csproj and restore
COPY ["CourtStack.CTC.Workshop.csproj", "CourtStack.CTC.Workshop/"]
WORKDIR "/src/CourtStack.CTC.Workshop"
RUN dotnet restore "CourtStack.CTC.Workshop.csproj"
# Copy everything else and build
COPY . .
RUN dotnet build "CourtStack.CTC.Workshop.csproj" -c Release -o /app/build

# Publish build
FROM build AS publish
RUN dotnet publish "CourtStack.CTC.Workshop.csproj" -c Release -o /app/publish /p:UseAppHost=false

# Build runtime image
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CourtStack.CTC.Workshop.dll"]
