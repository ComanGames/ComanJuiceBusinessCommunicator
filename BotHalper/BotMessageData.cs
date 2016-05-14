using System;

namespace ComanJuiceBusinessCommunicator
{
    [Serializable]
    public class BotMessageData
    {
        public string FirstMessage;
        public string[]  RendomMessages;
        public BotMessageData()
        {
        }

        public BotMessageData(string firstMessage, string[] rendomMessages)
        {
            FirstMessage = firstMessage;
            RendomMessages = rendomMessages;
        }
    }
}