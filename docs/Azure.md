# Prerequisites

Deploying FAH on an Azure virtual machine is easy. Rather you are a Windows, MacOs or Linux user, all you really need is to [install Azure CLI](https://docs.microsoft.com/en-us/cli/azure/install-azure-cli?view=azure-cli-latest). 

The VM is Ubuntu Server 18.04 based image and will be deployed as an Azure "Standard_F4s_v2" VM which is a great fit for such a CPU-intense workload. 

# Deploying the Azure VM

In order to deploy the VM, you will need to log in to Azure using AZ CLI, point to the subscription you want to deploy to and optionally create an Azure Resource Group.

* Login to Azure using the ```az login``` command.

* After successfully login, set the default subscription using the ```az account set -s "Your subscription id"```.<br> you can easily retrieve the subscription id using the ```az account list -o table``` command. 

* Every Azure VM needs to be deploy in a Resource Group so go ahead and deploy one: <br>   
```az group create -l "The Azure region" -n "Name of the RG"``` <br>   
Example: ```az group create -l westus2 -n Folding-COVID19```

![](../img/Azure/rg_01.png)

* Now that you have a new RG created, you can go ahead and deploy the VM in a single command: <br>

```az deployment group create --name "folding" --resource-group "Folding-COVID19" --template-uri https://raw.githubusercontent.com/likamrat/foldingathome/master/deploy/azure/azuredeploy.json```

**Note: Don't forget to match the resource group name based on the one you created**

![](../img/Azure/az_01.png)

![](../img/Azure/az_02.png)

![](../img/Azure/az_03.png)

# How to use it?

The VM is now deployed and you can use it. Get the public IP of the VM, paste it in your browser and add the "7396" port to it. 

![](../img/Azure/deployed_01.png)

![](../img/Azure/deployed_02.png)

![](../img/Azure/deployed_03.png)

You can see how the CPUs are hitting all cylinders and the utilization is consistently close to 100%. 

![](../img/Azure/perf_01.png)

# Reboot & Shutdown

Don't worry about rebooting the VM, the FAM client will start automatically on boot. 

To stop folding just click "Stop Folding" or shutdown/delete the VM. 
