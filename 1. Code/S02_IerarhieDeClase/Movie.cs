using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S02_IerarhieDeClase
{
    class Movie
    {
        //Definire atribute
        private string title;
        private DateTime releaseDate;
        private float profit;
        private string genre;
        private string platform;


        /*      //Constructor implicit - Varianta 1
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



        //Constructor cu parametri
        public Movie(string title, DateTime releaseDate, float profit, string genre, string platform)
        {
            this.title = title;
            this.releaseDate = releaseDate;
            this.profit = profit;
            this.genre = genre;
            this.platform = platform;
        }

        //Constructor de copiere
        public Movie(Movie movie)
        {
            this.title = movie.title;
            this.releaseDate = movie.releaseDate;
            this.profit = movie.profit;
            this.genre = movie.genre;
            this.platform = movie.platform;
        }

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

        //Functie de afisare - Varianta 1 - Clasic
        public void afisare()
        {
            Console.WriteLine("Filmul {0}, are profitul {1}, genul {2} si premierea la data de {3} ",
                title, profit, genre, releaseDate);
        }
    }

}
