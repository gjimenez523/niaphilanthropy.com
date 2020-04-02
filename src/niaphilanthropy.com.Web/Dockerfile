#FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
#WORKDIR /app
#EXPOSE 80

#FROM microsoft/dotnet:2.1-sdk AS build
#WORKDIR /src
#COPY src/niaphilanthropy.com.Web/niaphilanthropy.com.Web.csproj src/niaphilanthropy.com.Web/
#COPY src/niaphilanthropy.com.Application/niaphilanthropy.com.Application.csproj src/niaphilanthropy.com.Application/
#COPY src/niaphilanthropy.com.Core/niaphilanthropy.com.Core.csproj src/niaphilanthropy.com.Core/
#COPY src/niaphilanthropy.com.EntityFrameworkCore/niaphilanthropy.com.EntityFrameworkCore.csproj src/niaphilanthropy.com.EntityFrameworkCore/
#RUN dotnet restore src/niaphilanthropy.com.Web/niaphilanthropy.com.Web.csproj
##COPY . .
#WORKDIR /src/src/niaphilanthropy.com.Web
#RUN dotnet build niaphilanthropy.com.Web.csproj -c Release -o /app

#FROM build AS publish
FROM microsoft/dotnet:2.1-sdk
#RUN dotnet publish niaphilanthropy.com.Web.csproj -c Release -o /app

#FROM base AS final
WORKDIR /app
#COPY --from=publish /app .
COPY ./ /app/

ENTRYPOINT ["dotnet", "niaphilanthropy.com.Web.dll"]