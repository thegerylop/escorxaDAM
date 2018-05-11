using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Data.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using Models;

namespace RecepcioBestiar
{
    public partial class Recepcio : BaseForm.BaseInserir
    {
        escorxadam2Entities _m = new escorxadam2Entities();
        ClassHelpers.EDI_TCPhelpers edi = new ClassHelpers.EDI_TCPhelpers();
        string[] dades;

        public Recepcio()
        {
            InitializeComponent();
        }

        private void Recepcio_Load(object sender, EventArgs e)
        {
            dateToday.Value = DateTime.Now;
            dateSortida.CustomFormat = "yyyymmdd";
            obtenirUsuaris();
        }
        private void Edi()
        {
            string ruta = edi.openFile();
            dades = edi.read(ruta);
            omplirCamps(dades);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Edi();
        }
        private void omplirCamps(string[] dades)
        {
            string output = "";
            string Char;
            int index;
            foreach (string item in dades)
            {
                int charLocation = item.IndexOf("|", StringComparison.Ordinal);
                if (charLocation > 0)
                {
                    Char = item.Substring(0, charLocation);
                    switch (Char)
                    {
                        case "REMO":
                            output = item.Split('|', '|')[1];
                            break;
                        case "ORI":
                            index = item.IndexOf("|");
                            output = item.Substring(index + 1);
                            break;
                        case "DES":
                            index = item.IndexOf("|");
                            output = item.Substring(index + 1);
                            break;
                        case "TRA":
                            output = item.Split('|', '|')[1];
                            index = item.LastIndexOf("|");
                            output += item.Substring(index);
                            break;
                        case "TOTAN":
                            index = item.IndexOf("|");
                            output = item.Substring(index + 1);
                            break;
                        case "IDAN":
                            index = item.IndexOf("|");
                            output = item.Substring(index + 1);
                            break;
                    }
                    if (!Char.Equals("IDAN"))
                    {
                        actualizarTextBox(Char, output);
                    }
                    else
                    {
                        actualitzarDataGrid(Char, output);
                    }
                }
            }
        }
        private void actualizarTextBox(string Char, string text)
        {
            foreach (Control txt in this.Controls)
            {
                if (txt.GetType() == typeof(CustomControl.CustomTextBox))
                {
                    if (txt.Name == Char)
                    {
                        if (Char == "TRA")
                        {
                            int index = text.IndexOf("|");
                            string output = text.Substring(0, index);
                            txt.Text = output;
                            index = text.LastIndexOf("|");
                            output = text.Substring(index + 1);
                            DateTime enteredDate = DateTime.ParseExact(output, "yyyyMMdd", CultureInfo.InvariantCulture, DateTimeStyles.AssumeLocal);
                            dateSortida.Value = enteredDate;
                        }
                        else
                        {
                            txt.Text = text;
                        }
                    }
                }
            }
        }
        private void actualitzarDataGrid(string Char, string text)
        {
            int i = 0;
            string[] dataAnimals = new string[5];
            while (i < 5)
            {
                int index = text.IndexOf("|");
                if (index > 0)
                {
                    dataAnimals[i] = text.Substring(0, index);
                    text = text.Substring(index + 1);
                }
                else
                {
                    dataAnimals[i] = text;
                }
                i++;
            }
            AnimalsGrid.Rows.Add(dataAnimals[0], dataAnimals[1], dataAnimals[2], dataAnimals[3], dataAnimals[3]);
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            inserirRecepcio();
            crearLot();
            inserir();
        }
        public void inserirRecepcio()
        {

            var proveidor = (from a in _m.proveidors
                             where a.codiExplotacio.ToString() == ORI.Text
                             select a.idProveidor).ToString();
        }
        public void crearLot()
        {
            string lot;
            string date = DateTime.Now.ToString("MMdd");

            var num = (from a in _m.lots
                       where a.numLot.ToString().StartsWith(date)
                       select a.numLot).Max();
            if (num != null)
            {
                num = num.Substring(num.Length - 4);
                long numero = Int64.Parse(num) + 1;
                lot = date + ORI.Text + numero.ToString();
            }
            else
            {
                lot = date + ORI.Text + "0001";
            }
            numLot.Text = lot;
        }

        public void obtenirUsuaris()
        {
            var usuaris = (from a in _m.usuaris
                           select new { a.idUsuari, a.Nom }).ToArray();
            userComboBox.DataSource = usuaris;
            userComboBox.DisplayMember = "Nom";
            userComboBox.ValueMember = "idUsuari";
        }

        public void inserir()
        {
            Data data = new Data(numLot.Text, Int32.Parse(userComboBox.SelectedValue.ToString()), Int32.Parse(ORI.Text), REMO.Text, TRA.Text, dateSortida.Text, dateToday.Text,Int32.Parse(TOTAN.Text))
            {
                lot = numLot.Text,
                idUsuariReceptor = Int32.Parse(userComboBox.SelectedValue.ToString()),
                idProveidor = Int32.Parse(ORI.Text),
                codiREMO = REMO.Text,
                codiTransportista = TRA.Text,
                dataSortidaExplotacio = dateSortida.Text,
                dataEntradaEscorxador = dateToday.Text,
                numTotalAnimals = Int32.Parse(TOTAN.Text)
            };
        }
    }
    public class Data
    {
        public string lot { get; set; }
        public int idUsuariReceptor { get; set; }
        public int idProveidor { get; set; }
        public string codiREMO { get; set; }
        public string codiTransportista { get; set; }
        public string dataSortidaExplotacio { get; set; }
        public string dataEntradaEscorxador { get; set; }
        public int numTotalAnimals { get; set; }
        public Data(string Lot, int usuari, int proveidor, string codiRemo, string codiTrans, string dataSortida, string dataEntrada, int animals)
        {
            lot = Lot;
            idUsuariReceptor = usuari;
            idProveidor = proveidor;
            codiREMO = codiRemo;
            codiTransportista = codiTrans;
            dataSortidaExplotacio = dataSortida;
            dataEntradaEscorxador = dataEntrada;
            numTotalAnimals = animals;
        }
    }
}
