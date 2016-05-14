using System;
using System.Threading.Tasks;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Connector;

namespace ComanJuiceBusinessCommunicator.Controllers
{
    [Serializable]
    public class DialogWithLogic:IDialog<Object>
    {
        private int count;

        public async Task StartAsync(IDialogContext context)
        {
           context.Wait(MessageReceivedAsync);
        }

        public async Task MessageReceivedAsync(IDialogContext context, IAwaitable<Message> argument)
        {
            var message = await argument;
            if (message.Text == "reset")
            {
                PromptDialog.Confirm(
                    context,
                    AfterResetAsync,
                    "Are you sure you want to reset the count?",
                    "Didn't get that!");
            }
            else
            {
                if(count==0)
                    await context.PostAsync(MessagesController.BotData.FirstMessage);
                else
                    await context.PostAsync(MessagesController.BotData.RendomMessages[new Random().Next(MessagesController.BotData.RendomMessages.Length)]);
                count++;
                context.Wait(MessageReceivedAsync);
            }
        }

        public async Task AfterResetAsync(IDialogContext context, IAwaitable<bool> argument)
        {
            var confirm = await argument;
            if (confirm)
            {
                this.count = 0;
                await context.PostAsync("Reset count.");
            }
            else
            {
                await context.PostAsync("Did not reset count.");
            }
            context.Wait(MessageReceivedAsync);
        }
    }
}