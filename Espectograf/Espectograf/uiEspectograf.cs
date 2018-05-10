using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Espectograf
{
    public partial class uiEspectograf : Form
    {
        float valorGauge1, valorGauge2, valorGauge3, weight;
        string ruta;
        private static IPEndPoint connPoint = null;
        private static IPAddress localAdd = IPAddress.Any;
        private static int PORT_NO = 5000;
        /// <summary>
        /// Inicialitza el form. Incialitza el thread i crea el punt d'escolta
        /// </summary>
        public uiEspectograf()
        {
            InitializeComponent();
            connPoint = new IPEndPoint(localAdd, PORT_NO);
            new Thread(listener).Start();
        }
        /// <summary>
        /// Funció que llegueix un arxiu d'espectrògraf i aconseguir les dades
        /// </summary>
        /// <param name="ruta">Ruta on trobem l'arxiu</param>
        /// <param name="safata">Tipus de safata que estem analitzant</param>
        /// <returns>Retorna una string amb les 3 dades que demana el programa</returns>
        public string llegirArxiu(string ruta, string safata)
        {
            string inici;
            string final;
            string texto = "";

            FileStream fs_text = new FileStream(ruta, FileMode.Open, FileAccess.Read);
            StreamReader fsText = new StreamReader(fs_text);

            int llargada = TotalLines(ruta);
            int linia = intRandom(llargada);
            for(int i = 0; i < linia; i++)
            {
                texto = fsText.ReadLine();
            }

            //Agafo valor de gauge1
            inici = "CO";
            final = "|";
            valorGauge1 = getValueFromString(inici, final, texto);

            //Agafo valor de gauge2
            inici = "|O2";
            final = "|M";
            valorGauge2 = getValueFromString(inici, final, texto);

            //Agafo valor de gauge3
            inici = "MG";
            final = "";
            valorGauge3 = getValueFromString(inici, final, texto);

            //Calculo el valor real de la 3ra gauge segons el pes
            switch(safata)
            {
                case "SF":
                    weight = 1.2f;
                    break;
                case "SE":
                    weight = 0.8f;
                    break;
                case "SN":
                    weight = 0.4f;
                    break;
                case "":
                    MessageBox.Show("Error en la comunicació");
                    weight = 0.0f;
                    break;
            }
 
            valorGauge3 = calculper100g(weight, valorGauge3);
            
            //Actualitzo les gauges
            updateGauges(valorGauge1, valorGauge2, valorGauge3);

            //Redondeixo els valors per passar-los
            double vGauge1 = Math.Truncate(valorGauge1);
            double vGauge2 = Math.Truncate(valorGauge2);
            double vGauge3 = Math.Truncate(valorGauge3);

            //Tanco el lector de text i passo els valors com a string
            fs_text.Close();
            return vGauge1.ToString() + "," + vGauge2.ToString() + "," + vGauge3.ToString();
        }
        /// <summary>
        /// Funció que agafa una línia random de l'arxiu
        /// </summary>
        /// <param name="llargadaMAX">Quantitat de línies de l'arxiu</param>
        /// <returns>Retorna un int que és una línia random</returns>
        private static int intRandom(int llargadaMAX)
        {
            Random linia = new Random();
            return linia.Next(0, llargadaMAX);
        }
        /// <summary>
        /// Aconsegueix el número total de línies que té un arxiu
        /// </summary>
        /// <param name="ruta">Ruta de l'arxiu a analitzar</param>
        /// <returns>Número de línies de l'arxiu</returns>
        private static int TotalLines(string ruta)
        {
            using(StreamReader r = new StreamReader(ruta))
            {
                int i = 0;
                while(r.ReadLine() != null)
                {
                    i++;
                }
                return i;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="texto"></param>
        /// <returns></returns>
        private float getValueFromString(string start, string end, string texto)
        {
            string dades = "";
            int inici, final, length;

            if (texto == "")
            {
                return 0f;
            }
            else
            {
                inici = texto.IndexOf(start) + start.Length;

                //Si end no té contingut significa que el valor és MG
                if (end != "")
                {
                    final = texto.IndexOf(end) - end.Length;
                    length = final - inici + 1;
                }
                else
                {
                    length = 2;
                }

                //Agafo les dades
                if (length > 1)
                {
                    dades = texto.Substring(inici, 2);
                    dades = (Int32.Parse(dades)).ToString();
                }

                return float.Parse(dades);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public void listener()
        {
            TcpListener listener = new TcpListener(localAdd, PORT_NO);

            while(true)
            {
                listener.Start();
                TcpClient client = listener.AcceptTcpClient();
                NetworkStream nwStream = client.GetStream();
                byte[] buffer = new byte[client.ReceiveBufferSize];   

                int bytesRead = nwStream.Read(buffer, 0, client.ReceiveBufferSize);
                string dataReceived = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                string safata = dataReceived;
                ruta = "..\\dll\\Envas" + safata.ToString() + ".txt";
                string resultat = llegirArxiu(ruta,safata);

                buffer = Encoding.ASCII.GetBytes(resultat);
                nwStream.Write(buffer, 0, buffer.Length);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pes"></param>
        /// <param name="mg"></param>
        /// <returns></returns>
        private float calculper100g(float pes, float mg)
        {
            float mgper100g;

            //paso de kg a g i de mg a g
            pes = pes * 1000;
            mg = mg / 100;

            //Faig el calcul
            mgper100g = (mg / pes) * 100;

            //passo a mg per a retornar valor
            mgper100g = mgper100g * 100;
            return mgper100g;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="vg1"></param>
        /// <param name="vg2"></param>
        /// <param name="vg3"></param>
        public void updateGauges(float vg1, float vg2, float vg3)
        {
            aGauge1.Invoke((MethodInvoker)delegate { aGauge1.Value = 0f; });
            aGauge2.Invoke((MethodInvoker)delegate { aGauge2.Value = 50f; });
            aGauge3.Invoke((MethodInvoker)delegate { aGauge3.Value = 0f; });
            vg1 = (float)Math.Floor(vg1);
            vg2 = (float)Math.Floor(vg2);
            vg3 = (float)Math.Floor(vg3);

            for(int i = 0;; i++)
            {
                if(aGauge1.Value != vg1) { aGauge1.Invoke((MethodInvoker)delegate { aGauge1.Value += 1; });}
                if(aGauge2.Value != vg2) { aGauge2.Invoke((MethodInvoker)delegate { aGauge2.Value += 1; });}
                if(aGauge3.Value != vg3) { aGauge3.Invoke((MethodInvoker)delegate { aGauge3.Value += 1; });}
                Thread.Sleep(50);
                if(aGauge1.Value == vg1 && aGauge2.Value == vg2 && aGauge3.Value == vg3) { break; }
            }
        }
    }
}
