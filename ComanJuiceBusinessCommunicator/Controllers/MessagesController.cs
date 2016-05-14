using System;
using System.Threading.Tasks;
using System.Web.Http;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Connector;
using Microsoft.Bot.Connector.Utilities;

namespace ComanJuiceBusinessCommunicator.Controllers
{
    [BotAuthentication]
    public class MessagesController : ApiController
    {
        /// <summary>
        /// POST: api/Messages
        /// Receive a message from a user and reply to it
        /// </summary>
        public static BotMessageData BotData;
        public static int count = 0;
        public string LastUserId;
        private static bool _isFirst=true;
        private string[] _randomMessages= new string[] {"See our web page it is great coman-juice.com","You can find a lot of interesting information about us on our blog blog.coman-juice.com","Find tones of interesting examples of our work on gallery.coman-juice.com"};
        public async Task<Message> Post([FromBody]Message message)
        {
            if (_isFirst)
            {
                BotData = SerializationUtilities.LoadData();
                _isFirst = false;
            }

            if (message.Type == "Message")
            {
                return await Conversation.SendAsync(message, ()=>new DialogWithLogic() );
            }
            else
            {
                return HandleSystemMessage(message);
            }
        }

        private Message HandleSystemMessage(Message message)
        {
            if (message.Type == "Ping")
            {
                Message reply = message.CreateReplyMessage();
                reply.Type = "Ping";
                return reply;
            }
            else if (message.Type == "DeleteUserData")
            {
                // Implement user deletion here
                // If we handle user deletion, return a real message
            }
            else if (message.Type == "BotAddedToConversation")
            {
            }
            else if (message.Type == "BotRemovedFromConversation")
            {
            }
            else if (message.Type == "UserAddedToConversation")
            {
            }
            else if (message.Type == "UserRemovedFromConversation")
            {
            }
            else if (message.Type == "EndOfConversation")
            {
                return message.CreateReplyMessage("Good bye it was nice to meet you");
            }

            return null;
        }

        private Message FirstBot(Message message)
        {
            Random random = new Random();
            // calculate something for us to return
            if (message.Text == null)
            {
                return message.CreateReplyMessage($"Can I help you with anything ?");
            }
            if (message.Text == "Hello")
            {
                return message.CreateReplyMessage("Hello my dear friend how can i help you?");
            }
            if (message.Text == "Fuck you")
            {
                return message.CreateReplyMessage("It was rude sir. I hope You are better than that.");
            }
            return message.CreateReplyMessage(RandomMessage(random));
        }

        private string RandomMessage(Random random)
        {
            return  _randomMessages[random.Next(0,_randomMessages.Length-1)];
        }
    }
}