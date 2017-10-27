using System;
using System.Text;

class Client_Test
{
    public static void Main(string[] args)
    {
        Client c1 = new Client(2004, "127.0.0.1");
        c1.StartClient();
        while (true)
        {
            string cmd = Console.ReadLine();

            if (cmd == "sair")
            {
                c1.ReleaseSocket();
            }
            else 
            {                
                Console.WriteLine(cmd);
                c1.Send(cmd);
                c1.EndMessage();
                c1.Receive(c1.GetSocket());
                c1.GetSocketReceiveResponse();             
                
            }
        }


    }
}