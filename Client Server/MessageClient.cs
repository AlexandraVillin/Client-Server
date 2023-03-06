using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client_Server
{
    class MessageClient : IClient
    {
        public string message { get; set; }

        public MessageClient()
        {
            this.message = "";
        }

        public MessageClient(string message)
        {
            this.message = message;
        }

        public string GetInfo()
        {
            string str = "\nMessage Client: " + message;
            return str;
        }

        public void Execute()
        {
            Console.WriteLine("\nOperation executed - Message Client: " + message);
        }
    }
}
