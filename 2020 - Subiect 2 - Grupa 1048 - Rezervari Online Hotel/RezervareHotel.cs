using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2020___Subiect_2___Grupa_1048___Rezervari_Online_Hotel
{
    class RezervareHotel
    {
        private String numeOaspete;
        private int codRezervare;

        public RezervareHotel(string numeOaspete, int codRezervare)
        {
            this.numeOaspete = numeOaspete;
            this.codRezervare = codRezervare;
        }

        public string NumeOaspete { get => numeOaspete; set => numeOaspete = value; }
        public int CodRezervare { get => codRezervare; set => codRezervare = value; }

        public override string ToString()
        {
            return "Clientul " + numeOaspete + " are rezervare cu codul " + codRezervare;
        }
    }

}
