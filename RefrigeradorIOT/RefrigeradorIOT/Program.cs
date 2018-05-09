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
        private static IPEndPoint connPoint = null;
        private static IPAddress listenerIP = IPAddress.Any;
        private static int port = 8000;

        static void Main(string[] args)
        {
            connPoint = new IPEndPoint(listenerIP, port);
            new Thread(Listener).Start();
            Console.ReadLine();
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
                Console.Write("Connection closed. \n\n");
            }
        }

        private static string FilteredData(string time)
        {
            Boolean checkTime = false;
            string line = null, data = "";
            string openTime = time.Substring(0, time.IndexOf('-'));
            string closeTime = time.Substring(time.IndexOf('-') + 1);
            string openTimeHo = "HO|" + openTime;
            string closeTimeHo = "HO|" + closeTime;
            string docTime = "";
            int max = -9999, min = 9999, tempmax = 0, tempmin = 0;
            string pathToTextFile = Path.Combine(Environment.CurrentDirectory.Substring(0, Environment.CurrentDirectory.IndexOf("bin")), @"Data\IOT.txt");
            File.OpenRead(pathToTextFile);
            StreamReader file = new StreamReader(pathToTextFile);

            if (Int32.Parse(openTime) < Int32.Parse(closeTime))
            {
                while (line != "")
                {
                    line = file.ReadLine();
                    if (line.StartsWith(openTimeHo))
                    {
                        checkTime = true;
                    }
                    if (checkTime)
                    {
                        tempmin = Convert.ToInt32(line.Substring(8, 4));
                        tempmax = Convert.ToInt32(line.Substring(13, 4));
                        if (tempmax > max)
                        {
                            max = tempmax;
                        }
                        if (tempmin < min)
                        {
                            min = tempmin;
                        }
                    }
                    if (line.StartsWith(closeTimeHo))
                    {
                        line = "";
                    }
                }
                data = min + "-" + max;
            }
            else if (Int32.Parse(openTime) > Int32.Parse(closeTime))
            {
                checkTime = true;
                while (line != "")
                {
                    line = file.ReadLine();
                    if (line.StartsWith(openTimeHo))
                    {
                        checkTime = true;
                    }
                    if (checkTime)
                    {
                        docTime = line.Substring(3, 4);
                        tempmin = Convert.ToInt32(line.Substring(8, 4));
                        tempmax = Convert.ToInt32(line.Substring(13, 4));
                        if (tempmax > max)
                        {
                            max = tempmax;
                        }
                        if (tempmin < min)
                        {
                            min = tempmin;
                        }
                    }
                    if (line.StartsWith(closeTimeHo))
                    {
                        checkTime = false;
                    }
                    if (docTime == "2345")
                    {
                        line = "";
                    }
                }
                data = min + "-" + max;
            }
            else
            {
                data = "Error";
            }
            return (data);
        }
    }
}
