using StudentManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem.Pages.MessagePage
{
    class MessageController
    {
        public static MessageController _instance = new MessageController();

        public MessageController()
        {
        }

        public void MessageScreen()
        {
            Console.Clear();
            Console.WriteLine("1) Show Inbox");
            Console.WriteLine("2) Send Message");
            string ans = Console.ReadLine();

            switch (ans)
            {
                case "1":
                    ShowInboxScreen();
                    break;
                case "2":
                    ShowSendMessageScreen();
                    break;
                default:
                    break;
            }

        }

        public void ShowSendMessageScreen()
        {
            Console.Clear();
            for (int i = 0; i < DefaultData.users.Count; i++)
            {
                if (CurrentUser.currentUser == DefaultData.users[i])
                {
                    continue;
                }
                Console.WriteLine((i + 1) + ") " + DefaultData.users[i].FullName);
            }
            Console.WriteLine("\n");

            
            Console.WriteLine("Choose a user");
            int receiver = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your message:");
            string content = Console.ReadLine();

            Message msg = new Message(CurrentUser.currentUser, DefaultData.users[receiver - 1], content, DateTime.Now);
            MessageManager._instance.SendMessage(msg);

            Console.WriteLine("\n");
            Console.WriteLine("Message sent....");
            Console.WriteLine("1) Back");
            var ans = Console.ReadLine();

            MainScreenController._instance.MainScreen();

        }

        public void ShowInboxScreen()
        {
            Console.Clear();
            List<Message> currentInbox = CurrentUser.currentUser.inbox;
            for (int i = 0; i < currentInbox.Count; i++)
            {
                Console.WriteLine(currentInbox[i].Time + " " +currentInbox[i].Sender.fullName + ": " + currentInbox[i].Msg);
            }

            Console.WriteLine("\n");
            Console.WriteLine("1) Back");
            var ans = Console.ReadLine();

            MainScreenController._instance.MainScreen();
        }
    }
}
