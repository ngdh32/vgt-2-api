# Set up environment variable
# export MYSQLPassword=""
# export MySQLConnectionString=""

docker-compose -f /workspaces/vgt-2-api/VgtInfra/docker-compose-mysql.yml down
docker-compose -f /workspaces/vgt-2-api/VgtInfra/docker-compose-mysql.yml up 

cd /workspaces/vgt-2-api/VgtApi/
dotnet new tool-manifest --force
dotnet tool install dotnet-ef

dotnet dotnet-ef migrations add InitCreate
dotnet dotnet-ef database update