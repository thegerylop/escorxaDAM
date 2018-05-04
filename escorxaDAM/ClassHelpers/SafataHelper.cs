using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassHelpers
{
    public class SafataHelper
    {
        float pes;
        Boolean correcte = false;
        public bool EstatSafata(string safata)
        {
            correcte = PesSafata(safata);
            if (correcte)
            {
                correcte = EstatEspectograf(safata);
                if (correcte)
                {
                    return true;
                }
                return false;
            }
            return false;
        }

        public bool PesSafata(string Safata)
        {
            string TipusSafata = Safata;
            pes = Convert.ToSingle(EDI_TCPhelpers.sendUDPData("172.17.50.2",7000,TipusSafata));

            if(TipusSafata == "familiar")
            {
               if(pes >= 1080 && pes <= 1320)
                {
                    return true;
                }
                return false;
            }
            else if(TipusSafata == "estalvi")
            {
                if (pes >= 720 && pes <= 880)
                {
                    return true;
                }
                return false;
            }
            else if(TipusSafata == "normal")
            {
                if (pes >= 360 && pes <= 440)
                {
                    return true;
                }
                return false;
            }
            else
            {
                return false;
            }
        }

        public bool EstatEspectograf(string Safata)
        {
            string TipusSafata = Safata;
            string valors = EDI_TCPhelpers.sendTCPData("172.17.50.2", 7000, Convert.ToString(TipusSafata));
            if (COcorrecte(valors[0]) && Ocorrecte(valors[1]) && ATMcorrecte(valors[2]))
            {
                return true;
            }
            return false;
        }

        public bool COcorrecte(int valor)
        {
            if(valor >= 20 && valor <= 30)
            {
                return true;
            }
            return false;
        }

        public bool Ocorrecte(int valor)
        {
            if (valor >= 20 && valor <= 30)
            {
                return true;
            }
            return false;
        }

        public bool ATMcorrecte(int valor)
        {
            if (valor >= 1 && valor <= 3)
            {
                return true;
            }
            return false;
        }
    }
}
