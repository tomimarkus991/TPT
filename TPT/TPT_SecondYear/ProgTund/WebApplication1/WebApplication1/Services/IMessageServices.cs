using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics;

namespace WebApplication1.Services
{
    public interface IMessageServices
    {
        void Send(string message);
    }
    public class Mailer : IMessageServices
    {
        public void Send(string message)
        {
            Debug.WriteLine("Mailer:" + message);
        }
    }
    public class SmsMessager : IMessageServices
    {
        public void Send(string message)
        {
            Debug.WriteLine("SMS" + message);
        }
    }
}
