#!/bin/bash

###### CHANGE THESE AS NEEDED #######
RG="vue-starter"
APPNAME="$RG-$RANDOM"
#You can get a list of locations by running 
#az account list-locations --query [].name
LOCATION="westus"
RUNTIME="DOTNETCORE:7.0"
ZIPSCRIPT="./Deployment/Azure/zip.sh"
ENVFILE="./Deployment/.env"
LOGSCRIPT="./Deployment/Azure/logs.sh"

#Pricing for Linux Service Plans changes from time to time given the location you choose
#and parameters of your subscription. You can review the pricing for Linux Service Plans here:
#https://azure.microsoft.com/en-us/pricing/details/app-service/linux/

#The sku should be one of:
#F1(Free), D1(Shared), B1(Basic Small), B2(Basic Medium), B3(Basic Large), 
#S1(Standard Small), P1(Premium Small), P1V2(Premium V2 Small), 
#PC2 (Premium Container Small), PC3 (Premium Container Medium), 
#PC4 (Premium Container Large).

#accepted values: B1, B2, B3, D1, F1, FREE, P1, P1V2, P2, P2V2, P3, P3V2, PC2, PC3, PC4, S1, S2, S3, SHARED
SKU=B1

rm $ENVFILE
rm $ZIPSCRIPT

echo "Creating .env"

# Adding these to the .env file for convenience
echo "RG=$RG" > $ENVFILE
echo "APPNAME=$APPNAME" >> $ENVFILE
echo "LOCATION=$LOCATION" >> $ENVFILE

echo "Creating a resource group"

#this can be run safely even if the group exists
az group create -n $RG -l $LOCATION

echo "Creating AppService Plan"
az appservice plan create --name $APPNAME \
                          --resource-group $RG \
                          --sku $SKU \
                          --is-linux


echo "Creating Web app"
az webapp create --resource-group $RG \
                  --plan $APPNAME \
                  --name $APPNAME \
                  --runtime $RUNTIME

az webapp config appsettings set --resource-group $RG --name $APPNAME --settings WEBSITE_RUN_FROM_PACKAGE="1"

echo "Setting up logging"
#setup logging and monitoring
az webapp log config --application-logging filesystem \
                    --detailed-error-messages true \
                    --web-server-logging filesystem \
                    --level information \
                    --name $APPNAME \
                    --resource-group $RG

echo "Adding logs alias to .env. Invoking this will allow you to see the application logs realtime-ish."
#set an alias for convenience - add to .env
echo "alias logs='az webapp log tail -n $APPNAME -g $RG'" >> $ENVFILE

echo "az webapp log tail -n $APPNAME -g $RG" > $LOGSCRIPT


echo "rm ./Deployment/Azure/deploy.zip" >> $ZIPSCRIPT
echo "rm -R bin/Release" >> $ZIPSCRIPT
echo "dotnet publish --configuration Release" >> $ZIPSCRIPT


echo "cd bin/Release/net7.0/publish/" >>$ZIPSCRIPT
echo "zip -r ../../../../Deployment/Azure/deploy.zip . -q"  >> $ZIPSCRIPT
echo "cd -" >> $ZIPSCRIPT


echo "az webapp deployment source config-zip --resource-group vue-starter --name $APPNAME --src ./Deployment/Azure/deploy.zip" >> $ZIPSCRIPT

echo "open https://$APPNAME.azurewebsites.net" >> $ZIPSCRIPT

echo "echo 'Site is published 🎉 watching logs. It takes 60 seconds or so to refresh...'" >> $ZIPSCRIPT
echo "az webapp log tail -n $APPNAME -g $RG" >> $ZIPSCRIPT

source $ZIPSCRIPT

echo "If there were no errors you should be able to view your site at https://$APPNAME.azurewebsites.net"