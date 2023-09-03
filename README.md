# vgt-2-api

# Run docker compose to start mysql and PhpMyAdmin
```
docker-compose -f /workspaces/vgt-2-api/VgtInfra/docker-compose-mysql.yml up --detach
```

# Shut down the mysql and phyMyAdmin
```
docker-compose -f /workspaces/vgt-2-api/VgtInfra/docker-compose-mysql.yml down 
```

# Create EF Migration
Execute the following command in VgtApi folder
```
dotnet dotnet-ef migrations add InitCreate
```

# Update the database
Execute the following command in VgtApi folder
```
dotnet dotnet-ef database update
```

# Remove EF Migration
Execute the following command in VgtApi folder
```
dotnet dotnet-ef migrations remove
```