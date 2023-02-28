
rm scripts/app.zip
dotnet publish


cd bin/Debug/net7.0/publish/
zip -r app.zip . -q

mv app.zip ../../../../scripts/
cd ../../../../

az webapp deployment source config-zip --resource-group vue-starter --name vue-starter-7349 --src scripts/app.zip
open https://vue-starter-7349.azurewebsites.net/

echo "Site's been pushed, watching logs..."
az webapp log tail -n vue-starter-7349 -g vue-starter