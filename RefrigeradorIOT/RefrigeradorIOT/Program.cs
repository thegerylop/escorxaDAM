using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using System.IO;

namespace RefrigeradorIOT
{
    class Program
    {
        private static Socket socket = null;
        private static bool listen = false;
        private static IPEndPoint connPoint = null;
        private static IPAddress listenerIP = IPAddress.Any;
        private static int port = 8000;

        static void Main(string[] args)
        {
            connPoint = new IPEndPoint(listenerIP, port);
            new Thread(Listener).Start();
            Console.ReadLine();
            listen = false;
        }

        private static void Listener()
        {
            UdpClient udpServer = new UdpClient(port);

            while (true)
            {
                Byte[] receiveBytes = udpServer.Receive(ref connPoint);
                string returnData = Encoding.ASCII.GetString(receiveBytes);
                Console.Write("Connection successful. Data received. \n");
                //Manipula les dades
                string temps = FilteredData(returnData);

                Byte[] sendBytes = Encoding.ASCII.GetBytes(temps);
                udpServer.Send(sendBytes, sendBytes.Length, connPoint);
            }
        }

        private static string FilteredData(string time)
        {
            string line = null, data = "";
            int max = 0, min = 9999, tempmax = 0, tempmin = 0;
            Boolean checkTime = false;
            string pathToTextFile = Path.Combine(Environment.CurrentDirectory.Substring(0, Environment.CurrentDirectory.IndexOf("bin")), @"Data\IOT.txt");
            string openTime = "HO|" + time.Substring(0, time.IndexOf('-'));
            string closeTime = "HO|" + time.Substring(time.IndexOf('-') + 1);
            File.OpenRead(pathToTextFile);
            StreamReader file = new StreamReader(pathToTextFile);
            while(line != "")
            {
                line = file.ReadLine();
                if (line.StartsWith(openTime))
                {
                    checkTime = true;
                }
                if (checkTime)
                {
                    tempmin = Convert.ToInt32(line.Substring(8, 4));
                    tempmax = Convert.ToInt32(line.Substring(13, 4));
                    if(tempmax > max)
                    {
                        max = tempmax;
                    }
                    if(tempmin < min)
                    {
                        min = tempmin;
                    }
                }
                if (line.StartsWith(closeTime))
                {
                    line = "";
                }
            }
            data = min + "-" + max;
            return (data);
        }
    }
}
