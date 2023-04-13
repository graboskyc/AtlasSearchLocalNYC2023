FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build-env
WORKDIR /App
ENV TZ="America/New_York"
EXPOSE 80
EXPOSE 443

# Copy everything
COPY ./ ./
# Restore as distinct layers
RUN dotnet restore
# Build and publish a release
RUN dotnet publish -c Release -o out

# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /App
COPY --from=build-env /App/out .
ENTRYPOINT ["dotnet", "AtlasSearchNYC.dll"]
