using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2020___Trenuri___1058
{
    class Teren
    {
       private float suprafata;
       private bool esteArabil;
       private int  codCadastral;

        public Teren()
        {
            this.suprafata = 10.0f;
            this.esteArabil = true;
            this.codCadastral = 1245;
        }

        public Teren(float suprafata, bool esteArabil, int codCadastral)
        {
            this.suprafata = suprafata;
            this.esteArabil = esteArabil;
            this.codCadastral = codCadastral;
        }

        public float Suprafata { get => suprafata; set => suprafata = value; }
        public bool EsteArabil { get => esteArabil; set => esteArabil = value; }
        public int CodCadastral { get => codCadastral; set => codCadastral = value; }

        public override string ToString()
        {
            return "Terenul cu codul cadastral " + codCadastral + " are suprafata de " + suprafata + " si este " + esteArabil;
        }

     
    }

}
