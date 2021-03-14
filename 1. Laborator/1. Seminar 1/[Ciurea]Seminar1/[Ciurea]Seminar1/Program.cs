using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Ciurea_Seminar1
{
    class Program
    {
        static void Main(string[] args)
        {
            //I. DOAR PENTRU APLICATII DE TIP CONSOLA - AFISARE SI CITIRE ****************************

            /*I.1. Afisare mesaj pe ecran COUT = Console.WriteLine():
                  - Console este o clasa
                  - Write() este metoda care imi afiseaza un sir de caractere
                  - WriteLine() imi afiseaza sirul de caractere si trece si pe linie noua*/
            Console.WriteLine("Cum te cheama?");

            /*I.2. Citire de la tastatura un nume CIN = Console.ReadLine():
                   - Declaram  un string nume pe care il preiau cu metoda ReadLine() 
                           Intr-un limbaj ca C# sirurile de caractere se initializeaza cu "string nume" fara sa mai alocam spatiu,
                           deoarece se aloca spatiu automat in HEAP si acel nume va fi defapt o referinta catre aceea adresa din HEAP
                           care va contine numele pe care il citesc eu de la tastatura */
            string nume = Console.ReadLine();
            string prenume = Console.ReadLine();
            /* - Apoi afisez mesajul "Numele este ... si numele introdus anterior de la tastatura
                           {0} inseamna primul parametru care urmeaza in lista dupa virgula adica numele*/
            Console.WriteLine("Nuemele este {0} si prenumele este {1}", nume, prenume);

            //****************************************************************************************************************************************************************
                        
                                                                 /*II.   DECLARARE VECTOR 1 
II.1.  - Vectorul este alocat in HEAP si initializat la declarare automat cu acele 4 valori*/
            int[] v1 = { 1, 2, 3, 4 };

            /* II.2.   - Traversare vector si afisare
                        -   Nu mai exidta acel n pe care il foloseam in for, ci vectorii sunt subclase ale unei clase de baza care se numeste Array 
                             de acolo ei mostenesc o serie de metode si proprietati printre care si PROPRIETATEA LENGTH
                          ATENTIE ! Diferenta dintre propritatea (cheie) si metoda(cub) este ca proprietatea nu are paranteza ().*/
            Console.WriteLine("Vector 1: ");

            for (int i = 0; i < v1.Length; i++)
            {
                Console.WriteLine(v1[i]);
            }


            /*DECLARARE VECTOR 2 = este identic cu Vector 1 pentru ca si V1 si V2 sunt 2 vectori alocati in HEAP, chiar daca la unul apare new, 
                                    iar la celalat nu si totodata sunt initializati cu aceleasi valori*/
            int[] v2 = new int[4] { 1, 2, 3, 4 };

            //********************************************************************************************************************************************

            /*III. SHALLOW COPY*/
            /*Declar o noua referinta v3 (adica un nou vector), dar vreau sa fie initializat cu valaorea vectorului v2
             ATENTIE!  -> In C# operatorul= NU se supraincarca deoarece el face doar copie de referinta (de adresa).
            Adica imi copiaza adresa spatiului de memorie aferent vectorului v2 catre referinta v3 - adica si v3 si v2 vor referi acelasi spatiu de memorie.*/
            int[] v3 = v2;

            /*Asta inseamna ca daca modific v2 atunci o sa se modifice si v3*/
            v2[1] = 10;

            //Il afisam pe v3 pentru a vedea ca intr-adevar s-a modificat si el
            for (int i = 0; i < v3.Length; i++)
            {
                Console.WriteLine(v3[i]);
            }

            //***************************************************************** IV.  DEEP COPY  ****************************************************************
            /*IV. 1. VARIANTA 1 - VARIANTA CLASICA
                    - Declar un vector v4
                    -  Ii aloc spatiu
                    -  Copiem element cu element
                    - Il afisam la sfarsit*/
            int[] v4 = new int[v2.Length];

            for (int i = 0; i < v2.Length; i++)
            {
                v4[i] = v2[i];
            }

            Console.WriteLine("Vector 4: ");
            for (int i = 0; i < v4.Length; i++)
            {
                Console.WriteLine(v4[i]);
            }

            //Daca modificam acum pe v2 cu valoarea 10, v4 o sa ramana cu valoarea initiala
            v2[1] = 20;

            Console.WriteLine("Vector 4 dupa modificare: ");
            for (int i = 0; i < v4.Length; i++)
            {
                Console.WriteLine(v4[i]);
            }

            /*IV. 2. VARIANTA 2 - FOLOSIRE METODA CLONE
                        - Metoda Clone este mostenita automat din clasa Array care implementeaza interfata IClonable - si returneaza un object
                        - Aceasta linie face tot ce am scris in Varianta 1 de mai sus*/
            int[] v5 = (int[])v2.Clone();

            //Daca afisam din nou - si acum v5 ar trebui sa fie cu valoarea 20

            v2[1] = 100;
            Console.WriteLine("Vector 5: ");
            for (int i = 0; i < v5.Length; i++)
            {
                Console.WriteLine(v5[i]);
            }

            //Deci Shallow Copy partajeaza acelasi spatiu de memorie, iar Deep Copy nu partajeaza acelasi spatiu de memorie

            //****************************************************** V. MASIVE BI-DIMENSIONALE **************************************************************
            /* Avem 2 tipuri de masive bi-dimensionale:
                    1. n linii si m coloane
                    2. Masiv in scara (zig-zag)*/

            /*V. 1. DECLARARE masiv cu n  linii si m coloane*/
            int[,] mat1 = new int[2, 3] { { 10, 20, 30 }, { 40, 50, 60 } };

            //          TRAVERSARE MATRICE - METODA 1
            /* Daca dau mat1.Lenght imi da cate elemente sunt in total deoarece un masiv reprezinta un spatiu contiguu de memorie unde avem liniile dispuse
               una in continuarea celeilalte => eu am 2 linii - 3 coloane = 6 elemente
                    10      20      30
                    40      50      60
               Pentru acest lucru avem metoda GetLenght(0) = metoda face parte tot din clasa Array care pentru fiecare dimensiune a masivului cu mai 
                multe dimensiuni, getLenght(0) inseamna nr de elemente pentru prima dimensiune => Adica numarul de elemente pe linii */
            for(int i = 0; i < mat1.GetLength(0); i++)
            {

                for (int j = 0; j < mat1.GetLength(1); j++)
                {
                    Console.Write("{0} ",mat1[i,j]);
                }
                Console.WriteLine();
            }


            /*V. 1. DECLARARE MASIV IN ZIG ZAG (SCARA)*/
            int[][]mat2 = new int[2][];
            mat2[0] = new int[2] { 10, 20 };
            mat2[1] = new int[3] { 30, 40, 50 };

            /******************************************* TRAVERSARE MASIV ZIG ZAG (IN SCARA)*******************************/
            //De data asta masivul este vazut ca vectori de vectori si merge sa apelez si proprietatea Length si pe linii si pe coloane.
            for (int i = 0; i < mat2.Length; i++)
            {

                for (int j = 0; j < mat2[i].Length; j++)
                {
                    Console.Write("{0} ", mat2[i][j]);
                }
                Console.WriteLine();
            }
        }
    }
}
