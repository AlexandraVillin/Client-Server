using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Client_Server
{
    class MyServer : IServer
    {
        public int port { get; set; }
        public bool active { get; set; }
        public List<IClient> clients = new List<IClient> {};

        public MyServer(int port)
        {
            this.active = false;
            clients.Clear();
        }

        public bool Start()
        {
            if (active == false)
            {
                active = true;
                Console.WriteLine($"“Server started at port {0}", port);
                return true;
            }
            else return false;
        }

        public bool Stop()
        {
            if (active == true)
            {
                active = false;
                clients.Clear();
                Console.WriteLine($"“Server stopped...");
                return true;
            }
            else return false;
        }

        public void AddClient(IClient c)
        {
            clients.Add(c);
        }

        public bool RemoveClient(int index)
        {
            if (index < clients.Count)
            {
                clients.RemoveAt(index);
                return true;
            }
            else return false;
        }

        public bool ExecuteClient(int index)
        {
            if (index < clients.Count)
            {
                clients[index].Execute();
                return true;
            }
            else return false;
        }

        public string YesNo(bool active)
        {
            if (active == true) return "yes";
            else return "no";
        }

        public override string ToString()
        {
            string str = "\nport: " + port + " clients: " + clients.Count + " active" + YesNo(active);
            foreach (IClient x in clients)
            {
                str = str + x.GetInfo();
            }
            return str;
        }

        public void Log(string file)
        {
            string str = "";

            foreach (IClient x in clients)
            {
                str = str + x.GetInfo();
            }
            string[] lines =
            {
            "MyServer", "port: " + port + " clients: " + clients.Count + " active: " + YesNo(active), "----------------------------------------------", str
            };

            File.WriteAllLines("log.txt", lines);
        }
    }
}
