using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Com_Ciurea_Seminar2_1046
{
    class Program
    {
        static void Main(string[] args)
        {


            /* Se supraincarca doar cativa operatori si de regula functii de supraincarcare vor fi statice (functii globale vazute la nivelul clasei) 
             si din aceasta cauza nu o sa putem lucra in interiorul claselor cu referinta this. Astfel vom avea nevoie intotdeauna de 2 parametri: 
                     - un obiect din clasa mea
                     - un al doilea parametri de tip int sau float
             Comutativitatea nu mai are sens si trebuie sa implementam ambele forme

             Operatori care NU se supraincarca:
                     -   Operator+=
                     -   Operator= , deoarece face Shallow Copy (face copie de referinta)
                     -   Operator index - se supraincarca sub forma unei proprietati care nu are nume si o sa porte numele this 

             O clasa abstracta poate sa includa: 
                     -  toate componentele pe care o clasa normala
                     -  o sa contina functii abstracte (virtuale) care se vor implementa in clasele derivate
            Noi realizaam o clasa abstracta doar ca sa derivam din ea deoarece odata ce am declarat o clasa abstracta nu mai putem instantia nici un 
            obiect cu new din clasa respectiva.*/


            Animal a1 = new Animal();
            Animal a2 = new Animal(10, "Zoro", 150);
            Animal a3 = (Animal)a2.Clone();
            a3.Nume = "Grivei";
            a3.Greutate = 15;
            Console.WriteLine(a1);
            Console.WriteLine(a2);
            Console.WriteLine(a3);


            Pantera p1 = new Pantera(15,"Pantera Roz", 50, "roz", true);
            Sarpe s1 = new Sarpe(20, "Python", 40, 50, false);


            //Creem un zoo si adaugam toate animalele anterior create in acel zoo
            Zoo z1 = new Zoo();
            z1.ListaAnimale.Add(a1);
            z1.ListaAnimale.Add(a2);
            z1.ListaAnimale.Add(a3);
            z1.ListaAnimale.Add(p1);
            z1.ListaAnimale.Add(s1);


            //Mai creem inca un zoo pe baza primului zoo
            Zoo z2 = (Zoo)z1.Clone();
            z2.Denumire = "Busan";

            /*Vreau sa modific colectia de animale din z2 o sa se modifice si in z1 deoarece am implementat in clasa Zoo
            metoda Clonable cu acel MemberwiseClone, acela copiaza ca un operator= referinta catre lista de Animale din z1 */
            foreach (Animal a in z2.ListaAnimale)
            {
                a.Nume += "Copie";
            }

            /*Sortare inainte de afisare - O sa se apeleze metoda CompareTo din clasa Animal
                    - Se compara in functie de tipul de obiect pe care le include (noi avem obiecte de tip Animal la modul general) - in clasa Zoo noi 
                        avem o lista de obiecte de tip Animal; ea poate include fie obiecte din clasa Animal fie subtipuri ale Animalului 
                        (Pantera, Sarpe - care sunt subclase ale clasei Animal). 
                    - Noi in lista Zoo avem 3 animale, 1 pantera si 1 sarpe - dar pe toate le vor compara deoarece se apeleaza IComparable din clasa de baza Animal
            
                    - IComparable substituie operatorii <, > =*/
            z1.ListaAnimale.Sort();
            z2.ListaAnimale.Sort();

            //Afisare lista de animale
            Console.WriteLine(z1);
            Console.WriteLine(z2);


            //APEL DE OPERATOR INDEX  -  Afisare un animal de pe o anumita pozitie
            Console.WriteLine("----------------------");
            Console.WriteLine(z2[3]);

            //APEL DE OPERATOR+
            Console.WriteLine("----------------------");
            a2 += 10; 
            a3 = a3 + 12;

            //Varianta comutativa
            a1 = 15 + a1;
            Console.WriteLine(a1);
            Console.WriteLine(a2);
            Console.WriteLine(a3);
        }
    }
}
