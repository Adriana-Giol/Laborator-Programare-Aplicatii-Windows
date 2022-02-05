using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapitulareTest
{
    class Colectiv:ICloneable
    {
        //1. DEFINIRE ATRIBUTE
        private String numeColectiv;
        private List<Persoana> listaPersoane;


        //2. CONSTRUCTOR FARA PARAMETRI
        public Colectiv()
        {
            this.numeColectiv = "Bucuria";
            this.listaPersoane = new List<Persoana>();
        }


        //3. CONSTRUCTOR CU PARAMETRI 
        public Colectiv(string numeColectiv, List<Persoana> listaPersoane)
        {
            this.numeColectiv = numeColectiv;
            this.listaPersoane = new List<Persoana>();
            foreach(Persoana c in listaPersoane)
            {
                this.listaPersoane.Add(c);
            }
        }

        //4. PROPRIETATI
        public string NumeColectiv { get => numeColectiv; set => numeColectiv = value; }
        public List<Persoana> ListaPersoane { get => listaPersoane; set => listaPersoane = value; }

      


        //5. TO STRING
        public override string ToString()
        {
            string rezultat = "In colectivul " + numeColectiv + " sunt inregistrare urmatoarele persoane " + Environment.NewLine;
            foreach (Persoana p in listaPersoane)
                rezultat += p.ToString() + Environment.NewLine;
            return rezultat;
        }

        //6. ICLONEABLE

        public object Clone()
        {
            Colectiv clona = (Colectiv)this.MemberwiseClone();
            List<Persoana> listaNoua = new List<Persoana>();
            foreach (Persoana p in listaPersoane)
                listaNoua.Add((Persoana)p.Clone());
            clona.listaPersoane = listaNoua;
            return clona;
        }


        //7. OPERATOR INDEX
        public Persoana this[int index]
        {
            get
            {
                if (index >= 0 && index < listaPersoane.Count && listaPersoane != null)
                    return listaPersoane[index];
                else
                    return null;
            }
        }

        //8. OPERATOR+ - LISTA 
        public static Colectiv operator +(Colectiv colectiv, Persoana p)
        {

            colectiv.listaPersoane.Add(p);
            return colectiv;
        }
    }
}
