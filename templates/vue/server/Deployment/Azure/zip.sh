rm ./Deployment/Azure/deploy.zip
rm -R bin/Release
dotnet publish --configuration Release
cd bin/Release/net7.0/publish/
zip -r ../../../../Deployment/Azure/deploy.zip . -q
cd -
az webapp deployment source config-zip --resource-group vue-starter --name vue-starter-11023 --src ./Deployment/Azure/deploy.zip
open https://vue-starter-11023.azurewebsites.net
echo 'Site's been pushed, watching logs...'
az webapp log tail -n vue-starter-11023 -g vue-starter
