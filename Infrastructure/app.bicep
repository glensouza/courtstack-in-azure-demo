// mandatory params
@description('The unique name for the App web app, such as CourtStack.Web.')
param appservicename string = '${resourceGroup().name}-Web'
param location string = resourceGroup().location

resource appServicePlan 'Microsoft.Web/serverfarms@2018-11-01' = {
  name: appservicename
  location: location
  sku: {
    name: 'F1'
    capacity: 1
    tier: 'Free'
  }
  kind: 'linux'
}

resource webApp 'Microsoft.Web/sites@2018-11-01' = {
  name: appservicename
  location: location
  tags: {}
  properties: {
    siteConfig: {
      appSettings: []
      linuxFxVersion: 'DOCKER|mcr.microsoft.com/appsvc/staticsite:latest'
    }
    serverFarmId: appServicePlan.id
  }
}

output webAppUrl string = webApp.properties.defaultHostName
