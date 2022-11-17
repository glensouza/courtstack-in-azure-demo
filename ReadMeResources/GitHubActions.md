[![Deploy a App Docker image](https://github.com/glensouza/courtstack-in-azure-demo/actions/workflows/deploy-app.yml/badge.svg)](https://github.com/glensouza/courtstack-in-azure-demo/actions/workflows/deploy-app.yml)

# GitHub Actions

Bicep [app-bicep.yml](../.github/workflows/app-bicep.yml)

App Docker Image [app-docker-image.yml](../.github/workflows/app-docker-image.yml)

SDK Docker Image [sdk-docker-image.yml](../.github/workflows/sdk-docker-image.yml) (NOT WORKING)

Deploy App to Azure [deploy-app.yml](../.github/workflows/deploy-app.yml)

## GitHub Actions Secrets

| Name | Description |
| --- | --- |
| AZURE_CREDENTIALS | Azure Service Principal |
| AZURE_SUBSCRIPTION | Azure Subscription ID |
| AZURE_RG | Azure Resource Group |

| [<== Previous Section: Deploy Infrastructure with Bicep](DeployBicep.md) | [Back to Main](../README.md) |
|--|--|
