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

        //Retornar el StreamReader amb tota la informació.
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

                //Rep les dades
                Byte[] receiveBytes = udpServer.Receive(ref connPoint);
                string returnData = Encoding.ASCII.GetString(receiveBytes);
                Console.Write("Connection successful. Data received. \n");
                //Manipula les dades
                string temps = FilteredData(returnData);

                //Envia les dades

                //Byte[] sendBytes = Encoding.ASCII.GetBytes(temps);
                //udpServer.Send(sendBytes, sendBytes.Length, connPoint);
            }
        }
        private static string FilteredData(string time)
        {
            // Manipular dades necesarias a trobar
            return "";
        }
    }
}
