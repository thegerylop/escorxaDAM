using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassHelpers
{
    class SafataHelper
    {
        float pes;
        Boolean correcte = false;
        public bool EstatSafata(object safata)
        {
            correcte = PesSafata(safata);
            if (correcte)
            {
                correcte = EstatEspectograf();
                if (correcte)
                {
                    return true;
                }
                return false;
            }
            return false;
        }

        public bool PesSafata(object safata)
        {
            string TipusSafata = "";
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

        public bool EstatEspectograf()
        {
            string valors = EDI_TCPhelpers.sendTCPData("172.17.50.2", 7000, Convert.ToString(pes));
            if (COcorrecte(valors[0]) && Ocorrecte(valors[1]) && ATMcorrecte(valors[2]))
            {
                correcte = true;
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
