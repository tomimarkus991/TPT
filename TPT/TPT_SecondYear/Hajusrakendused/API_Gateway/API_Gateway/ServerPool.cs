using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Gateway
{
    public class ServerPool
    {
        private List<string> servers = new List<string>();


        public void Add(string item)
        {
            servers.Add(item);
        }
        public void Remove(string item)
        {
            servers.Remove(item);
        }
        private int lastIndex = 0;
        public string Next()
        {
            if (servers.Count == 0)
                return null;
            if (lastIndex >= servers.Count)
                lastIndex = 0;
            return servers[lastIndex++];
        }
        public bool isEmpty()
        {
            return servers.Count() == 0;
        }
    }
}