﻿using System;
using System.Threading.Tasks;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Connector;

namespace ComanJuiceBusinessCommunicator.Controllers
{
    [Serializable]
    public class EchoDialog :IDialog<object>
    {
        public async Task StartAsync(IDialogContext context)
        {
            context.Wait(MessageReceivedAsync);
        }
        public async Task MessageReceivedAsync(IDialogContext context, IAwaitable<Message> argument)
        {
            var message = await argument;
            await context.PostAsync("You said: " + message.Text);
            context.Wait(MessageReceivedAsync);
        }
    }
}