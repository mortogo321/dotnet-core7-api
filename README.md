# .NET Core 7 Sample Api
The sample api of query city from json file.

## Dockerized
To run MsSQL in docker by following command:
```shell
docker run -it \
-e "ACCEPT_EULA=Y" \
-e "SA_PASSWORD=SA_SUPER_SECURED_PASSWORD" \
-p 1433:1433 \
--name mssql \
-d \
mcr.microsoft.com/mssql/server:2022-latest

```

## Seeder
At first time we initial data by seeder from file: `./Data/Seeder/current.city.list.json` into database name `DemoDb`

## Run
```
dotnet run
```

Open url in browser: http://localhost:5255/api/cities
Swagger: http://localhost:5255/swagger
