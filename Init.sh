# Set up environment variable
# export MYSQLPassword=""
# export MySQLConnectionString=""

docker-compose -f /workspaces/vgt-2-api/VgtInfra/docker-compose-mysql.yml down
docker-compose -f /workspaces/vgt-2-api/VgtInfra/docker-compose-mysql.yml up --detach

cd /workspaces/vgt-2-api/VgtApi/
dotnet new tool-manifest --force
dotnet tool install dotnet-ef --version 7.0.15

dotnet dotnet-ef migrations add InitCreate
dotnet dotnet-ef database update