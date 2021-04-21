using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2020___Trenuri___1058
{
    class Localitate
    {
        private String denumireLocalitate;
        private List<Teren> listaTerenuri;

        public Localitate()
        {
            this.denumireLocalitate = "Braila";
            this.listaTerenuri = new List<Teren>();
        }

        public string DenumireLocalitate { get => denumireLocalitate; set => denumireLocalitate = value; }
        public List<Teren> ListaTerenuri { get => listaTerenuri; set => listaTerenuri = value; }

        public override string ToString()
        {
            {
                string rezultat = "In localitatea " + denumireLocalitate + " se regasesc urmatorele terenuri: " + Environment.NewLine;
                foreach (Teren a in listaTerenuri)
                    rezultat += a.ToString() + Environment.NewLine;
                return rezultat;
            }
        }

        public Teren this[int index]
        {
            get
            {
                if (index >= 0 && index < listaTerenuri.Count && listaTerenuri != null)
                    return listaTerenuri[index];
                else
                    return null;
            }
        }


    }

}
