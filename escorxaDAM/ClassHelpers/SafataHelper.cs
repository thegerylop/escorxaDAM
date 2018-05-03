using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassHelpers
{
    class SafataHelper
    {
        Boolean correcte = false;
        public bool EstatSafata(object safata)
        {
            correcte = EstatPes(safata);
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

        public bool EstatPes(object safata)
        {
            correcte = PesSafata(safata);
            return correcte;
        }

        public bool PesSafata(object safata)
        {
            string TipusSafata = safata.TipusSafata;
            int pes = //Trucada udp
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

        public bool EstatEspectograf(object safata)
        {
            int[] valors = //TrucadaUDPEspectograf
            if(COcorrecte(valors[0]) && Ocorrecte(valors[1]) && ATMcorrecte(valors[2]))
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
