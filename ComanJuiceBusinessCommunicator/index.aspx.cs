using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ComanJuiceBusinessCommunicator
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            BotMessageData messageData = new BotMessageData();
            messageData.FirstMessage = TextBox1.Text;
            SerializationUtilities.SaveData(messageData);
        }
    }
}