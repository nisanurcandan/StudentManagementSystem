using StudentManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem.Pages.MessagePage
{
    class MessageManager
    {
        public static MessageManager _instance = new MessageManager();

        public MessageManager()
        {
        }

        public void SendMessage(Message message)
        {
            message.Receiver.inbox.Add(message);
        }
    }
}
