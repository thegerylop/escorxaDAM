using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text;

namespace Balança
{
    public class Program
    {
        
        /// <summary>
        /// Agafa el tipus de safata de la referencia del lot sencer
        /// </summary>
        /// <param name="info">Referència que rebem</param>
        /// <returns>Retorna el tipus de safata</returns>
        public static string safataArxiu (string info)
        {
            int inici = info.IndexOf("|") + 1;
            string safata = info.Substring(inici);
            return safata;
        }
        /// <summary>
        /// Agafa una línia aleatoria de l'arxiu passat per paràmetre
        /// </summary>
        /// <param name="safata">Nom de l'arxiu (sense extenció) que volem llegir</param>
        /// <returns>Retorna tot el contingut de la línia aleatoria seleccionada</returns>
        public static string liniaRandom(string safata)
        {
            string file = "Pes" + safata + ".txt";
            var lines = File.ReadAllLines("C:/Users/admin/Desktop/escorxaDAM/Balança/Fitxers" + file);
            var r = new Random();
            var randomLineNumber = r.Next(0, lines.Length - 1);
            var line = lines[randomLineNumber];

            return line;
        }
        /// <summary>
        /// Agafa el pes trobat a la línia que li passem per paràmetre
        /// </summary>
        /// <param name="linia">Línia d'on ha d'extreure el pes en format string</param>
        /// <returns>Retorna el pes que es trobava a la línia que ha arribat</returns>
        public static int agafaPes(string linia)
        {
            int inici = linia.IndexOf("|") + 1;
            int pes = Int32.Parse(linia.Substring(inici));
            return pes;
        }
    }
}