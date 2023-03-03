
# Delete all the artifacts to ensure no caching
rm scripts/app.zip
rm -R bin/Debug
#rm -R bin/Release

#build the API
dotnet publish #if you just want debug
#dotnet publish --configuration release #for release

cd bin/Debug/net7.0/publish/
zip -r app.zip . -q

mv app.zip ../../../../scripts/
cd ../../../../

az webapp deployment source config-zip --resource-group vue-starter --name vue-starter-7349 --src scripts/app.zip
open https://vue-starter-7349.azurewebsites.net/

echo "Site's been pushed, watching logs..."
az webapp log tail -n vue-starter-7349 -g vue-starter