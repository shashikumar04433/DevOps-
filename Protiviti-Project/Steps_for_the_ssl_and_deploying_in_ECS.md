## Steps_for_the_ssl_and_deploying_in_ECS:

**Step1:**
**Commands to generate the self-signed-certificates**
```
* openssl req -newkey rsa:4096 -x509 -sha256 -days 3650 -nodes -out example.crt -keyout example.key
* openssl pkcs12 -export -out protiviti.pfx -inkey example.key -in example.crt
* openssl req -newkey rsa:4096 \
            -x509 \
            -sha256 \
            -days 3650 \
            -nodes \
            -out example.crt \
            -keyout example.key
 
* openssl pkcs12 -export -out example.pfx -inkey example.key -in example.crt
```
**Step2**
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
**Step3**
**Then run the application with environment variables in docker using below command**
```
docker run -d -p 80:80 -p 443:443 \
  -e ASPNETCORE_URLS="https://+;http://+" \
  -e ASPNETCORE_HTTPS_PORT=443 \
  -e ASPNETCORE_Kestrel__Certificates__Default__Password="protiviti@123" \
  -e ASPNETCORE_Kestrel__Certificates__Default__Path="/https/protiviti.pfx" \
  -e MetadataAddress="https://login.microsoftonline.com/ba04dd9d-19c9-423e-85c1-63bc63f9ff4c/federationmetadata/2007-06/federationmetadata.xml?appid=d58bfe58-9cf7-4e27-84ec-39fd728ab156" \
  -e username="sa" \
  -e password="fcra@123" \
  -e host="13.201.123.96" \
  -e port="" \
  -e bucketname="" \
  -e AWSRegion="ap-south-1" \
  -e dbInstanceIdentifier="RISKDBADCB" \
  -e engine="" \
  -e IsThroughSMTP="N" \
  -e From="" \
  -e SMTPUsername="" \
  -e SMTPPassword="" \
  -e SMTPHost="" \
  -e SMTPPort="587" \
  -e RealmUrl="https://ec2-3-6-40-111.ap-south-1.compute.amazonaws.com/" \
  -e certificatepath="" \
  -e certificatepassword="" \
  -e httpport="" \
  -e httpsport="" \
  -e IsSSOApplicable="Y" \
  -e IsEnvironmentVariableApplicable="Y" \
  abcd
```
**Step4**
**Push the image into ECR with below commands**
```
* aws ecr get-login-password --region ap-south-1 | docker login --username AWS --password-stdin 240887461522.dkr.ecr.ap-south-1.amazonaws.com
```
```
* docker tag abcd:latest 240887461522.dkr.ecr.ap-south-1.amazonaws.com/protiviti-ewra-with-sso:latest
```
```
* docker push 240887461522.dkr.ecr.ap-south-1.amazonaws.com/protiviti-ewra-with-sso:latest
```
**Step5**
**Then Create a task definition in AWS ECS and attach the environment variables with the values**
* Create a cluster and attach that task to it.
