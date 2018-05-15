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
        /// Punt d'entrada de l'aplicació. Generem un thread i gestionem l'UDP.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            connPoint = new IPEndPoint(listenerIP, port);
            //Començar threading
            new Thread(listener).Start();
            Application.Run(new Balança());
            
        }
        /// <summary>
        /// Començem el listener i el mantenim obert permanentment
        /// </summary>
        public static void listener()
        {
            while (true)
            {
                Byte[] receiveBytes = udpServer.Receive(ref connPoint);
                returnData = Encoding.ASCII.GetString(receiveBytes);
                MessageBox.Show(returnData);
            }
        }
        /// <summary>
        /// Inicialitzem l'aplicació
        /// </summary>
        public Balança()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Quan pesem, agafem les dades rebudes, seleccionem l'arxiu corresponent, en llegim una línia random i n'agafem el pes.
        /// Posem el pes en el textbox
        /// </summary>
        private void btnPesar_Click(object sender, EventArgs e)
        {
            string data = returnData;
            string safata = Program.safataArxiu(data);
            string linia = Program.liniaRandom(safata);
            int pes = Program.agafaPes(linia);
            txtPes.Text = pes.ToString();
            
        }
        /// <summary>
        /// Enviem el pes al programa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            Byte[] sendBytes = Encoding.ASCII.GetBytes(txtPes.Text);
            udpServer.Send(sendBytes, sendBytes.Length, connPoint);
        }
    }
}
