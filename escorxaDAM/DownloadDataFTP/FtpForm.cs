
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Configuration;

namespace DownloadDataFTP
{
    public partial class FtpForm : Form
    {
        ClassHelpers.FTPhelper ftp = new ClassHelpers.FTPhelper();
        public FtpForm()
        {
            InitializeComponent();
        }

        private byte[] downloadedData;
        string[] credentials = new string[2];

        //Connects to the FTP server and downloads the file
        private void downloadFile(string FTPAddress, string filename, string username, string password)
        {
            downloadedData = new byte[0];

            try
            {

                //Crea una peticio FTP
                FtpWebRequest request = FtpWebRequest.Create(FTPAddress + "/" + filename) as FtpWebRequest;
                

                //Consegueixo el tamany del arxiu per a la progress bar
                request.Method = WebRequestMethods.Ftp.GetFileSize;
                request.Credentials = new NetworkCredential(username, password);
                request.UsePassive = true;
                request.UseBinary = true;
                request.KeepAlive = true;

                int dataLength = (int)request.GetResponse().ContentLength;
                

                //Now get the actual data
                request = FtpWebRequest.Create(FTPAddress + "/" + filename) as FtpWebRequest;
                request.Method = WebRequestMethods.Ftp.DownloadFile;
                request.Credentials = new NetworkCredential(username, password);
                request.UsePassive = true;
                request.UseBinary = true;
                request.KeepAlive = false; //close the connection when done

                //Reinicia la progress bar
                progressBar1.Value = 0;
                progressBar1.Maximum = dataLength;

                //Streams
                FtpWebResponse response = request.GetResponse() as FtpWebResponse;
                Stream reader = response.GetResponseStream();

                //Descarrega en memoria
                MemoryStream memStream = new MemoryStream();
                byte[] buffer = new byte[1024];

                while (true)
                {
                    Application.DoEvents(); // No crash

                    // Llegeix l'arxiu
                    int bytesRead = reader.Read(buffer, 0, buffer.Length);

                    if (bytesRead == 0)
                    {
                        // Si no hi ha res a llegir, acaba de descarregar
                        progressBar1.Value = progressBar1.Maximum;

                        Application.DoEvents();
                        break;
                    }
                    else
                    {
                        // Escriu la Data
                        memStream.Write(buffer, 0, bytesRead);

                        // Actualitza la progressBar
                        if (progressBar1.Value + bytesRead <= progressBar1.Maximum)
                        {
                            progressBar1.Value += bytesRead;

                            progressBar1.Refresh();
                            Application.DoEvents();
                        }
                    }
                }

                // stream to array de byte
                downloadedData = memStream.ToArray();

                //Clean up
                reader.Close();
                memStream.Close();
                response.Close();

                MessageBox.Show("Descarregat correctament");
            }
            catch (Exception)
            {
                MessageBox.Show("error en el servidor FTP.");
            }
        }

        //Conecta amb el ftp i aconsegueix la llista d'arxius
        private void getFileList(string FTPAddress, string username, string password)
        {
            List<string> files = new List<string>();

            try
            {

                //Peticio FTP
                FtpWebRequest request = FtpWebRequest.Create(FTPAddress) as FtpWebRequest;

                request.Method = WebRequestMethods.Ftp.ListDirectory;
                request.Credentials = new NetworkCredential(username, password);
                request.UsePassive = true;
                request.UseBinary = true;
                request.KeepAlive = false;

                FtpWebResponse response = request.GetResponse() as FtpWebResponse;
                Stream responseStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(responseStream);

                while (!reader.EndOfStream)
                {
                    Application.DoEvents();
                    files.Add(reader.ReadLine());
                }

                //Deixas de llegir
                reader.Close();
                responseStream.Close(); //redundant
                response.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("error en el servidor FTP.");
            }

            username = string.Empty;
            password = string.Empty;

            //Mostra una llista amb els arxius
            if (files.Count != 0)
            {
                listDialogForm dialog = new listDialogForm(files);
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    //Actualitza el nom del arxiu en el camp
                    txtFileName.Text = dialog.ArxiuEscollit;
                }
            }
        }

        //Comprova que la ruta comença per "ftp://"
        private void txtFTPAddress_Leave(object sender, EventArgs e)
        {
            if (!txtFTPAddress.Text.StartsWith("ftp://"))
                txtFTPAddress.Text = "ftp://" + txtFTPAddress.Text;
        }

        private void btnGetList_Click(object sender, EventArgs e)
        {
            if (txtFTPAddress.Text != "ftp://" && txtFTPAddress.Text != string.Empty)
                getFileList(txtFTPAddress.Text, txtUsername.Text, txtPassword.Text);
            else
                MessageBox.Show("Introdueix una adreça FTP");
        }

        // Descarrega el arxiu en memoria
        private void btnDownload_Click(object sender, EventArgs e)
        {
            if (txtFTPAddress.Text != "ftp://" && txtFTPAddress.Text != string.Empty)
                if (txtFileName.Text != string.Empty)
                {
                    downloadFile(txtFTPAddress.Text, txtFileName.Text, txtUsername.Text, txtPassword.Text);

                    saveFile1.FileName = txtFileName.Text;
                    save();
                }
                else
                    MessageBox.Show("Seleciona o escriu un arxiu");
            else
                MessageBox.Show("Introdueix una adreça FTP");
        }

        //Guarda el arxiu descarregat
        public void save()
        {
            if (downloadedData != null && downloadedData.Length != 0)
            {
                string CombinedPath = System.IO.Path.Combine(Directory.GetCurrentDirectory(), "..\\ArxiusFTP");
                saveFile1.InitialDirectory = System.IO.Path.GetFullPath(CombinedPath);
                saveFile1.Filter = "All files (*.*)|*.*";
                if (saveFile1.ShowDialog() == DialogResult.OK)
                {
                    FileStream newFile = new FileStream(saveFile1.FileName, FileMode.Create);
                    newFile.Write(downloadedData, 0, downloadedData.Length);
                    newFile.Close();
                    MessageBox.Show("Guardat correctament");
                }
            }
        }

        private void ftpForm_Load(object sender, EventArgs e)
        {
            //comprova que hi hagi conexio i omple els camps de les credencials obtingudes en el config
            string connexio = ftp.AccesoInternet();
            if(connexio != "")
            {
                MessageBox.Show(connexio);
            }
            credentials = ftp.getCredentials();
            txtUsername.Text = credentials[0];
            txtPassword.Text = credentials[1];
        }
    }
}