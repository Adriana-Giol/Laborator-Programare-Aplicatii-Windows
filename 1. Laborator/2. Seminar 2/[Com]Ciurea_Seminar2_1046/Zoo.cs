using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Com_Ciurea_Seminar2_1046
{
    class Zoo:ICloneable
    {
        //Clasa Zoo nu este derivata din nimic si va contine o colectie de animale adica un list de animale

        //Atribute
        private string denumire;
        private List<Animal> listaAnimale;

        //Constructorul initial
        public Zoo()
        {
            this.denumire = "Seul";
            this.listaAnimale = new List<Animal>();
        }

        //Fara constructor cu parametri

        //Proprietati
        public string Denumire
        {
            get { return denumire; }
            set { if (value != null) denumire = value; }
        }

        public List<Animal> ListaAnimale
        {
            get { return listaAnimale; }
            set { if (value != null) listaAnimale =  value; }
        }


        //ToString
        public override string ToString()
        {
            /*Trebuie sa afiseze numele Zoo si lista de animale
                - Nu putem sa avem return direct ci trebuie mai intai sa parcurgem lista de animale 
                - Enviroment.NewLine = linie noua \n*/

            string rezultat = "Zoo " + denumire + " are urmatoarele animale: " + listaAnimale + Environment.NewLine;

            //Parcurgem lista de animale 
            foreach (Animal a in listaAnimale)
            {
                rezultat += a.ToString() + Environment.NewLine;

            }
            return rezultat;
        }

        //Implementare IClonable
        public object Clone()
        {
            //return this.MemberwiseClone(); // Daca folosesc aceasta varianta nu o sa stie sa copieze lista de animale 
            /*Metoda MemeberwiseClone nu stie sa trateze obiecte care incapsuleze alte obiecte - FACE SHALLOW COPY*/


            /*DEEP COPY - Alocam spatiu pentru o noua lista si iau din lista initiale si pun in noua lista si apoi o atasez obiectului clona:
                    - Imi creez o lista noua
                    -  Modificam referinta colectiei in obiectul clona
                    - Returnam obiectul clona care este independent si nu mai depinde de obiectul curent*/
            Zoo clona = (Zoo)this.MemberwiseClone();
            List<Animal> listaNoua = new List<Animal>();
            foreach(Animal a in listaAnimale)
            {
                listaNoua.Add((Animal)a.Clone());  // Creem  o lista noua in care punem copii ale obiectelor din colectia curenta

            }

            //Atasam lista creata si populata obiectului clona
            clona.listaAnimale = listaNoua;
            return clona;

        }
        
    }
}
