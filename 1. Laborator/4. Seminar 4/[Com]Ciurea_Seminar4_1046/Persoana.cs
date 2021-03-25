using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Com_Ciurea_Seminar4_1046
{
    [Serializable]
    //Clasa Abstracta Persoana
    public abstract class Persoana
    {
        /*Definire atribute protected deoarece vreau sa derivez din clasa Persoana si astfel le asigur acestor atribute vizibilitatea in clasa derivata
                - Nu mai trebuie sa implementez proprietati pentru ele*/
        protected int cod;
        protected char sex;


        //Constructor implicit
        public Persoana()
        {
            this.cod = 0;
            this.sex = 'F';
        }

        //Constructorul cu parametri
        public Persoana(int cod, char sex)
        {
            this.cod = cod;
            this.sex = sex;
        }

        //To String
        public override string ToString()
        {
            return "Persoana cu codul " + cod + " are sexul " + sex;
        }

        //Implementare metoda abstracta - metoda care se va implementa in clasa derivata
        public abstract void spuneAnNastere();
    }
}
