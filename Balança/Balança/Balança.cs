using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Threading;

namespace Balança
{

    public partial class Balança : Form
    {
        public static Socket socket = null;
        public static bool listen = false;
        public static IPEndPoint connPoint = null;
        public static IPAddress listenerIP = IPAddress.Any;
        public static int port = 7000;
        public static string returnData = "";
        public static UdpClient udpServer = new UdpClient(port);
        /// <summary>
        /// Punt d'entrada de l'aplicació. Generen un thread i gestionem l'UDP.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Balança());
            //Començar threading
            Thread newThread = new Thread(listener);
            newThread.Start();

        }
        public static void listener()
        {
            while (true)
            {
                Byte[] receiveBytes = udpServer.Receive(ref connPoint);
                returnData = Encoding.ASCII.GetString(receiveBytes);
            }
        }
        /// <summary>
        /// Inicialitzem l'aplicació
        /// </summary>
        public Balança()
        {
            InitializeComponent();
        }

        private void btnPesar_Click(object sender, EventArgs e)
        {
            string data = returnData;
            string safata = Program.safataArxiu(data);
            string linia = Program.liniaRandom(safata);
            int pes = Program.agafaPes(linia);
            txtPes.Text = pes.ToString();
            
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            Byte[] sendBytes = Encoding.ASCII.GetBytes(txtPes.Text);
            udpServer.Send(sendBytes, sendBytes.Length, connPoint);
        }
    }
}
