using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Com_Ciurea_Seminar2_1046
{
    class Sarpe:Animal
    {
        //Atribute
        private int lungime;
        private bool esteVeninos;


        //Constructor implicit
        public Sarpe() : base()
        {
            this.lungime = 0;
            this.esteVeninos = false;
        }

        //Constructor cu parametri
        public Sarpe(int varsta, string nume, float greutate, int lungime, bool esteVeninos) : base(varsta,nume, greutate)
        {
            this.lungime = lungime;
            this.esteVeninos = esteVeninos;
        }

        //ToString
        public override string ToString()
        {
            return base.ToString() + " lungimea " + lungime + " si este veninos " + esteVeninos;
        }
    }
}
