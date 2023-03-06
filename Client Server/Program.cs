using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client_Server
{
    class Program
    {
        static void Main(string[] args)
        {
            DummyClient d1 = new DummyClient(1, "grah");
            DummyClient d2 = new DummyClient(2, "crnja");

            MessageClient m1 = new MessageClient("kul grah");
            MessageClient m2 = new MessageClient("lud crnja");

            MyServer server1 = new MyServer(69);
            server1.AddClient(d1);
            server1.AddClient(d2);
            server1.AddClient(m1);
            server1.AddClient(m2);

            server1.ExecuteClient(1);

            Console.WriteLine(server1.ToString());

            server1.Log("log.txt");

            Console.ReadLine();
        }
    }
}
