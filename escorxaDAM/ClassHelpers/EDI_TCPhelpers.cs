using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace ClassHelpers
{
    class EDI_TCPhelpers
    {
        String ruta;
        public void openFile()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            // Especifico el nom que surtira a la capsa del buscador, junt amb l'extensio del fitxer i quina posicio ocupa.
            openFileDialog1.Filter = "Fichero XML (.xml)|*.xml";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.Multiselect = false;

            // Crido el method per mostrarlo a la dialog box.
            openFileDialog1.ShowDialog();
            ruta = openFileDialog1.FileName;
            read(ruta);
        }

        public FileStream read(string ruta)
        {
            FileStream fs_text = new FileStream(ruta, FileMode.Open, FileAccess.Read);

            // fs es la variable que utilizaremos en el programa
            // FileStream es la clase que utilizaré para trabajar con ficheros

            //StreamReader rtext = new StreamReader(fs_text);

            fs_text.Close();

            return fs_text;
        }
    }
}
