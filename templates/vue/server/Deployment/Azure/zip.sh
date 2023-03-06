
# Delete all the artifacts to ensure no caching
rm -R bin/Debug
rm -R bin/Release 
rm ./Deployment/Azure/deploy.zip

#build the API
dotnet publish #if you just want debug
#dotnet publish --configuration release #for release

# navigating to directory to preserve file structure
# without recreating it entirely
cd bin/Debug/net7.0/publish/
zip -r ../../../../Deployment/Azure/deploy.zip . -q

cd -

az webapp deployment source config-zip \
    --resource-group vue-starter \
    --name vue-starter-7349 \
    --src ./Deployment/Azure/deploy.zip

open https://vue-starter-7349.azurewebsites.net/

echo "Site's been pushed, watching logs..."
az webapp log tail -n vue-starter-7349 -g vue-starter