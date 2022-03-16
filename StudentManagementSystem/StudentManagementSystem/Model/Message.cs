using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem.Model
{
    class Message
    {
        private User sender;
        private User receiver;
        private string msg;
        private DateTime time;

        public Message(User sender, User receiver, string msg, DateTime time)
        {
            this.sender = sender;
            this.receiver = receiver;
            this.msg = msg;
            this.time = time;
        }

        public User Sender
        {
            get { return sender; }
            set { sender = value; }
        }
        public User Receiver
        {
            get { return receiver; }
            set { receiver = value; }
        }
        public string Msg
        {
            get { return msg; }
            set { msg = value; }
        }
        public DateTime Time
        {
            get { return time; }
            set { time = value; }
        }
    }
}
