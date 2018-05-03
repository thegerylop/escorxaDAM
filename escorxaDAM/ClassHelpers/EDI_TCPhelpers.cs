using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Threading;

namespace ClassHelpers
{
    public class EDI_TCPhelpers
    {
        String ruta;
        private static Socket socket = null;
        private static bool listen = false;
        private static IPEndPoint connPoint = null;
        private static IPAddress listenerIP = IPAddress.Any;
        private static int port = 8000;

        public void openFile()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            // Especifico el nom que surtira a la capsa del buscador, junt amb l'extensio del fitxer i quina posicio ocupa.
            openFileDialog1.Filter = "Fichero TXT (.txt)|*.txt";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.Multiselect = false;

            // Crido el method per mostrarlo a la dialog box.
            openFileDialog1.ShowDialog();
            ruta = openFileDialog1.FileName;
            read(ruta);
        }

        public StreamReader read(string ruta)
        {
            FileStream fs_text = new FileStream(ruta, FileMode.Open, FileAccess.Read);

            StreamReader rtext = new StreamReader(fs_text);
            while (rtext.Peek() >= 0)
            {
                MessageBox.Show(rtext.ReadLine());
            }

            fs_text.Close();
            return rtext;
        }

        private string sendUDPData(string Ip, int port, string data)
        {
            string DestinationIP = Ip;
            int Port = port;
            UdpClient client = new UdpClient();
            IPEndPoint ep = new IPEndPoint(IPAddress.Parse(DestinationIP), Port);
            client.Connect(ep);

            // send data
            Byte[] sendBytes = Encoding.ASCII.GetBytes(data);
            client.Send(sendBytes, sendBytes.Length);

            // then receive data
            Byte[] receiveBytes = client.Receive(ref ep);
            string returnData = Encoding.ASCII.GetString(receiveBytes);
            client.Close();

            return returnData;
        }

        private string sendTCPData(string Ip, int port, string data)
        {
            TcpClient client = new TcpClient(Ip, port);
            NetworkStream nwStream = client.GetStream();
            byte[] buffer = new byte[client.ReceiveBufferSize];
            // send data
            Byte[] sendBytes = Encoding.ASCII.GetBytes(data);
            nwStream.Write(sendBytes, 0, sendBytes.Length);
            //---convert the data received into a string---
            int bytesRead = nwStream.Read(buffer, 0, client.ReceiveBufferSize);
            string dataReceived = Encoding.ASCII.GetString(buffer, 0, bytesRead);
            return dataReceived;
        }
    }
}
