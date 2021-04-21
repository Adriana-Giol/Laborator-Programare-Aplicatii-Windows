using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subiect2019_2_
{
    public abstract class Client
    {
        private String nume;
        private int cod;
        private String adresa;

        protected Client(String nume, int cod, String adresa)
        {
            this.nume = nume;
            this.cod = cod;
            this.adresa = adresa;
        }

        public string Nume { get => nume; set => nume = value; }
        public int Cod { get => cod; }
        public string Adresa { get => adresa; set => adresa = value; }

        public override string ToString()
        {
            return "Clientul " + nume + " cu codul " + cod + " are adresa " + adresa;
        }

        //Metoda abstracta
    }

}
