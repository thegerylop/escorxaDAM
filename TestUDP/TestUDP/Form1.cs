using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TestUDP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sendData()
        {
            string DestinationIP = File.ReadAllText(Path.Combine(Environment.CurrentDirectory.Substring(0, Environment.CurrentDirectory.IndexOf("bin")), @"Config\Config.txt"));
            UdpClient client = new UdpClient();
            IPEndPoint ep = new IPEndPoint(IPAddress.Parse(DestinationIP), 8000);
            client.Connect(ep);

            // send data
            Byte[] sendBytes = Encoding.ASCII.GetBytes(textBox1.Text + "-" + textBox2.Text);
            client.Send(sendBytes, sendBytes.Length);

            // then receive data
            Byte[] receiveBytes = client.Receive(ref ep);
            string returnData = Encoding.ASCII.GetString(receiveBytes);
            label1.Text = returnData;

            Console.Read();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sendData();
        }
    }
}
