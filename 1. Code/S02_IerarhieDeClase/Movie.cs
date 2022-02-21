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
        string title;                    //definire implicita private
        private DateTime releaseDate;   //definire explicita private

        public float profit;
        protected string genre;
        private string platform;

        //Constructor implicit - Varianta 1
        public Movie()
        {

        }
        //Constructor implicit - Varianta 2
/*      public Movie()
      {
          this.title = " ";
          this.releaseDate = System.DateTime.Now;
          this.profit = 0.0f;
          this.genre = "";
          this.platform = " ";
      }
*/


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
                    this.title = value;
            }
        }
}
}
