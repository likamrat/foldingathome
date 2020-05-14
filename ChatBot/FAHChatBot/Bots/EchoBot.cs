// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.
//
// Generated with Bot Builder V4 SDK Template for Visual Studio EchoBot v4.6.2

using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Bot.Builder;
using Microsoft.Bot.Schema;
using System.Linq;
using Microsoft.Bot.Builder.AI.QnA;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Extensions.Logging;

namespace FAHChatBot.Bots
{
 
    public class EchoBot : ActivityHandler
    {
        public QnAMaker EchoBotQnA { get; private set; }
        public EchoBot(QnAMakerEndpoint endpoint)
        {
            // connects to QnA Maker endpoint for each turn
            EchoBotQnA = new QnAMaker(endpoint);
        }

        protected override async Task OnMessageActivityAsync(ITurnContext<IMessageActivity> turnContext, CancellationToken cancellationToken)
        {
    

            await AccessQnAMaker(turnContext, cancellationToken);
        }

        protected override async Task OnMembersAddedAsync(IList<ChannelAccount> membersAdded, ITurnContext<IConversationUpdateActivity> turnContext, CancellationToken cancellationToken)
        {
            foreach (var member in membersAdded)
            {
                if (member.Id != turnContext.Activity.Recipient.Id)
                {
                    await SendIntroCardAsync(turnContext, cancellationToken);
                }
            }
        }
        private async Task AccessQnAMaker(ITurnContext<IMessageActivity> turnContext, CancellationToken cancellationToken)
        {
            var results = await EchoBotQnA.GetAnswersAsync(turnContext);
            if (results.Any())
            {
                await turnContext.SendActivityAsync(MessageFactory.Text( results.First().Answer), cancellationToken);
            }
            else
            {
                await turnContext.SendActivityAsync(MessageFactory.Text("Sorry, could not find an answer in the Q and A system."), cancellationToken);
            }
        }
        private static async Task SendIntroCardAsync(ITurnContext turnContext, CancellationToken cancellationToken)
        {
            var card = new HeroCard();
            card.Title = "Welcome to Folding@Home Chat Bot!";
            card.Text = @"Hi friend, welcome to Folding@Home Chat Bot!! This a great way get all you need to know about Folding@Home project.";
            card.Images = new List<CardImage>() { new CardImage("https://upload.wikimedia.org/wikipedia/commons/4/47/F%40H_Logo_2012.png") };
            var response = MessageFactory.Attachment(card.ToAttachment());
            await turnContext.SendActivityAsync(response, cancellationToken);
        }
    }
}
