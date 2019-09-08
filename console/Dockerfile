FROM microsoft/dotnet:sdk AS build-env
WORKDIR /code

COPY *.csproj /code
RUN dotnet restore 

COPY . /code
RUN dotnet publish -c Release -o out

FROM microsoft/dotnet:2.2-aspnetcore-runtime 
WORKDIR /app

COPY --from=build-env /code/out ./
ENTRYPOINT [ "dotnet","console.dll"]
