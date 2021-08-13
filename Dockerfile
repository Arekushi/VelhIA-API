#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app

ENV ASPNETCORE_URLS="http://*:5000"
ENV ASPNETCORE_ENVIRONMENT="Development"

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["VelhIA-API.API/VelhIA-API.API.csproj", "VelhIA-API.API/"]
COPY ["VelhIA-API.Domain/VelhIA-API.Domain.csproj", "VelhIA-API.Domain/"]
COPY ["VelhIA-API.Application/VelhIA-API.Application.csproj", "VelhIA-API.Application/"]
COPY ["VelhIA-API.Data/VelhIA-API.Data.csproj", "VelhIA-API.Data/"]
COPY ["VelhIA-API.IoC/VelhIA-API.IoC.csproj", "VelhIA-API.IoC/"]
COPY ["VelhIA-API.Repositories/VelhIA-API.Repositories.csproj", "VelhIA-API.Repositories/"]
COPY ["VelhIA-API.Services/VelhIA-API.Services.csproj", "VelhIA-API.Services/"]
RUN dotnet restore "VelhIA-API.API/VelhIA-API.API.csproj"
COPY . .
WORKDIR "/src"
RUN dotnet build "VelhIA-API.API/VelhIA-API.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "VelhIA-API.API/VelhIA-API.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .

#RUN useradd -m defaultUser
#USER defaultUser

EXPOSE 5000

#CMD ASPNETCORE_URLS="http://*:$PORT" dotnet VelhIA-API.API.dll
ENTRYPOINT ["dotnet", "VelhIA-API.API.dll", "--server.urls", "http://*:5000"]