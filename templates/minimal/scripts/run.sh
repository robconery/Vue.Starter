cd ./client
echo "Building Vue application"
npm run build

echo "Done! Vue app is now built and located in /server/wwwroot"
echo "Starting up server..."

cd ../
dotnet watch --project ./server