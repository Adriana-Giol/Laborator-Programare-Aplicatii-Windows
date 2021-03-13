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

          /* II.2.   - Traversare vector
                      -   Nu mai exidta acel n pe care il foloseam in for, ci vectorii sunt subclase ale unei clase de baza care se numeste Array 
                           de acolo ei mostenesc o serie de metode si proprietati printre care si PROPRIETATEA LENGTH
                        ATENTIE ! Diferenta dintre propritatea (cheie) si metoda(cub) este ca proprietatea nu are paranteza ().*/
            for(int i= 0; i< v1.Length; i++)
            {
                Console.WriteLine(v1[i]);
            }


            /*DECLARARE VECTOR 2 = este identic cu Vector 1 pentru ca si V1 si V2 sunt 2 vectori alocati in HEAP, chiar daca la unul apare new, 
                                    iar la celalat nu si totodata sunt initializati cu aceleasi valori*/
            int[] v2 = new int[4] { 1, 2, 3, 4 };

            //********************************************************************************************************************************************
           
            /*III. SHALLOW COPY*/
            /*Declar o noua referinta v3 (adica un nou vector), dar vreau sa fie initializat cu valaorea vectorului v2
             ATENTIE!  -> In C# operatorul= NU se supraincarca deoarece el face doar copie de referinta*/
            int[] v3 = v2;
        }
    }
}
