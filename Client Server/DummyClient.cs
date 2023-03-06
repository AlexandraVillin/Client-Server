using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client_Server
{
    class DummyClient : IClient
    {
        public int id { get; set; }
        public string name { get; set; }

        public DummyClient()
        {
            this.id = 0;
            this.name = "";
        }

        public DummyClient(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public string GetInfo()
        {
            string str = "\nDummy Client: " + id + " " + name;
            return str;
        }

        public void Execute()
        {
            Console.WriteLine($"\nOperation executed - Dummy Client: " + id + " " + name);
        }
    }
}
