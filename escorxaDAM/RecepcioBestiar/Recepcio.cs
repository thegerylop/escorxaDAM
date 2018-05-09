using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecepcioBestiar
{
    public partial class Recepcio : BaseForm.BaseInserir
    {
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
            foreach(string item in dades)
            {
                int charLocation = item.IndexOf("|", StringComparison.Ordinal);
                if (charLocation > 0)
                {
                    Char =  item.Substring(0, charLocation);
                    switch (Char)
                    {
                        case "REMO":
                            output = item.Split('|', '|')[1];
                            break;
                        case "ORI":
                            index =  item.IndexOf("|");
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
                    actualizarTextBox(Char, output);
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
                        if(Char == "TRA")
                        {
                            int index = text.IndexOf("|");
                            string output = text.Substring(0 , index);
                            txt.Text = output;
                            index = text.LastIndexOf("|");
                            output = text.Substring(index + 1);
                            DateTime enteredDate = DateTime.Parse(output);
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
    }
}
