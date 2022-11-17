param name string = 'CourtStack-Web'
param location string = 'westus'
param hostingPlanName string = 'CourtStack-WebPlan'
param alwaysOn bool = false
param ftpsState string = 'AllAllowed'
param sku string = 'Free'
param skuCode string = 'F1'
param linuxFxVersion string = 'DOCKER|mcr.microsoft.com/appsvc/staticsite:latest'

@secure()
param dockerRegistryStartupCommand string

resource hostingPlan 'Microsoft.Web/serverfarms@2020-12-01' = {
  name: hostingPlanName
  location: location
  kind: 'linux'
  tags: {
  }
  properties: {
    reserved: true
  }
  sku: {
    tier: sku
    name: skuCode
  }
  dependsOn: []
}

resource name_resource 'Microsoft.Web/sites@2018-11-01' = {
  name: name
  location: location
  tags: {
  }
  properties: {
    siteConfig: {
      appSettings: []
      linuxFxVersion: linuxFxVersion
      appCommandLine: dockerRegistryStartupCommand
      alwaysOn: alwaysOn
      ftpsState: ftpsState
    }
    serverFarmId: hostingPlan.id
    clientAffinityEnabled: false
    httpsOnly: true
  }
}
