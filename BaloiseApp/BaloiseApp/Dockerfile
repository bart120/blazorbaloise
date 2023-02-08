FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR src/
COPY BaloiseApp.sln .
COPY CarsLibrary CarsLibrary 
COPY LazyLibrary LazyLibrary
COPY MyComponentsLibrary MyComponentsLibrary
COPY ServicesLibrary ServicesLibrary
COPY BaloiseApp BaloiseApp
RUN dotnet restore BaloiseApp/BaloiseApp.csproj
COPY . .
RUN dotnet build  BaloiseApp/BaloiseApp.csproj -c Release -o /app/build

FROM build AS publish
RUN dotnet publish  BaloiseApp/BaloiseApp.csproj -c Release -o /app/publish

FROM nginx:alpine AS final
WORKDIR /usr/share/nginx/html
COPY --from=publish /app/publish/wwwroot .
COPY BaloiseApp/nginx.conf /etc/nginx/conf.d/default.conf
