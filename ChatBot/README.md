# FOLDING@HOME Team 999 - Microsoft fight on COVID-19

This is a solution to create a Folding@Home Chat bot to help answer FAQ Questions
[Applicaton URL](https://fahfrontend.azurewebsites.net)

## How does it work?

1. You should use the folding@homekb.tsv file to create an knowledgebase in https://www.qnamaker.ai/
2. Once the KB is created, then you can use the sample bot application I have provided in 'FAHChatBot'
3. Change the appsettings.json file to store your own environment information
4. Deploy it to Azure. Here is the instruction on how to do the deployment: https://docs.microsoft.com/en-us/azure/bot-service/bot-builder-deploy-az-cli?view=azure-bot-service-4.0&tabs=csharp
5. You can use the 'frontendwebapp' in this repo directory to create a Front End speech enabled web broswer app to embed your web bot app. 
6. You will need to change the 'const bearer' line to update your own key to your bot direct line channel.
7. You will need to change the 'const subscriptionkey' line to reflect your own azure subscription id.


![Final Result](https://github.com/anniexudan/foldingathome/blob/master/ChatBot/Screenshotofthebot.PNG)

