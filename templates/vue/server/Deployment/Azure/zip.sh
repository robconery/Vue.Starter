
# Delete all the artifacts to ensure no caching
rm -R bin/Release 
rm ./Deployment/Azure/deploy.zip

#build the API
dotnet publish --configuration Release #for release

# navigating to directory to preserve file structure
# without recreating it entirely
cd bin/Release/net7.0/publish/
zip -r ../../../../Deployment/Azure/deploy.zip . -q

cd -

az webapp deployment source config-zip \
    --resource-group vue-starter \
    --name vue-starter-7349 \
    --src ./Deployment/Azure/deploy.zip

open https://vue-starter-7349.azurewebsites.net/

echo "Site's been pushed, watching logs..."
az webapp log tail -n vue-starter-7349 -g vue-starter