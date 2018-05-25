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
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;

namespace RecepcioBestiar
{
    public partial class Recepcio : BaseForm.BaseInserir
    {
        escorxadam2Entities _m = new escorxadam2Entities();
        ClassHelpers.EDI_TCPhelpers edi = new ClassHelpers.EDI_TCPhelpers();
        string[] dades;
        string proveidor;

        public Recepcio()
        {
            InitializeComponent();
        }

        private void Recepcio_Load(object sender, EventArgs e)
        {
            MenuPrincipal.MenuPrincipal m = ParentForm as MenuPrincipal.MenuPrincipal;
            dateToday.Value = DateTime.Now;
            dateSortida.CustomFormat = "yyyymmdd";
            obtenirUsuaris();
            userComboBox.SelectedValue = m.User;
        }
        private void Edi()
        {
            DownloadDataFTP.FtpForm ftp = new DownloadDataFTP.FtpForm();

            ftp.ShowDialog();

            string ruta = edi.openFile();
            dades = edi.read(ruta);
            omplirCamps(dades);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BuidarCamps();
            Edi();
            btnInserir.Enabled = true;
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
            btnInserir.Enabled = false;
        }
        public void inserirRecepcio()
        {

            proveidor = (from a in _m.proveidors
                         where a.codiExplotacio.ToString() == ORI.Text
                         select a.idProveidor).First().ToString();

        }
        public void crearLot()
        {
            string lot;
            string date = DateTime.Now.ToString("MMyy");

            var num = (from a in _m.lots
                       where a.numLot.ToString().StartsWith(date)
                       select a.numLot).Max();
            if (num != null)
            {
                num = num.Substring(num.Length - 4);
                long numero = Int64.Parse(num) + 1;
                num = numero.ToString().PadLeft(5-numero.ToString().Length,'0');
                lot = date + ORI.Text + num.ToString();
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

            using (escorxadam2Entities test = new escorxadam2Entities())
            {
                var estable = new estables
                {
                    idUsuariResponsable = 1,
                    idEstatEstabulacio = 1,
                    idInspeccioSanitaria = 1,

                };
                _m.estables.Add(estable);
                _m.SaveChanges();


                var recepcio = new recepcions_bestiar
                {
                    idUsuariReceptor = Int32.Parse(userComboBox.SelectedValue.ToString()),
                    idProveidor = Int32.Parse(proveidor),
                    codiREMO = REMO.Text,
                    codiREGA = ORI.Text,
                    codiTransportista = TRA.Text,
                    dataSortidaExplotacio = DateTime.ParseExact(dateSortida.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.AssumeLocal),
                    dataEntradaEscorxador = DateTime.ParseExact(dateToday.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.AssumeLocal),
                    numTotalAnimals = Int32.Parse(TOTAN.Text)
                };

                _m.recepcions_bestiar.Add(recepcio);
                _m.SaveChanges();

                string remo = (from a in _m.recepcions_bestiar
                               where a.codiREMO.ToString() == REMO.Text
                               select a.idRecepcio).First().ToString();

                var lot = new lots
                {
                    idRemo = Int32.Parse(remo),
                    numLot = numLot.Text,

                };

                _m.lots.Add(lot);
                _m.SaveChanges();

                foreach (DataGridViewRow row in AnimalsGrid.Rows)
                {
                    string pais = row.Cells["Pais"].Value.ToString();
                    string paisAnimal = (from a in _m.paisos
                                         where a.abreviaturaPais.ToString() == pais
                                         select a.idPais).First().ToString();

                    int idRecepcio = Int32.Parse(_m.recepcions_bestiar.Max(u => u.idRecepcio).ToString());

                    string DIB = row.Cells["DIB"].Value.ToString();
                    string Sexe = row.Cells["Sexe"].Value.ToString();
                    string Edat = row.Cells["Edat"].Value.ToString();
                    string DIBMare = row.Cells["DIB_Mare"].Value.ToString();

                    var animal = new animals
                    {
                        idPaisNaixement = Int32.Parse(paisAnimal),
                        idRecepcioBestiar = idRecepcio,
                        DIB = DIB,
                        Sexe = Sexe,
                        Edat = Edat,
                        DIBmare = DIBMare,
                    };
                    _m.animals.Add(animal);
                    _m.SaveChanges();

                    int idEstable = Int32.Parse(_m.estables.Max(u => u.idEstable).ToString());
                    var lotes = _m.lots.OrderByDescending(u => u.idLot).FirstOrDefault();

                    lotes.idEstabulacio = idEstable;
                    _m.SaveChanges();
                }
            }
            MessageBox.Show("Finalitzat");
        }
        public void BuidarCamps()
        {
            foreach (Control txt in this.Controls)
            {
                if (txt.GetType() == typeof(CustomControl.CustomTextBox))
                {

                    txt.Text = "";

                }
            }
        }
    }
}