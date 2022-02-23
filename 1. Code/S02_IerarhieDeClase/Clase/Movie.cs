using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S02_IerarhieDeClase
{
    class Movie
    {
        //*********************************************** DEFINIRE ATRIBUTE *****************************************************************
        private string title;
        private DateTime releaseDate;
        private float profit;
        private string genre;
        private string platform;

        //***************************************************** CONSTRUCTOR IMPLICIT *********************************************************

        /*   //Constructor implicit - Varianta 1
              public Movie()
              {

              } 
        */

        //Constructor implicit - Varianta 2
        public Movie()
        {
            this.title = " ";
            this.releaseDate = System.DateTime.Now;
            this.profit = 0.0f;
            this.genre = "";
            this.platform = " ";
        }

        //****************************************************CONSTRUCTOR CU PARAMETRI*********************************************************
        //Constructor cu parametri
        public Movie(string title, DateTime releaseDate, float profit, string genre, string platform)
        {
            this.title = title;
            this.releaseDate = releaseDate;
            this.profit = profit;
            this.genre = genre;
            this.platform = platform;
        }

        //****************************************************CONSTRUCTOR DE COPIERE **********************************************************
        //- Creaza spatiu pentru un nou obiect in HEAP si va copia in acel spatiu valorile primit ca parametru
        //Constructor de copiere
        public Movie(Movie movie)
        {
            this.title = movie.title;
            this.releaseDate = movie.releaseDate;
            this.profit = movie.profit;
            this.genre = movie.genre;
            this.platform = movie.platform;
        }

        //********************************************* PROPRIETATI - FUNCTII ACCESOR ********************************************************
        //Proprietati
        public string Title
        {
            get {
                return title;
            }
            set
            {
                if (value != null)
                    this.title = value; //value joaca rol de parametru pe care il primeam la seter
            }
        }

        //***********************************************  FUNCTIE DE AFISARE CLASICA *********************************************************
        //Functie de afisare - Varianta 1 - Clasic
        public void afisare()
        {
            Console.WriteLine("Filmul {0}, are profitul {1}, genul {2} si premierea la data de {3} ",
                title, profit, genre, releaseDate);
        }

        //***********************************************  SUPRAINCARCARE FUNCTIE TO STRING*****************************************************
        //Functia de afisare - Varianta 2 - ToString
        public override string ToString()
        {
            return "Filmul " + title  
                +  "are profitul" + profit 
                +  ", genul " + genre 
                +  "si premierea la data de" + releaseDate;
        }
    }

}
