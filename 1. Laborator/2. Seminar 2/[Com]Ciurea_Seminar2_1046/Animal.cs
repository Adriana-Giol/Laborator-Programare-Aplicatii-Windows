using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Com_Ciurea_Seminar2_1046
{
    class Animal: ICloneable, IComparable
    {
        //Definire atribute
        private int varsta;
        private string nume;
        private float greutate;

        //Constructorul implicit
        public Animal()
        {
            this.varsta = 0;
            this.nume = "Anonim";
            this.greutate = 0.0f;
        }

        //Constructorul cu parametri
        public Animal(int varsta, string nume, float greutate)
        {
            this.varsta = varsta;
            this.nume = nume;
            this.greutate = greutate;
        }

        //Nu implementam constructor de copiere deoarece vom implementa metoda Clone

        //Proprietati
        public int Varsta
        {
            get { return varsta; }
            set { if (value > 0) varsta = value; }
        }

        public string Nume
        {
            get { return nume; }
            set { if (value != null) nume = value; }
        }

        public float Greutate
        {
            get { return Greutate; }
            set { if (value > 0) greutate = value; }
        }

      

        //Implementare metoda TO STRING
        // - Transforma obiectele in sir de caractere  si il putem folosi in loc de metoda de afisare

        public override string ToString()
        {

            //base este cuvantul cheie pe care o sa il folosim si la derivare si este clasa si referinta clasei Object
            // return base.ToString();  Nu ne ajuta la nimic deoarece nu am derivat clasa Animal din nici o alta clasa

            return "Animalul " + nume + "are varsta " + varsta + "si greutatea " + greutate;
        }

        //***********************************Implementarea interfetei ICLONABLE************************************************
        /*Nu mai facem constructor de copiere deoarece exista interfata IClonable 
         PAS 1: Derivam clasa Iclonable din clasa Animal
         PAS 2: Implementam metoda clone*/

        public object Clone()
        { 
            return this.MemberwiseClone(); //Face o Copie Deep doar pentru atribute normal
        
            /*Clone nu stie sa faca o clona completa (Deep Copy), cu un spatiu de memorie distinct pentru cazul in care as avea atribute vectori 
             sau colectii (face Shallow Copy), in acele situatii trebuie noi sa implementam Clone*/
        }


        //***********************************Implementarea interfetei ICOMPARABLE************************************************
        /*
         PAS 1: Derivam clasa IComparable din clasa Animal
         PAS 2: Implementam metoda CompareTo pentru a compara obiecte si ii vom spune dupa ce atribut vrem sa comparam
        
         SCOPUL METODEI CompareTo este de a permite sortarea de obiecte pentru ca noi o sa punem acele obiecte intr-un vector, pe care le dorim sortate
        
         Intotdeauna metoda CompareTo returneaza 3 valori:
            - -1, obiectul curent este mai mic decat cel primit ca parametru 
            -  0, cand sunt egale
            -  1, cand obiectul curent este mai mare*/

        public int CompareTo(object obj)
        {
            //Ne asiguram ca obiectele sunt de acelasi tip, astfel facem un cast
            Animal a = (Animal)obj;

            //Implementam cele 3 situatii 
            if (this.greutate < a.greutate)
            {
                return -1;
            }
            else
                if (this.greutate > a.greutate)
            {
                return 1;
            }
            else
                //return 0; // daca vrem sa facem compararea doar dupa atributul greutate
                return string.Compare(this.nume, a.nume); //daca vrem sa continuam compararea si dupa alte atribute 
                /*Metoda Compare Implementeaza acel strcpy intre 2 siruri de caractere si returneaza si el cele 3 valori {-1, 0, 1}*/

        }

    }
}
