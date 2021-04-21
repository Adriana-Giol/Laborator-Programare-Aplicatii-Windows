using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapitulareTest
{
    class Colectiv
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

        //4. 
    }
}
