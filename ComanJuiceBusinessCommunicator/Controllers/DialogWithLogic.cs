using System;
using System.Threading.Tasks;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Connector;

namespace ComanJuiceBusinessCommunicator.Controllers
{
    [Serializable]
    public class DialogWithLogic:IDialog<Object>
    {
        public async Task StartAsync(IDialogContext context)
        {
             context.Wait(AsyncAnswer);
        }

        private async Task AsyncAnswer(IDialogContext context, IAwaitable<Message> result)
        {
            await context.PostAsync("Hello new User");
            context.Wait(AsyncAnswer);
        }
    }
}