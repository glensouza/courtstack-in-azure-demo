# Demo for CourtStack Hosted in Azure
# 1 - Requirements to start:
* **System Requirements**
  * **Operating System**: Windows 10
  * **Browser**:
    * [Chrome](https://www.google.com/chrome/)
    * [Edge](https://www.microsoft.com/en-us/windows/microsoft-edge)
* Sign up for a free [GitHub](https://github.com/signup) Account
* Sign up for an [Azure](https://azure.microsoft.com/en-us/free) account with $200 free credit
* Install [Azure CLI](https://learn.microsoft.com/en-us/cli/azure)
* Install [Visual Studio Code](https://code.visualstudio.com)
* Install VS Code [Bicep Extension](https://marketplace.visualstudio.com/items?*temName=ms-azuretools.vscode-bicep)
* Install [Bicep CLI](https://learn.microsoft.com/en-us/azure/*zure-resource-manager/bicep/install)
* Install [Docker Desktop](https://www.docker.com/products/docker-desktop)
* Install [.NET 5 SDK or Runtime](https://dotnet.microsoft.com/en-us/download/dotnet/5.0)
* Download the [CourtStack.SDK.zip](https://github.com/CourtStack/CTC-Workshop-2021/releases/download/2021.09.11/CourtStack.SDK.zip) file
* A little knowledge about [Bicep](bicep.md)
  * Bicep is a domain-specific language (DSL) that uses declarative syntax to deploy Azure resources. It provides concise syntax, reliable type safety, and support for code reuse. I believe Bicep offers the best authoring experience for your infrastructure-as-code solutions in Azure.

* A little knowledge about [GitHub Actions](https://docs.github.com/en/actions)
  * GitHub Actions helps you automate your software development workflows from within GitHub. You can deploy workflows in the same place where you store code.
* **Optional Tools**:
  * Development IDE:
    * [Visual Studio (Community Edition)](https://visualstudio.microsoft.com/downloads/)
    * [Visual Studio Code](https://code.visualstudio.com/)
    * [Rider](https://jetbrains.com/rider/)
  * [Node.js](https://nodejs.org) to get access to npm.
  * If you want to see the raw JSON response from a CourtStack API request on the Chrome browser, you will need something like the **[ModHeader](https://chrome.google.com/webstore/detail/modheader/idgpnmonknjnojddfkpgkljpfnnfcklj/related?hl=en)** extension.
  * If you want to see the JSON response formatted in a more human readable format on the Chrome browser, you will need something like the **[JSON Formatter](https://chrome.google.com/webstore/detail/json-formatter/bcjindcccaagfpapjjmafapmmgkkhgoa/related)** extension.

---
# 2 - Set Up Azure Environment
Follow [this guide](SetUpAzure.md) to set up your Azure environment.

---
# 4 - Containerize the CourtStack SDK
Follow [this guide](ContainerizeSDK.md) to containerize the CourtStack SDK.

---
# 5 - Containerize the App that Consumes the CourtStack Data
Follow [this guide](ContainerizeApp.md) to containerize the App that Consumes the CourtStack Data.

---
# 6 - Deploy Infrastructure with Bicep
Follow [this guide](DeployBicep.md) to deploy the infrastructure with Bicep.

---
# 7 - GitHub Actions
Follow [this guide](GitHubActions.md) to set up GitHub Actions.

---
# 8 - More Things That Can Be Done
- Store secrets in [Azure Key Vault](https://learn.microsoft.com/en-us/azure/key-vault/general/basic-concepts)
