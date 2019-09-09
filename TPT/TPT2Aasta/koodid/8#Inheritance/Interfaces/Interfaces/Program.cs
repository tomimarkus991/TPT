using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface INotifications
    {
        void showNotification();
        string getDate();
    }
    // Notification inheritates from INotifications
    public class Notification: INotifications
{
        private string sender;
        private string message;
        private string date;
        // Deafault
        public Notification()
        {
            sender = "Admin";
            message = "This is default message";
            date = "Date";
        }
        public Notification(string mySender, string myMessage, string myDate)
        {
            this.sender = mySender;
            this.message = myMessage;
            this.date = myDate;
        }
        public void showNotification()
        {
            Console.WriteLine("Message {0} - was sent by {1} - at {2}", message, sender, date);
        }
        public string getDate()
        {
            return date;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Notification n1 = new Notification("Tomi", "bla bla", "24.08.19");
            n1.showNotification();
            Console.ReadKey();
        }
    }
}
