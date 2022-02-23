using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S02_IerarhieDeClase
{
    class Program
    {
        static void Main(string[] args)
        {
            //Constructor implicit - GRESIT APELAT
          //  Movie movie1;

            //Constructor implicit - CORECT APELAT
            Movie movie1 = new Movie();

            //Constructor cu parametri
            Movie movie2 = new Movie("Singur acasa", new DateTime(), 12.5f, "Comedy", "NETFLIX");


            //Constructor de copiere - GRESIT APELAT
            //Movie movie3(movie2);

            //Constructor de copiere - GRESIT APELAT - SHALLOW COPY
           // Movie movie3 = movie2;

            //Constructor de copiere - CORECT APELAT - DEEP COPY
             Movie movie3 = new Movie(movie2);

            //Proprietate
            movie2.Title = "Harry Potter";          // se apeleaza seterul din proprietate
            Console.WriteLine(movie2.Title);        //se apeleaza geterul din proprietate

            //Metoda de afisare - clasic
            movie1.afisare();
            movie2.afisare();
            movie3.afisare();
        }
    }
}
