using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2020___Subiect_2___Grupa_1048___Rezervari_Online_Hotel
{
    class RezervarileZilei
    {  private int nrRezervari;
       private List<RezervareHotel> listaRezervari;

        public RezervarileZilei()
        {
            nrRezervari = 0;
            listaRezervari = new List<RezervareHotel>();
        }

        public override string ToString()
        {
            string rezervari = "Rezervarile zilei de azi sunt in numar de " + nrRezervari + " si avem urmatoarele rezervari " + Environment.NewLine;
            foreach (RezervareHotel a in listaRezervari)
                rezervari += a.ToString() + Environment.NewLine;
            return rezervari;

        }
        public RezervareHotel this[int index]
        {
            get
            {
                if (index >= 0 && index < listaRezervari.Count && listaRezervari != null)
                    return listaRezervari[index];
                else
                    return null;
            }
        }

        //public static RezervarileZilei operator +(RezervarileZilei rz, List<RezervareHotel> rh)
        //{
            
        //}
    }
}
