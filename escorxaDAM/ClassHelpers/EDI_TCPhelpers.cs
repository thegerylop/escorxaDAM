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

        public string openFile()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            // Especifico el nom que surtira a la capsa del buscador, junt amb l'extensio del fitxer i quina posicio ocupa.
            openFileDialog1.Filter = "Fichero TXT (.txt)|*.txt";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.Multiselect = false;

            // Crido el method per mostrarlo a la dialog box.
            openFileDialog1.ShowDialog();
            ruta = openFileDialog1.FileName;
            return ruta;
        }

        public string[] read(string ruta)
        {
            var list = new List<string>();
            FileStream fs_text = new FileStream(ruta, FileMode.Open, FileAccess.Read);

            StreamReader rtext = new StreamReader(fs_text);
            string line;
            while ((line = rtext.ReadLine()) != null)
            {
                list.Add(line);
            }
            string[] result = list.ToArray();
            fs_text.Close();
            return result;

        }

        public static string sendUDPData(string Ip, int port, string data)
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
            MessageBox.Show(returnData);
            client.Close();

            return returnData;
        }

        public string sendTCPData(string Ip, int port, string data)
        {
            Byte[] fileBuffer = System.Text.Encoding.ASCII.GetBytes(data);
            TcpClient clientSocket = new TcpClient(Ip, port);
            NetworkStream networkStream = clientSocket.GetStream();
            networkStream.Write(fileBuffer, 0, fileBuffer.Length);
            Byte[] dataRec = new Byte[256];
            String responseData = String.Empty;
            Int32 bytes = networkStream.Read(dataRec, 0, dataRec.Length);
            responseData = System.Text.Encoding.ASCII.GetString(dataRec, 0, bytes);
            networkStream.Close();
            MessageBox.Show(responseData);
            return responseData;
        }
    }
}
