# Set Up Azure Environment
### Get your Subscription Id, set it as a variable
Using Powershell, execute the following commands:

```powershell
az login
```

This will open a brownser session and get you to log in with the credentials to your Azure account. Once you are logged in, you should see a message **"You have logged into Microsoft Azure!"**

Return to the Powershell window and type this command to verify you have access to your Azure account:

```powershell
az account list
```

This will list all the subscriptions you have access to.

If you have access to only one subscription you may skip the next command. If you have more than one subscription, you will need to set the subscription you want to use for this demo:

```powershell
az account set --subscription "<Your Azure Subscription Name>"
```

You can verify the subscription you are using by executing:

```powershell
az account show --query "id" -o tsv
```

Finally, set an environment variable called **SUBSCRIPTION** with its value set to the subscription id you are using:

```powershell
Set-Variable -Name "SUBSCRIPTION" -Value (az account show --query "id" -o tsv)
```

Verify the new variable's value:

```powershell
$SUBSCRIPTION
```

We will use this variable later in the demo.

### Create a Resource Group
Execute the following command to set some variables we will use later:

```powershell
Set-Variable -Name "RGNAME" -Value "<Unique Name>"
Set-Variable -Name "LOCATION" -Value "westus"
```

Where **$RGNAME** is the name of the Resource Group you want to create and **$LOCATION** is the Azure region you want to use. Make sure the Resource Group name is unique across your Azure subscription.

We will create a Resource Group that will serve as a base for all automation in GitHub Actions. 

```powershell
az group create -n $RGNAME --location $LOCATION
```

### Generate Deployment Credentials
Execute the following command to create a Service Principal to the newly created Resource Group so that we can deploy resources to it:

```powershell
az ad sp create-for-rbac --name $RGNAME --role contributor --scopes /subscriptions/$SUBSCRIPTION/resourceGroups/$RGNAME --sdk-auth | Out-File -FilePath .\sp.txt
```

This `sp.txt` file now contains your service principal credentials to login to your Azure account when running GitHub Actions. Please ensure you never share this file with anyone and don't check it in to your repository.

### Configure the GitHub secrets
Now to add them as secrets within the GitHub Secrets environment variables to connect your Azure account to the GitHub repo for actions to run.
* Go to your GitHub repo you created from template. Click Settings, then click Secrets.
* Click "New Repository Secret"
* Create secrets in the repo for:
  * `AZURE_CREDENTIALS` is the output of `sp.txt`. Paste the entire contents of the JSON generated for the service principal in `AZURE_CREDENTIALS`.
  * `AZURE_RG` is your resource group name set in the `$RGNAME` variable.
  * `AZURE_SUBSCRIPTION` is the subscription ID in your `$SUBSCRIPTION` variable.

---
# 3 - Get [CourtStack](https://courtstack.org) SDK Running Locally

Download the CourtStack.SDK.zip file by:
* Navigate to CourtStack's GitHub repo [CTC Workshop 2021](https://github.com/CourtStack/CTC-Workshop-2021)
* Click on the Releases tab
* Download the [CourtStack.SDK.zip](https://github.com/CourtStack/CTC-Workshop-2021/releases/download/2021.09.11/CourtStack.SDK.zip) file

It should only take a couple of minutes to download.

Extract its contents to `C:\CourtStack\CourtStack.SDK`

Ensure you have dotnet 5 runtime or dotnet 5 SDK installed on your machine and execute the file: `C:\CourtStack\CourtStack.SDK\Vcms Rest Api\CourtStack.Vcms.Api.Rest.exe`

| [<== Previous Section: Requirements](Requirements.md) | [Back to Main](README.md) | [Next Section: Run CourtStack SDK Locally ==>](RunSDK.md) |