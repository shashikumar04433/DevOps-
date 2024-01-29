## Steps_for_the_ssl_and_deploying_in_ECS:

Step1:
**Commands to generate the self-signed-certificates**
```
* openssl req -newkey rsa:4096 -x509 -sha256 -days 3650 -nodes -out protiviti.crt -keyout protiviti.key
* openssl pkcs12 -export -out protiviti.pfx -inkey protiviti.key -in protiviti.crt
```
**Then include in the certificate path in docker example below**
```
FROM mcr.microsoft.com/dotnet/aspnet:6.0-alpine AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

RUN apk apk update && apk upgrade && \
    apk add --no-cache openssl \
    tzdata \
    icu-libs>=67 \
    krb5-libs>=1.18 \
    libgcc>=10.3 \
    libintl>=0.21 \
    libssl1.1>=1.1.1 \
    libstdc++>=10.3 \
    zlib>=1.2.11

ENV TZ=Asia/Calcutta
ENV ASPNETCORE_ENVIRONMENT=testing
ENV DOTNET_RUNNING_IN_CONTAINER=true
ENV DOTNET_SYSTEM_GLOBALIZATION_INVARIANT=false

FROM mcr.microsoft.com/dotnet/sdk:6.0-alpine AS build
WORKDIR /src
COPY ["FCRA.Web/FCRA.Web.csproj", "FCRA.Web/"]
COPY ["FCRA.Common/FCRA.Common.csproj", "FCRA.Common/"]
COPY ["FCRA.Repository/FCRA.Repository.csproj", "FCRA.Repository/"]
COPY ["FCRA.Models/FCRA.Models.csproj", "FCRA.Models/"]
COPY ["FCRA.ViewModels/FCRA.ViewModels.csproj", "FCRA.ViewModels/"]
RUN dotnet restore "FCRA.Web/FCRA.Web.csproj"
COPY . .
WORKDIR "/src/FCRA.Web"
RUN dotnet build "FCRA.Web.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "FCRA.Web.csproj" -c Release -o /app/publish /p:UseAppHost=false
//ARG CERT_PASSWORD
//RUN dotnet dev-certs https -ep /app/ewraprotiviti.pfx -p ewraprotiviti@123

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
//RUN mkdir -p /https
//COPY ewraprotiviti.pfx /app
COPY ewraprotiviti.pfx /https
ENTRYPOINT ["dotnet", "FCRA.Web.dll"]
```
```
* docker build -t <nameof_dockerfile> .
```
```
* docker build -t abcd .
```




